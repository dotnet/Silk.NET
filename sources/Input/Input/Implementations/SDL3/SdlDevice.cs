// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Pointers;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A base class for all SDL input devices.
/// </summary>
internal abstract unsafe class SdlDevice : IInputDevice
{
    bool IEquatable<IInputDevice>.Equals(IInputDevice? other) =>
        other?.GetType() == GetType()
        && other.Id == Id
        && other is SdlBoundedPointerDevice dev
        && dev.Backend.Sdl == Backend.Sdl;

    public nint Id => Backend.AsSilkId(SdlDeviceId);
    public uint SdlDeviceId { get; }
    public SdlInputBackend Backend { get; }

    public abstract string Name { get; }
    /*{
        {
            var namePtr = _sdlNameFunc(SdlDeviceId);
            ref var casted = ref Unsafe.As<sbyte,byte>(ref namePtr[0]);
            var marshalled = SilkMarshal.NativeToString(ref casted);
            return marshalled ?? "Unknown Sdl Keyboard";
        }
    }*/


    public SdlDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        Backend = backend;
        SdlDeviceId = sdlDeviceId;
    }
}

/// <summary>
/// An interface defining a generic constructor for managed SDL devices.
/// </summary>
/// <typeparam name="T"></typeparam>
internal interface ISdlDevice<out T> : IInputDevice where T : SdlDevice
{
    public static abstract T CreateDevice(SdlInputBackend backend, uint sdlDeviceId);
}
