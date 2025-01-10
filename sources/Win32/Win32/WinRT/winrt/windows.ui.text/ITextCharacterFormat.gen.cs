// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5ADEF3DB-05FB-442D-8065-642AFEA02CED")]
[NativeTypeName("struct ITextCharacterFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextCharacterFormat : ITextCharacterFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextCharacterFormat));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextCharacterFormat, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextCharacterFormat, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllCaps(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllCaps(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, Color*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, Color, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Bold(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Bold(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FontStretch(
        [NativeTypeName("ABI::Windows::UI::Text::FontStretch *")] FontStretch* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FontStretch*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FontStretch(
        [NativeTypeName("ABI::Windows::UI::Text::FontStretch")] FontStretch value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FontStretch, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FontStyle(
        [NativeTypeName("ABI::Windows::UI::Text::FontStyle *")] FontStyle* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FontStyle*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_FontStyle(
        [NativeTypeName("ABI::Windows::UI::Text::FontStyle")] FontStyle value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FontStyle, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, Color*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, Color, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Hidden(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Hidden(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Italic(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Italic(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Kerning(float* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Kerning(float value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_LanguageTag(HSTRING* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, HSTRING*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_LanguageTag(HSTRING value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, HSTRING, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_LinkType(
        [NativeTypeName("ABI::Windows::UI::Text::LinkType *")] LinkType* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, LinkType*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, HSTRING*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, HSTRING, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Outline(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Outline(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Position(float* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_Position(float value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_ProtectedText(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_ProtectedText(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Size(float* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float*, int>)((*lpVtbl)[35]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_Size(float value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float, int>)((*lpVtbl)[36]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_SmallCaps(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[37]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_SmallCaps(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[38]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Spacing(float* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float*, int>)((*lpVtbl)[39]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_Spacing(float value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, float, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_Strikethrough(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[41]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_Strikethrough(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[42]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_Subscript(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[43]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_Subscript(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[44]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_Superscript(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect*, int>)((*lpVtbl)[45]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_Superscript(
        [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, FormatEffect, int>)((*lpVtbl)[46]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_TextScript(
        [NativeTypeName("ABI::Windows::UI::Text::TextScript *")] TextScript* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, TextScript*, int>)((*lpVtbl)[47]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_TextScript(
        [NativeTypeName("ABI::Windows::UI::Text::TextScript")] TextScript value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, TextScript, int>)((*lpVtbl)[48]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_Underline(
        [NativeTypeName("ABI::Windows::UI::Text::UnderlineType *")] UnderlineType* value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, UnderlineType*, int>)((*lpVtbl)[49]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_Underline(
        [NativeTypeName("ABI::Windows::UI::Text::UnderlineType")] UnderlineType value
    )
    {
        return ((delegate* unmanaged<ITextCharacterFormat, UnderlineType, int>)((*lpVtbl)[50]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_Weight([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, int*, int>)((*lpVtbl)[51]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT put_Weight([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ITextCharacterFormat, int, int>)((*lpVtbl)[52]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SetClone(
        [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")]
            ITextCharacterFormat value
    )
    {
        return (
            (delegate* unmanaged<ITextCharacterFormat, ITextCharacterFormat, int>)((*lpVtbl)[53])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetClone(
        [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")]
            ITextCharacterFormat* result
    )
    {
        return (
            (delegate* unmanaged<ITextCharacterFormat, ITextCharacterFormat*, int>)((*lpVtbl)[54])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT IsEqual(
        [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")]
            ITextCharacterFormat format,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<ITextCharacterFormat, ITextCharacterFormat, byte*, int>)(
                (*lpVtbl)[55]
            )
        )(this, format, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllCaps(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(7)]
        HRESULT put_AllCaps(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(8)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT get_Bold(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(11)]
        HRESULT put_Bold(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(12)]
        HRESULT get_FontStretch(
            [NativeTypeName("ABI::Windows::UI::Text::FontStretch *")] FontStretch* value
        );

        [VtblIndex(13)]
        HRESULT put_FontStretch(
            [NativeTypeName("ABI::Windows::UI::Text::FontStretch")] FontStretch value
        );

        [VtblIndex(14)]
        HRESULT get_FontStyle(
            [NativeTypeName("ABI::Windows::UI::Text::FontStyle *")] FontStyle* value
        );

        [VtblIndex(15)]
        HRESULT put_FontStyle(
            [NativeTypeName("ABI::Windows::UI::Text::FontStyle")] FontStyle value
        );

        [VtblIndex(16)]
        HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(18)]
        HRESULT get_Hidden(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(19)]
        HRESULT put_Hidden(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(20)]
        HRESULT get_Italic(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(21)]
        HRESULT put_Italic(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(22)]
        HRESULT get_Kerning(float* value);

        [VtblIndex(23)]
        HRESULT put_Kerning(float value);

        [VtblIndex(24)]
        HRESULT get_LanguageTag(HSTRING* value);

        [VtblIndex(25)]
        HRESULT put_LanguageTag(HSTRING value);

        [VtblIndex(26)]
        HRESULT get_LinkType(
            [NativeTypeName("ABI::Windows::UI::Text::LinkType *")] LinkType* value
        );

        [VtblIndex(27)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(28)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(29)]
        HRESULT get_Outline(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(30)]
        HRESULT put_Outline(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(31)]
        HRESULT get_Position(float* value);

        [VtblIndex(32)]
        HRESULT put_Position(float value);

        [VtblIndex(33)]
        HRESULT get_ProtectedText(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(34)]
        HRESULT put_ProtectedText(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(35)]
        HRESULT get_Size(float* value);

        [VtblIndex(36)]
        HRESULT put_Size(float value);

        [VtblIndex(37)]
        HRESULT get_SmallCaps(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(38)]
        HRESULT put_SmallCaps(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(39)]
        HRESULT get_Spacing(float* value);

        [VtblIndex(40)]
        HRESULT put_Spacing(float value);

        [VtblIndex(41)]
        HRESULT get_Strikethrough(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(42)]
        HRESULT put_Strikethrough(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(43)]
        HRESULT get_Subscript(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(44)]
        HRESULT put_Subscript(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(45)]
        HRESULT get_Superscript(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value
        );

        [VtblIndex(46)]
        HRESULT put_Superscript(
            [NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value
        );

        [VtblIndex(47)]
        HRESULT get_TextScript(
            [NativeTypeName("ABI::Windows::UI::Text::TextScript *")] TextScript* value
        );

        [VtblIndex(48)]
        HRESULT put_TextScript(
            [NativeTypeName("ABI::Windows::UI::Text::TextScript")] TextScript value
        );

        [VtblIndex(49)]
        HRESULT get_Underline(
            [NativeTypeName("ABI::Windows::UI::Text::UnderlineType *")] UnderlineType* value
        );

        [VtblIndex(50)]
        HRESULT put_Underline(
            [NativeTypeName("ABI::Windows::UI::Text::UnderlineType")] UnderlineType value
        );

        [VtblIndex(51)]
        HRESULT get_Weight([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(52)]
        HRESULT put_Weight([NativeTypeName("INT32")] int value);

        [VtblIndex(53)]
        HRESULT SetClone(
            [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")]
                ITextCharacterFormat value
        );

        [VtblIndex(54)]
        HRESULT GetClone(
            [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")]
                ITextCharacterFormat* result
        );

        [VtblIndex(55)]
        HRESULT IsEqual(
            [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")]
                ITextCharacterFormat format,
            [NativeTypeName("boolean *")] byte* result
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
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_AllCaps;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_AllCaps;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_BackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Bold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Bold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStretch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FontStretch*, int> get_FontStretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStretch) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FontStretch, int> put_FontStretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FontStyle*, int> get_FontStyle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStyle) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FontStyle, int> put_FontStyle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_ForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Hidden;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Hidden;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Italic;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Italic;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Kerning;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Kerning;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LanguageTag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_LanguageTag;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::LinkType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LinkType*, int> get_LinkType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Outline;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Outline;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Position;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_ProtectedText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_ProtectedText;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Size;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Size;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_SmallCaps;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_SmallCaps;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Spacing;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Spacing;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Strikethrough;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Strikethrough;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Subscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Subscript;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FormatEffect*, int> get_Superscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FormatEffect, int> put_Superscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextScript *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TextScript*, int> get_TextScript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextScript) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TextScript, int> put_TextScript;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::UnderlineType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UnderlineType*, int> get_Underline;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::UnderlineType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UnderlineType, int> put_Underline;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Weight;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Weight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextCharacterFormat, int> SetClone;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextCharacterFormat*, int> GetClone;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextCharacterFormat, byte*, int> IsEqual;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextCharacterFormat"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextCharacterFormat(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITextCharacterFormat"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITextCharacterFormat(Silk.NET.WinRT.IInspectable value)
    {
        return new ITextCharacterFormat(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextCharacterFormat"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITextCharacterFormat"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITextCharacterFormat value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextCharacterFormat"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextCharacterFormat(Silk.NET.Windows.IUnknown value)
    {
        return new ITextCharacterFormat(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextCharacterFormat"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextCharacterFormat"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextCharacterFormat value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
