// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12Debug6.xml' path='doc/member[@name="ID3D12Debug6"]/*'/>
[Guid("82A816D6-5D01-4157-97D0-4975463FD1ED")]
[NativeTypeName("struct ID3D12Debug6 : ID3D12Debug5")]
[NativeInheritance("ID3D12Debug5")]
public unsafe partial struct ID3D12Debug6 : ID3D12Debug6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug6));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Debug6*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12Debug6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Debug6*, uint> )(lpVtbl[1]))((ID3D12Debug6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Debug6*, uint> )(lpVtbl[2]))((ID3D12Debug6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Debug.EnableDebugLayer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug6*, void> )(lpVtbl[3]))((ID3D12Debug6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Debug3.SetEnableGPUBasedValidation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6*, BOOL, void> )(lpVtbl[4]))((ID3D12Debug6*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <inheritdoc cref = "ID3D12Debug3.SetEnableSynchronizedCommandQueueValidation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6*, BOOL, void> )(lpVtbl[5]))((ID3D12Debug6*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <inheritdoc cref = "ID3D12Debug3.SetGPUBasedValidationFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
    {
        ((delegate* unmanaged<ID3D12Debug6*, D3D12_GPU_BASED_VALIDATION_FLAGS, void> )(lpVtbl[6]))((ID3D12Debug6*)Unsafe.AsPointer(ref this), Flags);
    }

    /// <inheritdoc cref = "ID3D12Debug4.DisableDebugLayer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void DisableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug6*, void> )(lpVtbl[7]))((ID3D12Debug6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Debug5.SetEnableAutoName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetEnableAutoName(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6*, BOOL, void> )(lpVtbl[8]))((ID3D12Debug6*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <include file='ID3D12Debug6.xml' path='doc/member[@name="ID3D12Debug6.SetForceLegacyBarrierValidation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetForceLegacyBarrierValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6*, BOOL, void> )(lpVtbl[9]))((ID3D12Debug6*)Unsafe.AsPointer(ref this), Enable);
    }

    public interface Interface : ID3D12Debug5.Interface
    {
        [VtblIndex(9)]
        void SetForceLegacyBarrierValidation(BOOL Enable);
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
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EnableDebugLayer;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableGPUBasedValidation;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableSynchronizedCommandQueueValidation;
        [NativeTypeName("void (D3D12_GPU_BASED_VALIDATION_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_GPU_BASED_VALIDATION_FLAGS, void> SetGPUBasedValidationFlags;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DisableDebugLayer;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableAutoName;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetForceLegacyBarrierValidation;
    }
}