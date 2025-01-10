// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A420BC4A-6E2E-4AF5-B556-355AE0CD4F29")]
[NativeTypeName("struct IStreamSocketStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketStatics : IStreamSocketStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamSocketStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamSocketStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamSocketStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamSocketStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamSocketStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamSocketStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEndpointPairsAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
        HSTRING remoteServiceName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSocketStatics,
                IHostName,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, remoteHostName, remoteServiceName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEndpointPairsWithSortOptionsAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
        HSTRING remoteServiceName,
        [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")]
            HostNameSortOptions sortOptions,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSocketStatics,
                IHostName,
                HSTRING,
                HostNameSortOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, remoteHostName, remoteServiceName, sortOptions, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetEndpointPairsAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
            HSTRING remoteServiceName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT GetEndpointPairsWithSortOptionsAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
            HSTRING remoteServiceName,
            [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")]
                HostNameSortOptions sortOptions,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetEndpointPairsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Networking::HostNameSortOptions, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            HSTRING,
            HostNameSortOptions,
            IAsyncOperation<IntPtr>**,
            int> GetEndpointPairsWithSortOptionsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamSocketStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamSocketStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamSocketStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamSocketStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamSocketStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamSocketStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamSocketStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamSocketStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamSocketStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamSocketStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
