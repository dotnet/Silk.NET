// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F")]
[NativeTypeName("struct IAudioSessionManager2 : IAudioSessionManager")]
[NativeInheritance("IAudioSessionManager")]
public unsafe partial struct IAudioSessionManager2 : IAudioSessionManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionManager2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionManager2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioSessionManager2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionManager2, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IAudioSessionManager2, Guid*, uint, IAudioSessionControl*, int>)(
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
            (delegate* unmanaged<IAudioSessionManager2, Guid*, uint, ISimpleAudioVolume*, int>)(
                (*lpVtbl)[4]
            )
        )(this, AudioSessionGuid, StreamFlags, AudioVolume);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSessionEnumerator(IAudioSessionEnumerator* SessionEnum)
    {
        return (
            (delegate* unmanaged<IAudioSessionManager2, IAudioSessionEnumerator*, int>)(
                (*lpVtbl)[5]
            )
        )(this, SessionEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterSessionNotification(IAudioSessionNotification SessionNotification)
    {
        return (
            (delegate* unmanaged<IAudioSessionManager2, IAudioSessionNotification, int>)(
                (*lpVtbl)[6]
            )
        )(this, SessionNotification);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterSessionNotification(IAudioSessionNotification SessionNotification)
    {
        return (
            (delegate* unmanaged<IAudioSessionManager2, IAudioSessionNotification, int>)(
                (*lpVtbl)[7]
            )
        )(this, SessionNotification);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterDuckNotification(
        [NativeTypeName("LPCWSTR")] ushort* sessionID,
        IAudioVolumeDuckNotification duckNotification
    )
    {
        return (
            (delegate* unmanaged<
                IAudioSessionManager2,
                ushort*,
                IAudioVolumeDuckNotification,
                int>)((*lpVtbl)[8])
        )(this, sessionID, duckNotification);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterDuckNotification(IAudioVolumeDuckNotification duckNotification)
    {
        return (
            (delegate* unmanaged<IAudioSessionManager2, IAudioVolumeDuckNotification, int>)(
                (*lpVtbl)[9]
            )
        )(this, duckNotification);
    }

    public interface Interface : IAudioSessionManager.Interface
    {
        [VtblIndex(5)]
        HRESULT GetSessionEnumerator(IAudioSessionEnumerator* SessionEnum);

        [VtblIndex(6)]
        HRESULT RegisterSessionNotification(IAudioSessionNotification SessionNotification);

        [VtblIndex(7)]
        HRESULT UnregisterSessionNotification(IAudioSessionNotification SessionNotification);

        [VtblIndex(8)]
        HRESULT RegisterDuckNotification(
            [NativeTypeName("LPCWSTR")] ushort* sessionID,
            IAudioVolumeDuckNotification duckNotification
        );

        [VtblIndex(9)]
        HRESULT UnregisterDuckNotification(IAudioVolumeDuckNotification duckNotification);
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

        [NativeTypeName("HRESULT (IAudioSessionEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioSessionEnumerator*, int> GetSessionEnumerator;

        [NativeTypeName("HRESULT (IAudioSessionNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioSessionNotification,
            int> RegisterSessionNotification;

        [NativeTypeName("HRESULT (IAudioSessionNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioSessionNotification,
            int> UnregisterSessionNotification;

        [NativeTypeName(
            "HRESULT (LPCWSTR, IAudioVolumeDuckNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IAudioVolumeDuckNotification,
            int> RegisterDuckNotification;

        [NativeTypeName("HRESULT (IAudioVolumeDuckNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioVolumeDuckNotification,
            int> UnregisterDuckNotification;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSessionManager2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSessionManager2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAudioSessionManager"/> to <see cref = "IAudioSessionManager2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAudioSessionManager"/> instance to be converted </param>
    public static explicit operator IAudioSessionManager2(
        Silk.NET.Windows.IAudioSessionManager value
    )
    {
        return new IAudioSessionManager2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionManager2"/> to <see cref = "Silk.NET.Windows.IAudioSessionManager"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionManager2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAudioSessionManager(
        IAudioSessionManager2 value
    )
    {
        return new Silk.NET.Windows.IAudioSessionManager(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSessionManager2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSessionManager2(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioSessionManager2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionManager2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionManager2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioSessionManager2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
