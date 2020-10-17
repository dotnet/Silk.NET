namespace Silk.NET.Input.Extensions
{
    public static class CaptureExtensions
    {
        public static InputSnapshot CaptureState(this IInputContext obj) => new InputSnapshot(obj);
        public static GamepadState CaptureState(this IGamepad obj) => new GamepadState(obj);
        public static JoystickState CaptureState(this IJoystick obj) => new JoystickState(obj);
        public static KeyboardState CaptureState(this IKeyboard obj) => new KeyboardState(obj);
        public static MouseState CaptureState(this IMouse obj) => new MouseState(obj);
    }
}
