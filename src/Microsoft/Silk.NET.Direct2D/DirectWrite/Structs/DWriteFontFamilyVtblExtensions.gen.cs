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

public unsafe static class DWriteFontFamilyVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFamily> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFamily> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteFontFamily> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontCount(this ComPtr<IDWriteFontFamily> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFont(this ComPtr<IDWriteFontFamily> thisVtbl, uint index, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFamily> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstMatchingFont(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFont** matchingFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFontList** matchingFonts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFonts);
        return ret;
    }

}
