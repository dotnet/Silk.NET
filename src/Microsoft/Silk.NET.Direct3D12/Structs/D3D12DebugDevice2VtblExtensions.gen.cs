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

public unsafe static class D3D12DebugDevice2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugDevice2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugDevice2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugDevice2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugDevice2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DebugDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DebugDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFeatureMask(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugFeature Mask)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugFeature, int>)@this->LpVtbl[3])(@this, Mask);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DebugFeature GetFeatureMask(this ComPtr<ID3D12DebugDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DebugFeature ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugFeature>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReportLiveDeviceObjects(this ComPtr<ID3D12DebugDevice2> thisVtbl, RldoFlags Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, RldoFlags, int>)@this->LpVtbl[5])(@this, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDebugParameter(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugDeviceParameterType Type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[6])(@this, Type, pData, DataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDebugParameter<T0>(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugDeviceParameterType Type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint DataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[6])(@this, Type, pDataPtr, DataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDebugParameter(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugDeviceParameterType Type, void* pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[7])(@this, Type, pData, DataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDebugParameter<T0>(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugDeviceParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[7])(@this, Type, pDataPtr, DataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12DebugDevice2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugDevice2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugDevice2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetDebugParameter<T0>(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugDeviceParameterType Type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint DataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDebugParameter(Type, in pData.GetPinnableReference(), DataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetDebugParameter<T0>(this ComPtr<ID3D12DebugDevice2> thisVtbl, DebugDeviceParameterType Type, Span<T0> pData, uint DataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDebugParameter(Type, ref pData.GetPinnableReference(), DataSize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12DebugDevice2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
