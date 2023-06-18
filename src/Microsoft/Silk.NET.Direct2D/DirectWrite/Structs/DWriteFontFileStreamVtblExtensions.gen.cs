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

public unsafe static class DWriteFontFileStreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileSize(this ComPtr<IDWriteFontFileStream> thisVtbl, ulong* fileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastWriteTime(this ComPtr<IDWriteFontFileStream> thisVtbl, ulong* lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTime);
        return ret;
    }

}
