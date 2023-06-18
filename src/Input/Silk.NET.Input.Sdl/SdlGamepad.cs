using System;
using System.Collections.Generic;
using Silk.NET.Core.Native;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal class SdlGamepad : IGamepad, ISdlDevice, ISdlJoystick, IDisposable
    {
        private readonly SdlInputContext _ctx;
        private readonly unsafe GameController* _controller;

        private readonly Button[] _buttons =
        {
            new Button(ButtonName.A, 0x0, false),
            new Button(ButtonName.B, 0x1, false),
            new Button(ButtonName.X, 0x2, false),
            new Button(ButtonName.Y, 0x3, false),
            new Button(ButtonName.Back, 0x4, false),
            new Button(ButtonName.Home, 0x5, false),
            new Button(ButtonName.Start, 0x6, false),
            new Button(ButtonName.LeftStick, 0x7, false),
            new Button(ButtonName.RightStick, 0x8, false),
            new Button(ButtonName.LeftBumper, 0x9, false),
            new Button(ButtonName.RightBumper, 0xA, false),
            new Button(ButtonName.DPadUp, 0xB, false),
            new Button(ButtonName.DPadDown, 0xC, false),
            new Button(ButtonName.DPadLeft, 0xD, false),
            new Button(ButtonName.DPadRight, 0xE, false)
        };

        private readonly bool[] _thumbsticksChanged = new bool[2];

        private readonly Thumbstick[] _thumbsticks =
        {
            new Thumbstick(0, 0, 0),
            new Thumbstick(1, 0, 0)
        };

        private readonly Trigger[] _triggers =
        {
            new Trigger(0, 0),
            new Trigger(1, 0)
        };

        public unsafe SdlGamepad(SdlInputContext ctx, int currentIndex, int instanceId)
        {
            _ctx = ctx;
            InstanceId = instanceId;
            ActualIndex = currentIndex;
            VibrationMotors = new IMotor[] {new SdlMotor(0, this), new SdlMotor(1, this)};
            _controller = ctx.Sdl.GameControllerOpen(currentIndex);
        }

        public unsafe string Name =>
            IsConnected
                ? SilkMarshal.PtrToString((nint) _ctx.Sdl.GameControllerName(_controller))!
                : "Silk.NET Gamepad (via SDL)";

        public int Index => ActualIndex;
        public bool IsConnected => _ctx.Sdl.IsGameController(Index) == SdlBool.True;
        public IReadOnlyList<Button> Buttons => _buttons;
        public IReadOnlyList<Thumbstick> Thumbsticks => _thumbsticks;
        public IReadOnlyList<Trigger> Triggers => _triggers;
        public IReadOnlyList<IMotor> VibrationMotors { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IGamepad, Button>? ButtonDown;
        public event Action<IGamepad, Button>? ButtonUp;
        public event Action<IGamepad, Thumbstick>? ThumbstickMoved;
        public event Action<IGamepad, Trigger>? TriggerMoved;

        public void DoEvent(Event @event)
        {
            switch ((EventType) @event.Type)
            {
                case EventType.Controlleraxismotion:
                {
                    switch ((GameControllerAxis) @event.Caxis.Axis)
                    {
                        case GameControllerAxis.ControllerAxisLeftx:
                        {
                            var thumbstick0 = new Thumbstick(0, 
                                Deadzone.Apply((float) @event.Caxis.Value / short.MaxValue), 
                                Deadzone.Apply(_thumbsticks[0].Y));

                            if (thumbstick0.X != _thumbsticks[0].X)
                            {
                                _thumbsticksChanged[0] = true;
                            }
                            _thumbsticks[0] = thumbstick0;
                            break;
                        }
                        case GameControllerAxis.ControllerAxisLefty:
                        {
                            var thumbstick0 = new Thumbstick(0,
                                Deadzone.Apply(_thumbsticks[0].X),
                                Deadzone.Apply((float) @event.Caxis.Value / short.MaxValue));

                            if (thumbstick0.Y != _thumbsticks[0].Y)
                            {
                                _thumbsticksChanged[0] = true;
                            }
                            _thumbsticks[0] = thumbstick0;
                            break;
                        }
                        case GameControllerAxis.ControllerAxisRightx:
                        {
                            var thumbstick1 = new Thumbstick(1,
                                Deadzone.Apply((float) @event.Caxis.Value / short.MaxValue),
                                Deadzone.Apply(_thumbsticks[1].Y));

                            if (thumbstick1.X != _thumbsticks[1].X)
                            {
                                _thumbsticksChanged[1] = true;
                            }
                            _thumbsticks[1] = thumbstick1;
                            break;
                        }
                        case GameControllerAxis.ControllerAxisRighty:
                        {
                            var thumbstick1 = new Thumbstick(1,
                                Deadzone.Apply(_thumbsticks[1].X),
                                Deadzone.Apply((float) @event.Caxis.Value / short.MaxValue));

                            if (thumbstick1.Y != _thumbsticks[1].Y)
                            {
                                _thumbsticksChanged[1] = true;
                            }
                            _thumbsticks[1] = thumbstick1;
                            break;
                        }
                        case GameControllerAxis.ControllerAxisTriggerleft:
                        {
                            TriggerMoved?.Invoke
                                (this, _triggers[0] = new Trigger(0, (float) @event.Caxis.Value / short.MaxValue));
                            break;
                        }
                        case GameControllerAxis.ControllerAxisTriggerright:
                        {
                            TriggerMoved?.Invoke
                                (this, _triggers[1] = new Trigger(1, (float) @event.Caxis.Value / short.MaxValue));
                            break;
                        }
                    }

                    break;
                }
                case EventType.Controllerbuttondown:
                {
                    var ogBtn = _buttons[@event.Cbutton.Button];
                    ButtonDown?.Invoke
                        (this, _buttons[@event.Cbutton.Button] = new Button(ogBtn.Name, ogBtn.Index, true));
                    break;
                }
                case EventType.Controllerbuttonup:
                {
                    var ogBtn = _buttons[@event.Cbutton.Button];
                    ButtonUp?.Invoke
                        (this, _buttons[@event.Cbutton.Button] = new Button(ogBtn.Name, ogBtn.Index, false));
                    break;
                }
                case EventType.Controllerdeviceadded:
                {
                    _ctx.ChangeConnection(this, true);
                    break;
                }
                case EventType.Controllerdeviceremoved:
                {
                    _ctx.ChangeConnection(this, false);
                    break;
                }
            }

            for (var i = 0; i < _thumbsticksChanged.Length; i++)
            {
                if (_thumbsticksChanged[i])
                {
                    ThumbstickMoved?.Invoke(this, _thumbsticks[i]);
                    _thumbsticksChanged[i] = false;
                }
            }
        }

        public unsafe void Update()
        {
            if (VibrationChanged)
            {
                _ctx.Sdl.GameControllerRumble
                (
                    _controller, (ushort) (0xffff / VibrationMotors[0].Speed),
                    (ushort) (0xffff / VibrationMotors[1].Speed), 0xffff
                );

                VibrationChanged = false;
            }
        }

        public int ActualIndex { get; set; }
        public int InstanceId { get; }
        public bool VibrationChanged { get; set; }

        public unsafe void Dispose()
        {
            _ctx.Sdl.GameControllerClose(_controller);
        }
    }
}
