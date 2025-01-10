// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A5C662C3-68C9-4D3D-B765-972029E21DEC")]
[NativeTypeName("struct INumeralSystemIdentifiersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INumeralSystemIdentifiersStatics
    : INumeralSystemIdentifiersStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INumeralSystemIdentifiersStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INumeralSystemIdentifiersStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INumeralSystemIdentifiersStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Arab(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ArabExt(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Bali(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Beng(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Cham(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Deva(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FullWide(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Gujr(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Guru(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_HaniDec(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Java(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Kali(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Khmr(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Knda(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Lana(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_LanaTham(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Laoo(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Latn(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Lepc(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Limb(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[25])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Mlym(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[26])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Mong(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[27])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Mtei(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[28])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Mymr(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[29])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_MymrShan(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[30])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Nkoo(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[31])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_Olck(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[32])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_Orya(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[33])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_Saur(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[34])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Sund(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[35])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_Talu(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[36])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_TamlDec(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[37])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_Telu(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[38])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Thai(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[39])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_Tibt(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[40])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_Vaii(HSTRING* value)
    {
        return (
            (delegate* unmanaged<INumeralSystemIdentifiersStatics, HSTRING*, int>)((*lpVtbl)[41])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Arab(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ArabExt(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Bali(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Beng(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Cham(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Deva(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_FullWide(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Gujr(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Guru(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_HaniDec(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Java(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Kali(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_Khmr(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_Knda(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_Lana(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_LanaTham(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_Laoo(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_Latn(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_Lepc(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_Limb(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_Mlym(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_Mong(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_Mtei(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_Mymr(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_MymrShan(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_Nkoo(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_Olck(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_Orya(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_Saur(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_Sund(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_Talu(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_TamlDec(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_Telu(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_Thai(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_Tibt(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_Vaii(HSTRING* value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Arab;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ArabExt;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Bali;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Beng;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Cham;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Deva;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FullWide;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Gujr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Guru;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_HaniDec;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Java;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Kali;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Khmr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Knda;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Lana;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LanaTham;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Laoo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Latn;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Lepc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Limb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mlym;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mong;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mtei;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mymr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MymrShan;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Nkoo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Olck;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Orya;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Saur;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Sund;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Talu;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TamlDec;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Telu;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Thai;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Tibt;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Vaii;
    }

    /// <summary>Initializes a new instance of the <see cref = "INumeralSystemIdentifiersStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INumeralSystemIdentifiersStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "INumeralSystemIdentifiersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator INumeralSystemIdentifiersStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new INumeralSystemIdentifiersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INumeralSystemIdentifiersStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "INumeralSystemIdentifiersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        INumeralSystemIdentifiersStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INumeralSystemIdentifiersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INumeralSystemIdentifiersStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new INumeralSystemIdentifiersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INumeralSystemIdentifiersStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INumeralSystemIdentifiersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        INumeralSystemIdentifiersStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
