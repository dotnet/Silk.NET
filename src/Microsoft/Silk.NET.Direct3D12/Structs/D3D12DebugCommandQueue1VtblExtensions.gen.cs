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

public unsafe static class D3D12DebugCommandQueue1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 AssertResourceState(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ID3D12Resource* pResource, uint Subresource, uint State)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this, pResource, Subresource, State);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 AssertResourceState(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ref ID3D12Resource pResource, uint Subresource, uint State)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this, pResourcePtr, Subresource, State);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AssertResourceAccess(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ID3D12Resource* pResource, uint Subresource, BarrierAccess Access)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierAccess, void>)@this->LpVtbl[4])(@this, pResource, Subresource, Access);
    }

    /// <summary>To be documented.</summary>
    public static void AssertResourceAccess(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ref ID3D12Resource pResource, uint Subresource, BarrierAccess Access)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierAccess, void>)@this->LpVtbl[4])(@this, pResourcePtr, Subresource, Access);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AssertTextureLayout(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ID3D12Resource* pResource, uint Subresource, BarrierLayout Layout)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierLayout, void>)@this->LpVtbl[5])(@this, pResource, Subresource, Layout);
    }

    /// <summary>To be documented.</summary>
    public static void AssertTextureLayout(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ref ID3D12Resource pResource, uint Subresource, BarrierLayout Layout)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierLayout, void>)@this->LpVtbl[5])(@this, pResourcePtr, Subresource, Layout);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 AssertResourceState<TI0>(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ComPtr<TI0> pResource, uint Subresource, uint State) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AssertResourceState((ID3D12Resource*) pResource.Handle, Subresource, State);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 AssertResourceState(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, uint State)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AssertResourceState(ref pResource.GetPinnableReference(), Subresource, State);
    }

    /// <summary>To be documented.</summary>
    public static void AssertResourceAccess<TI0>(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ComPtr<TI0> pResource, uint Subresource, BarrierAccess Access) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AssertResourceAccess((ID3D12Resource*) pResource.Handle, Subresource, Access);
    }

    /// <summary>To be documented.</summary>
    public static void AssertResourceAccess(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, BarrierAccess Access)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AssertResourceAccess(ref pResource.GetPinnableReference(), Subresource, Access);
    }

    /// <summary>To be documented.</summary>
    public static void AssertTextureLayout<TI0>(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, ComPtr<TI0> pResource, uint Subresource, BarrierLayout Layout) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AssertTextureLayout((ID3D12Resource*) pResource.Handle, Subresource, Layout);
    }

    /// <summary>To be documented.</summary>
    public static void AssertTextureLayout(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, BarrierLayout Layout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AssertTextureLayout(ref pResource.GetPinnableReference(), Subresource, Layout);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12DebugCommandQueue1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
