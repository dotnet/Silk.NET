using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Silk.NET.Input;
using Silk.NET.Windowing;
using MouseButton = Silk.NET.Input.MouseButton;

namespace InputTest
{
    public class Program
    {
#if !NET6_0
        // Exclude the entry point if we're running in .NET 6, as this file is
        // compiled into the TriangleNET6 project too which has its own
        // entrypoint.
        private static void Main(string[] args) => Run(args);
#endif

        private static void Run(string[]? args = null)
        {
            if (args?.Contains("--sdl") ?? false)
            {
                Window.PrioritizeSdl();
            }
            var opts = WindowOptions.Default;
            opts.FramesPerSecond = 60;
            opts.UpdatesPerSecond = 60;
            var window = Window.Create(opts);
            window.Load += OnLoad(window);
            window.Run();
        }

        static Key[] _allKeys = Enum.GetValues(typeof(Key)).Cast<Key>().Where(x => x != Key.Unknown).ToArray();
        static List<Key> _keysDown = new List<Key>();
        static List<int> _scancodesDown = new List<int>();

        public static Action OnLoad(IView window) =>
            () =>
            {
                var input = window.CreateInput();
                window.Update += OnUpdate(input);
                input.ConnectionChanged += DoConnect;
                Console.WriteLine("Now, go press buttons in the window and you'll see the feedback here.");
                foreach (var gamepad in input.Gamepads)
                {
                    if (!gamepad.IsConnected) continue;
                    DoConnect(gamepad, gamepad.IsConnected);
                }

                foreach (var joystick in input.Joysticks)
                {
                    if (!joystick.IsConnected) continue;
                    DoConnect(joystick, joystick.IsConnected);
                }

                foreach (var keyboard in input.Keyboards)
                {
                    if (!keyboard.IsConnected) continue;
                    DoConnect(keyboard, keyboard.IsConnected);
                }

                foreach (var mouse in input.Mice)
                {
                    if (!mouse.IsConnected) continue;
                    DoConnect(mouse, mouse.IsConnected);
                }

                //window.Update += d =>
                //{
                //    Debug.WriteLine(input.Mice[0].ScrollWheels[0].X + " " + input.Mice[0].ScrollWheels[0].Y);
                //};
            };

        public static Action<double> OnUpdate(IInputContext input) =>
            (dt) =>
            {
                foreach (Key k in _allKeys)
                {
                    // This should really be separated into different keyboards, but since all current backends
                    // just report a single keyboard we'll leave this test as is for now.
                    if (_keysDown.Contains(k) != input.Keyboards.Any(x => x.IsKeyPressed(k)))
                    {
                        Console.WriteLine($"[ERROR] IsKeyPressed() and event mismatch! Key {k}");
                    }
                }

                for (int s = 0; s < 256; s++)
                {
                    if (_scancodesDown.Contains(s) != input.Keyboards.Any(x => x.IsScancodePressed(s)))
                    {
                        Console.WriteLine($"[ERROR] IsScancodePressed() and event mismatch! Scancode {s}");
                    }
                }
            };

        private static void GamepadOnTriggerMoved(IGamepad gamepad, Trigger trigger)
        {
            Console.WriteLine($"G{gamepad.Index}> {trigger.Index} trigger moved: {trigger.Position}");
        }

        private static void GamepadOnThumbstickMoved(IGamepad gamepad, Thumbstick thumbstick)
        {
            Console.WriteLine($"G{gamepad.Index}> {thumbstick.Index} thumbstick moved: ({thumbstick.X}, {thumbstick.Y})");
        }

        private static void JoystickOnHatMoved(IJoystick joystick, Hat hat)
        {
            Console.WriteLine($"J{joystick.Index}> {hat.Index} hat moved: {hat.Position}");
        }

        private static void JoystickOnAxisMoved(IJoystick joystick, Axis axis)
        {
            Console.WriteLine($"J{joystick.Index}> {axis.Index} axis moved: {axis.Position}");
        }

