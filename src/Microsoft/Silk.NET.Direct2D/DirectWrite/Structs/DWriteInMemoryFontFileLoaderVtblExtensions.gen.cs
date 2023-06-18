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

public unsafe static class DWriteInMemoryFontFileLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObject, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFileCount(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

}
