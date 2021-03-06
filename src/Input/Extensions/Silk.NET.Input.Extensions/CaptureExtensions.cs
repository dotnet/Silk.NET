using System.Buffers;

namespace Silk.NET.Input.Extensions
{
    public static class CaptureExtensions
    {
        public static InputSnapshot CaptureState(this IInputContext obj, MemoryPool<byte>? memoryPool = null)
            => new(obj, memoryPool ?? MemoryPool<byte>.Shared);
        public static GamepadState CaptureState(this IGamepad obj, MemoryPool<byte>? memoryPool = null)
            => new(obj, memoryPool ?? MemoryPool<byte>.Shared);
        public static JoystickState CaptureState(this IJoystick obj, MemoryPool<byte>? memoryPool = null)
            => new(obj, memoryPool ?? MemoryPool<byte>.Shared);
        public static KeyboardState CaptureState(this IKeyboard obj, MemoryPool<byte>? memoryPool = null)
            => new(obj, memoryPool ?? MemoryPool<byte>.Shared);
        public static MouseState CaptureState(this IMouse obj, MemoryPool<byte>? memoryPool = null)
            => new MouseState(obj, memoryPool ?? MemoryPool<byte>.Shared);
    }
}
