// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12Debug2.xml' path='doc/member[@name="ID3D12Debug2"]/*'/>
[Guid("93A665C4-A3B2-4E5D-B692-A26AE14E3374")]
[NativeTypeName("struct ID3D12Debug2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Debug2 : ID3D12Debug2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Debug2*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12Debug2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Debug2*, uint> )(lpVtbl[1]))((ID3D12Debug2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Debug2*, uint> )(lpVtbl[2]))((ID3D12Debug2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12Debug2.xml' path='doc/member[@name="ID3D12Debug2.SetGPUBasedValidationFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
    {
        ((delegate* unmanaged<ID3D12Debug2*, D3D12_GPU_BASED_VALIDATION_FLAGS, void> )(lpVtbl[3]))((ID3D12Debug2*)Unsafe.AsPointer(ref this), Flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
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
        [NativeTypeName("void (D3D12_GPU_BASED_VALIDATION_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_GPU_BASED_VALIDATION_FLAGS, void> SetGPUBasedValidationFlags;
    }
}