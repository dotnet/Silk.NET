// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;

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

        _rawButtonState[idx] = new Button<JoystickButton>(button, isDown, pressure);
    }

    internal void UpdateRawAxisState(JoystickAxis axis, float value)
    {
        var index = axis.Index();
        if (index < 0)
        {
            throw new Exception("Received an invalid SDL axis??");
        }

        _rawAxisState[axis.Index()] = value;
    }

    private readonly List<ISdlJoystick> _devices = [];
}
