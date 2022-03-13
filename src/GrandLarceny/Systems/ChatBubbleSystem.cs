using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using SampSharp.Entities.SAMP.Commands;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which provides chat bubbles above the heads of players.
    /// </summary>
    public class ChatBubbleSystem : ISystem
    {
        [Event]
        public bool OnPlayerText(Player player, string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length > SampLimits.MaxPlayerChatBubbleLength - 8)
                return false;

            player.SendClientMessage(Color.LightGray, $">> {text}");
            player.SetChatBubble($"Says: {text}", Color.LightGray, 35, 10000);

            return false; // disable normal chat
        }


        /// <summary>
        /// Handler for the "/me [text]" command.
        /// </summary>
        [PlayerCommand]
        public void MeCommand(Player player, string text)
        {
            text = $"* {text}";
            var color = Color.FromInteger(0xEE66EEFF, ColorFormat.RGBA);

            player.SendClientMessage(color, text);
            player.SetChatBubble(text, color, 30, 10000);
        }
    }
}