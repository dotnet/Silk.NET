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

public unsafe static class DWriteFontFallbackBuilderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMappings(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, IDWriteFontFallback* fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)@this->LpVtbl[4])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFallback(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, IDWriteFontFallback** fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)@this->LpVtbl[5])(@this, fontFallback);
        return ret;
    }

}
