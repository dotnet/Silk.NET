// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1"]/*' />
[Guid("A9B71770-D099-4A65-A698-3DEE10020F88")]
[NativeTypeName("struct ID3D12DebugDevice1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugDevice1 : ID3D12DebugDevice1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DebugDevice1*, uint>)(lpVtbl[1]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DebugDevice1*, uint>)(lpVtbl[2]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.SetDebugParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, uint DataSize)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice1*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[3]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
    }

    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.GetDebugParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, uint DataSize)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice1*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[4]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
    }

    /// <include file='ID3D12DebugDevice1.xml' path='doc/member[@name="ID3D12DebugDevice1.ReportLiveDeviceObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice1*, D3D12_RLDO_FLAGS, int>)(lpVtbl[5]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, uint DataSize);

        [VtblIndex(4)]
        HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, uint DataSize);

        [VtblIndex(5)]
        HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
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

        [NativeTypeName("HRESULT (D3D12_DEBUG_DEVICE_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int> SetDebugParameter;

        [NativeTypeName("HRESULT (D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int> GetDebugParameter;

        [NativeTypeName("HRESULT (D3D12_RLDO_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RLDO_FLAGS, int> ReportLiveDeviceObjects;
    }
}
