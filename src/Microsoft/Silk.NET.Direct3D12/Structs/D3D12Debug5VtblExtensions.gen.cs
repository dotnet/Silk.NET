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

public unsafe static class D3D12Debug5VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void EnableDebugLayer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, void>)@this->LpVtbl[3])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableGPUBasedValidation<TThis>(this TThis thisVtbl, int Enable) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, int, void>)@this->LpVtbl[4])(@this, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableSynchronizedCommandQueueValidation<TThis>(this TThis thisVtbl, int Enable) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, int, void>)@this->LpVtbl[5])(@this, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void SetGPUBasedValidationFlags<TThis>(this TThis thisVtbl, GpuBasedValidationFlags Flags) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, GpuBasedValidationFlags, void>)@this->LpVtbl[6])(@this, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void DisableDebugLayer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, void>)@this->LpVtbl[7])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableAutoName<TThis>(this TThis thisVtbl, int Enable) where TThis : IComVtbl<ID3D12Debug5>
    {
        var @this = (ID3D12Debug5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug5*, int, void>)@this->LpVtbl[8])(@this, Enable);
    }

}
