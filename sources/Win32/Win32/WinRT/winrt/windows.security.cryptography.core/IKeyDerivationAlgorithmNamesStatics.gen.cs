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

[Guid("7B6E363E-94D2-4739-A57B-022E0C3A402A")]
[NativeTypeName("struct IKeyDerivationAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationAlgorithmNamesStatics
    : IKeyDerivationAlgorithmNamesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyDerivationAlgorithmNamesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Pbkdf2Md5(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Pbkdf2Sha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Pbkdf2Sha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Pbkdf2Sha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Pbkdf2Sha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Sp800108CtrHmacMd5(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Sp800108CtrHmacSha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Sp800108CtrHmacSha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Sp800108CtrHmacSha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Sp800108CtrHmacSha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Sp80056aConcatMd5(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Sp80056aConcatSha1(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Sp80056aConcatSha256(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Sp80056aConcatSha384(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Sp80056aConcatSha512(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IKeyDerivationAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Pbkdf2Md5(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Pbkdf2Sha1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Pbkdf2Sha256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Pbkdf2Sha384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Pbkdf2Sha512(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Sp800108CtrHmacMd5(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Sp800108CtrHmacSha1(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Sp800108CtrHmacSha256(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Sp800108CtrHmacSha384(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_Sp800108CtrHmacSha512(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Sp80056aConcatMd5(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Sp80056aConcatSha1(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_Sp80056aConcatSha256(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_Sp80056aConcatSha384(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_Sp80056aConcatSha512(HSTRING* value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Pbkdf2Md5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Pbkdf2Sha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Pbkdf2Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Pbkdf2Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Pbkdf2Sha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp800108CtrHmacMd5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp80056aConcatMd5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp80056aConcatSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp80056aConcatSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp80056aConcatSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sp80056aConcatSha512;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKeyDerivationAlgorithmNamesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKeyDerivationAlgorithmNamesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKeyDerivationAlgorithmNamesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKeyDerivationAlgorithmNamesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IKeyDerivationAlgorithmNamesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyDerivationAlgorithmNamesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyDerivationAlgorithmNamesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IKeyDerivationAlgorithmNamesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKeyDerivationAlgorithmNamesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKeyDerivationAlgorithmNamesStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IKeyDerivationAlgorithmNamesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyDerivationAlgorithmNamesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyDerivationAlgorithmNamesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IKeyDerivationAlgorithmNamesStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
