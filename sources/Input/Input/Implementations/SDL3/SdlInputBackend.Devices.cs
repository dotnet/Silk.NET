// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Joysticks;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend
{
    internal bool TryGetOrCreateDevice<T>(ulong id, long timestamp, ulong sdlTimestamp, [NotNullWhen(true)] out T? device, bool isSimulated = false)
        where T : SdlDevice, ISdlDevice<T>
    {
        // If we already have a device with this ID, return it.
        var sdlDevices = _deviceRegistry.Devices;
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
            device = T.CreateDevice(id, timestamp, sdlTimestamp, isSimulated, this, _sdlInputEvents);
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

        if (_deviceRegistry.AddDevice(device))
        {
            _sdlInputEvents.ConnectionEvents.Enqueue(new ConnectionEvent(device, timestamp, true), sdlTimestamp);
        }

        #if DEBUG
        InputLog.Debug($"DEVICE ADDED: {typeof(T)} (sdl ID: {id})");
        #endif
        return true;
    }

    private bool RemoveDevice<T>(uint id, long timestamp, ulong sdlTimestamp) where T : SdlDevice, ISdlDevice<T>
    {
        if (_deviceRegistry.RemoveDevice<T>(id, out var device))
        {
            _sdlInputEvents.ConnectionEvents.Enqueue(new ConnectionEvent(device, timestamp, false), sdlTimestamp);

            // device IDs may have changed when a device was removed, so we need to refresh them
            RefreshDeviceIds(_deviceRegistry.Devices);
            return true;
        }

        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool ContainsDevice(nint uniqueId) => _deviceRegistry.ContainsDevice(uniqueId);

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

    /// <summary>
    /// A struct containing all the data required for processing SDL events.
    /// This is a struct to prevent additional pointer indirections, but the field is applied to should be considered
    /// an
    /// </summary>
    private readonly struct DeviceRegistry
    {
        public IReadOnlyList<SdlDevice> Devices => _devices;
        private readonly List<SdlDevice> _devices;
        private readonly HashSet<nint> _deviceRegistry = [];

        /// <param name="sdlDevices">A list of sdl devices. If not provided, a new list will be allocated.</param>
        public DeviceRegistry(List<SdlDevice>? sdlDevices = null) => _devices = sdlDevices ?? [];

        public bool AddDevice<T>(T device) where T : SdlDevice, ISdlDevice<T>
        {
            if (!_deviceRegistry.Add(device.Id))
            {
                InputLog.Error($"Tried to add device with id {device.Id} that was already registered");
                return false;
            }

            _devices.Add(device);
            return true;
        }

        public bool RemoveDevice<T>(uint id, [NotNullWhen(true)] out SdlDevice? device)
            where T : SdlDevice, ISdlDevice<T>
        {
            var deviceIdx = _devices.FindIndex(x => x is T && x.SdlDeviceId == id);

            if (deviceIdx == -1)
            {
                // we never used this device to begin with, so just ignore its removal
                device = null;
                return false;
            }

            device = _devices[deviceIdx];
            device.Dispose();
            _devices.RemoveAt(deviceIdx);
            // note - registration is handled in the device ID creation process
            if (!_deviceRegistry.Remove(device.Id))
            {
                InputLog.Error($"Tried to unregister device with id {device.Id} that was not registered");
                return false;
            }

            return true;
        }

        public bool ContainsDevice(nint uniqueId) => _deviceRegistry.Contains(uniqueId);
    }
}
