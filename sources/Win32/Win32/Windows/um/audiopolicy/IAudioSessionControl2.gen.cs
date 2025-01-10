// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BFB7FF88-7239-4FC9-8FA2-07C950BE9C6D")]
[NativeTypeName("struct IAudioSessionControl2 : IAudioSessionControl")]
[NativeInheritance("IAudioSessionControl")]
public unsafe partial struct IAudioSessionControl2 : IAudioSessionControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioSessionControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(AudioSessionState* pRetVal)
    {
        return (
            (delegate* unmanaged<IAudioSessionControl2, AudioSessionState*, int>)((*lpVtbl)[3])
        )(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, ushort**, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IAudioSessionControl2, ushort*, Guid*, int>)((*lpVtbl)[5]))(
            this,
            Value,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, ushort**, int>)((*lpVtbl)[6]))(
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
        return ((delegate* unmanaged<IAudioSessionControl2, ushort*, Guid*, int>)((*lpVtbl)[7]))(
            this,
            Value,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGroupingParam(Guid* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, Guid*, int>)((*lpVtbl)[8]))(
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
        return ((delegate* unmanaged<IAudioSessionControl2, Guid*, Guid*, int>)((*lpVtbl)[9]))(
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
            (delegate* unmanaged<IAudioSessionControl2, IAudioSessionEvents, int>)((*lpVtbl)[10])
        )(this, NewNotifications);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents NewNotifications)
    {
        return (
            (delegate* unmanaged<IAudioSessionControl2, IAudioSessionEvents, int>)((*lpVtbl)[11])
        )(this, NewNotifications);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSessionIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, ushort**, int>)((*lpVtbl)[12]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSessionInstanceIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, ushort**, int>)((*lpVtbl)[13]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetProcessId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, uint*, int>)((*lpVtbl)[14]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsSystemSoundsSession()
    {
        return ((delegate* unmanaged<IAudioSessionControl2, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDuckingPreference(BOOL optOut)
    {
        return ((delegate* unmanaged<IAudioSessionControl2, BOOL, int>)((*lpVtbl)[16]))(
            this,
            optOut
        );
    }

    public interface Interface : IAudioSessionControl.Interface
    {
        [VtblIndex(12)]
        HRESULT GetSessionIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal);

        [VtblIndex(13)]
        HRESULT GetSessionInstanceIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal);

        [VtblIndex(14)]
        HRESULT GetProcessId([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(15)]
        HRESULT IsSystemSoundsSession();

        [VtblIndex(16)]
        HRESULT SetDuckingPreference(BOOL optOut);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSessionIdentifier;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSessionInstanceIdentifier;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProcessId;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSystemSoundsSession;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetDuckingPreference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSessionControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSessionControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAudioSessionControl"/> to <see cref = "IAudioSessionControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAudioSessionControl"/> instance to be converted </param>
    public static explicit operator IAudioSessionControl2(
        Silk.NET.Windows.IAudioSessionControl value
    )
    {
        return new IAudioSessionControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionControl2"/> to <see cref = "Silk.NET.Windows.IAudioSessionControl"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAudioSessionControl(
        IAudioSessionControl2 value
    )
    {
        return new Silk.NET.Windows.IAudioSessionControl(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSessionControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSessionControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioSessionControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioSessionControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
