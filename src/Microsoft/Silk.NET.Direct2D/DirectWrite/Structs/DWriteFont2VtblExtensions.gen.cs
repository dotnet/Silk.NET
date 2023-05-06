// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFont2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IDWriteFont2> thisVtbl, IDWriteFontFamily** fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFamily**, int>)@this->LpVtbl[3])(@this, fontFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IDWriteFont2> thisVtbl, ref IDWriteFontFamily* fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFamily** fontFamilyPtr = &fontFamily)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFamily**, int>)@this->LpVtbl[3])(@this, fontFamilyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetWeight(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontWeight>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetStretch(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontStretch>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetStyle(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontStyle>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSymbolFont(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFaceNames(this ComPtr<IDWriteFont2> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[8])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFaceNames(this ComPtr<IDWriteFont2> thisVtbl, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[8])(@this, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStrings, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStrings, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStringsPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStringsPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontSimulations>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetMetrics(this ComPtr<IDWriteFont2> thisVtbl, FontMetrics* fontMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontMetrics*, void>)@this->LpVtbl[11])(@this, fontMetrics);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFont2> thisVtbl, ref FontMetrics fontMetrics)
    {
        var @this = thisVtbl.Handle;
        fixed (FontMetrics* fontMetricsPtr = &fontMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontMetrics*, void>)@this->LpVtbl[11])(@this, fontMetricsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HasCharacter(this ComPtr<IDWriteFont2> thisVtbl, uint unicodeValue, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, int*, int>)@this->LpVtbl[12])(@this, unicodeValue, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HasCharacter(this ComPtr<IDWriteFont2> thisVtbl, uint unicodeValue, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, int*, int>)@this->LpVtbl[12])(@this, unicodeValue, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFont2> thisVtbl, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFace**, int>)@this->LpVtbl[13])(@this, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFont2> thisVtbl, ref IDWriteFontFace* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFace**, int>)@this->LpVtbl[13])(@this, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPanose(this ComPtr<IDWriteFont2> thisVtbl, Panose* panose)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Panose*, void>)@this->LpVtbl[15])(@this, panose);
    }

    /// <summary>To be documented.</summary>
    public static void GetPanose(this ComPtr<IDWriteFont2> thisVtbl, ref Panose panose)
    {
        var @this = thisVtbl.Handle;
        fixed (Panose* panosePtr = &panose)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Panose*, void>)@this->LpVtbl[15])(@this, panosePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, ref uint actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualRangeCountPtr = &actualRangeCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRanges, actualRangeCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, ref UnicodeRange unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, ref UnicodeRange unicodeRanges, ref uint actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
        {
            fixed (uint* actualRangeCountPtr = &actualRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMonospacedFont(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Silk.NET.Core.Bool32>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsColorFont(this ComPtr<IDWriteFont2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Silk.NET.Core.Bool32>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFont2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFamily<TI0>(this ComPtr<IDWriteFont2> thisVtbl, ref ComPtr<TI0> fontFamily) where TI0 : unmanaged, IComVtbl<IDWriteFontFamily>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFamily((IDWriteFontFamily**) fontFamily.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFaceNames<TI0>(this ComPtr<IDWriteFont2> thisVtbl, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFaceNames((IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings<TI0>(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInformationalStrings(informationalStringID, informationalStrings, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInformationalStrings<TI0>(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont2> thisVtbl, InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInformationalStrings(informationalStringID, ref informationalStrings, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFont2> thisVtbl, Span<FontMetrics> fontMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetMetrics(ref fontMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int HasCharacter(this ComPtr<IDWriteFont2> thisVtbl, uint unicodeValue, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HasCharacter(unicodeValue, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFace<TI0>(this ComPtr<IDWriteFont2> thisVtbl, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace((IDWriteFontFace**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetPanose(this ComPtr<IDWriteFont2> thisVtbl, Span<Panose> panose)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetPanose(ref panose.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, Span<uint> actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, unicodeRanges, ref actualRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, Span<UnicodeRange> unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, ref unicodeRanges.GetPinnableReference(), actualRangeCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnicodeRanges(this ComPtr<IDWriteFont2> thisVtbl, uint maxRangeCount, Span<UnicodeRange> unicodeRanges, Span<uint> actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, ref unicodeRanges.GetPinnableReference(), ref actualRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFont2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
