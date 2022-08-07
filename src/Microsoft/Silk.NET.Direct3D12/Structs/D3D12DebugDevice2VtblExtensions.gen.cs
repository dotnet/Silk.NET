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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFeatureMask<TThis>(this TThis thisVtbl, DebugFeature Mask) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugFeature, int>)@this->LpVtbl[3])(@this, Mask);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DebugFeature GetFeatureMask<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        DebugFeature ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugFeature>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReportLiveDeviceObjects<TThis>(this TThis thisVtbl, RldoFlags Flags) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, RldoFlags, int>)@this->LpVtbl[5])(@this, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDebugParameter<TThis>(this TThis thisVtbl, DebugDeviceParameterType Type, void* pData, uint DataSize) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[6])(@this, Type, pData, DataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDebugParameter<T0, TThis>(this TThis thisVtbl, DebugDeviceParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[6])(@this, Type, pDataPtr, DataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDebugParameter<TThis>(this TThis thisVtbl, DebugDeviceParameterType Type, void* pData, uint DataSize) where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[7])(@this, Type, pData, DataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDebugParameter<T0, TThis>(this TThis thisVtbl, DebugDeviceParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12DebugDevice2>
    {
        var @this = (ID3D12DebugDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)@this->LpVtbl[7])(@this, Type, pDataPtr, DataSize);
        }
        return ret;
    }

}
