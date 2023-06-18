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

namespace Silk.NET.DirectStorage;

public unsafe static class DStorageCompressionCodecVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCompressionCodec> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageCompressionCodec> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageCompressionCodec> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedData, uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, compressedDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedData, compressedDataSize, uncompressedBuffer, uncompressedBufferSize, uncompressedDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint CompressBufferBound(this ComPtr<IDStorageCompressionCodec> thisVtbl, nuint uncompressedDataSize)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, nuint, nuint>)@this->LpVtbl[5])(@this, uncompressedDataSize);
        return ret;
    }

}
