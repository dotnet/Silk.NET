// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlInputBackend : IInputBackend
{
    public unsafe SdlInputBackend()
    {
        var ptr = new EventFilter(OnEvent);
        Sdl.AddEventWatch(ptr, nullptr);
        Id = (nint)ptr.Handle;
    }

    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        throw new NotImplementedException();
    }

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => throw new NotImplementedException();

    public void Update(IInputHandler? handler = null) => throw new NotImplementedException();

    private unsafe void ReleaseUnmanagedResources()
    {
        Sdl.RemoveEventWatch(
            new EventFilter((delegate* unmanaged<void*, Event*, byte>)(void*)Id),
            nullptr
        );
        SilkMarshal.Free((Ptr)Id);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~SdlInputBackend() => ReleaseUnmanagedResources();
}
