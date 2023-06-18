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

public unsafe static class DWriteFont3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFont3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IDWriteFont3> thisVtbl, IDWriteFontFamily** fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, IDWriteFontFamily**, int>)@this->LpVtbl[3])(@this, fontFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetWeight(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, FontWeight>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetStretch(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, FontStretch>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetStyle(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, FontStyle>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSymbolFont(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFaceNames(this ComPtr<IDWriteFont3> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[8])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFont3> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStrings, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, FontSimulations>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetMetrics(this ComPtr<IDWriteFont3> thisVtbl, FontMetrics* fontMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFont3*, FontMetrics*, void>)@this->LpVtbl[11])(@this, fontMetrics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HasCharacter(this ComPtr<IDWriteFont3> thisVtbl, uint unicodeValue, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, uint, int*, int>)@this->LpVtbl[12])(@this, unicodeValue, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFont3> thisVtbl, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, IDWriteFontFace**, int>)@this->LpVtbl[13])(@this, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPanose(this ComPtr<IDWriteFont3> thisVtbl, Panose* panose)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFont3*, Panose*, void>)@this->LpVtbl[15])(@this, panose);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFont3> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMonospacedFont(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, Silk.NET.Core.Bool32>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsColorFont(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, Silk.NET.Core.Bool32>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 Equals(this ComPtr<IDWriteFont3> thisVtbl, IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, IDWriteFont*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFont3> thisVtbl, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, IDWriteFontFaceReference**, int>)@this->LpVtbl[21])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetLocality(this ComPtr<IDWriteFont3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFont3*, Locality>)@this->LpVtbl[23])(@this);
        return ret;
    }

}
