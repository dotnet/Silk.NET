// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

internal sealed unsafe partial class SdlJoystick : SdlDevice, IJoystick, ISdlDevice<SdlJoystick>, IOrderedDevice
{
    public JoystickState State { get; private set; }
    private JoystickType _joystickType;
    internal JoystickHandle JoystickHandle { get; private set; }

    public static SdlJoystick CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, SdlInputBackend backend, SilkEventContext silkEvents)
    {
        nint uniqueId = 0;

        var guid = backend.Sdl.GetJoystickGuidForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(new ReadOnlySpan<byte>(&guid, 16), ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, silkEvents);
        }

        var pathPtr = backend.Sdl.GetJoystickPathForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(pathPtr, ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, silkEvents);
        }

        var name = backend.Sdl.GetJoystickNameForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(name, ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, silkEvents);
        }

        var type = backend.Sdl.GetJoystickTypeForID((uint)sdlDeviceId);
        if (backend.AttemptUniqueId(type, ref uniqueId))
        {
            return CreatePls(backend, uniqueId, sdlDeviceId, silkEvents);
        }

        uniqueId = SdlInputBackend.FallbackUniqueId<SdlJoystick>(sdlDeviceId, uniqueId);
        return CreatePls(backend, uniqueId, sdlDeviceId, silkEvents);

        static SdlJoystick CreatePls(SdlInputBackend sdlInputBackend, nint uniqueId, ulong sdlDeviceId,
            SilkEventContext context)
        {
            return new SdlJoystick(sdlDeviceId, uniqueId, sdlInputBackend) {
                ButtonEvents = context.ButtonChangedSdlEvents,
                AxisEvents = context.JoystickAxisMoveSdlEvents,
                HatEvents = context.JoystickHatMoveSdlEvents
            };
        }
    }


    public override string Name => NativeBackend.GetJoystickNameForID((uint)SdlDeviceId).ReadToString();

    public override ulong SdlDeviceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _sdlDeviceId;
    }


    private SdlJoystick(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend) : base(backend, uniqueId,
        sdlDeviceId)
    {
        _sdlDeviceId = sdlDeviceId;
    }


    [Flags]
    internal enum HatState : byte
    {
        Up = (byte)Sdl.HatUp,
        Right = (byte)Sdl.HatRight,
        Down = (byte)Sdl.HatDown,
        Left = (byte)Sdl.HatLeft,
        Centered = (byte)Sdl.HatCentered,
        LeftUp = (byte)Sdl.HatLeftup,
        RightUp = (byte)Sdl.HatRightup,
        LeftDown = (byte)Sdl.HatLeftdown,
        RightDown = (byte)Sdl.HatRightdown
    }

    #region Sdl Events

    public void AddHatEvent(int hatIdx, byte hatInput, ulong sdlTimestamp, long timestamp)
    {
        var hatState = (HatState)hatInput;
        var left = (hatState & HatState.Left) == HatState.Left;
        var right = (hatState & HatState.Right) == HatState.Right;

        var x = (float)(*(byte*)&right - *(byte*)&left);
        var up = (hatState & HatState.Up) == HatState.Up;
        var down = (hatState & HatState.Down) == HatState.Down;
        var y = (float)(*(byte*)&up - *(byte*)&down);

        ref var hatStateRef = ref _rawHatState[hatIdx];
        var previous = hatStateRef;
        hatStateRef = new Vector2(x, y);

        foreach (var device in _devices)
        {
            device.UpdateFromJoyHat(hatIdx, hatState, sdlTimestamp, timestamp);
        }

        var delta = hatStateRef - previous;
        if (delta != Vector2.Zero)
        {
            HatEvents.Enqueue(new JoystickHatMoveEvent(this, timestamp, hatIdx, hatStateRef, delta), sdlTimestamp);
        }
    }

    public void AddAxisEvent(int axis, short joystickInput, ulong sdlTimestamp, long timestamp)
    {
        _rawAxisState[axis] = (float)(joystickInput + short.MaxValue) / ushort.MaxValue;
        foreach (var device in _devices)
        {
            device.UpdateFromJoyAxis(axis, joystickInput, sdlTimestamp, timestamp);
        }
    }

    public void AddButtonEvent(byte sdlButtonId, byte sdlButtonDown, ulong sdlTimestamp, long timestamp)
    {
        var down = sdlButtonDown > 0;
        var joystickButton = (JoystickButton)sdlButtonId;
        var idx = joystickButton.Index();
        if (idx == -1)
        {
            InputLog.Error($"No index for button {sdlButtonId} on joystick {Id}");
            return;
        }

        if (idx >= _rawButtonState.Length)
        {
            InputLog.Error($"Button index {idx} exceeds button state array length {_rawButtonState.Length} on joystick {Id}");
            return;
        }

        _rawButtonState[idx] = new Button<JoystickButton>(joystickButton, down, down ? 1 : 0);
        foreach (var device in _devices)
        {
            device.UpdateFromJoyButton(sdlButtonId, down, sdlTimestamp, timestamp);
        }
    }

    #endregion

    /// <summary>
    /// Returns a "split" axis vector, taking what would be a single axis value (e.g. Left Thumbstick X) from (0, 1)
    /// and splitting it into two separate axes from (0, 1)
    /// </summary>
    /// <param name="value">The axis value on a scale of 0 to 1</param>
    /// <returns>
    /// A vector representing the split axis values with <br/>
    /// X as the 'minus' component and
    /// Y as the 'plus' component
    /// </returns>
    /// <remarks>
    /// Todo: the gamepad api demands that joystick axes are (-1, 1)
    /// </remarks>
    internal static Vector2 SplitValue(float value)
    {
        value = (float)((value - 0.5d) * 2d);
        return value > 0 ? new Vector2(0, value) : new Vector2(value, 0);
    }

    protected internal override void Initialize(long timestamp, ulong sdlTimestamp)
    {
        var nowTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
        var nowSdlTimestamp = NativeBackend.GetTicks();

        var joystickHandle = NativeBackend.OpenJoystick((uint)SdlDeviceId);
        if (joystickHandle.Handle == null)
        {
            var error = NativeBackend.GetError();
            string? errorStr = null;
            if (error.Native != null)
            {
                errorStr = error.ReadToString();
                NativeBackend.Free(error.Native);
            }

            throw new Exception($"Failed to open joystick: {errorStr ?? "Unknown error."}");
        }

        // init current joystick state
        var buttonCount = NativeBackend.GetNumJoystickButtons(joystickHandle);
        var uniqueJoyButtonCount = Math.Max(EnumInfo<JoystickButton>.UniqueValues.Count, (int)GamepadButton.Count);
        _rawButtonState = new Button<JoystickButton>[uniqueJoyButtonCount + buttonCount];

        var axisCount = NativeBackend.GetNumJoystickAxes(joystickHandle);
        _rawAxisState = new float[EnumInfo<JoystickAxis>.UniqueValues.Count + axisCount];

        var hatCount = NativeBackend.GetNumJoystickHats(joystickHandle);
        _rawHatState = new Vector2[hatCount];

        for (byte i = 0; i < buttonCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickButtonRaw(JoystickHandle, i);
            AddButtonEvent(i, joystickInput, nowSdlTimestamp, nowTimestamp);
        }

        for (var i = 0; i < axisCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickAxis(JoystickHandle, i);
            if (joystickInput == 0)
            {
                // this indicates an sdl error, so just set our internal axis to 0
                joystickInput = short.MinValue;
            }

            AddAxisEvent(i, joystickInput, nowSdlTimestamp, nowTimestamp);
        }

        for (var i = 0; i < hatCount; ++i)
        {
            var hatInput = NativeBackend.GetJoystickHat(joystickHandle, i);
            AddHatEvent(i, hatInput, nowSdlTimestamp, nowTimestamp);
        }

        JoystickHandle = joystickHandle;
        _joystickType = NativeBackend.GetJoystickType(joystickHandle);
        State = new JoystickState(_rawAxisState, _rawButtonState, _rawHatState);
    }

    protected override void Release() => NativeBackend.CloseJoystick(JoystickHandle);

    public void RefreshSdlId() => _sdlDeviceId = NativeBackend.GetJoystickID(JoystickHandle);
    private ulong _sdlDeviceId;

    // State
    private Button<JoystickButton>[] _rawButtonState;
    private float[] _rawAxisState;
    private Vector2[] _rawHatState;

    // Constants
    internal const short DigitalThreshold = short.MaxValue / 8;

    // events
    internal required ISdlEventQueue<ButtonChangedEvent<JoystickButton>> ButtonEvents { get; init; }
    internal required ISdlEventQueue<JoystickAxisMoveEvent> AxisEvents { get; init; }
    internal required ISdlEventQueue<JoystickHatMoveEvent> HatEvents { get; init; }

    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
}
