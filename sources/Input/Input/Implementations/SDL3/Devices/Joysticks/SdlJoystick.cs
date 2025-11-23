// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

internal sealed unsafe partial class SdlJoystick : SdlDevice, IJoystick, ISdlDevice<SdlJoystick>, IOrderedDevice
{
    public JoystickState State { get; }
    internal readonly JoystickType JoystickType;
    internal JoystickHandle JoystickHandle { get; }

    public static SdlJoystick CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        nint uniqueId = 0;

        var guid = backend.Sdl.GetJoystickGuidForID(sdlDeviceId);
        if (backend.AttemptUniqueId(new ReadOnlySpan<byte>(&guid, 16), ref uniqueId))
        {
            return new SdlJoystick(sdlDeviceId, uniqueId, backend);
        }

        var pathPtr = backend.Sdl.GetJoystickPathForID(sdlDeviceId);
        if (backend.AttemptUniqueId(pathPtr, ref uniqueId))
        {
            return new SdlJoystick(sdlDeviceId, uniqueId, backend);
        }

        var name = backend.Sdl.GetJoystickNameForID(sdlDeviceId);
        if (backend.AttemptUniqueId(name, ref uniqueId))
        {
            return new SdlJoystick(sdlDeviceId, uniqueId, backend);
        }

        var type = backend.Sdl.GetJoystickTypeForID(sdlDeviceId);
        if (backend.AttemptUniqueId(type, ref uniqueId))
        {
            return new SdlJoystick(sdlDeviceId, uniqueId, backend);
        }

        uniqueId = backend.FallbackUniqueId(sdlDeviceId, uniqueId);
        return new SdlJoystick(sdlDeviceId, uniqueId, backend);
    }


    public override string Name => NativeBackend.GetJoystickNameForID(SdlDeviceId).ReadToString();

    public override uint SdlDeviceId => _sdlDeviceId;



    private SdlJoystick(uint sdlDeviceId, nint uniqueId, SdlInputBackend backend) : base(backend, uniqueId, sdlDeviceId)
    {
        var joystickHandle = NativeBackend.OpenJoystick(sdlDeviceId);
        _sdlDeviceId = sdlDeviceId;

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

        JoystickHandle = joystickHandle;
        JoystickType = NativeBackend.GetJoystickType(joystickHandle);


        // init current joystick state
        var buttonCount = NativeBackend.GetNumJoystickButtons(joystickHandle);
        for (byte i = 0; i < buttonCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickButtonRaw(JoystickHandle, i);
            AddButtonEvent(i, joystickInput);
        }

        var axisCount = NativeBackend.GetNumJoystickAxes(joystickHandle);
        for (var i = 0; i < axisCount; i++)
        {
            var joystickInput = NativeBackend.GetJoystickAxis(JoystickHandle, i);
            if (joystickInput == 0)
            {
                // this indicates an sdl error, so just set our internal axis to 0
                joystickInput = short.MinValue;
            }

            AddAxisEvent(i, joystickInput);
        }

        var hatCount = NativeBackend.GetNumJoystickHats(joystickHandle);
        for (var i = 0; i < hatCount; ++i)
        {
            var hatInput = NativeBackend.GetJoystickHat(joystickHandle, i);
            AddHatEvent(i, hatInput);
        }

        _rawAxisState = new float[EnumInfo<JoystickAxis>.UniqueValues.Count + axisCount];
        _rawButtonState = new Button<JoystickButton>[EnumInfo<JoystickButton>.UniqueValues.Count + buttonCount];

        State = new JoystickState(_rawAxisState, _rawButtonState, _rawHatState);
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

    public void AddHatEvent(int hatIdx, byte hatInput)
    {
        var hatState = (HatState)hatInput;
        var left = (hatState & HatState.Left) == HatState.Left;
        var right = (hatState & HatState.Right) == HatState.Right;

        var x = (float)(*(byte*)&right - *(byte*)&left);
        var up = (hatState & HatState.Up) == HatState.Up;
        var down = (hatState & HatState.Down) == HatState.Down;
        var y = (float)(*(byte*)&up - *(byte*)&down);

        _rawHatState[hatIdx] = new Vector2(x, y);

        foreach(var device in _devices)
        {
            device.UpdateFromJoyHat(hatIdx, hatState);
        }
    }

    public void AddAxisEvent(int axis, short joystickInput)
    {
        _rawAxisState[axis] = (float)(joystickInput + short.MaxValue) / ushort.MaxValue;
        foreach (var device in _devices)
        {
            device.UpdateFromJoyAxis(axis, joystickInput);
        }
    }

    public void AddButtonEvent(byte sdlButtonId, byte sdlButtonDown)
    {
        var down = sdlButtonDown > 0;
        _rawButtonState[sdlButtonId] = new Button<JoystickButton>((JoystickButton)sdlButtonId, down, down ? 1 : 0);
        foreach (var device in _devices)
        {
            device.UpdateFromJoyButton(sdlButtonId, down);
        }
    }

    #endregion

    internal static (float minus, float plus) SplitValue(float mappedValue)
    {
        mappedValue = (float)((mappedValue - 0.5d) * 2d);
        return mappedValue > 0 ? (0, mappedValue) : (mappedValue, 0);
    }


    protected override void Release() => NativeBackend.CloseJoystick(JoystickHandle);

    public void RefreshSdlId() => _sdlDeviceId = NativeBackend.GetJoystickID(JoystickHandle);
    private uint _sdlDeviceId;

    // State
    private readonly Button<JoystickButton>[] _rawButtonState;
    private readonly float[] _rawAxisState;
    private readonly Vector2[] _rawHatState = [];

    // Constants
    internal const short DigitalThreshold = short.MaxValue / 8;

    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;

}