        private static void JoystickOnButtonUp(IJoystick joystick, Button button)
        {
            Console.WriteLine($"J{joystick.Index}> {button.Name} down.");
        }

        private static void JoystickOnButtonDown(IJoystick joystick, Button button)
        {
            Console.WriteLine($"J{joystick.Index}> {button.Name} down.");
        }

        private static void InputGamepadOnButtonDown(IGamepad gamepad, Button button)
        {
            Console.WriteLine($"G{gamepad.Index}> {button.Name} down. {(int) button.Name}");
        }

        private static void InputGamepadOnButtonUp(IGamepad gamepad, Button button)
        {
            Console.WriteLine($"G{gamepad.Index}> {button.Name} up.");
        }

        public static unsafe void DoConnect(IInputDevice device, bool isConnected)
        {
            Console.WriteLine("bong");
            Console.WriteLine(isConnected
                ? $"{device.GetType().Name} {device.Name} connected"
                : $"{device.GetType().Name} {device.Name} disconnected");
            if (device is IGamepad gamepad)
            {
                Console.WriteLine($"Discovered controller {gamepad.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    gamepad.Deadzone = new Deadzone(0.2f, DeadzoneMethod.AdaptiveGradient);
                    gamepad.ButtonDown += InputGamepadOnButtonDown;
                    gamepad.ButtonUp += InputGamepadOnButtonUp;
                    gamepad.ThumbstickMoved += GamepadOnThumbstickMoved;
                    gamepad.TriggerMoved += GamepadOnTriggerMoved;
                    //Console.WriteLine("GUID: " + GlfwProvider.GLFW.Value.GetJoystickGUID(gamepad.Index));
                    //GlfwProvider.GLFW.Value.GetJoystickButtons(gamepad.Index, out var count);
                    //Console.WriteLine("Button Count: " + count + " Expected Button Count: " +Enum.GetValues(typeof(GamepadButton)).Length);
                }
                else
                {
                    gamepad.ButtonDown -= InputGamepadOnButtonDown;
                    gamepad.ButtonUp -= InputGamepadOnButtonUp;
                    gamepad.ThumbstickMoved -= GamepadOnThumbstickMoved;
                    gamepad.TriggerMoved -= GamepadOnTriggerMoved;
                }

                Console.Write("    Buttons: ");
                const string s = "\n             ";
                Console.WriteLine(string.Join(s, gamepad.Buttons.Select(x => x.Index + "/" + x.Name + (x.Pressed ? "(1)" : "(0)"))));
                Console.WriteLine($"    {gamepad.Thumbsticks.Count} thumbsticks found.");
                Console.WriteLine($"    {gamepad.Triggers.Count} triggers found.");
            }
            else if (device is IJoystick joystick)
            {
                Console.WriteLine($"Discovered joystick {joystick.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    joystick.ButtonDown += JoystickOnButtonDown;
                    joystick.ButtonUp += JoystickOnButtonUp;
                    joystick.AxisMoved += JoystickOnAxisMoved;
                    joystick.HatMoved += JoystickOnHatMoved;
                }
                else
                {
                    joystick.ButtonDown -= JoystickOnButtonDown;
                    joystick.ButtonUp -= JoystickOnButtonUp;
                    joystick.AxisMoved -= JoystickOnAxisMoved;
                    joystick.HatMoved -= JoystickOnHatMoved;
                }

                Console.Write("    Buttons: ");
                const string s = "\n             ";
                Console.WriteLine(string.Join(s, joystick.Buttons.Select(x => x.Name + (x.Pressed ? "(1)" : "(0)"))));
            }
            else if (device is IKeyboard keyboard)
            {
                Console.WriteLine($"Discovered keyboard {keyboard.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    keyboard.KeyDown += KeyboardOnKeyDown;
                    keyboard.KeyUp += KeyboardOnKeyUp;
                    keyboard.KeyChar += KeyboardOnKeyChar;
                }
                else
                {
                    keyboard.KeyDown -= KeyboardOnKeyDown;
                    keyboard.KeyUp -= KeyboardOnKeyUp;
                    keyboard.KeyChar -= KeyboardOnKeyChar;
                }

                Console.Write("    Buttons: ");
                Console.WriteLine(string.Join(", ", keyboard.SupportedKeys.Select(x => x)));
            }
            else if (device is IMouse mouse)
            {
                Console.WriteLine($"Discovered mouse {mouse.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    mouse.MouseUp += MouseOnMouseUp;
                    mouse.MouseDown += MouseOnMouseDown;
                    mouse.Click += MouseOnClick;
                    mouse.DoubleClick += MouseOnDoubleClick;
                    mouse.Scroll += MouseOnScroll;
                    mouse.MouseMove += MouseOnMouseMove;
                }
                else
                {
                    mouse.MouseUp -= MouseOnMouseUp;
                    mouse.MouseDown -= MouseOnMouseDown;
                    mouse.Click -= MouseOnClick;
                    mouse.DoubleClick -= MouseOnDoubleClick;
                    mouse.Scroll -= MouseOnScroll;
                    mouse.MouseMove -= MouseOnMouseMove;
                }

                // mouse.Cursor.IsConfined = true;

                Console.Write("    Buttons: ");
                Console.WriteLine(string.Join(", ", mouse.SupportedButtons.Select(x => x)));
                Console.WriteLine($"    {mouse.ScrollWheels.Count} scroll wheels.");
            }
        }

