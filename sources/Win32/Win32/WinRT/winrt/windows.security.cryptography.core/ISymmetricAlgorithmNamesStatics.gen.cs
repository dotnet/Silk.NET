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

[Guid("6870727B-C996-4EAE-84D7-79B2AEB73B9C")]
[NativeTypeName("struct ISymmetricAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISymmetricAlgorithmNamesStatics
    : ISymmetricAlgorithmNamesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISymmetricAlgorithmNamesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISymmetricAlgorithmNamesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISymmetricAlgorithmNamesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesCbc(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesEcb(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TripleDesCbc(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TripleDesEcb(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Rc2Cbc(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Rc2Ecb(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AesCbc(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AesEcb(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AesGcm(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AesCcm(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AesCbcPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_AesEcbPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DesCbcPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DesEcbPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TripleDesCbcPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_TripleDesEcbPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Rc2CbcPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Rc2EcbPkcs7(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Rc4(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISymmetricAlgorithmNamesStatics, HSTRING*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesCbc(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DesEcb(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_TripleDesCbc(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_TripleDesEcb(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Rc2Cbc(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Rc2Ecb(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_AesCbc(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_AesEcb(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_AesGcm(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_AesCcm(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_AesCbcPkcs7(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_AesEcbPkcs7(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_DesCbcPkcs7(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_DesEcbPkcs7(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_TripleDesCbcPkcs7(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_TripleDesEcbPkcs7(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_Rc2CbcPkcs7(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_Rc2EcbPkcs7(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_Rc4(HSTRING* value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DesCbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DesEcb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TripleDesCbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TripleDesEcb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rc2Cbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rc2Ecb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AesCbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AesEcb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AesGcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AesCcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AesCbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AesEcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DesCbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DesEcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TripleDesCbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TripleDesEcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rc2CbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rc2EcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rc4;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISymmetricAlgorithmNamesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISymmetricAlgorithmNamesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISymmetricAlgorithmNamesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISymmetricAlgorithmNamesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISymmetricAlgorithmNamesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISymmetricAlgorithmNamesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISymmetricAlgorithmNamesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISymmetricAlgorithmNamesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISymmetricAlgorithmNamesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISymmetricAlgorithmNamesStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ISymmetricAlgorithmNamesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISymmetricAlgorithmNamesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISymmetricAlgorithmNamesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISymmetricAlgorithmNamesStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
