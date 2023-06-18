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

public unsafe static class DWriteFontCollection2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontCollection2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontCollection2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFamilyCount(this ComPtr<IDWriteFontCollection2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IDWriteFontCollection2> thisVtbl, uint index, IDWriteFontFamily** fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection2> thisVtbl, IDWriteFontFace* fontFace, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSet(this ComPtr<IDWriteFontCollection2> thisVtbl, IDWriteFontSet** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontSet**, int>)@this->LpVtbl[7])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyName, fontAxisValues, fontAxisValueCount, fontList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontFamilyModel GetFontFamilyModel(this ComPtr<IDWriteFontCollection2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontFamilyModel ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, FontFamilyModel>)@this->LpVtbl[11])(@this);
        return ret;
    }

}
