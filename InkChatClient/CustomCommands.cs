using System.Windows.Input;

namespace InkChatClient
{
    static class CustomCommands
    {
        public static RoutedCommand Connect = new RoutedCommand();
        public static RoutedCommand Disconnect = new RoutedCommand();
    }
}
