// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Silk.NET.Input.SDL3.Devices.Joysticks;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend
{
    internal bool TryGetOrCreateDevice<T>(ulong id, [NotNullWhen(true)] out T? device)
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
            device = T.CreateDevice(id, this);
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


        sdlDevices.Add(device);
        InputLog.Debug($"{typeof(T)} added: (sdl ID: {id})");
        return true;
    }

    private bool RemoveDevice<T>(List<SdlDevice> devices, uint id)
    {
        var deviceIdx = devices.FindIndex(x => x is T && x.SdlDeviceId == id);

        if (deviceIdx == -1)
        {
            // we never used this device to begin with, so just ignore its removal
            return false;
        }

        var device = devices[deviceIdx];
        device.Dispose();
        devices.RemoveAt(deviceIdx);
        _ = UnregisterDevice(device.Id);

        // device IDs may have changed when a device was removed, so we need to refresh them
        RefreshDeviceIds(devices);
        return true;
    }

    private bool UnregisterDevice(nint uniqueId)
    {
#if DEBUG
        if (_deviceRegistry.Remove(uniqueId))
        {
            return true;
        }

        InputLog.Error($"Tried to unregister device with id {uniqueId} that was not registered");
        return false;

#else
        return _deviceRegistry.Remove(uniqueId);
#endif
    }

    public bool RegisterDevice(nint uniqueId)
    {
#if DEBUG
        if (_deviceRegistry.Add(uniqueId))
        {
            return true;
        }

        InputLog.Error($"Tried to register device with id {uniqueId} that was already registered");
        return false;

#else
        return _deviceRegistry.Add(uniqueId);
#endif
    }

    private static void RefreshDeviceIds(List<SdlDevice> devices)
    {
        for (var i = 0; i < devices.Count; i++)
        {
            if (devices[i] is IOrderedDevice d)
            {
                d.RefreshSdlId();
            }
        }
    }
}
