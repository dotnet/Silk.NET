// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice"]/*' />
[Guid("BC66D368-7373-4943-8757-FC87DC79E476")]
[NativeTypeName("struct ID3D12VirtualizationGuestDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VirtualizationGuestDevice : ID3D12VirtualizationGuestDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VirtualizationGuestDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VirtualizationGuestDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice*, uint>)(lpVtbl[1]))((ID3D12VirtualizationGuestDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice*, uint>)(lpVtbl[2]))((ID3D12VirtualizationGuestDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice.ShareWithHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShareWithHost(ID3D12DeviceChild* pObject, HANDLE* pHandle)
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, HANDLE*, int>)(lpVtbl[3]))((ID3D12VirtualizationGuestDevice*)Unsafe.AsPointer(ref this), pObject, pHandle);
    }

    /// <include file='ID3D12VirtualizationGuestDevice.xml' path='doc/member[@name="ID3D12VirtualizationGuestDevice.CreateFenceFd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateFenceFd(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue, int* pFenceFd)
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)(lpVtbl[4]))((ID3D12VirtualizationGuestDevice*)Unsafe.AsPointer(ref this), pFence, FenceValue, pFenceFd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShareWithHost(ID3D12DeviceChild* pObject, HANDLE* pHandle);

        [VtblIndex(4)]
        HRESULT CreateFenceFd(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue, int* pFenceFd);
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

        [NativeTypeName("HRESULT (ID3D12DeviceChild *, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12DeviceChild*, HANDLE*, int> ShareWithHost;

        [NativeTypeName("HRESULT (ID3D12Fence *, UINT64, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence*, ulong, int*, int> CreateFenceFd;
    }
}
