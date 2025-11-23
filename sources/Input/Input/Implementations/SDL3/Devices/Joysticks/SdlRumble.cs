// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

internal unsafe class SdlRumble : IReadOnlyList<IMotor>
{
    public IMotor this[int index] => _motors[index];
    public int Count => _motors.Length;

    public static SdlRumble Create<T>(void* handle, ISdl sdl, int count) where T : unmanaged
    {
        SetRumbleDelegate setRumble;
        if (typeof(T) == typeof(GamepadHandle))
        {
            setRumble = SetGamepadRumble;
        }
        else if (typeof(T) == typeof(JoystickHandle))
        {
            setRumble = SetJoystickRumble;
        }
        else
        {
            throw new InvalidOperationException("Invalid device type");
        }

        return new SdlRumble(handle, sdl, count, setRumble);
    }

    private SdlRumble(void* handle, ISdl nativeBackend, int count, SetRumbleDelegate setRumble)
    {
        _setRumble = setRumble;
        _handle = handle;
        _motors = new IMotor[count];
        _motorFrequencies = new ushort[count];
        _nativeBackend = nativeBackend;
        CreateMotors(_motors);
    }

    private void CreateMotors(IMotor[] motors)
    {
        for (var i = 0; i < motors.Length; i++)
        {
            motors[i] = new Motor(this, i);
        }
    }

    IEnumerator<IMotor> IEnumerable<IMotor>.GetEnumerator() => (IEnumerator<IMotor>)_motors.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => _motors.GetEnumerator();

    private float GetRumble01(int motor) => _motorFrequencies[motor] * _toFloat;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void SetRumble01(int motor, float value) =>
        SetRumble01(motor, (ushort)(value * ushort.MaxValue), _motorFrequencies);

    private void SetRumble01(int motor, ushort value, ushort[] motorFrequencies)
    {
        // todo - use Haptics API instead?
        // todo - dispatch this to the correct input thread

        // TODO this entire API needs to be redesigned as right now this is literally only ever going to be useful if it's
        // just left or right. The original intention was that this would be useful for things like 3D haptics, but what did
        // I know. The SDL people seem to have done a good job with their haptic API, let's see what we can do with it.
        // For now, this has the same implementation as it always has.
        var valueShort = value;
        motorFrequencies[motor] = valueShort;
        var left = motorFrequencies[0];
        var right = motorFrequencies[1];
        _setRumble(_nativeBackend, _handle, left, right);
    }

    private static void SetJoystickRumble(ISdl backend, void* handle, ushort left, ushort right)
    {
        var average = (ushort)((left + right) >> 2);
        var joystickHandle = *(JoystickHandle*)&handle;
        if (!backend.RumbleJoystick(joystickHandle, average, average, _durationMs))
        {
            backend.ThrowError();
        }

        if (!backend.RumbleJoystickTriggers(joystickHandle, left, right, _durationMs))
        {
            backend.ThrowError();
        }
    }

    private static void SetGamepadRumble(ISdl backend, void* handle, ushort left, ushort right)
    {
        var average = (ushort)((left + right) >> 2);
        var gamepadHandle = *(GamepadHandle*)&handle;
        if (!backend.RumbleGamepad(gamepadHandle, average, average, _durationMs))
        {
            backend.ThrowError();
        }

        if (!backend.RumbleGamepadTriggers(gamepadHandle, left, right, _durationMs))
        {
            backend.ThrowError();
        }
    }

    private readonly SetRumbleDelegate _setRumble;
    private readonly void* _handle;
    private readonly IMotor[] _motors;
    private readonly ushort[] _motorFrequencies;
    private readonly ISdl _nativeBackend;
    private const float _toFloat = 1f / ushort.MaxValue;
    private const uint _durationMs = uint.MaxValue;


    private delegate void SetRumbleDelegate(ISdl nativeBackend, void* handle, ushort left, ushort right);

    private class Motor : IMotor
    {
        private readonly int _freqIndex;
        private readonly SdlRumble _rumbler;

        public Motor(SdlRumble rumbler, int freqIdx)
        {
            _freqIndex = freqIdx;
            _rumbler = rumbler;
        }

        public float Speed
        {
            get => _rumbler.GetRumble01(_freqIndex);
            set => _rumbler.SetRumble01(_freqIndex, value);
        }
    }
}

