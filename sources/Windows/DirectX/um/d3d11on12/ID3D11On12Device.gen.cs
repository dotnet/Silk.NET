// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11On12Device.xml' path='doc/member[@name="ID3D11On12Device"]/*'/>
[Guid("85611E73-70A9-490E-9614-A9E302777904")]
[NativeTypeName("struct ID3D11On12Device : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11On12Device : ID3D11On12Device.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11On12Device*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11On12Device*, uint> )(lpVtbl[1]))((ID3D11On12Device*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11On12Device*, uint> )(lpVtbl[2]))((ID3D11On12Device*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11On12Device.xml' path='doc/member[@name="ID3D11On12Device.CreateWrappedResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateWrappedResource(IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, void** ppResource11)
    {
        return ((delegate* unmanaged<ID3D11On12Device*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int> )(lpVtbl[3]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
    }

    /// <include file='ID3D11On12Device.xml' path='doc/member[@name="ID3D11On12Device.ReleaseWrappedResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, uint NumResources)
    {
        ((delegate* unmanaged<ID3D11On12Device*, ID3D11Resource**, uint, void> )(lpVtbl[4]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
    }

    /// <include file='ID3D11On12Device.xml' path='doc/member[@name="ID3D11On12Device.AcquireWrappedResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, uint NumResources)
    {
        ((delegate* unmanaged<ID3D11On12Device*, ID3D11Resource**, uint, void> )(lpVtbl[5]))((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateWrappedResource(IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, void** ppResource11);
        [VtblIndex(4)]
        void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, uint NumResources);
        [VtblIndex(5)]
        void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, uint NumResources);
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
        [NativeTypeName("HRESULT (IUnknown *, const D3D11_RESOURCE_FLAGS *, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int> CreateWrappedResource;
        [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource**, uint, void> ReleaseWrappedResources;
        [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource**, uint, void> AcquireWrappedResources;
    }
}