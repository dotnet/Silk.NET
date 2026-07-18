// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Joysticks;
using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend
{
    internal bool TryGetOrCreateDevice<T>(ulong id, long timestamp, ulong sdlTimestamp, [NotNullWhen(true)] out T? device, bool isSimulated = false)
        where T : SdlDevice, ISdlDevice<T>
    {
        // If we already have a device with this ID, return it.
        var sdlDevices = _eventProcessingArgs.Devices;
        for (var i = 0; i < sdlDevices.Count; i++)
        {
            if (sdlDevices[i] is T typedDevice && typedDevice.SdlDeviceId == id)
            {
                device = typedDevice;
                return true;
            }
        }

        try
        {
            device = T.CreateDevice(id, timestamp, sdlTimestamp, isSimulated, this, _silkEvents);
        }
        catch (Exception e)
        {
            InputLog.Error($"Failed to create device {nameof(T)} with id '{id}': {e}");
            device = null;
            return false;
        }

        if (device is null)
        {
            InputLog.Error($"Failed to create device {nameof(T)} with id '{id}'");
            return false;
        }

        try
        {
            device.Initialize(timestamp, sdlTimestamp);
        }
        catch (Exception e)
        {
            InputLog.Error($"Failed to initialize device {nameof(T)} with id '{id}': {e}");
            device.Dispose();
            device = null;
            return false;
        }

        _eventProcessingArgs.AddDevice(device, timestamp, sdlTimestamp);
        InputLog.Debug($"{typeof(T)} added: (sdl ID: {id})");
        return true;
    }

    private bool RemoveDevice<T>(uint id, long timestamp, ulong sdlTimestamp) where T : SdlDevice, ISdlDevice<T>
    {
        if (_eventProcessingArgs.RemoveDevice<T>(id, timestamp, sdlTimestamp, out var device))
        {
            // device IDs may have changed when a device was removed, so we need to refresh them
            RefreshDeviceIds(_eventProcessingArgs.Devices);
            return true;
        }

        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool ContainsDevice(nint uniqueId) => _eventProcessingArgs.ContainsDevice(uniqueId);

    private static void RefreshDeviceIds(IReadOnlyList<SdlDevice> devices)
    {
        for (var i = 0; i < devices.Count; i++)
        {
            if (devices[i] is IOrderedDevice d)
            {
                d.RefreshSdlId();
            }
        }
    }

    public bool TryGetVirtualTouchpad(nint ownerId, int touchpadId, in Maths.Box3D<float> bounds, ulong sdlTimestamp, long timestamp, [NotNullWhen(true)] out SdlTouchSurface? device)
    {
        var hash = HashCode.Combine(ownerId, touchpadId);
        ulong id = Unsafe.As<int, uint>(ref hash);
        if (!TryGetOrCreateDevice(id, timestamp, sdlTimestamp, out device, isSimulated: true))
        {
            return false;
        }

        device.UpdateFalseTarget(bounds);
        return true;
    }
}
