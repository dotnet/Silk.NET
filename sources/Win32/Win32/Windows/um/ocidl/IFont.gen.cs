// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BEF6E002-A874-101A-8BBA-00AA00300CAB")]
[NativeTypeName("struct IFont : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFont : IFont.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFont));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFont, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFont, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFont, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pName)
    {
        return ((delegate* unmanaged<IFont, ushort**, int>)((*lpVtbl)[3]))(this, pName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_Name([NativeTypeName("BSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IFont, ushort*, int>)((*lpVtbl)[4]))(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Size(CY* pSize)
    {
        return ((delegate* unmanaged<IFont, CY*, int>)((*lpVtbl)[5]))(this, pSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Size(CY size)
    {
        return ((delegate* unmanaged<IFont, CY, int>)((*lpVtbl)[6]))(this, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bold(BOOL* pBold)
    {
        return ((delegate* unmanaged<IFont, BOOL*, int>)((*lpVtbl)[7]))(this, pBold);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Bold(BOOL bold)
    {
        return ((delegate* unmanaged<IFont, BOOL, int>)((*lpVtbl)[8]))(this, bold);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Italic(BOOL* pItalic)
    {
        return ((delegate* unmanaged<IFont, BOOL*, int>)((*lpVtbl)[9]))(this, pItalic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Italic(BOOL italic)
    {
        return ((delegate* unmanaged<IFont, BOOL, int>)((*lpVtbl)[10]))(this, italic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Underline(BOOL* pUnderline)
    {
        return ((delegate* unmanaged<IFont, BOOL*, int>)((*lpVtbl)[11]))(this, pUnderline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Underline(BOOL underline)
    {
        return ((delegate* unmanaged<IFont, BOOL, int>)((*lpVtbl)[12]))(this, underline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Strikethrough(BOOL* pStrikethrough)
    {
        return ((delegate* unmanaged<IFont, BOOL*, int>)((*lpVtbl)[13]))(this, pStrikethrough);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Strikethrough(BOOL strikethrough)
    {
        return ((delegate* unmanaged<IFont, BOOL, int>)((*lpVtbl)[14]))(this, strikethrough);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Weight(short* pWeight)
    {
        return ((delegate* unmanaged<IFont, short*, int>)((*lpVtbl)[15]))(this, pWeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Weight(short weight)
    {
        return ((delegate* unmanaged<IFont, short, int>)((*lpVtbl)[16]))(this, weight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Charset(short* pCharset)
    {
        return ((delegate* unmanaged<IFont, short*, int>)((*lpVtbl)[17]))(this, pCharset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_Charset(short charset)
    {
        return ((delegate* unmanaged<IFont, short, int>)((*lpVtbl)[18]))(this, charset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_hFont(HFONT* phFont)
    {
        return ((delegate* unmanaged<IFont, HFONT*, int>)((*lpVtbl)[19]))(this, phFont);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Clone(IFont* ppFont)
    {
        return ((delegate* unmanaged<IFont, IFont*, int>)((*lpVtbl)[20]))(this, ppFont);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT IsEqual(IFont pFontOther)
    {
        return ((delegate* unmanaged<IFont, IFont, int>)((*lpVtbl)[21]))(this, pFontOther);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetRatio(
        [NativeTypeName("LONG")] int cyLogical,
        [NativeTypeName("LONG")] int cyHimetric
    )
    {
        return ((delegate* unmanaged<IFont, int, int, int>)((*lpVtbl)[22]))(
            this,
            cyLogical,
            cyHimetric
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT QueryTextMetrics([NativeTypeName("TEXTMETRICOLE *")] TEXTMETRICW* pTM)
    {
        return ((delegate* unmanaged<IFont, TEXTMETRICW*, int>)((*lpVtbl)[23]))(this, pTM);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT AddRefHfont(HFONT hFont)
    {
        return ((delegate* unmanaged<IFont, HFONT, int>)((*lpVtbl)[24]))(this, hFont);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ReleaseHfont(HFONT hFont)
    {
        return ((delegate* unmanaged<IFont, HFONT, int>)((*lpVtbl)[25]))(this, hFont);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetHdc(HDC hDC)
    {
        return ((delegate* unmanaged<IFont, HDC, int>)((*lpVtbl)[26]))(this, hDC);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pName);

        [VtblIndex(4)]
        HRESULT put_Name([NativeTypeName("BSTR")] ushort* name);

        [VtblIndex(5)]
        HRESULT get_Size(CY* pSize);

        [VtblIndex(6)]
        HRESULT put_Size(CY size);

        [VtblIndex(7)]
        HRESULT get_Bold(BOOL* pBold);

        [VtblIndex(8)]
        HRESULT put_Bold(BOOL bold);

        [VtblIndex(9)]
        HRESULT get_Italic(BOOL* pItalic);

        [VtblIndex(10)]
        HRESULT put_Italic(BOOL italic);

        [VtblIndex(11)]
        HRESULT get_Underline(BOOL* pUnderline);

        [VtblIndex(12)]
        HRESULT put_Underline(BOOL underline);

        [VtblIndex(13)]
        HRESULT get_Strikethrough(BOOL* pStrikethrough);

        [VtblIndex(14)]
        HRESULT put_Strikethrough(BOOL strikethrough);

        [VtblIndex(15)]
        HRESULT get_Weight(short* pWeight);

        [VtblIndex(16)]
        HRESULT put_Weight(short weight);

        [VtblIndex(17)]
        HRESULT get_Charset(short* pCharset);

        [VtblIndex(18)]
        HRESULT put_Charset(short charset);

        [VtblIndex(19)]
        HRESULT get_hFont(HFONT* phFont);

        [VtblIndex(20)]
        HRESULT Clone(IFont* ppFont);

        [VtblIndex(21)]
        HRESULT IsEqual(IFont pFontOther);

        [VtblIndex(22)]
        HRESULT SetRatio(
            [NativeTypeName("LONG")] int cyLogical,
            [NativeTypeName("LONG")] int cyHimetric
        );

        [VtblIndex(23)]
        HRESULT QueryTextMetrics([NativeTypeName("TEXTMETRICOLE *")] TEXTMETRICW* pTM);

        [VtblIndex(24)]
        HRESULT AddRefHfont(HFONT hFont);

        [VtblIndex(25)]
        HRESULT ReleaseHfont(HFONT hFont);

        [VtblIndex(26)]
        HRESULT SetHdc(HDC hDC);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Name;

        [NativeTypeName("HRESULT (CY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CY*, int> get_Size;

        [NativeTypeName("HRESULT (CY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CY, int> put_Size;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Bold;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Bold;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Italic;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Italic;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Underline;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Underline;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Strikethrough;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Strikethrough;

        [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Weight;

        [NativeTypeName("HRESULT (SHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Weight;

        [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Charset;

        [NativeTypeName("HRESULT (SHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Charset;

        [NativeTypeName("HRESULT (HFONT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HFONT*, int> get_hFont;

        [NativeTypeName("HRESULT (IFont **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFont*, int> Clone;

        [NativeTypeName("HRESULT (IFont *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFont, int> IsEqual;

        [NativeTypeName("HRESULT (LONG, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetRatio;

        [NativeTypeName("HRESULT (TEXTMETRICOLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TEXTMETRICW*, int> QueryTextMetrics;

        [NativeTypeName("HRESULT (HFONT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HFONT, int> AddRefHfont;

        [NativeTypeName("HRESULT (HFONT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HFONT, int> ReleaseHfont;

        [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int> SetHdc;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFont"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFont(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFont"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFont(Silk.NET.Windows.IUnknown value)
    {
        return new IFont(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFont"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFont"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFont value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
