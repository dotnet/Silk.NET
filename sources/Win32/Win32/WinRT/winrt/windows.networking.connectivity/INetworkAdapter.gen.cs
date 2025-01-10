// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3B542E03-5388-496C-A8A3-AFFD39AEC2E6")]
[NativeTypeName("struct INetworkAdapter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkAdapter : INetworkAdapter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkAdapter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INetworkAdapter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INetworkAdapter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INetworkAdapter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<INetworkAdapter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<INetworkAdapter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<INetworkAdapter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<INetworkAdapter, ulong*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_InboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<INetworkAdapter, ulong*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IanaInterfaceType([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<INetworkAdapter, uint*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_NetworkItem(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkItem **")]
            INetworkItem* value
    )
    {
        return ((delegate* unmanaged<INetworkAdapter, INetworkItem*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NetworkAdapterId(Guid* value)
    {
        return ((delegate* unmanaged<INetworkAdapter, Guid*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetConnectedProfileAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<INetworkAdapter, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[11])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_InboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT get_IanaInterfaceType([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_NetworkItem(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkItem **")]
                INetworkItem* value
        );

        [VtblIndex(10)]
        HRESULT get_NetworkAdapterId(Guid* value);

        [VtblIndex(11)]
        HRESULT GetConnectedProfileAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **"
            )]
                IAsyncOperation<IntPtr>** value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_OutboundMaxBitsPerSecond;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_InboundMaxBitsPerSecond;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_IanaInterfaceType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::INetworkItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, INetworkItem*, int> get_NetworkItem;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_NetworkAdapterId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetConnectedProfileAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "INetworkAdapter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INetworkAdapter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "INetworkAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator INetworkAdapter(Silk.NET.WinRT.IInspectable value)
    {
        return new INetworkAdapter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkAdapter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkAdapter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(INetworkAdapter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INetworkAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INetworkAdapter(Silk.NET.Windows.IUnknown value)
    {
        return new INetworkAdapter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkAdapter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkAdapter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INetworkAdapter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
