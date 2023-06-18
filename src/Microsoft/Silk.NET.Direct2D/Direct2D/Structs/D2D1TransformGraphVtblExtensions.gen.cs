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

public unsafe static class D2D1TransformGraphVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1TransformGraph> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1TransformGraph> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1TransformGraph> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1TransformGraph> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSingleTransformNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[4])(@this, node);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[5])(@this, node);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[6])(@this, node);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[7])(@this, node);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)@this->LpVtbl[8])(@this, fromNode, toNode, toNodeInputIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConnectToEffectInput(this ComPtr<ID2D1TransformGraph> thisVtbl, uint toEffectInputIndex, ID2D1TransformNode* node, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int>)@this->LpVtbl[9])(@this, toEffectInputIndex, node, toNodeInputIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void Clear(this ComPtr<ID2D1TransformGraph> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, void>)@this->LpVtbl[10])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int SetPassthroughGraph(this ComPtr<ID2D1TransformGraph> thisVtbl, uint effectInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint, int>)@this->LpVtbl[11])(@this, effectInputIndex);
        return ret;
    }

}
