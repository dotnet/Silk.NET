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

public unsafe static class D3D12SharingContractVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12SharingContract> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12SharingContract> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Present(this ComPtr<ID3D12SharingContract> thisVtbl, ID3D12Resource* pResource, uint Subresource, nint window)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResource, Subresource, window);
    }

    /// <summary>To be documented.</summary>
    public static void Present(this ComPtr<ID3D12SharingContract> thisVtbl, ref ID3D12Resource pResource, uint Subresource, nint window)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResourcePtr, Subresource, window);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SharedFenceSignal(this ComPtr<ID3D12SharingContract> thisVtbl, ID3D12Fence* pFence, ulong FenceValue)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFence, FenceValue);
    }

    /// <summary>To be documented.</summary>
    public static void SharedFenceSignal(this ComPtr<ID3D12SharingContract> thisVtbl, ref ID3D12Fence pFence, ulong FenceValue)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* guid)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guid);
    }

    /// <summary>To be documented.</summary>
    public static void BeginCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, ref Guid guid)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* guidPtr = &guid)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guidPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* guid)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guid);
    }

    /// <summary>To be documented.</summary>
    public static void EndCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, ref Guid guid)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* guidPtr = &guid)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guidPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12SharingContract> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void Present<TI0>(this ComPtr<ID3D12SharingContract> thisVtbl, ComPtr<TI0> pResource, uint Subresource, nint window) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->Present((ID3D12Resource*) pResource.Handle, Subresource, window);
    }

    /// <summary>To be documented.</summary>
    public static void Present(this ComPtr<ID3D12SharingContract> thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, nint window)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Present(ref pResource.GetPinnableReference(), Subresource, window);
    }

    /// <summary>To be documented.</summary>
    public static void SharedFenceSignal<TI0>(this ComPtr<ID3D12SharingContract> thisVtbl, ComPtr<TI0> pFence, ulong FenceValue) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SharedFenceSignal((ID3D12Fence*) pFence.Handle, FenceValue);
    }

    /// <summary>To be documented.</summary>
    public static void SharedFenceSignal(this ComPtr<ID3D12SharingContract> thisVtbl, Span<ID3D12Fence> pFence, ulong FenceValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SharedFenceSignal(ref pFence.GetPinnableReference(), FenceValue);
    }

    /// <summary>To be documented.</summary>
    public static void BeginCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, Span<Guid> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginCapturableWork(ref guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EndCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, Span<Guid> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EndCapturableWork(ref guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12SharingContract> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
