// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Internals;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

namespace Silk.NET.Input.Sdl
{
    internal class SdlInputContext : IInputContext
    {
        private readonly SdlView _view;

        public SdlInputContext(SdlView view)
        {
            _view = view;
            _view.Update += ViewOnUpdate;
            SdlGamepads = new Dictionary<int, SdlGamepad>();
            SdlJoysticks = new Dictionary<int, SdlJoystick>();
            Gamepads = new CastReadOnlyList<SdlGamepad, IGamepad>
                (new ReadOnlyCollectionListAdapter<SdlGamepad>(SdlGamepads.Values));
            Joysticks = new CastReadOnlyList<SdlJoystick, IJoystick>
                (new ReadOnlyCollectionListAdapter<SdlJoystick>(SdlJoysticks.Values));
            Keyboards = new IKeyboard[]{new SdlKeyboard(this)};
            Mice = new IMouse[]{new SdlMouse(this)};
        }

        // Public properties
        public IReadOnlyList<IGamepad> Gamepads { get; }
        public IReadOnlyList<IJoystick> Joysticks { get; }
        public IReadOnlyList<IKeyboard> Keyboards { get; }
        public IReadOnlyList<IMouse> Mice { get; }
        public IReadOnlyList<IInputDevice> OtherDevices { get; }

        // Implementation-specific properties
        public Dictionary<int, SdlGamepad> SdlGamepads { get; }
        public Dictionary<int, SdlJoystick> SdlJoysticks { get; }

        public SDL.Sdl Sdl => _view.Sdl;
        public IntPtr Handle => _view.Handle;
        public event Action<IInputDevice, bool>? ConnectionChanged;

        private void ViewOnUpdate(double obj)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
