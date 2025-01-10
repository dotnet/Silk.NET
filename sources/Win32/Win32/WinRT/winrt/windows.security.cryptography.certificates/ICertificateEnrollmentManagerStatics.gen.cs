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

[Guid("8846EF3F-A986-48FB-9FD7-9AEC06935BF1")]
[NativeTypeName("struct ICertificateEnrollmentManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateEnrollmentManagerStatics
    : ICertificateEnrollmentManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateEnrollmentManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICertificateEnrollmentManagerStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificateEnrollmentManagerStatics, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateRequestAsync(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *"
        )]
            ICertificateRequestProperties request,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateEnrollmentManagerStatics,
                ICertificateRequestProperties,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[6])
        )(this, request, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InstallCertificateAsync(
        HSTRING certificate,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
            InstallOptions installOption,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateEnrollmentManagerStatics,
                HSTRING,
                InstallOptions,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(this, certificate, installOption, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ImportPfxDataAsync(
        HSTRING pfxData,
        HSTRING password,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")]
            ExportOption exportable,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")]
            KeyProtectionLevel keyProtectionLevel,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
            InstallOptions installOption,
        HSTRING friendlyName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateEnrollmentManagerStatics,
                HSTRING,
                HSTRING,
                ExportOption,
                KeyProtectionLevel,
                InstallOptions,
                HSTRING,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(
            this,
            pfxData,
            password,
            exportable,
            keyProtectionLevel,
            installOption,
            friendlyName,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateRequestAsync(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *"
            )]
                ICertificateRequestProperties request,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** value
        );

        [VtblIndex(7)]
        HRESULT InstallCertificateAsync(
            HSTRING certificate,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
                InstallOptions installOption,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(8)]
        HRESULT ImportPfxDataAsync(
            HSTRING pfxData,
            HSTRING password,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")]
                ExportOption exportable,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel"
            )]
                KeyProtectionLevel keyProtectionLevel,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
                InstallOptions installOption,
            HSTRING friendlyName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
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
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificateRequestProperties,
            IAsyncOperation<HSTRING>**,
            int> CreateRequestAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            InstallOptions,
            IAsyncAction*,
            int> InstallCertificateAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Cryptography::Certificates::ExportOption, ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            ExportOption,
            KeyProtectionLevel,
            InstallOptions,
            HSTRING,
            IAsyncAction*,
            int> ImportPfxDataAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificateEnrollmentManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificateEnrollmentManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificateEnrollmentManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificateEnrollmentManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICertificateEnrollmentManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateEnrollmentManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateEnrollmentManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICertificateEnrollmentManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificateEnrollmentManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificateEnrollmentManagerStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICertificateEnrollmentManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateEnrollmentManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateEnrollmentManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICertificateEnrollmentManagerStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
