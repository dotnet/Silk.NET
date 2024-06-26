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

public unsafe static class DStorageQueue2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueRequest(this ComPtr<IDStorageQueue2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Request* request)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Request*, void>)@this->LpVtbl[3])(@this, request);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueRequest(this ComPtr<IDStorageQueue2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Request request)
    {
        var @this = thisVtbl.Handle;
        fixed (Request* requestPtr = &request)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Request*, void>)@this->LpVtbl[3])(@this, requestPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueStatus(this ComPtr<IDStorageQueue2> thisVtbl, IDStorageStatusArray* statusArray, uint index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueStatus(this ComPtr<IDStorageQueue2> thisVtbl, ref IDStorageStatusArray statusArray, uint index)
    {
        var @this = thisVtbl.Handle;
        fixed (IDStorageStatusArray* statusArrayPtr = &statusArray)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArrayPtr, index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueSignal(this ComPtr<IDStorageQueue2> thisVtbl, Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueSignal(this ComPtr<IDStorageQueue2> thisVtbl, ref Silk.NET.Direct3D12.ID3D12Fence fence, ulong value)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Direct3D12.ID3D12Fence* fencePtr = &fence)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fencePtr, value);
        }
    }

    /// <summary>To be documented.</summary>
    public static void Submit(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void CancelRequestsWithTag(this ComPtr<IDStorageQueue2> thisVtbl, ulong mask, ulong value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
    }

    /// <summary>To be documented.</summary>
    public static void Close(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetErrorEvent(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void*>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RetrieveErrorRecord(this ComPtr<IDStorageQueue2> thisVtbl, ErrorRecord* record)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
    }

    /// <summary>To be documented.</summary>
    public static void RetrieveErrorRecord(this ComPtr<IDStorageQueue2> thisVtbl, ref ErrorRecord record)
    {
        var @this = thisVtbl.Handle;
        fixed (ErrorRecord* recordPtr = &record)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, recordPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Query(this ComPtr<IDStorageQueue2> thisVtbl, QueueInfo* info)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
    }

    /// <summary>To be documented.</summary>
    public static void Query(this ComPtr<IDStorageQueue2> thisVtbl, ref QueueInfo info)
    {
        var @this = thisVtbl.Handle;
        fixed (QueueInfo* infoPtr = &info)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, QueueInfo*, void>)@this->LpVtbl[11])(@this, infoPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueSetEvent(this ComPtr<IDStorageQueue2> thisVtbl, void* handle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void*, void>)@this->LpVtbl[12])(@this, handle);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueSetEvent<T0>(this ComPtr<IDStorageQueue2> thisVtbl, ref T0 handle) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* handlePtr = &handle)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void*, void>)@this->LpVtbl[12])(@this, handlePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static CompressionSupport GetCompressionSupport(this ComPtr<IDStorageQueue2> thisVtbl, CompressionFormat format)
    {
        var @this = thisVtbl.Handle;
        CompressionSupport ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, CompressionFormat, CompressionSupport>)@this->LpVtbl[13])(@this, format);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDStorageQueue2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueRequest(this ComPtr<IDStorageQueue2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Request> request)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EnqueueRequest(in request.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueStatus<TI0>(this ComPtr<IDStorageQueue2> thisVtbl, ComPtr<TI0> statusArray, uint index) where TI0 : unmanaged, IComVtbl<IDStorageStatusArray>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EnqueueStatus((IDStorageStatusArray*) statusArray.Handle, index);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueStatus(this ComPtr<IDStorageQueue2> thisVtbl, Span<IDStorageStatusArray> statusArray, uint index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EnqueueStatus(ref statusArray.GetPinnableReference(), index);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueSignal(this ComPtr<IDStorageQueue2> thisVtbl, Span<Silk.NET.Direct3D12.ID3D12Fence> fence, ulong value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EnqueueSignal(ref fence.GetPinnableReference(), value);
    }

    /// <summary>To be documented.</summary>
    public static void RetrieveErrorRecord(this ComPtr<IDStorageQueue2> thisVtbl, Span<ErrorRecord> record)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RetrieveErrorRecord(ref record.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void Query(this ComPtr<IDStorageQueue2> thisVtbl, Span<QueueInfo> info)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Query(ref info.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueSetEvent<T0>(this ComPtr<IDStorageQueue2> thisVtbl, Span<T0> handle) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EnqueueSetEvent(ref handle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDStorageQueue2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
