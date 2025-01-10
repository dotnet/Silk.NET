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

[Guid("680D3511-9A08-47C8-864A-2EDD4D8EB46C")]
[NativeTypeName("struct IPfxImportParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPfxImportParameters : IPfxImportParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPfxImportParameters));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPfxImportParameters, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPfxImportParameters, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPfxImportParameters, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPfxImportParameters, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPfxImportParameters, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Exportable(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption *")]
            ExportOption* value
    )
    {
        return ((delegate* unmanaged<IPfxImportParameters, ExportOption*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Exportable(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")]
            ExportOption value
    )
    {
        return ((delegate* unmanaged<IPfxImportParameters, ExportOption, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyProtectionLevel(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *")]
            KeyProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IPfxImportParameters, KeyProtectionLevel*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_KeyProtectionLevel(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")]
            KeyProtectionLevel value
    )
    {
        return ((delegate* unmanaged<IPfxImportParameters, KeyProtectionLevel, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InstallOptions(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions *")]
            InstallOptions* value
    )
    {
        return ((delegate* unmanaged<IPfxImportParameters, InstallOptions*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InstallOptions(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
            InstallOptions value
    )
    {
        return ((delegate* unmanaged<IPfxImportParameters, InstallOptions, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_KeyStorageProviderName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_KeyStorageProviderName(HSTRING value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ContainerNamePrefix(HSTRING* value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ContainerNamePrefix(HSTRING value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ReaderName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ReaderName(HSTRING value)
    {
        return ((delegate* unmanaged<IPfxImportParameters, HSTRING, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Exportable(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption *")]
                ExportOption* value
        );

        [VtblIndex(7)]
        HRESULT put_Exportable(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")]
                ExportOption value
        );

        [VtblIndex(8)]
        HRESULT get_KeyProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *"
            )]
                KeyProtectionLevel* value
        );

        [VtblIndex(9)]
        HRESULT put_KeyProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel"
            )]
                KeyProtectionLevel value
        );

        [VtblIndex(10)]
        HRESULT get_InstallOptions(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions *")]
                InstallOptions* value
        );

        [VtblIndex(11)]
        HRESULT put_InstallOptions(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")]
                InstallOptions value
        );

        [VtblIndex(12)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_KeyStorageProviderName(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_KeyStorageProviderName(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_ContainerNamePrefix(HSTRING* value);

        [VtblIndex(17)]
        HRESULT put_ContainerNamePrefix(HSTRING value);

        [VtblIndex(18)]
        HRESULT get_ReaderName(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_ReaderName(HSTRING value);
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
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ExportOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ExportOption*, int> get_Exportable;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ExportOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ExportOption, int> put_Exportable;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, KeyProtectionLevel*, int> get_KeyProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, KeyProtectionLevel, int> put_KeyProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::InstallOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InstallOptions*, int> get_InstallOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::InstallOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InstallOptions, int> put_InstallOptions;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_KeyStorageProviderName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_KeyStorageProviderName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContainerNamePrefix;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ContainerNamePrefix;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ReaderName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ReaderName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPfxImportParameters"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPfxImportParameters(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPfxImportParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPfxImportParameters(Silk.NET.WinRT.IInspectable value)
    {
        return new IPfxImportParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPfxImportParameters"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPfxImportParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPfxImportParameters value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPfxImportParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPfxImportParameters(Silk.NET.Windows.IUnknown value)
    {
        return new IPfxImportParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPfxImportParameters"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPfxImportParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPfxImportParameters value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
