using System.IO;
using System.Linq;
using VRC.Core;
namespace Example.Modules
{
    internal class FriendLogger
    {




        internal static void AutoLogFriendsToFile()
        {



            foreach (string text in APIUser.CurrentUser.friendIDs)
            {
                if (!File.ReadLines(FileHelper.GetCheatFolder() + "\\FriendList.CE").Contains(text))
                {
                    File.AppendAllText(FileHelper.GetCheatFolder() + "\\FriendList.CE", text + "\n");
                }
            }

        }
    }
}
