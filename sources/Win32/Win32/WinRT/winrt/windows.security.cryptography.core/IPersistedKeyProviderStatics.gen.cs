// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("77274814-D9D4-4CF5-B668-E0457DF30894")]
[NativeTypeName("struct IPersistedKeyProviderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPersistedKeyProviderStatics
    : IPersistedKeyProviderStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistedKeyProviderStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPersistedKeyProviderStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistedKeyProviderStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistedKeyProviderStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPersistedKeyProviderStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPersistedKeyProviderStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPersistedKeyProviderStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenKeyPairFromCertificateAsync(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
            ICertificate certificate,
        HSTRING hashAlgorithmName,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")]
            CryptographicPadding padding,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPersistedKeyProviderStatics,
                ICertificate,
                HSTRING,
                CryptographicPadding,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, certificate, hashAlgorithmName, padding, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenPublicKeyFromCertificate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
            ICertificate certificate,
        HSTRING hashAlgorithmName,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")]
            CryptographicPadding padding,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<
                IPersistedKeyProviderStatics,
                ICertificate,
                HSTRING,
                CryptographicPadding,
                ICryptographicKey*,
                int>)((*lpVtbl)[7])
        )(this, certificate, hashAlgorithmName, padding, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenKeyPairFromCertificateAsync(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
                ICertificate certificate,
            HSTRING hashAlgorithmName,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")]
                CryptographicPadding padding,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT OpenPublicKeyFromCertificate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
                ICertificate certificate,
            HSTRING hashAlgorithmName,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")]
                CryptographicPadding padding,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
                ICryptographicKey* key
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
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *, HSTRING, ABI::Windows::Security::Cryptography::Core::CryptographicPadding, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificate,
            HSTRING,
            CryptographicPadding,
            IAsyncOperation<IntPtr>**,
            int> OpenKeyPairFromCertificateAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *, HSTRING, ABI::Windows::Security::Cryptography::Core::CryptographicPadding, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificate,
            HSTRING,
            CryptographicPadding,
            ICryptographicKey*,
            int> OpenPublicKeyFromCertificate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistedKeyProviderStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistedKeyProviderStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPersistedKeyProviderStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPersistedKeyProviderStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IPersistedKeyProviderStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistedKeyProviderStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistedKeyProviderStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPersistedKeyProviderStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistedKeyProviderStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistedKeyProviderStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistedKeyProviderStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistedKeyProviderStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistedKeyProviderStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistedKeyProviderStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
