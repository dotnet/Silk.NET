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

public unsafe static class DWriteRemoteFontFileLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalityFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, locality);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrl, fontFile);
        return ret;
    }

}
