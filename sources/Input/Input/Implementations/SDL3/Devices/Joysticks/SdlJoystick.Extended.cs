// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

// This partial class contains the logic for handling joystick-based device types such as SdlGamepad.
internal sealed partial class SdlJoystick
{
    public bool TryGetDevice<T>([NotNullWhen(true)] out T? device) where T : class, ISdlJoystick
    {
        foreach (var d in _devices)
        {
            if (d is T typedDevice)
            {
                device = typedDevice;
                return true;
            }
        }

        device = null;
        return false;
    }

    internal IReadOnlyList<Vector2> RawHatState => _rawHatState;
    internal IReadOnlyList<Button<JoystickButton>> RawButtonState => _rawButtonState;
    internal IReadOnlyList<float> RawAxisState => _rawAxisState;
    internal void AddDeviceMapping(ISdlJoystick device) => _devices.Add(device);
    internal void RemoveDeviceMapping(ISdlJoystick device) => _devices.Remove(device);

    internal void UpdateRawButtonState(JoystickButton button, bool isDown, float pressure)
    {
        var idx = button.Index();
        if (idx < 0)
        {
            throw new Exception("Received an invalid SDL button??");
        }

        ref var buttonState = ref _rawButtonState[idx];

        var previous = buttonState;

        buttonState = new Button<JoystickButton>(button, isDown, pressure);

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if (previous.IsDown != buttonState.IsDown || previous.Pressure != buttonState.Pressure)
        {
            _buttonEvents.Enqueue(new ButtonChangedEvent<JoystickButton>(this, Stopwatch.GetTimestamp(), buttonState, previous));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal float GetAxisState(JoystickAxis axis) => _rawAxisState[axis.Index()];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private float GetAxisStateByIndex(int index) => _rawAxisState[index];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector2 GetAxisStateByIndex2D(int xIndex, int yIndex) => new(GetAxisStateByIndex(xIndex), GetAxisStateByIndex(yIndex));

    internal bool UpdateRawAxisState(JoystickAxis axis, float value, out JoystickAxisMoveEvent evt)
    {
        var index = axis.Index();
        if (index < 0)
        {
            throw new Exception("Received an invalid SDL axis??");
        }

        ref var state = ref _rawAxisState[index];
        var p = state;
        state = value;

        var delta = value - p;
        if (delta != 0)
        {
            evt = new JoystickAxisMoveEvent(this, Stopwatch.GetTimestamp(), index, value, delta);
            _axisEvents.Enqueue(evt);
            return true;
        }

        evt = default;
        return false;
    }

    private readonly List<ISdlJoystick> _devices = [];
}
