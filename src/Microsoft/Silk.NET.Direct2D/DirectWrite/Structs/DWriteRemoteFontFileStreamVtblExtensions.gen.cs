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

public unsafe static class DWriteRemoteFontFileStreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong* fileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastWriteTime(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong* lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong* localFileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[7])(@this, localFileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, int* isLocal, ulong* partialSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocal, partialSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Locality>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragments, fragmentCount, asyncResult);
        return ret;
    }

}
