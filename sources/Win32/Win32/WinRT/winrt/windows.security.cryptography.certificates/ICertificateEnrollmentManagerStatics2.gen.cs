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

[Guid("DC5B1C33-6429-4014-999C-5D9735802D1D")]
[NativeTypeName("struct ICertificateEnrollmentManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateEnrollmentManagerStatics2
    : ICertificateEnrollmentManagerStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateEnrollmentManagerStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICertificateEnrollmentManagerStatics2, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificateEnrollmentManagerStatics2, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics2, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICertificateEnrollmentManagerStatics2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UserCertificateEnrollmentManager(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::IUserCertificateEnrollmentManager **"
        )]
            IUserCertificateEnrollmentManager* value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateEnrollmentManagerStatics2,
                IUserCertificateEnrollmentManager*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ImportPfxDataToKspAsync(
        HSTRING pfxData,
        HSTRING password,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")]
            ExportOption exportable,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")]
            KeyProtectionLevel keyProtectionLevel,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
            InstallOptions installOption,
        HSTRING friendlyName,
        HSTRING keyStorageProvider,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateEnrollmentManagerStatics2,
                HSTRING,
                HSTRING,
                ExportOption,
                KeyProtectionLevel,
                InstallOptions,
                HSTRING,
                HSTRING,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(
            this,
            pfxData,
            password,
            exportable,
            keyProtectionLevel,
            installOption,
            friendlyName,
            keyStorageProvider,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UserCertificateEnrollmentManager(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::IUserCertificateEnrollmentManager **"
            )]
                IUserCertificateEnrollmentManager* value
        );

        [VtblIndex(7)]
        HRESULT ImportPfxDataToKspAsync(
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
            HSTRING keyStorageProvider,
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
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::IUserCertificateEnrollmentManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUserCertificateEnrollmentManager*,
            int> get_UserCertificateEnrollmentManager;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Cryptography::Certificates::ExportOption, ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            ExportOption,
            KeyProtectionLevel,
            InstallOptions,
            HSTRING,
            HSTRING,
            IAsyncAction*,
            int> ImportPfxDataToKspAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificateEnrollmentManagerStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificateEnrollmentManagerStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificateEnrollmentManagerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificateEnrollmentManagerStatics2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICertificateEnrollmentManagerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateEnrollmentManagerStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateEnrollmentManagerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICertificateEnrollmentManagerStatics2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificateEnrollmentManagerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificateEnrollmentManagerStatics2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICertificateEnrollmentManagerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateEnrollmentManagerStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateEnrollmentManagerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICertificateEnrollmentManagerStatics2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
