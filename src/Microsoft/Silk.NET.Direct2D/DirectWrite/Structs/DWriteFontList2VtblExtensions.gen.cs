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

public unsafe static class DWriteFontList2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontList2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteFontList2> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontCount(this ComPtr<IDWriteFontList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFont(this ComPtr<IDWriteFontList2> thisVtbl, uint index, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetFontLocality(this ComPtr<IDWriteFontList2> thisVtbl, uint listIndex)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, Locality>)@this->LpVtbl[6])(@this, listIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontList2> thisVtbl, uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[8])(@this, listIndex, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSet(this ComPtr<IDWriteFontList2> thisVtbl, IDWriteFontSet1** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, IDWriteFontSet1**, int>)@this->LpVtbl[9])(@this, fontSet);
        return ret;
    }

}
