using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottify
{
    static class DiscordRichPresence
    {
        private static DiscordRpcClient client;
        static DiscordRichPresence()
        {
            initialize();
        }
        private static void initialize()
        {
            client = new("1312575696249426050");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Info };
            client.OnReady += (sender, e) =>
            {
                Debug.WriteLine($"Received Ready from user {e.User.Username}");
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Debug.WriteLine($"Received Update! {e.Presence.Details}");
            };
            client.Initialize();
        }

        public static void setPresence(Song s)
        {
            client.SetPresence(new RichPresence()
            {
                Details = s.ToString(),
                State = "Playing",
                Assets = new Assets()
                {
                    LargeImageKey = "image_large",
                    LargeImageText = "Lachee's Discord IPC Library",
                    SmallImageKey = "image_small"
                }
            });
        }
    }
}
