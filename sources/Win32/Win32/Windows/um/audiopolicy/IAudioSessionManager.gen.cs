// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BFA971F1-4D5E-40BB-935E-967039BFBEE4")]
[NativeTypeName("struct IAudioSessionManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionManager : IAudioSessionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionManager, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSessionManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAudioSessionControl(
        [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid,
        [NativeTypeName("DWORD")] uint StreamFlags,
        IAudioSessionControl* SessionControl
    )
    {
        return (
            (delegate* unmanaged<IAudioSessionManager, Guid*, uint, IAudioSessionControl*, int>)(
                (*lpVtbl)[3]
            )
        )(this, AudioSessionGuid, StreamFlags, SessionControl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSimpleAudioVolume(
        [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid,
        [NativeTypeName("DWORD")] uint StreamFlags,
        ISimpleAudioVolume* AudioVolume
    )
    {
        return (
            (delegate* unmanaged<IAudioSessionManager, Guid*, uint, ISimpleAudioVolume*, int>)(
                (*lpVtbl)[4]
            )
        )(this, AudioSessionGuid, StreamFlags, AudioVolume);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAudioSessionControl(
            [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid,
            [NativeTypeName("DWORD")] uint StreamFlags,
            IAudioSessionControl* SessionControl
        );

        [VtblIndex(4)]
        HRESULT GetSimpleAudioVolume(
            [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid,
            [NativeTypeName("DWORD")] uint StreamFlags,
            ISimpleAudioVolume* AudioVolume
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName(
            "HRESULT (LPCGUID, DWORD, IAudioSessionControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            uint,
            IAudioSessionControl*,
            int> GetAudioSessionControl;

        [NativeTypeName("HRESULT (LPCGUID, DWORD, ISimpleAudioVolume **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            uint,
            ISimpleAudioVolume*,
            int> GetSimpleAudioVolume;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSessionManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSessionManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSessionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSessionManager(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioSessionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioSessionManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
