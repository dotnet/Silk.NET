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

[Guid("E8D2FF37-6259-4E88-B7E0-94191FDE699E")]
[NativeTypeName("struct IAsymmetricKeyAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAsymmetricKeyAlgorithmProvider
    : IAsymmetricKeyAlgorithmProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsymmetricKeyAlgorithmProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateKeyPair(
        [NativeTypeName("UINT32")] uint keySize,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<IAsymmetricKeyAlgorithmProvider, uint, ICryptographicKey*, int>)(
                (*lpVtbl)[7]
            )
        )(this, keySize, key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ImportDefaultPrivateKeyBlob(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<
                IAsymmetricKeyAlgorithmProvider,
                IBuffer,
                ICryptographicKey*,
                int>)((*lpVtbl)[8])
        )(this, keyBlob, key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ImportKeyPairWithBlobType(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType"
        )]
            CryptographicPrivateKeyBlobType BlobType,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<
                IAsymmetricKeyAlgorithmProvider,
                IBuffer,
                CryptographicPrivateKeyBlobType,
                ICryptographicKey*,
                int>)((*lpVtbl)[9])
        )(this, keyBlob, BlobType, key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ImportDefaultPublicKeyBlob(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<
                IAsymmetricKeyAlgorithmProvider,
                IBuffer,
                ICryptographicKey*,
                int>)((*lpVtbl)[10])
        )(this, keyBlob, key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ImportPublicKeyWithBlobType(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType"
        )]
            CryptographicPublicKeyBlobType BlobType,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<
                IAsymmetricKeyAlgorithmProvider,
                IBuffer,
                CryptographicPublicKeyBlobType,
                ICryptographicKey*,
                int>)((*lpVtbl)[11])
        )(this, keyBlob, BlobType, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT CreateKeyPair(
            [NativeTypeName("UINT32")] uint keySize,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
                ICryptographicKey* key
        );

        [VtblIndex(8)]
        HRESULT ImportDefaultPrivateKeyBlob(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
                ICryptographicKey* key
        );

        [VtblIndex(9)]
        HRESULT ImportKeyPairWithBlobType(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType"
            )]
                CryptographicPrivateKeyBlobType BlobType,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
                ICryptographicKey* key
        );

        [VtblIndex(10)]
        HRESULT ImportDefaultPublicKeyBlob(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
                ICryptographicKey* key
        );

        [VtblIndex(11)]
        HRESULT ImportPublicKeyWithBlobType(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyBlob,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType"
            )]
                CryptographicPublicKeyBlobType BlobType,
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AlgorithmName;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ICryptographicKey*, int> CreateKeyPair;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            ICryptographicKey*,
            int> ImportDefaultPrivateKeyBlob;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            CryptographicPrivateKeyBlobType,
            ICryptographicKey*,
            int> ImportKeyPairWithBlobType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            ICryptographicKey*,
            int> ImportDefaultPublicKeyBlob;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            CryptographicPublicKeyBlobType,
            ICryptographicKey*,
            int> ImportPublicKeyWithBlobType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAsymmetricKeyAlgorithmProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAsymmetricKeyAlgorithmProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAsymmetricKeyAlgorithmProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAsymmetricKeyAlgorithmProvider(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAsymmetricKeyAlgorithmProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAsymmetricKeyAlgorithmProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAsymmetricKeyAlgorithmProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAsymmetricKeyAlgorithmProvider value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAsymmetricKeyAlgorithmProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAsymmetricKeyAlgorithmProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IAsymmetricKeyAlgorithmProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAsymmetricKeyAlgorithmProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAsymmetricKeyAlgorithmProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAsymmetricKeyAlgorithmProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
