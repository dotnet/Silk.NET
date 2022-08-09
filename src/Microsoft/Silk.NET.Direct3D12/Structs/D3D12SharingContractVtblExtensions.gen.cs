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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Present<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint Subresource, nint window) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResource, Subresource, window);
    }

    /// <summary>To be documented.</summary>
    public static void Present<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint Subresource, nint window) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResourcePtr, Subresource, window);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SharedFenceSignal<TThis>(this TThis thisVtbl, ID3D12Fence* pFence, ulong FenceValue) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFence, FenceValue);
    }

    /// <summary>To be documented.</summary>
    public static void SharedFenceSignal<TThis>(this TThis thisVtbl, ref ID3D12Fence pFence, ulong FenceValue) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginCapturableWork<TThis>(this TThis thisVtbl, Guid* guid) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guid);
    }

    /// <summary>To be documented.</summary>
    public static void BeginCapturableWork<TThis>(this TThis thisVtbl, ref Guid guid) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        fixed (Guid* guidPtr = &guid)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guidPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndCapturableWork<TThis>(this TThis thisVtbl, Guid* guid) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guid);
    }

    /// <summary>To be documented.</summary>
    public static void EndCapturableWork<TThis>(this TThis thisVtbl, ref Guid guid) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        fixed (Guid* guidPtr = &guid)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guidPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void Present<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, nint window) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->Present(ref pResource.GetPinnableReference(), Subresource, window);
    }

    /// <summary>To be documented.</summary>
    public static void SharedFenceSignal<TThis>(this TThis thisVtbl, Span<ID3D12Fence> pFence, ulong FenceValue) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SharedFenceSignal(ref pFence.GetPinnableReference(), FenceValue);
    }

    /// <summary>To be documented.</summary>
    public static void BeginCapturableWork<TThis>(this TThis thisVtbl, Span<Guid> guid) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->BeginCapturableWork(ref guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EndCapturableWork<TThis>(this TThis thisVtbl, Span<Guid> guid) where TThis : IComVtbl<ID3D12SharingContract>
    {
        var @this = (ID3D12SharingContract*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EndCapturableWork(ref guid.GetPinnableReference());
    }

}
