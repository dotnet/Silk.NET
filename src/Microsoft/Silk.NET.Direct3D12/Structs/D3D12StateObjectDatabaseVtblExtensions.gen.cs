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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12StateObjectDatabaseVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12StateObjectDatabase> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12StateObjectDatabase> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, ApplicationDesc*, int>)@this->LpVtbl[3])(@this, pApplicationDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, ApplicationDesc*, int>)@this->LpVtbl[3])(@this, pApplicationDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, PfnApplicationDescFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, PfnApplicationDescFunc, void*, int>)@this->LpVtbl[4])(@this, CallbackFunc, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetApplicationDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, PfnApplicationDescFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, PfnApplicationDescFunc, void*, int>)@this->LpVtbl[4])(@this, CallbackFunc, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipelineStateDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKey, KeySize, Version, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipelineStateDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineStateStreamDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKey, KeySize, Version, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKeyPtr, KeySize, Version, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StorePipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineStateStreamDesc pDesc) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKeyPtr, KeySize, Version, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindPipelineStateDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKey, KeySize, CallbackFunc, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindPipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKey, KeySize, CallbackFunc, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindPipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, void* pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKeyPtr, KeySize, CallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindPipelineStateDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, ref T1 pContext) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKeyPtr, KeySize, CallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDesc, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDesc, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDescPtr, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDescPtr, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDesc, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDesc, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDescPtr, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StoreStateObjectDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDescPtr, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindStateObjectDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, CallbackFunc, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, CallbackFunc, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, void* pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, CallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindStateObjectDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, ref T1 pContext) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, CallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindObjectVersion(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint* pVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindObjectVersion(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, ref uint pVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pVersionPtr = &pVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindObjectVersion<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint* pVersion) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKeyPtr, KeySize, pVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindObjectVersion<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, ref uint pVersion) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (uint* pVersionPtr = &pVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKeyPtr, KeySize, pVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetApplicationDesc(in pApplicationDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetApplicationDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, PfnApplicationDescFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationDesc(CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipelineStateDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineStateStreamDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipelineStateDesc(pKey, KeySize, Version, in pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipelineStateDesc(in pKey.GetPinnableReference(), KeySize, Version, pDesc);
    }

    /// <summary>To be documented.</summary>
    public static int StorePipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineStateStreamDesc> pDesc) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipelineStateDesc(in pKey.GetPinnableReference(), KeySize, Version, in pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindPipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindPipelineStateDesc(pKey, KeySize, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindPipelineStateDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, void* pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindPipelineStateDesc(in pKey.GetPinnableReference(), KeySize, CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static int FindPipelineStateDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, Span<T1> pContext) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindPipelineStateDesc(in pKey.GetPinnableReference(), KeySize, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(pKey, KeySize, Version, pDesc, in pStateObjectToGrowFromKey.GetPinnableReference(), StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StateObjectDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(pKey, KeySize, Version, in pDesc.GetPinnableReference(), pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StateObjectDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(pKey, KeySize, Version, in pDesc.GetPinnableReference(), in pStateObjectToGrowFromKey.GetPinnableReference(), StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(in pKey.GetPinnableReference(), KeySize, Version, pDesc, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(in pKey.GetPinnableReference(), KeySize, Version, pDesc, in pStateObjectToGrowFromKey.GetPinnableReference(), StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StateObjectDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(in pKey.GetPinnableReference(), KeySize, Version, in pDesc.GetPinnableReference(), pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static int StoreStateObjectDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StateObjectDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreStateObjectDesc(in pKey.GetPinnableReference(), KeySize, Version, in pDesc.GetPinnableReference(), in pStateObjectToGrowFromKey.GetPinnableReference(), StateObjectToGrowFromKeySize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindStateObjectDesc(pKey, KeySize, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindStateObjectDesc<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, void* pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindStateObjectDesc(in pKey.GetPinnableReference(), KeySize, CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static int FindStateObjectDesc<T0, T1>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, Span<T1> pContext) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindStateObjectDesc(in pKey.GetPinnableReference(), KeySize, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindObjectVersion(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, Span<uint> pVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindObjectVersion(pKey, KeySize, ref pVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindObjectVersion<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, uint* pVersion) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindObjectVersion(in pKey.GetPinnableReference(), KeySize, pVersion);
    }

    /// <summary>To be documented.</summary>
    public static int FindObjectVersion<T0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pKey, uint KeySize, Span<uint> pVersion) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindObjectVersion(in pKey.GetPinnableReference(), KeySize, ref pVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12StateObjectDatabase> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
