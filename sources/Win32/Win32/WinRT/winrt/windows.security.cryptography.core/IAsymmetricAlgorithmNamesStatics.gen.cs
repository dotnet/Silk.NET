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

[Guid("CAF6FCE4-67C0-46AA-84F9-752E77449F9B")]
[NativeTypeName("struct IAsymmetricAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAsymmetricAlgorithmNamesStatics
    : IAsymmetricAlgorithmNamesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsymmetricAlgorithmNamesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RsaPkcs1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RsaOaepSha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RsaOaepSha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RsaOaepSha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RsaOaepSha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_EcdsaP256Sha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EcdsaP384Sha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_EcdsaP521Sha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DsaSha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DsaSha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RsaSignPkcs1Sha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RsaSignPkcs1Sha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RsaSignPkcs1Sha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_RsaSignPkcs1Sha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_RsaSignPssSha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_RsaSignPssSha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_RsaSignPssSha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_RsaSignPssSha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAsymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[23])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RsaPkcs1(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_RsaOaepSha1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RsaOaepSha256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_RsaOaepSha384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_RsaOaepSha512(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_EcdsaP256Sha256(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_EcdsaP384Sha384(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_EcdsaP521Sha512(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_DsaSha1(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_DsaSha256(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_RsaSignPkcs1Sha1(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_RsaSignPkcs1Sha256(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_RsaSignPkcs1Sha384(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_RsaSignPkcs1Sha512(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_RsaSignPssSha1(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_RsaSignPssSha256(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_RsaSignPssSha384(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_RsaSignPssSha512(HSTRING* value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaPkcs1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaOaepSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaOaepSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaOaepSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaOaepSha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_EcdsaP256Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_EcdsaP384Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_EcdsaP521Sha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DsaSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DsaSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPssSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPssSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPssSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RsaSignPssSha512;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAsymmetricAlgorithmNamesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAsymmetricAlgorithmNamesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAsymmetricAlgorithmNamesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAsymmetricAlgorithmNamesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAsymmetricAlgorithmNamesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAsymmetricAlgorithmNamesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAsymmetricAlgorithmNamesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAsymmetricAlgorithmNamesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAsymmetricAlgorithmNamesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAsymmetricAlgorithmNamesStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAsymmetricAlgorithmNamesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAsymmetricAlgorithmNamesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAsymmetricAlgorithmNamesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAsymmetricAlgorithmNamesStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
