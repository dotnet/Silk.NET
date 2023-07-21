// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph"]/*' />
[Guid("13D29038-C3E6-4034-9081-13B53A417992")]
[NativeTypeName("struct ID2D1TransformGraph : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1TransformGraph : ID2D1TransformGraph.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1TransformGraph));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, uint>)(lpVtbl[1]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, uint>)(lpVtbl[2]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.GetInputCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, uint>)(lpVtbl[3]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.SetSingleTransformNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSingleTransformNode(ID2D1TransformNode* node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[4]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.AddNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddNode(ID2D1TransformNode* node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[5]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.RemoveNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveNode(ID2D1TransformNode* node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[6]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.SetOutputNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetOutputNode(ID2D1TransformNode* node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[7]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.ConnectNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConnectNode(ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)(lpVtbl[8]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), fromNode, toNode, toNodeInputIndex);
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.ConnectToEffectInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ConnectToEffectInput([NativeTypeName("UINT32")] uint toEffectInputIndex, ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int>)(lpVtbl[9]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), toEffectInputIndex, node, toNodeInputIndex);
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Clear()
    {
        ((delegate* unmanaged<ID2D1TransformGraph*, void>)(lpVtbl[10]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1TransformGraph.xml' path='doc/member[@name="ID2D1TransformGraph.SetPassthroughGraph"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph*, uint, int>)(lpVtbl[11]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), effectInputIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetInputCount();

        [VtblIndex(4)]
        HRESULT SetSingleTransformNode(ID2D1TransformNode* node);

        [VtblIndex(5)]
        HRESULT AddNode(ID2D1TransformNode* node);

        [VtblIndex(6)]
        HRESULT RemoveNode(ID2D1TransformNode* node);

        [VtblIndex(7)]
        HRESULT SetOutputNode(ID2D1TransformNode* node);

        [VtblIndex(8)]
        HRESULT ConnectNode(ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex);

        [VtblIndex(9)]
        HRESULT ConnectToEffectInput([NativeTypeName("UINT32")] uint toEffectInputIndex, ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex);

        [VtblIndex(10)]
        void Clear();

        [VtblIndex(11)]
        HRESULT SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;

        [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode*, int> SetSingleTransformNode;

        [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode*, int> AddNode;

        [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode*, int> RemoveNode;

        [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode*, int> SetOutputNode;

        [NativeTypeName("HRESULT (ID2D1TransformNode *, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int> ConnectNode;

        [NativeTypeName("HRESULT (UINT32, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID2D1TransformNode*, uint, int> ConnectToEffectInput;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Clear;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPassthroughGraph;
    }
}
