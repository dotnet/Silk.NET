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

[Guid("20BF5385-3691-4501-A62C-FD97278B31EE")]
[NativeTypeName("struct ICertificateChain : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateChain : ICertificateChain.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateChain));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICertificateChain, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICertificateChain, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificateChain, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICertificateChain, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICertificateChain, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICertificateChain, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Validate(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *"
        )]
            ChainValidationResult* status
    )
    {
        return (
            (delegate* unmanaged<ICertificateChain, ChainValidationResult*, int>)((*lpVtbl)[6])
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ValidateWithParameters(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::IChainValidationParameters *"
        )]
            IChainValidationParameters parameter,
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *"
        )]
            ChainValidationResult* status
    )
    {
        return (
            (delegate* unmanaged<
                ICertificateChain,
                IChainValidationParameters,
                ChainValidationResult*,
                int>)((*lpVtbl)[7])
        )(this, parameter, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCertificates(
        [NativeTypeName("boolean")] byte includeRoot,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
        )]
            IVectorView<IntPtr>** certificates
    )
    {
        return (
            (delegate* unmanaged<ICertificateChain, byte, IVectorView<IntPtr>**, int>)((*lpVtbl)[8])
        )(this, includeRoot, certificates);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Validate(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *"
            )]
                ChainValidationResult* status
        );

        [VtblIndex(7)]
        HRESULT ValidateWithParameters(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::IChainValidationParameters *"
            )]
                IChainValidationParameters parameter,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *"
            )]
                ChainValidationResult* status
        );

        [VtblIndex(8)]
        HRESULT GetCertificates(
            [NativeTypeName("boolean")] byte includeRoot,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
            )]
                IVectorView<IntPtr>** certificates
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
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ChainValidationResult*, int> Validate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::IChainValidationParameters *, ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IChainValidationParameters,
            ChainValidationResult*,
            int> ValidateWithParameters;

        [NativeTypeName(
            "HRESULT (boolean, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte, IVectorView<IntPtr>**, int> GetCertificates;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificateChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificateChain(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificateChain"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificateChain(Silk.NET.WinRT.IInspectable value)
    {
        return new ICertificateChain(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateChain"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateChain"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICertificateChain value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificateChain"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificateChain(Silk.NET.Windows.IUnknown value)
    {
        return new ICertificateChain(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateChain"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateChain"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICertificateChain value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
