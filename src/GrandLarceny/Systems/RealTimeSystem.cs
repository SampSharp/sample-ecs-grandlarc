using System;
using System.Threading.Tasks;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which provides real time to the player's game time.
    /// </summary>
    public class RealTimeSystem : ISystem
    {
        private TextDraw _textDraw;
        
        [Event]
        public void OnGameModeInit(IWorldService worldService)
        {
            // Create clock textdraw in the top-right corner of the screen
            _textDraw = worldService.CreateTextDraw(new Vector2(605, 25), "00:00");
            _textDraw.UseBox = false;
            _textDraw.Font = TextDrawFont.Pricedown;
            _textDraw.Shadow = 0;
            _textDraw.Outline = 2;
            _textDraw.BackColor = Color.Black;
            _textDraw.ForeColor = Color.White;
            _textDraw.Alignment = TextDrawAlignment.Right;
            _textDraw.LetterSize = new Vector2(0.5f, 1.5f);
        }
        
        [Timer(1000)]
        public void Tick(IServerService serverService, IEntityManager entityManager)
        {
            var now = DateTime.Now;

            // Update the textdraw and server time
            _textDraw.Text = now.ToString("t");
            serverService.SetWorldTime(now.Hour);

            // Get all players and update their time
            var players = entityManager.GetComponents<Player>();

            foreach (var player in players)
                player.SetTime(now.Hour, now.Minute);
        }

        [Event]
        public void OnPlayerSpawn(Player player)
        {
            _textDraw.Show(player);

            var now = DateTime.Now;
            player.SetTime(now.Hour, now.Minute);
        }

        [Event]
        public void OnPlayerDeath(Player player, Player killer, Weapon reason)
        {
            _textDraw.Hide(player);
        }

        [Event]
        public void OnPlayerConnect(Player player)
        {
            var now = DateTime.Now;
            player.SetTime(now.Hour, now.Minute);
        }
    }
}