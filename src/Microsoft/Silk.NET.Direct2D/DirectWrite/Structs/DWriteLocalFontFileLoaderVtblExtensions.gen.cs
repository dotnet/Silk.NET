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

public unsafe static class DWriteLocalFontFileLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilePathLengthFromKey(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilePathFromKey(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, char* filePath, uint filePathSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastWriteTimeFromKey(this ComPtr<IDWriteLocalFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Silk.NET.Core.Win32Extras.Filetime* lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[6])(@this, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
        return ret;
    }

}
