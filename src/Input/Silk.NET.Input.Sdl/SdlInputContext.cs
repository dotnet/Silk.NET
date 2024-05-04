// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Internals;
using Silk.NET.SDL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

namespace Silk.NET.Input.Sdl
{
    internal class SdlInputContext : InputContextImplementationBase
    {
        private readonly SdlView _sdlView; // to circumvent CS0122
        private nint _lastHandle;

        public SdlInputContext(SdlView view) : base(view)
        {
            _sdlView = view;
            SdlGamepads = new Dictionary<int, SdlGamepad>();
            SdlJoysticks = new Dictionary<int, SdlJoystick>();
            Gamepads = new IsConnectedWrapper<IGamepad>
            (
                new CastReadOnlyList<SdlGamepad, IGamepad>
                    (new ReadOnlyCollectionListAdapter<SdlGamepad>(SdlGamepads.Values))
            );
            Joysticks = new IsConnectedWrapper<IJoystick>
            (
                new CastReadOnlyList<SdlJoystick, IJoystick>
                    (new ReadOnlyCollectionListAdapter<SdlJoystick>(SdlJoysticks.Values))
            );
            Keyboards = new IKeyboard[] {new SdlKeyboard(this)};
            Mice = new IMouse[] {new SdlMouse(this)};
        }

        // Public properties
        public override IReadOnlyList<IGamepad> Gamepads { get; }
        public override IReadOnlyList<IJoystick> Joysticks { get; }
        public override IReadOnlyList<IKeyboard> Keyboards { get; }
        public override IReadOnlyList<IMouse> Mice { get; }
        public override IReadOnlyList<IInputDevice> OtherDevices { get; } = Array.Empty<IInputDevice>();

        // Implementation-specific properties
        public Dictionary<int, SdlGamepad> SdlGamepads { get; }
        public Dictionary<int, SdlJoystick> SdlJoysticks { get; }

        public SDL.Sdl Sdl => _sdlView.Sdl;
        public override nint Handle => Window.Handle;
        public override event Action<IInputDevice, bool>? ConnectionChanged;

        public override void ProcessEvents()
        {
            if (Window.Handle == 0)
            {
                throw new InvalidOperationException("Input update event fired without an underlying window.");
            }

            if (_lastHandle != Window.Handle)
            {
                RefreshJoysticksAndGamepads();
                _lastHandle = Window.Handle;
            }

            var i = 0;
            var c = _sdlView.Events.Count;
            for (var j = 0; j < c; j++)
            {
                var @event = _sdlView.Events[i];
                var skipped = false;
                var r = 0;
                switch ((EventType) @event.Type)
                {
                    case EventType.Keydown:
                    case EventType.Keyup:
                    case EventType.Textediting:
                    case EventType.Textinput:
                    {
                        ((SdlKeyboard) Keyboards[0]).DoEvent(@event);
                        break;
                    }
                    case EventType.Mousemotion:
                    case EventType.Mousebuttondown:
                    case EventType.Mousebuttonup:
                    case EventType.Mousewheel:
                    {
                        ((SdlMouse) Mice[0]).DoEvent(@event);
                        break;
                    }
                    case EventType.Joyaxismotion:
                    {
                        if (SdlJoysticks.TryGetValue(@event.Jaxis.Which, out var joy))
                        {
                            joy.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Joyaxismotion;
                    }
                    case EventType.Joyballmotion:
                    {
                        if (SdlJoysticks.TryGetValue(@event.Jball.Which, out var joy))
                        {
                            joy.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event, this joystick does not exist
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Joyballmotion;
                    }
                    case EventType.Joyhatmotion:
                    {
                        if (SdlJoysticks.TryGetValue(@event.Jhat.Which, out var joy))
                        {
                            joy.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event, this joystick does not exist
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Joyhatmotion;
                    }
                    case EventType.Joybuttondown:
                    case EventType.Joybuttonup:
                    {
                        if (SdlJoysticks.TryGetValue(@event.Jbutton.Which, out var joy))
                        {
                            joy.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event, this joystick does not exist
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Joybuttonup;
                    }
                    case EventType.Joydeviceadded:
                    case EventType.Joydeviceremoved:
                    {
                        RefreshJoysticksAndGamepads();
                        if (SdlJoysticks.TryGetValue(@event.Jbutton.Which, out var joy))
                        {
                            ConnectionChanged?.Invoke(joy, @event.Type != (ulong) EventType.Joydeviceremoved);
                        }

                        break;
                    }
                    case EventType.Controlleraxismotion:
                    {
                        if (SdlGamepads.TryGetValue(@event.Caxis.Which, out var gp))
                        {
                            gp.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event, this gamepad does not exist
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Controlleraxismotion;
                    }
                    case EventType.Controllerbuttondown:
                    case EventType.Controllerbuttonup:
                    {
                        if (SdlGamepads.TryGetValue(@event.Cbutton.Which, out var gp))
                        {
                            gp.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event, this gamepad does not exist
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Controllerbuttonup;
                    }
                    case EventType.Controllerdeviceadded:
                    case EventType.Controllerdeviceremoved:
                    case EventType.Controllerdeviceremapped:
                    {
                        if (SdlGamepads.TryGetValue(@event.Cdevice.Which, out var gp))
                        {
                            gp.DoEvent(@event);
                            break;
                        }

                        if (r > 0)
                        {
                            // discard this event, this gamepad does not exist
                            skipped = true;
                            break;
                        }

                        RefreshJoysticksAndGamepads();
                        r++;
                        goto case EventType.Controllerdeviceremapped;
                    }
                    case EventType.Fingerdown:
                    case EventType.Fingerup:
                    case EventType.Fingermotion:
                    case EventType.Dollargesture:
                    case EventType.Dollarrecord:
                    case EventType.Multigesture:
                    {
                        // TODO touch input
                        break;
                    }
                    default:
                    {
                        skipped = true;
                        break;
                    }
                }

                if (!skipped)
                {
                    _sdlView.RemoveEvent(i);
                }
                else
                {
                    i++;
                }
            }

            ((SdlMouse) Mice[0]).Update();
            foreach (var gp in SdlGamepads.Values)
            {
                gp.Update();
            }

            // There's actually nowhere here that will raise an SDL error that we cause.
            // Sdl.ThrowError();
        }

        private void RefreshJoysticksAndGamepads()
        {
            for (var i = 0; i < Sdl.NumJoysticks(); i++)
            {
                var instanceId = Sdl.JoystickGetDeviceInstanceID(i);
                if (Sdl.IsGameController(i) == SdlBool.True)
                {
                    if (!SdlGamepads.TryGetValue(instanceId, out var gp))
                    {
                        SdlGamepads.Add(instanceId, new SdlGamepad(this, i, instanceId));
                    }
                    else
                    {
                        gp.ActualIndex = i;
                    }
                }
                else
                {
                    if (!SdlJoysticks.TryGetValue(instanceId, out var joy))
                    {
                        SdlJoysticks.Add(instanceId, new SdlJoystick(this, i, instanceId));
                    }
                    else
                    {
                        joy.ActualIndex = i;
                    }
                }
            }
        }

        public override void CoreDispose()
        {
            foreach (var gp in SdlGamepads.Values)
            {
                gp.Dispose();
            }

            foreach (var joy in SdlJoysticks.Values)
            {
                joy.Dispose();
            }
        }

        public void ChangeConnection(IInputDevice device, bool connected)
            => ConnectionChanged?.Invoke(device, connected);
    }
}
