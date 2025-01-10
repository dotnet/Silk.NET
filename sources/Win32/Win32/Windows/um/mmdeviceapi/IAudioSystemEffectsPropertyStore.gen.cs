// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("302AE7F9-D7E0-43E4-971B-1F8293613D2A")]
[NativeTypeName("struct IAudioSystemEffectsPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct IAudioSystemEffectsPropertyStore
    : IAudioSystemEffectsPropertyStore.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSystemEffectsPropertyStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioSystemEffectsPropertyStore, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OpenDefaultPropertyStore(
        [NativeTypeName("DWORD")] uint stgmAccess,
        IPropertyStore* propStore
    )
    {
        return (
            (delegate* unmanaged<IAudioSystemEffectsPropertyStore, uint, IPropertyStore*, int>)(
                (*lpVtbl)[3]
            )
        )(this, stgmAccess, propStore);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenUserPropertyStore(
        [NativeTypeName("DWORD")] uint stgmAccess,
        IPropertyStore* propStore
    )
    {
        return (
            (delegate* unmanaged<IAudioSystemEffectsPropertyStore, uint, IPropertyStore*, int>)(
                (*lpVtbl)[4]
            )
        )(this, stgmAccess, propStore);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OpenVolatilePropertyStore(
        [NativeTypeName("DWORD")] uint stgmAccess,
        IPropertyStore* propStore
    )
    {
        return (
            (delegate* unmanaged<IAudioSystemEffectsPropertyStore, uint, IPropertyStore*, int>)(
                (*lpVtbl)[5]
            )
        )(this, stgmAccess, propStore);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ResetUserPropertyStore()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetVolatilePropertyStore()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterPropertyChangeNotification(
        IAudioSystemEffectsPropertyChangeNotificationClient callback
    )
    {
        return (
            (delegate* unmanaged<
                IAudioSystemEffectsPropertyStore,
                IAudioSystemEffectsPropertyChangeNotificationClient,
                int>)((*lpVtbl)[8])
        )(this, callback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterPropertyChangeNotification(
        IAudioSystemEffectsPropertyChangeNotificationClient callback
    )
    {
        return (
            (delegate* unmanaged<
                IAudioSystemEffectsPropertyStore,
                IAudioSystemEffectsPropertyChangeNotificationClient,
                int>)((*lpVtbl)[9])
        )(this, callback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OpenDefaultPropertyStore(
            [NativeTypeName("DWORD")] uint stgmAccess,
            IPropertyStore* propStore
        );

        [VtblIndex(4)]
        HRESULT OpenUserPropertyStore(
            [NativeTypeName("DWORD")] uint stgmAccess,
            IPropertyStore* propStore
        );

        [VtblIndex(5)]
        HRESULT OpenVolatilePropertyStore(
            [NativeTypeName("DWORD")] uint stgmAccess,
            IPropertyStore* propStore
        );

        [VtblIndex(6)]
        HRESULT ResetUserPropertyStore();

        [VtblIndex(7)]
        HRESULT ResetVolatilePropertyStore();

        [VtblIndex(8)]
        HRESULT RegisterPropertyChangeNotification(
            IAudioSystemEffectsPropertyChangeNotificationClient callback
        );

        [VtblIndex(9)]
        HRESULT UnregisterPropertyChangeNotification(
            IAudioSystemEffectsPropertyChangeNotificationClient callback
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

        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore*, int> OpenDefaultPropertyStore;

        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore*, int> OpenUserPropertyStore;

        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore*, int> OpenVolatilePropertyStore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetUserPropertyStore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetVolatilePropertyStore;

        [NativeTypeName(
            "HRESULT (IAudioSystemEffectsPropertyChangeNotificationClient *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioSystemEffectsPropertyChangeNotificationClient,
            int> RegisterPropertyChangeNotification;

        [NativeTypeName(
            "HRESULT (IAudioSystemEffectsPropertyChangeNotificationClient *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioSystemEffectsPropertyChangeNotificationClient,
            int> UnregisterPropertyChangeNotification;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSystemEffectsPropertyStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSystemEffectsPropertyStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSystemEffectsPropertyStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSystemEffectsPropertyStore(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAudioSystemEffectsPropertyStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSystemEffectsPropertyStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSystemEffectsPropertyStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAudioSystemEffectsPropertyStore value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
