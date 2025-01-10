// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F4B1A599-7266-4319-A8CA-E70ACB11E8CD")]
[NativeTypeName("struct IAudioSessionControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionControl : IAudioSessionControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioSessionControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(AudioSessionState* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl, AudioSessionState*, int>)((*lpVtbl)[3]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDisplayName(
        [NativeTypeName("LPCWSTR")] ushort* Value,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionControl, ushort*, Guid*, int>)((*lpVtbl)[5]))(
            this,
            Value,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetIconPath(
        [NativeTypeName("LPCWSTR")] ushort* Value,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionControl, ushort*, Guid*, int>)((*lpVtbl)[7]))(
            this,
            Value,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGroupingParam(Guid* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl, Guid*, int>)((*lpVtbl)[8]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGroupingParam(
        [NativeTypeName("LPCGUID")] Guid* Override,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionControl, Guid*, Guid*, int>)((*lpVtbl)[9]))(
            this,
            Override,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterAudioSessionNotification(IAudioSessionEvents NewNotifications)
    {
        return (
            (delegate* unmanaged<IAudioSessionControl, IAudioSessionEvents, int>)((*lpVtbl)[10])
        )(this, NewNotifications);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents NewNotifications)
    {
        return (
            (delegate* unmanaged<IAudioSessionControl, IAudioSessionEvents, int>)((*lpVtbl)[11])
        )(this, NewNotifications);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetState(AudioSessionState* pRetVal);

        [VtblIndex(4)]
        HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal);

        [VtblIndex(5)]
        HRESULT SetDisplayName(
            [NativeTypeName("LPCWSTR")] ushort* Value,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(6)]
        HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal);

        [VtblIndex(7)]
        HRESULT SetIconPath(
            [NativeTypeName("LPCWSTR")] ushort* Value,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(8)]
        HRESULT GetGroupingParam(Guid* pRetVal);

        [VtblIndex(9)]
        HRESULT SetGroupingParam(
            [NativeTypeName("LPCGUID")] Guid* Override,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(10)]
        HRESULT RegisterAudioSessionNotification(IAudioSessionEvents NewNotifications);

        [VtblIndex(11)]
        HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents NewNotifications);
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

        [NativeTypeName("HRESULT (AudioSessionState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioSessionState*, int> GetState;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> SetDisplayName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetIconPath;

        [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> SetIconPath;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGroupingParam;

        [NativeTypeName("HRESULT (LPCGUID, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> SetGroupingParam;

        [NativeTypeName("HRESULT (IAudioSessionEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioSessionEvents,
            int> RegisterAudioSessionNotification;

        [NativeTypeName("HRESULT (IAudioSessionEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioSessionEvents,
            int> UnregisterAudioSessionNotification;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSessionControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSessionControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSessionControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSessionControl(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioSessionControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioSessionControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
