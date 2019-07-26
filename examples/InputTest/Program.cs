using System;
using System.Threading.Tasks;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace InputTest
{
    internal class Program
    {
        private static void Main()
        {

            var window = Window.Create(WindowOptions.Default);
            Task.Run(() => window.Run());
            Console.Write("Connect your controller(s) and press ENTER (in the console window).");
            Console.ReadLine();
            var input = window.GetInput();
            input.ConnectionChanged += ControllerConnected;
            foreach (var inputGamepad in input.Gamepads)
            {
                Console.WriteLine("Discovered controller " + inputGamepad.Index);
                inputGamepad.ButtonDown += InputGamepadOnButtonDown;
                inputGamepad.ButtonUp += InputGamepadOnButtonUp;
                foreach (var inputGamepadButton in inputGamepad.Buttons)
                {
                    Console.WriteLine("Controller ");
                }
            }
        }

        private static void InputGamepadOnButtonDown(IGamepad arg1, Button arg2)
        {
            Console.WriteLine(arg1.Index + "> " + arg2.Name + " down.");
        }

        private static void InputGamepadOnButtonUp(IGamepad arg1, Button arg2)
        {
            Console.WriteLine(arg1.Index + "> " + arg2.Name + " up.");
        }

        public static void ControllerConnected(IInputDevice device, bool isConnected)
        {
            Console.WriteLine(isConnected
                ? $"Controller {device.Name} connected"
                : $"Controller {device.Name} disconnected");
        }
    }
}