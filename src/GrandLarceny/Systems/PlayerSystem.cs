using GrandLarceny.Components;
using GrandLarceny.Repositories;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which handles basic player events.
    /// </summary>
    public class PlayerSystem : ISystem
    {
        [Event]
        public void OnPlayerConnect(Player player)
        {
            player.GameText("~w~Grand Larceny", 3000, 4);
            player.SendClientMessage("Welcome to {88AA88}G{FFFFFF}rand {88AA88}L{FFFFFF}arceny");
        }

        [Event]
        public void OnPlayerSpawn(CitizenComponent citizen, ISpawnLocationRepository spawnLocationRepository)
        {
            var player = citizen.GetComponent<Player>();

            player.Interior = 0;
            player.ToggleClock(false);
            player.Money = 30000;
            player.GiveWeapon(Weapon.Colt45, 100);

            var location = spawnLocationRepository.GetRandomSpawnLocation(citizen.City);

            player.Position = location.Position;
            player.Angle = location.Angle;
        }

        [Event]
        public void OnPlayerDeath(Player player, Player killer, Weapon reason)
        {
            if (killer == null)
            {
                // If the player killed itself, remove their money.
                player.ResetMoney();
            }
            else
            {
                // If the player was killed, give their money to the killer.
                var money = player.Money;
                if (money > 0)
                {
                    killer.GiveMoney(money);
                    player.ResetMoney();
                }
            }
        }

        [Event]
        public bool OnPlayerUpdate(Player player)
        {
            // Don't allow minigun
            if (player.Weapon == Weapon.Minigun)
            {
                player.Kick();
                return false;
            }

            return true;
        }
    }
}