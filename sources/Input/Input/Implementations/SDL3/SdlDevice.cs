// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.Pointers;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A base class for all SDL input devices.
/// </summary>
internal abstract class SdlDevice : IInputDevice, IDisposable
{
    bool IEquatable<IInputDevice>.Equals(IInputDevice? other) =>
        other?.GetType() == GetType()
        && other.Id == Id
        && other is SdlBoundedPointerDevice dev
        && dev.NativeBackend == NativeBackend;

    public nint Id => Backend.AsSilkId(SdlDeviceId);
    public uint SdlDeviceId { get; }
    public SdlInputBackend Backend { get; }

    /// <summary>
    /// For readability and refactorability - provides the SDL interface instance.
    /// </summary>
    protected ISdl NativeBackend => Backend.Sdl;

    public abstract string Name { get; }
    /*{
        {
            var namePtr = _sdlNameFunc(SdlDeviceId);
            ref var casted = ref Unsafe.As<sbyte,byte>(ref namePtr[0]);
            var marshalled = SilkMarshal.NativeToString(ref casted);
            return marshalled ?? "Unknown Sdl Keyboard";
        }
    }*/


    protected SdlDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        Backend = backend;
        SdlDeviceId = sdlDeviceId;
    }

    protected abstract void Release();

    public void Dispose()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, GetType());
        _isDisposed = true;
        Release();
        GC.SuppressFinalize(this);
    }

    ~SdlDevice()
    {
        _isDisposed = true;
        Release();
    }

    private bool _isDisposed;
}

/// <summary>
/// An interface defining a generic constructor for managed SDL devices.
/// </summary>
/// <typeparam name="T"></typeparam>
internal interface ISdlDevice<out T> : IInputDevice where T : SdlDevice
{
    public static abstract T CreateDevice(SdlInputBackend backend, uint sdlDeviceId);
}
