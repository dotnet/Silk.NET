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

public unsafe static class DWriteFontFileVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, uint* fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLoader(this ComPtr<IDWriteFontFile> thisVtbl, IDWriteFontFileLoader** fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, IDWriteFontFileLoader**, int>)@this->LpVtbl[4])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
        return ret;
    }

}