        private static void KeyboardOnKeyChar(IKeyboard keyboard, char c)
        {
            Console.WriteLine($"K{keyboard.Index}> {c} received.");
        }

        private static void MouseOnMouseMove(IMouse mouse, Vector2 pos)
        {
            Console.WriteLine($"M{mouse.Index}> Moved: {pos}");
        }

        private static void MouseOnScroll(IMouse mouse, ScrollWheel sw)
        {
            Console.WriteLine($"K{mouse.Index}> Scrolled: ({sw.X}, {sw.Y})");
        }

        private static void MouseOnMouseDown(IMouse mouse, MouseButton button)
        {
            Console.WriteLine($"M{mouse.Index}> {button} down.");
        }

        private static void MouseOnMouseUp(IMouse mouse, MouseButton button)
        {
            Console.WriteLine($"M{mouse.Index}> {button} up.");
        }

        private static void MouseOnClick(IMouse mouse, MouseButton button, Vector2 pos)
        {
            Console.WriteLine($"M{mouse.Index}> {button} single click.");
        }

        private static void MouseOnDoubleClick(IMouse mouse, MouseButton button, Vector2 pos)
        {
            Console.WriteLine($"M{mouse.Index}> {button} double click.");
        }

        private static void KeyboardOnKeyUp(IKeyboard keyboard, Key key, int scancode)
        {
            Console.WriteLine($"K{keyboard.Index}> key={key} scancode={scancode} up.");

            if (key != Key.Unknown)
            {
                int keyIndex = _keysDown.IndexOf(key);
                if (keyIndex < 0)
                    Console.WriteLine($"[ERROR] Double key up detected? K{keyboard.Index}> {key} up.");
                else
                    _keysDown.RemoveAt(keyIndex);
            }

            int scancodeIndex = _scancodesDown.IndexOf(scancode);
            if (scancodeIndex < 0)
                Console.WriteLine($"[ERROR] Double scancode up detected? K{keyboard.Index}> {scancode} up.");
            else
                _scancodesDown.RemoveAt(scancodeIndex);
        }

        private static void KeyboardOnKeyDown(IKeyboard keyboard, Key key, int scancode)
        {
            Console.WriteLine($"K{keyboard.Index}> key={key} scancode={scancode} down.");

            if (key != Key.Unknown)
            {
                if (_keysDown.Contains(key))
                    Console.WriteLine($"[ERROR] Double key down detected? K{keyboard.Index}> {key} down.");
                else
                    _keysDown.Add(key);
            }

            if (_scancodesDown.Contains(scancode))
                Console.WriteLine($"[ERROR] Double scancode down detected? K{keyboard.Index}> {scancode} down.");
            else
                _scancodesDown.Add(scancode);
        }
    }
}
