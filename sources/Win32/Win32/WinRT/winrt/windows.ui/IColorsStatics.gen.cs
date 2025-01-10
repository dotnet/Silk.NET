// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CFF52E04-CCA6-4614-A17E-754910C84A99")]
[NativeTypeName("struct IColorsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IColorsStatics : IColorsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IColorsStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IColorsStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IColorsStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IColorsStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IColorsStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IColorsStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IColorsStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AliceBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AntiqueWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Aqua([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Aquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Azure([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Beige([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Bisque([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Black([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_BlanchedAlmond([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Blue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_BlueViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Brown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BurlyWood([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_CadetBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Chartreuse([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Chocolate([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Coral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CornflowerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Cornsilk([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Crimson([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Cyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_DarkBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_DarkCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_DarkGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[29]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_DarkGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_DarkGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[31]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_DarkKhaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[32]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_DarkMagenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[33]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_DarkOliveGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[34]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_DarkOrange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[35]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_DarkOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[36]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_DarkRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[37]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_DarkSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[38]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_DarkSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[39]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_DarkSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[40]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_DarkSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[41]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_DarkTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[42]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_DarkViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[43]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_DeepPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[44]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_DeepSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[45]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_DimGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[46]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_DodgerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[47]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_Firebrick([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[48]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_FloralWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[49]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_ForestGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[50]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_Fuchsia([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[51]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_Gainsboro([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[52]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_GhostWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[53]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_Gold([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[54]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_Goldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[55]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_Gray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[56]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_Green([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[57]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_GreenYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[58]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_Honeydew([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[59]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_HotPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[60]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_IndianRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[61]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_Indigo([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[62]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_Ivory([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[63]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_Khaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[64]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_Lavender([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[65]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_LavenderBlush([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[66]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_LawnGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[67]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_LemonChiffon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[68]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_LightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[69]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_LightCoral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[70]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_LightCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[71]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_LightGoldenrodYellow(
        [NativeTypeName("ABI::Windows::UI::Color *")] Color* value
    )
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[72]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_LightGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[73]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_LightGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[74]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_LightPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[75]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_LightSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[76]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_LightSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[77]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_LightSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[78]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_LightSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[79]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_LightSteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[80]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_LightYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[81]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_Lime([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[82]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_LimeGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[83]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_Linen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[84]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_Magenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[85]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_Maroon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[86]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_MediumAquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[87]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_MediumBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[88]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_MediumOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[89]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_MediumPurple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[90]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_MediumSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[91]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_MediumSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[92]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_MediumSpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[93]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_MediumTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[94]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_MediumVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[95]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_MidnightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[96]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_MintCream([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[97]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_MistyRose([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[98]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_Moccasin([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[99]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_NavajoWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[100]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_Navy([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[101]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_OldLace([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[102]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_Olive([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[103]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_OliveDrab([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[104]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_Orange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[105]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_OrangeRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[106]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_Orchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[107]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_PaleGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[108]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_PaleGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[109]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_PaleTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[110]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_PaleVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[111]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_PapayaWhip([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[112]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_PeachPuff([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[113]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT get_Peru([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[114]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT get_Pink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[115]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT get_Plum([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[116]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT get_PowderBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[117]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT get_Purple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[118]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT get_Red([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[119]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT get_RosyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[120]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT get_RoyalBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[121]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT get_SaddleBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[122]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT get_Salmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[123]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT get_SandyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[124]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT get_SeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[125]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT get_SeaShell([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[126]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT get_Sienna([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[127]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT get_Silver([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[128]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT get_SkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[129]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT get_SlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[130]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT get_SlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[131]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT get_Snow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[132]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT get_SpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[133]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT get_SteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[134]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT get_Tan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[135]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT get_Teal([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[136]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT get_Thistle([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[137]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT get_Tomato([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[138]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT get_Transparent([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[139]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT get_Turquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[140]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT get_Violet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[141]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT get_Wheat([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[142]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT get_White([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[143]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT get_WhiteSmoke([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[144]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT get_Yellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[145]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT get_YellowGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics, Color*, int>)((*lpVtbl)[146]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AliceBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT get_AntiqueWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(8)]
        HRESULT get_Aqua([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT get_Aquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(10)]
        HRESULT get_Azure([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(11)]
        HRESULT get_Beige([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(12)]
        HRESULT get_Bisque([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(13)]
        HRESULT get_Black([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(14)]
        HRESULT get_BlanchedAlmond([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(15)]
        HRESULT get_Blue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(16)]
        HRESULT get_BlueViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT get_Brown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(18)]
        HRESULT get_BurlyWood([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(19)]
        HRESULT get_CadetBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(20)]
        HRESULT get_Chartreuse([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(21)]
        HRESULT get_Chocolate([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(22)]
        HRESULT get_Coral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(23)]
        HRESULT get_CornflowerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(24)]
        HRESULT get_Cornsilk([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(25)]
        HRESULT get_Crimson([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(26)]
        HRESULT get_Cyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(27)]
        HRESULT get_DarkBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(28)]
        HRESULT get_DarkCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(29)]
        HRESULT get_DarkGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(30)]
        HRESULT get_DarkGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(31)]
        HRESULT get_DarkGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(32)]
        HRESULT get_DarkKhaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(33)]
        HRESULT get_DarkMagenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(34)]
        HRESULT get_DarkOliveGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(35)]
        HRESULT get_DarkOrange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(36)]
        HRESULT get_DarkOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(37)]
        HRESULT get_DarkRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(38)]
        HRESULT get_DarkSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(39)]
        HRESULT get_DarkSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(40)]
        HRESULT get_DarkSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(41)]
        HRESULT get_DarkSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(42)]
        HRESULT get_DarkTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(43)]
        HRESULT get_DarkViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(44)]
        HRESULT get_DeepPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(45)]
        HRESULT get_DeepSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(46)]
        HRESULT get_DimGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(47)]
        HRESULT get_DodgerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(48)]
        HRESULT get_Firebrick([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(49)]
        HRESULT get_FloralWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(50)]
        HRESULT get_ForestGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(51)]
        HRESULT get_Fuchsia([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(52)]
        HRESULT get_Gainsboro([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(53)]
        HRESULT get_GhostWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(54)]
        HRESULT get_Gold([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(55)]
        HRESULT get_Goldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(56)]
        HRESULT get_Gray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(57)]
        HRESULT get_Green([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(58)]
        HRESULT get_GreenYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(59)]
        HRESULT get_Honeydew([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(60)]
        HRESULT get_HotPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(61)]
        HRESULT get_IndianRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(62)]
        HRESULT get_Indigo([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(63)]
        HRESULT get_Ivory([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(64)]
        HRESULT get_Khaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(65)]
        HRESULT get_Lavender([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(66)]
        HRESULT get_LavenderBlush([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(67)]
        HRESULT get_LawnGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(68)]
        HRESULT get_LemonChiffon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(69)]
        HRESULT get_LightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(70)]
        HRESULT get_LightCoral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(71)]
        HRESULT get_LightCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(72)]
        HRESULT get_LightGoldenrodYellow(
            [NativeTypeName("ABI::Windows::UI::Color *")] Color* value
        );

        [VtblIndex(73)]
        HRESULT get_LightGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(74)]
        HRESULT get_LightGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(75)]
        HRESULT get_LightPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(76)]
        HRESULT get_LightSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(77)]
        HRESULT get_LightSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(78)]
        HRESULT get_LightSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(79)]
        HRESULT get_LightSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(80)]
        HRESULT get_LightSteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(81)]
        HRESULT get_LightYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(82)]
        HRESULT get_Lime([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(83)]
        HRESULT get_LimeGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(84)]
        HRESULT get_Linen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(85)]
        HRESULT get_Magenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(86)]
        HRESULT get_Maroon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(87)]
        HRESULT get_MediumAquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(88)]
        HRESULT get_MediumBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(89)]
        HRESULT get_MediumOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(90)]
        HRESULT get_MediumPurple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(91)]
        HRESULT get_MediumSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(92)]
        HRESULT get_MediumSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(93)]
        HRESULT get_MediumSpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(94)]
        HRESULT get_MediumTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(95)]
        HRESULT get_MediumVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(96)]
        HRESULT get_MidnightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(97)]
        HRESULT get_MintCream([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(98)]
        HRESULT get_MistyRose([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(99)]
        HRESULT get_Moccasin([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(100)]
        HRESULT get_NavajoWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(101)]
        HRESULT get_Navy([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(102)]
        HRESULT get_OldLace([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(103)]
        HRESULT get_Olive([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(104)]
        HRESULT get_OliveDrab([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(105)]
        HRESULT get_Orange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(106)]
        HRESULT get_OrangeRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(107)]
        HRESULT get_Orchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(108)]
        HRESULT get_PaleGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(109)]
        HRESULT get_PaleGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(110)]
        HRESULT get_PaleTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(111)]
        HRESULT get_PaleVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(112)]
        HRESULT get_PapayaWhip([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(113)]
        HRESULT get_PeachPuff([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(114)]
        HRESULT get_Peru([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(115)]
        HRESULT get_Pink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(116)]
        HRESULT get_Plum([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(117)]
        HRESULT get_PowderBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(118)]
        HRESULT get_Purple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(119)]
        HRESULT get_Red([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(120)]
        HRESULT get_RosyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(121)]
        HRESULT get_RoyalBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(122)]
        HRESULT get_SaddleBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(123)]
        HRESULT get_Salmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(124)]
        HRESULT get_SandyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(125)]
        HRESULT get_SeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(126)]
        HRESULT get_SeaShell([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(127)]
        HRESULT get_Sienna([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(128)]
        HRESULT get_Silver([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(129)]
        HRESULT get_SkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(130)]
        HRESULT get_SlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(131)]
        HRESULT get_SlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(132)]
        HRESULT get_Snow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(133)]
        HRESULT get_SpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(134)]
        HRESULT get_SteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(135)]
        HRESULT get_Tan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(136)]
        HRESULT get_Teal([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(137)]
        HRESULT get_Thistle([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(138)]
        HRESULT get_Tomato([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(139)]
        HRESULT get_Transparent([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(140)]
        HRESULT get_Turquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(141)]
        HRESULT get_Violet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(142)]
        HRESULT get_Wheat([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(143)]
        HRESULT get_White([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(144)]
        HRESULT get_WhiteSmoke([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(145)]
        HRESULT get_Yellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(146)]
        HRESULT get_YellowGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_AliceBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_AntiqueWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Aqua;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Aquamarine;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Azure;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Beige;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Bisque;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Black;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BlanchedAlmond;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Blue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BlueViolet;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Brown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BurlyWood;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_CadetBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Chartreuse;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Chocolate;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Coral;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_CornflowerBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Cornsilk;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Crimson;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Cyan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkCyan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkGoldenrod;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkKhaki;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkMagenta;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkOliveGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkOrange;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkOrchid;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSalmon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSlateBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSlateGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkTurquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkViolet;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DeepPink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DeepSkyBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DimGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DodgerBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Firebrick;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_FloralWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_ForestGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Fuchsia;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Gainsboro;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_GhostWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Gold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Goldenrod;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Gray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Green;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_GreenYellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Honeydew;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_HotPink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_IndianRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Indigo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Ivory;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Khaki;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Lavender;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LavenderBlush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LawnGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LemonChiffon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightCoral;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightCyan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightGoldenrodYellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightPink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSalmon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSkyBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSlateGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSteelBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightYellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Lime;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LimeGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Linen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Magenta;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Maroon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumAquamarine;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumOrchid;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumPurple;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumSeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumSlateBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumSpringGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumTurquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumVioletRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MidnightBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MintCream;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MistyRose;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Moccasin;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_NavajoWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Navy;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OldLace;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Olive;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OliveDrab;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Orange;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OrangeRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Orchid;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleGoldenrod;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleTurquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleVioletRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PapayaWhip;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PeachPuff;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Peru;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Pink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Plum;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PowderBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Purple;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Red;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_RosyBrown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_RoyalBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SaddleBrown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Salmon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SandyBrown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SeaShell;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Sienna;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Silver;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SkyBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SlateBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SlateGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Snow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SpringGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SteelBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Tan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Teal;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Thistle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Tomato;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Transparent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Turquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Violet;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Wheat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_White;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_WhiteSmoke;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Yellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_YellowGreen;
    }

    /// <summary>Initializes a new instance of the <see cref = "IColorsStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IColorsStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IColorsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IColorsStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IColorsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IColorsStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IColorsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IColorsStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IColorsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IColorsStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IColorsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IColorsStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IColorsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IColorsStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
