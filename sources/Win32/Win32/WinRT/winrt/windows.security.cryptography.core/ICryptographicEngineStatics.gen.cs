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

[Guid("9FEA0639-6FF7-4C85-A095-95EB31715EB9")]
[NativeTypeName("struct ICryptographicEngineStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICryptographicEngineStatics
    : ICryptographicEngineStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICryptographicEngineStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICryptographicEngineStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICryptographicEngineStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICryptographicEngineStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICryptographicEngineStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICryptographicEngineStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICryptographicEngineStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Encrypt(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer iv,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IBuffer,
                IBuffer,
                IBuffer*,
                int>)((*lpVtbl)[6])
        )(this, key, data, iv, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Decrypt(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer iv,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IBuffer,
                IBuffer,
                IBuffer*,
                int>)((*lpVtbl)[7])
        )(this, key, data, iv, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EncryptAndAuthenticate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer nonce,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer authenticatedData,
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Core::IEncryptedAndAuthenticatedData **"
        )]
            IEncryptedAndAuthenticatedData* value
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IBuffer,
                IBuffer,
                IBuffer,
                IEncryptedAndAuthenticatedData*,
                int>)((*lpVtbl)[8])
        )(this, key, data, nonce, authenticatedData, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DecryptAndAuthenticate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer nonce,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer authenticationTag,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer authenticatedData,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IBuffer,
                IBuffer,
                IBuffer,
                IBuffer,
                IBuffer*,
                int>)((*lpVtbl)[9])
        )(this, key, data, nonce, authenticationTag, authenticatedData, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Sign(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IBuffer,
                IBuffer*,
                int>)((*lpVtbl)[10])
        )(this, key, data, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT VerifySignature(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer signature,
        [NativeTypeName("boolean *")] byte* isAuthenticated
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IBuffer,
                IBuffer,
                byte*,
                int>)((*lpVtbl)[11])
        )(this, key, data, signature, isAuthenticated);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeriveKeyMaterial(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
            ICryptographicKey key,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters *")]
            IKeyDerivationParameters parameters,
        [NativeTypeName("UINT32")] uint desiredKeySize,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* keyMaterial
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicEngineStatics,
                ICryptographicKey,
                IKeyDerivationParameters,
                uint,
                IBuffer*,
                int>)((*lpVtbl)[12])
        )(this, key, parameters, desiredKeySize, keyMaterial);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Encrypt(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer iv,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(7)]
        HRESULT Decrypt(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer iv,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(8)]
        HRESULT EncryptAndAuthenticate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer nonce,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer authenticatedData,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::IEncryptedAndAuthenticatedData **"
            )]
                IEncryptedAndAuthenticatedData* value
        );

        [VtblIndex(9)]
        HRESULT DecryptAndAuthenticate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer nonce,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer authenticationTag,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer authenticatedData,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(10)]
        HRESULT Sign(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(11)]
        HRESULT VerifySignature(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer signature,
            [NativeTypeName("boolean *")] byte* isAuthenticated
        );

        [VtblIndex(12)]
        HRESULT DeriveKeyMaterial(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")]
                ICryptographicKey key,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters *"
            )]
                IKeyDerivationParameters parameters,
            [NativeTypeName("UINT32")] uint desiredKeySize,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* keyMaterial
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
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICryptographicKey,
            IBuffer,
            IBuffer,
            IBuffer*,
            int> Encrypt;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICryptographicKey,
            IBuffer,
            IBuffer,
            IBuffer*,
            int> Decrypt;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IEncryptedAndAuthenticatedData **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICryptographicKey,
            IBuffer,
            IBuffer,
            IBuffer,
            IEncryptedAndAuthenticatedData*,
            int> EncryptAndAuthenticate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICryptographicKey,
            IBuffer,
            IBuffer,
            IBuffer,
            IBuffer,
            IBuffer*,
            int> DecryptAndAuthenticate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICryptographicKey, IBuffer, IBuffer*, int> Sign;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICryptographicKey,
            IBuffer,
            IBuffer,
            byte*,
            int> VerifySignature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters *, UINT32, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICryptographicKey,
            IKeyDerivationParameters,
            uint,
            IBuffer*,
            int> DeriveKeyMaterial;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICryptographicEngineStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICryptographicEngineStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICryptographicEngineStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICryptographicEngineStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICryptographicEngineStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICryptographicEngineStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICryptographicEngineStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICryptographicEngineStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICryptographicEngineStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICryptographicEngineStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ICryptographicEngineStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICryptographicEngineStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICryptographicEngineStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICryptographicEngineStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
