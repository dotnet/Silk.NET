// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1"]/*'/>
[Guid("16BE35A2-BFD6-49F2-BCAE-EAAE4AFF862D")]
[NativeTypeName("struct ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue")]
[NativeInheritance("ID3D12DebugCommandQueue")]
public unsafe partial struct ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandQueue1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12DebugCommandQueue1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue1*, uint> )(lpVtbl[1]))((ID3D12DebugCommandQueue1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue1*, uint> )(lpVtbl[2]))((ID3D12DebugCommandQueue1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12DebugCommandQueue.AssertResourceState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, uint, int> )(lpVtbl[3]))((ID3D12DebugCommandQueue1*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
    }

    /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1.AssertResourceAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void AssertResourceAccess(ID3D12Resource* pResource, uint Subresource, D3D12_BARRIER_ACCESS Access)
    {
        ((delegate* unmanaged<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, D3D12_BARRIER_ACCESS, void> )(lpVtbl[4]))((ID3D12DebugCommandQueue1*)Unsafe.AsPointer(ref this), pResource, Subresource, Access);
    }

    /// <include file='ID3D12DebugCommandQueue1.xml' path='doc/member[@name="ID3D12DebugCommandQueue1.AssertTextureLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void AssertTextureLayout(ID3D12Resource* pResource, uint Subresource, D3D12_BARRIER_LAYOUT Layout)
    {
        ((delegate* unmanaged<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, D3D12_BARRIER_LAYOUT, void> )(lpVtbl[5]))((ID3D12DebugCommandQueue1*)Unsafe.AsPointer(ref this), pResource, Subresource, Layout);
    }

    public interface Interface : ID3D12DebugCommandQueue.Interface
    {
        [VtblIndex(4)]
        void AssertResourceAccess(ID3D12Resource* pResource, uint Subresource, D3D12_BARRIER_ACCESS Access);
        [VtblIndex(5)]
        void AssertTextureLayout(ID3D12Resource* pResource, uint Subresource, D3D12_BARRIER_LAYOUT Layout);
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
        [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint, uint, int> AssertResourceState;
        [NativeTypeName("void (ID3D12Resource *, UINT, D3D12_BARRIER_ACCESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint, D3D12_BARRIER_ACCESS, void> AssertResourceAccess;
        [NativeTypeName("void (ID3D12Resource *, UINT, D3D12_BARRIER_LAYOUT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint, D3D12_BARRIER_LAYOUT, void> AssertTextureLayout;
    }
}