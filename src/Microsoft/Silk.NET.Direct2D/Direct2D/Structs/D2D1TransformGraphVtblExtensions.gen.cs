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
    public static unsafe int QueryInterface(this ComPtr<ID2D1TransformGraph> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1TransformGraph> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1TransformGraph> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int SetSingleTransformNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* nodePtr = &node)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[4])(@this, nodePtr);
        }
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
    public static int AddNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* nodePtr = &node)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[5])(@this, nodePtr);
        }
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
    public static int RemoveNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* nodePtr = &node)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[6])(@this, nodePtr);
        }
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
    public static int SetOutputNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode node)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* nodePtr = &node)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)@this->LpVtbl[7])(@this, nodePtr);
        }
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
    public static unsafe int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* fromNode, ref ID2D1TransformNode toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* toNodePtr = &toNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)@this->LpVtbl[8])(@this, fromNode, toNodePtr, toNodeInputIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode fromNode, ID2D1TransformNode* toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* fromNodePtr = &fromNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)@this->LpVtbl[8])(@this, fromNodePtr, toNode, toNodeInputIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode fromNode, ref ID2D1TransformNode toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* fromNodePtr = &fromNode)
        {
            fixed (ID2D1TransformNode* toNodePtr = &toNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)@this->LpVtbl[8])(@this, fromNodePtr, toNodePtr, toNodeInputIndex);
            }
        }
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
    public static int ConnectToEffectInput(this ComPtr<ID2D1TransformGraph> thisVtbl, uint toEffectInputIndex, ref ID2D1TransformNode node, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode* nodePtr = &node)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int>)@this->LpVtbl[9])(@this, toEffectInputIndex, nodePtr, toNodeInputIndex);
        }
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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSingleTransformNode<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, ComPtr<TI0> node) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetSingleTransformNode((ID2D1TransformNode*) node.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetSingleTransformNode(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<ID2D1TransformNode> node)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSingleTransformNode(ref node.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddNode<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, ComPtr<TI0> node) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddNode((ID2D1TransformNode*) node.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddNode(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<ID2D1TransformNode> node)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddNode(ref node.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RemoveNode<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, ComPtr<TI0> node) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveNode((ID2D1TransformNode*) node.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveNode(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<ID2D1TransformNode> node)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveNode(ref node.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputNode<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, ComPtr<TI0> node) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputNode((ID2D1TransformNode*) node.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputNode(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<ID2D1TransformNode> node)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputNode(ref node.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ConnectNode<TI0, TI1>(this ComPtr<ID2D1TransformGraph> thisVtbl, ComPtr<TI0> fromNode, ComPtr<TI1> toNode, uint toNodeInputIndex) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConnectNode((ID2D1TransformNode*) fromNode.Handle, (ID2D1TransformNode*) toNode.Handle, toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, ID2D1TransformNode* fromNode, Span<ID2D1TransformNode> toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConnectNode(fromNode, ref toNode.GetPinnableReference(), toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static int ConnectNode<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, ComPtr<TI0> fromNode, ref ID2D1TransformNode toNode, uint toNodeInputIndex) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConnectNode((ID2D1TransformNode*) fromNode.Handle, ref toNode, toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<ID2D1TransformNode> fromNode, ID2D1TransformNode* toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConnectNode(ref fromNode.GetPinnableReference(), toNode, toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static int ConnectNode<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, ref ID2D1TransformNode fromNode, ComPtr<TI0> toNode, uint toNodeInputIndex) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConnectNode(ref fromNode, (ID2D1TransformNode*) toNode.Handle, toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static int ConnectNode(this ComPtr<ID2D1TransformGraph> thisVtbl, Span<ID2D1TransformNode> fromNode, Span<ID2D1TransformNode> toNode, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConnectNode(ref fromNode.GetPinnableReference(), ref toNode.GetPinnableReference(), toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static int ConnectToEffectInput<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl, uint toEffectInputIndex, ComPtr<TI0> node, uint toNodeInputIndex) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConnectToEffectInput(toEffectInputIndex, (ID2D1TransformNode*) node.Handle, toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static int ConnectToEffectInput(this ComPtr<ID2D1TransformGraph> thisVtbl, uint toEffectInputIndex, Span<ID2D1TransformNode> node, uint toNodeInputIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConnectToEffectInput(toEffectInputIndex, ref node.GetPinnableReference(), toNodeInputIndex);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1TransformGraph> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
