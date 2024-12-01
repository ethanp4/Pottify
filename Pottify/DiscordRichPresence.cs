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
            client = new("asdfghjkl");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };
            client.Initialize();
        }

        public static void setPresence(Song s)
        {
            client.SetPresence(new RichPresence()
            {
                Details = s.title,
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
