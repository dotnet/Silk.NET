// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;
using Silk.NET.Windowing.Desktop;


namespace Silk.NET.Input.Desktop
{
    /// <summary>
    /// A GLFW-based input context.
    /// </summary>
    public class GlfwInputContext : IInputContext
    {
        internal readonly List<GlfwGamepad> _gamepads;
        internal readonly List<GlfwJoystick> _joysticks;
        internal readonly GlfwKeyboard _keyboard;
        internal readonly GlfwMouse _mouse;
        internal readonly GlfwWindow _window;

        /// <summary>
        /// Create a new input context from the given window.
        /// </summary>
        /// <param name="window">The window to create a context for.</param>
        internal GlfwInputContext(GlfwWindow window)
        {
            Handle = window.Handle;
            _window = window;
            InputHandler.RegisterContext(this);
            _window.Update += WindowUpdate;
            
            // initialize auto-properties
            Gamepads = new GlfwGamepadCollection(this);
            Joysticks = new GlfwJoystickCollection(this);
            Keyboards = new GlfwKeyboardCollection(this);
            Mice = new GlfwMouseCollection(this);

            // initialize joysticks
            _joysticks = new List<GlfwJoystick>(Enumerable.Range(0, 16).Select(i => new GlfwJoystick(i)));
            _gamepads = new List<GlfwGamepad>(Enumerable.Range(0, 16).Select(i => new GlfwGamepad(i)));
            _keyboard = new GlfwKeyboard(this);
            _mouse = new GlfwMouse(this);
        }

        /// <inheritdoc />
        public IntPtr Handle { get; }
        
        /// <inheritdoc />
        public IReadOnlyList<IGamepad> Gamepads { get; }
        
        /// <inheritdoc />
        public IReadOnlyList<IJoystick> Joysticks { get; }
        
        /// <inheritdoc />
        public IReadOnlyList<IKeyboard> Keyboards { get; }
        
        /// <inheritdoc />
        public IReadOnlyList<IMouse> Mice { get; }
        
        /// <inheritdoc />
        public IReadOnlyList<IInputDevice> OtherDevices { get; } = Array.Empty<IInputDevice>(); // not supported in GLFW

        /// <inheritdoc />
        public void Dispose()
        {
            InputHandler.UnregisterContext(this);
            _window.Update -= WindowUpdate;
        }

        ~GlfwInputContext()
        {
            Dispose();
        }

        /// <summary>
        /// Update all joysticks and gamepads in this input context.
        /// </summary>
        /// <param name="delta">Time in seconds since the last update.</param>
        private void WindowUpdate(double delta)
        {
            foreach (var t in _joysticks)
            {
                t.Update();
            }

            foreach (var t in _gamepads)
            {
                t.Update();
            }
        }
        
        /// <inheritdoc />
        public event Action<IInputDevice, bool> ConnectionChanged;

        /// <summary>
        /// Raise a ConnectionChanged event for the given joystick/state.
        /// </summary>
        /// <param name="joystick">The joystick to raise the event for.</param>
        /// <param name="state">The state of the joystick to raise the event for.</param>
        public void RaiseConnectionChange(int joystick, ConnectedState state)
        {
            ConnectionChanged?.Invoke(Util.Glfw.JoystickIsGamepad(joystick) ? (IInputDevice) Gamepads[joystick] : Joysticks[joystick], state == ConnectedState.Connected);
        }
    }
}
