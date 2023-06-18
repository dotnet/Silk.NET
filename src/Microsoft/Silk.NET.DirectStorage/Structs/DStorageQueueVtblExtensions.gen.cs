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
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueRequest(this ComPtr<IDStorageQueue> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Request* request)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Request*, void>)@this->LpVtbl[3])(@this, request);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueStatus(this ComPtr<IDStorageQueue> thisVtbl, IDStorageStatusArray* statusArray, uint index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueSignal(this ComPtr<IDStorageQueue> thisVtbl, Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
    }

    /// <summary>To be documented.</summary>
    public static void Submit(this ComPtr<IDStorageQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void CancelRequestsWithTag(this ComPtr<IDStorageQueue> thisVtbl, ulong mask, ulong value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
    }

    /// <summary>To be documented.</summary>
    public static void Close(this ComPtr<IDStorageQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetErrorEvent(this ComPtr<IDStorageQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void*>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RetrieveErrorRecord(this ComPtr<IDStorageQueue> thisVtbl, ErrorRecord* record)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Query(this ComPtr<IDStorageQueue> thisVtbl, QueueInfo* info)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
    }

}
