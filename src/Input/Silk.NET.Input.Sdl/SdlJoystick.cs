using System;
using System.Collections.Generic;
using Silk.NET.Core.Native;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal class SdlJoystick : IJoystick, ISdlDevice, ISdlJoystick, IDisposable
    {
        private readonly SdlInputContext _ctx;
        private readonly unsafe Joystick* _joystick;

        private Button[] _buttons;
        private Axis[] _axes;
        private Hat[] _hats;

        public unsafe SdlJoystick(SdlInputContext ctx, int currentIndex, int instanceId)
        {
            _ctx = ctx;
            InstanceId = instanceId;
            ActualIndex = currentIndex;
            _joystick = _ctx.Sdl.JoystickOpen(currentIndex);
            _buttons = new Button[0]; // arrays will be sized appropriately later
            _axes = new Axis[0];
            _hats = new Hat[0];
        }

        public unsafe string Name => SilkMarshal.PtrToString((nint) _ctx.Sdl.JoystickName(_joystick))!;
        public int Index => ActualIndex;
        public int ActualIndex { get; set; }
        public int InstanceId { get; }

        public unsafe bool IsConnected => _ctx.Sdl.JoystickGetAttached(_joystick) == SdlBool.True &&
                                          _ctx.Sdl.IsGameController(ActualIndex) == SdlBool.False;

        public IReadOnlyList<Axis> Axes => _axes;
        public IReadOnlyList<Button> Buttons => _buttons;
        public IReadOnlyList<Hat> Hats => _hats;
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button>? ButtonDown;
        public event Action<IJoystick, Button>? ButtonUp;
        public event Action<IJoystick, Axis>? AxisMoved;
        public event Action<IJoystick, Hat>? HatMoved;

        public void DoEvent(Event @event)
        {
            switch ((EventType) @event.Type)
            {
                case EventType.Joyaxismotion:
                {
                    if (_axes.Length < @event.Jaxis.Axis + 1)
                    {
                        Array.Resize(ref _axes, @event.Jaxis.Axis + 1);
                    }

                    AxisMoved?.Invoke
                    (
                        this,
                        _axes[@event.Jaxis.Axis] = new Axis
                            (@event.Jaxis.Axis, (float) @event.Jaxis.Value / short.MaxValue)
                    );
                    break;
                }
                case EventType.Joyballmotion:
                {
                    // todo investigate adding balls to the input spec later down the line
                    break;
                }
                case EventType.Joyhatmotion:
                {
                    if (_hats.Length < @event.Jhat.Hat + 1)
                    {
                        Array.Resize(ref _hats, @event.Jhat.Hat + 1);
                    }

                    var val = @event.Jhat.Value;
                    HatMoved?.Invoke
                    (
                        this,
                        _hats[@event.Jhat.Hat] = new Hat
                        (
                            @event.Jhat.Hat, (Position2D) ((val & 0x01) * (int) Position2D.Up +
                                                           (val & 0x02) * (int) Position2D.Right +
                                                           (val & 0x04) * (int) Position2D.Down +
                                                           (val & 0x08) * (int) Position2D.Left)
                        )
                    );
                    break;
                }
                case EventType.Joybuttondown:
                {
                    if (_buttons.Length < @event.Jbutton.Button + 1)
                    {
                        Array.Resize(ref _buttons, @event.Jbutton.Button + 1);
                    }

                    ButtonDown?.Invoke
                    (
                        this,
                        _buttons[@event.Jbutton.Button] = new Button
                            ((ButtonName) @event.Jbutton.Button, @event.Jbutton.Button, true)
                    );
                    break;
                }
                case EventType.Joybuttonup:
                {
                    if (_buttons.Length < @event.Jbutton.Button + 1)
                    {
                        Array.Resize(ref _buttons, @event.Jbutton.Button + 1);
                    }

                    ButtonUp?.Invoke
                    (
                        this,
                        _buttons[@event.Jbutton.Button] = new Button
                            ((ButtonName) @event.Jbutton.Button, @event.Jbutton.Button, false)
                    );
                    break;
                }
                case EventType.Joydeviceadded:
                {
                    _ctx.ChangeConnection(this, true);
                    break;
                }
                case EventType.Joydeviceremoved:
                {
                    _ctx.ChangeConnection(this, false);
                    break;
                }
            }
        }

        public unsafe void Dispose()
        {
            _ctx.Sdl.JoystickClose(_joystick);
        }
    }
}
