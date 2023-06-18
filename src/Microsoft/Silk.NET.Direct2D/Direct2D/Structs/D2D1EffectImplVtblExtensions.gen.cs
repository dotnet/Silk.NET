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

}
