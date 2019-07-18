using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace InputTest
{
    internal class Program
    {
        private static void Main()
        {
            var window = new GlfwWindow(WindowOptions.Default);

            var inputContext = new GlfwInputContext(window);
            inputContext.ConnectionChanged += ControllerConnected;
        }

        public static void ControllerConnected(IInputDevice device, bool state)
        {
            
        }
    }
}