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

public unsafe static class DWriteFontResourceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFile(this ComPtr<IDWriteFontResource> thisVtbl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, IDWriteFontFile**, int>)@this->LpVtbl[3])(@this, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFaceIndex(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontAxisCount(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefaultFontAxisValues(this ComPtr<IDWriteFontResource> thisVtbl, FontAxisValue* fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisValue*, uint, int>)@this->LpVtbl[6])(@this, fontAxisValues, fontAxisValueCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontResource> thisVtbl, FontAxisRange* fontAxisRanges, uint fontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)@this->LpVtbl[7])(@this, fontAxisRanges, fontAxisRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontAxisAttributes GetFontAxisAttributes(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex)
    {
        var @this = thisVtbl.Handle;
        FontAxisAttributes ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, FontAxisAttributes>)@this->LpVtbl[8])(@this, axisIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, axisIndex, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAxisValueNameCount(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint>)@this->LpVtbl[10])(@this, axisIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRange, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVariations(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Silk.NET.Core.Bool32>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
        return ret;
    }

}
