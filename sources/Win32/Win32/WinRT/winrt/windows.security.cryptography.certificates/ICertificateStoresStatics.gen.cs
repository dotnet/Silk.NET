// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FBECC739-C6FE-4DE7-99CF-74C3E596E032")]
[NativeTypeName("struct ICertificateStoresStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateStoresStatics
    : ICertificateStoresStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateStoresStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICertificateStoresStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICertificateStoresStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificateStoresStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICertificateStoresStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICertificateStoresStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICertificateStoresStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAllAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<ICertificateStoresStatics, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllWithQueryAsync(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateQuery *")]
            ICertificateQuery query,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateStoresStatics,
                ICertificateQuery,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, query, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrustedRootCertificationAuthorities(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")]
            ICertificateStore* value
    )
    {
        return (
            (delegate* unmanaged<ICertificateStoresStatics, ICertificateStore*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IntermediateCertificationAuthorities(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")]
            ICertificateStore* value
    )
    {
        return (
            (delegate* unmanaged<ICertificateStoresStatics, ICertificateStore*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStoreByName(
        HSTRING storeName,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")]
            ICertificateStore* value
    )
    {
        return (
            (delegate* unmanaged<ICertificateStoresStatics, HSTRING, ICertificateStore*, int>)(
                (*lpVtbl)[10]
            )
        )(this, storeName, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAllAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT FindAllWithQueryAsync(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ICertificateQuery *"
            )]
                ICertificateQuery query,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT get_TrustedRootCertificationAuthorities(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **"
            )]
                ICertificateStore* value
        );

        [VtblIndex(9)]
        HRESULT get_IntermediateCertificationAuthorities(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **"
            )]
                ICertificateStore* value
        );

        [VtblIndex(10)]
        HRESULT GetStoreByName(
            HSTRING storeName,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **"
            )]
                ICertificateStore* value
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateQuery *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificateQuery,
            IAsyncOperation<IntPtr>**,
            int> FindAllWithQueryAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificateStore*,
            int> get_TrustedRootCertificationAuthorities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificateStore*,
            int> get_IntermediateCertificationAuthorities;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ICertificateStore*, int> GetStoreByName;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificateStoresStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificateStoresStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificateStoresStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificateStoresStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICertificateStoresStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateStoresStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateStoresStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICertificateStoresStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificateStoresStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificateStoresStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ICertificateStoresStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateStoresStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateStoresStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICertificateStoresStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
