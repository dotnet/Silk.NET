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

public unsafe static class DStorageQueueVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueRequest<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Request* request) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Request*, void>)@this->LpVtbl[3])(@this, request);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueRequest<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Request request) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        fixed (Request* requestPtr = &request)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Request*, void>)@this->LpVtbl[3])(@this, requestPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueStatus<TThis>(this TThis thisVtbl, IDStorageStatusArray* statusArray, uint index) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueStatus<TThis>(this TThis thisVtbl, ref IDStorageStatusArray statusArray, uint index) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        fixed (IDStorageStatusArray* statusArrayPtr = &statusArray)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArrayPtr, index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueSignal<TThis>(this TThis thisVtbl, Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueSignal<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D12.ID3D12Fence fence, ulong value) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Direct3D12.ID3D12Fence* fencePtr = &fence)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fencePtr, value);
        }
    }

    /// <summary>To be documented.</summary>
    public static void Submit<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void CancelRequestsWithTag<TThis>(this TThis thisVtbl, ulong mask, ulong value) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
    }

    /// <summary>To be documented.</summary>
    public static void Close<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetErrorEvent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void*>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RetrieveErrorRecord<TThis>(this TThis thisVtbl, ErrorRecord* record) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
    }

    /// <summary>To be documented.</summary>
    public static void RetrieveErrorRecord<TThis>(this TThis thisVtbl, ref ErrorRecord record) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        fixed (ErrorRecord* recordPtr = &record)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, recordPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Query<TThis>(this TThis thisVtbl, QueueInfo* info) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
    }

    /// <summary>To be documented.</summary>
    public static void Query<TThis>(this TThis thisVtbl, ref QueueInfo info) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        fixed (QueueInfo* infoPtr = &info)
        {
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, QueueInfo*, void>)@this->LpVtbl[11])(@this, infoPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueRequest<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Request> request) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EnqueueRequest(in request.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueStatus<TThis>(this TThis thisVtbl, Span<IDStorageStatusArray> statusArray, uint index) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EnqueueStatus(ref statusArray.GetPinnableReference(), index);
    }

    /// <summary>To be documented.</summary>
    public static void EnqueueSignal<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D12.ID3D12Fence> fence, ulong value) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EnqueueSignal(ref fence.GetPinnableReference(), value);
    }

    /// <summary>To be documented.</summary>
    public static void RetrieveErrorRecord<TThis>(this TThis thisVtbl, Span<ErrorRecord> record) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RetrieveErrorRecord(ref record.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void Query<TThis>(this TThis thisVtbl, Span<QueueInfo> info) where TThis : IComVtbl<IDStorageQueue>
    {
        var @this = (IDStorageQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->Query(ref info.GetPinnableReference());
    }

}
