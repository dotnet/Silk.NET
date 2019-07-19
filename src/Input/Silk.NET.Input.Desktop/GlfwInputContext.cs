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
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input.Desktop
{
    public class GlfwInputContext : IInputContext
    {
        internal List<GlfwGamepad> _gamepads;
        internal List<GlfwJoystick> _joysticks;
        internal IKeyboard _keyboard;
        internal IMouse _mouse;
        internal IWindow _window;

        public GlfwInputContext(IWindow window)
        {
            Handle = window.Handle;
            _window = window;
            InputHandler.RegisterContext(this);
            
            // initialize auto-properties
            Gamepads = new GlfwGamepadCollection(this);
            Joysticks = new GlfwJoystickCollection(this);
            
            // initialize joysticks
            _joysticks = new List<GlfwJoystick>(Enumerable.Range(0, 16).Select(i => new GlfwJoystick(i)));
            _gamepads = new List<GlfwGamepad>(Enumerable.Range(0, 16).Select(i => new GlfwGamepad(i)));
        }

        public IntPtr Handle { get; }
        public IReadOnlyList<IGamepad> Gamepads { get; }
        public IReadOnlyList<IJoystick> Joysticks { get; }
        public IReadOnlyList<IKeyboard> Keyboards { get; } // TODO
        public IReadOnlyList<IMouse> Mice { get; } // TODO
        public IReadOnlyList<IInputDevice> OtherDevices { get; } = Array.Empty<IInputDevice>(); // not supported in GLFW

        public void Dispose()
        {
            InputHandler.UnregisterContext(this);
        }

        ~GlfwInputContext()
        {
            Dispose();
        }

        public void WindowUpdate(double obj)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        public event Action<IInputDevice, bool> ConnectionChanged;
    }
}
