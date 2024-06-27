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
    public static unsafe int QueryInterface(this ComPtr<IDStorageCompressionCodec> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCompressionCodec> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCompressionCodec> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe int CompressBuffer(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, ref nuint compressedDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* compressedDataSizePtr = &compressedDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedData, uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, compressedDataSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, ref T0 compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* compressedBufferPtr = &compressedBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedData, uncompressedDataSize, compressionSetting, compressedBufferPtr, compressedBufferSize, compressedDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, ref T0 compressedBuffer, nuint compressedBufferSize, ref nuint compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* compressedBufferPtr = &compressedBuffer)
        {
            fixed (nuint* compressedDataSizePtr = &compressedDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedData, uncompressedDataSize, compressionSetting, compressedBufferPtr, compressedBufferSize, compressedDataSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* uncompressedDataPtr = &uncompressedData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedDataPtr, uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, compressedDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, ref nuint compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* uncompressedDataPtr = &uncompressedData)
        {
            fixed (nuint* compressedDataSizePtr = &compressedDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedDataPtr, uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, compressedDataSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, ref T1 compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* uncompressedDataPtr = &uncompressedData)
        {
            fixed (void* compressedBufferPtr = &compressedBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedDataPtr, uncompressedDataSize, compressionSetting, compressedBufferPtr, compressedBufferSize, compressedDataSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, ref T1 compressedBuffer, nuint compressedBufferSize, ref nuint compressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* uncompressedDataPtr = &uncompressedData)
        {
            fixed (void* compressedBufferPtr = &compressedBuffer)
            {
                fixed (nuint* compressedDataSizePtr = &compressedDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedDataPtr, uncompressedDataSize, compressionSetting, compressedBufferPtr, compressedBufferSize, compressedDataSizePtr);
                }
            }
        }
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
    public static unsafe int DecompressBuffer(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, ref nuint uncompressedDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* uncompressedDataSizePtr = &uncompressedDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedData, compressedDataSize, uncompressedBuffer, uncompressedBufferSize, uncompressedDataSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, ref T0 uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* uncompressedBufferPtr = &uncompressedBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedData, compressedDataSize, uncompressedBufferPtr, uncompressedBufferSize, uncompressedDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, ref T0 uncompressedBuffer, nuint uncompressedBufferSize, ref nuint uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* uncompressedBufferPtr = &uncompressedBuffer)
        {
            fixed (nuint* uncompressedDataSizePtr = &uncompressedDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedData, compressedDataSize, uncompressedBufferPtr, uncompressedBufferSize, uncompressedDataSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* compressedDataPtr = &compressedData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedDataPtr, compressedDataSize, uncompressedBuffer, uncompressedBufferSize, uncompressedDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, ref nuint uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* compressedDataPtr = &compressedData)
        {
            fixed (nuint* uncompressedDataSizePtr = &uncompressedDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedDataPtr, compressedDataSize, uncompressedBuffer, uncompressedBufferSize, uncompressedDataSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 compressedData, nuint compressedDataSize, ref T1 uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* compressedDataPtr = &compressedData)
        {
            fixed (void* uncompressedBufferPtr = &uncompressedBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedDataPtr, compressedDataSize, uncompressedBufferPtr, uncompressedBufferSize, uncompressedDataSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 compressedData, nuint compressedDataSize, ref T1 uncompressedBuffer, nuint uncompressedBufferSize, ref nuint uncompressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* compressedDataPtr = &compressedData)
        {
            fixed (void* uncompressedBufferPtr = &uncompressedBuffer)
            {
                fixed (nuint* uncompressedDataSizePtr = &uncompressedDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedDataPtr, compressedDataSize, uncompressedBufferPtr, uncompressedBufferSize, uncompressedDataSizePtr);
                }
            }
        }
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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCompressionCodec> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCompressionCodec> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, Span<nuint> compressedDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(uncompressedData, uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, ref compressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, Span<T0> compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(uncompressedData, uncompressedDataSize, compressionSetting, ref compressedBuffer.GetPinnableReference(), compressedBufferSize, compressedDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, Span<T0> compressedBuffer, nuint compressedBufferSize, Span<nuint> compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(uncompressedData, uncompressedDataSize, compressionSetting, ref compressedBuffer.GetPinnableReference(), compressedBufferSize, ref compressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(in uncompressedData.GetPinnableReference(), uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, compressedDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, Span<nuint> compressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(in uncompressedData.GetPinnableReference(), uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, ref compressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, Span<T1> compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(in uncompressedData.GetPinnableReference(), uncompressedDataSize, compressionSetting, ref compressedBuffer.GetPinnableReference(), compressedBufferSize, compressedDataSize);
    }

    /// <summary>To be documented.</summary>
    public static int CompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, Span<T1> compressedBuffer, nuint compressedBufferSize, Span<nuint> compressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompressBuffer(in uncompressedData.GetPinnableReference(), uncompressedDataSize, compressionSetting, ref compressedBuffer.GetPinnableReference(), compressedBufferSize, ref compressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, Span<nuint> uncompressedDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(compressedData, compressedDataSize, uncompressedBuffer, uncompressedBufferSize, ref uncompressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, Span<T0> uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(compressedData, compressedDataSize, ref uncompressedBuffer.GetPinnableReference(), uncompressedBufferSize, uncompressedDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, Span<T0> uncompressedBuffer, nuint uncompressedBufferSize, Span<nuint> uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(compressedData, compressedDataSize, ref uncompressedBuffer.GetPinnableReference(), uncompressedBufferSize, ref uncompressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(in compressedData.GetPinnableReference(), compressedDataSize, uncompressedBuffer, uncompressedBufferSize, uncompressedDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, Span<nuint> uncompressedDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(in compressedData.GetPinnableReference(), compressedDataSize, uncompressedBuffer, uncompressedBufferSize, ref uncompressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> compressedData, nuint compressedDataSize, Span<T1> uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(in compressedData.GetPinnableReference(), compressedDataSize, ref uncompressedBuffer.GetPinnableReference(), uncompressedBufferSize, uncompressedDataSize);
    }

    /// <summary>To be documented.</summary>
    public static int DecompressBuffer<T0, T1>(this ComPtr<IDStorageCompressionCodec> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> compressedData, nuint compressedDataSize, Span<T1> uncompressedBuffer, nuint uncompressedBufferSize, Span<nuint> uncompressedDataSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecompressBuffer(in compressedData.GetPinnableReference(), compressedDataSize, ref uncompressedBuffer.GetPinnableReference(), uncompressedBufferSize, ref uncompressedDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDStorageCompressionCodec> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
