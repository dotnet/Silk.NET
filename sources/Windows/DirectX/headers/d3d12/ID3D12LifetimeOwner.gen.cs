// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12LifetimeOwner.xml' path='doc/member[@name="ID3D12LifetimeOwner"]/*'/>
[Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
[NativeTypeName("struct ID3D12LifetimeOwner : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12LifetimeOwner : ID3D12LifetimeOwner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12LifetimeOwner));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12LifetimeOwner*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12LifetimeOwner*, uint> )(lpVtbl[1]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12LifetimeOwner*, uint> )(lpVtbl[2]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12LifetimeOwner.xml' path='doc/member[@name="ID3D12LifetimeOwner.LifetimeStateUpdated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState)
    {
        ((delegate* unmanaged<ID3D12LifetimeOwner*, D3D12_LIFETIME_STATE, void> )(lpVtbl[3]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), NewState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState);
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
        [NativeTypeName("void (D3D12_LIFETIME_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_LIFETIME_STATE, void> LifetimeStateUpdated;
    }
}