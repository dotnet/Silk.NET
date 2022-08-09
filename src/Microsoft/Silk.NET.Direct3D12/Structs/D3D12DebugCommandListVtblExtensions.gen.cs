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

public unsafe static class D3D12DebugCommandListVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssertResourceState<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint Subresource, uint State) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, ID3D12Resource*, uint, uint, int>)@this->LpVtbl[3])(@this, pResource, Subresource, State);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AssertResourceState<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint Subresource, uint State) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, ID3D12Resource*, uint, uint, int>)@this->LpVtbl[3])(@this, pResourcePtr, Subresource, State);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFeatureMask<TThis>(this TThis thisVtbl, DebugFeature Mask) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, DebugFeature, int>)@this->LpVtbl[4])(@this, Mask);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DebugFeature GetFeatureMask<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        DebugFeature ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, DebugFeature>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AssertResourceState<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, uint State) where TThis : IComVtbl<ID3D12DebugCommandList>
    {
        var @this = (ID3D12DebugCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AssertResourceState(ref pResource.GetPinnableReference(), Subresource, State);
    }

}
