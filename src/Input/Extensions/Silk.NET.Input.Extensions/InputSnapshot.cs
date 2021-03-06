// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Buffers;

namespace Silk.NET.Input.Extensions
{
    public sealed class InputSnapshot : IDisposable
    {
        internal InputSnapshot(IInputContext ctx, MemoryPool<byte> pool)
        {
            var gamepads = ctx.Gamepads;
            var joysticks = ctx.Joysticks;
            var keyboards = ctx.Keyboards;
            var mice = ctx.Mice;
            Gamepads = new GamepadState[gamepads.Count];
            Joysticks = new JoystickState[joysticks.Count];
            Keyboards = new KeyboardState[keyboards.Count];
            Mice = new MouseState[mice.Count];
            for (var i = 0; i < gamepads.Count; i++)
            {
                Gamepads[i] = new(gamepads[i], pool);
            }

            for (var i = 0; i < joysticks.Count; i++)
            {
                Joysticks[i] = new(joysticks[i], pool);
            }

            for (var i = 0; i < keyboards.Count; i++)
            {
                Keyboards[i] = new(keyboards[i], pool);
            }

            for (var i = 0; i < mice.Count; i++)
            {
                Mice[i] = new(mice[i], pool);
            }
        }

        // TODO in 3.0 rent these too! right now the capture extensions are very expensive
        public GamepadState[] Gamepads { get; }
        public JoystickState[] Joysticks { get; }
        public KeyboardState[] Keyboards { get; }
        public MouseState[] Mice { get; }

        public void Dispose()
        {
            foreach (var state in Gamepads)
            {
                state.Dispose();
            }

            foreach (var state in Joysticks)
            {
                state.Dispose();
            }

            foreach (var state in Keyboards)
            {
                state.Dispose();
            }

            foreach (var state in Mice)
            {
                state.Dispose();
            }
        }
    }
}
