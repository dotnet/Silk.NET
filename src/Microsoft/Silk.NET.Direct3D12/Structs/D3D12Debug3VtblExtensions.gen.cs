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

public unsafe static class D3D12Debug3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void EnableDebugLayer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, void>)@this->LpVtbl[3])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableGPUBasedValidation<TThis>(this TThis thisVtbl, int Enable) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, int, void>)@this->LpVtbl[4])(@this, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableSynchronizedCommandQueueValidation<TThis>(this TThis thisVtbl, int Enable) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, int, void>)@this->LpVtbl[5])(@this, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void SetGPUBasedValidationFlags<TThis>(this TThis thisVtbl, GpuBasedValidationFlags Flags) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Debug3*, GpuBasedValidationFlags, void>)@this->LpVtbl[6])(@this, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Debug3>
    {
        var @this = (ID3D12Debug3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

}
