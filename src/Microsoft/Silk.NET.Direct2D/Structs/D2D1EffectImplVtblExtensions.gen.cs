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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1EffectImplVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectImpl> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectImpl> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectImpl> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectImpl> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1EffectImpl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1EffectImpl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContext, transformGraph);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, ID2D1EffectContext* effectContext, ref ID2D1TransformGraph transformGraph)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformGraph* transformGraphPtr = &transformGraph)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContext, transformGraphPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, ref ID2D1EffectContext effectContext, ID2D1TransformGraph* transformGraph)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1EffectContext* effectContextPtr = &effectContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContextPtr, transformGraph);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, ref ID2D1EffectContext effectContext, ref ID2D1TransformGraph transformGraph)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1EffectContext* effectContextPtr = &effectContext)
        {
            fixed (ID2D1TransformGraph* transformGraphPtr = &transformGraph)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContextPtr, transformGraphPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PrepareForRender(this ComPtr<ID2D1EffectImpl> thisVtbl, ChangeType changeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ChangeType, int>)@this->LpVtbl[4])(@this, changeType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGraph(this ComPtr<ID2D1EffectImpl> thisVtbl, ID2D1TransformGraph* transformGraph)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1TransformGraph*, int>)@this->LpVtbl[5])(@this, transformGraph);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGraph(this ComPtr<ID2D1EffectImpl> thisVtbl, ref ID2D1TransformGraph transformGraph)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformGraph* transformGraphPtr = &transformGraph)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1TransformGraph*, int>)@this->LpVtbl[5])(@this, transformGraphPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1EffectImpl> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectImpl> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectImpl> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0, TI1>(this ComPtr<ID2D1EffectImpl> thisVtbl, ComPtr<TI0> effectContext, ComPtr<TI1> transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1EffectContext>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformGraph>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((ID2D1EffectContext*) effectContext.Handle, (ID2D1TransformGraph*) transformGraph.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, ID2D1EffectContext* effectContext, Span<ID2D1TransformGraph> transformGraph)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(effectContext, ref transformGraph.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<ID2D1EffectImpl> thisVtbl, ComPtr<TI0> effectContext, ref ID2D1TransformGraph transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1EffectContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((ID2D1EffectContext*) effectContext.Handle, ref transformGraph);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, Span<ID2D1EffectContext> effectContext, ID2D1TransformGraph* transformGraph)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref effectContext.GetPinnableReference(), transformGraph);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<ID2D1EffectImpl> thisVtbl, ref ID2D1EffectContext effectContext, ComPtr<TI0> transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1TransformGraph>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref effectContext, (ID2D1TransformGraph*) transformGraph.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<ID2D1EffectImpl> thisVtbl, Span<ID2D1EffectContext> effectContext, Span<ID2D1TransformGraph> transformGraph)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref effectContext.GetPinnableReference(), ref transformGraph.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetGraph<TI0>(this ComPtr<ID2D1EffectImpl> thisVtbl, ComPtr<TI0> transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1TransformGraph>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetGraph((ID2D1TransformGraph*) transformGraph.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetGraph(this ComPtr<ID2D1EffectImpl> thisVtbl, Span<ID2D1TransformGraph> transformGraph)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetGraph(ref transformGraph.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1EffectImpl> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
