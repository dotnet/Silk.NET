// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("BC66D368-7373-4943-8757-FC87DC79E476")]
[NativeTypeName("struct ID3D12VirtualizationGuestDevice : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct ID3D12VirtualizationGuestDevice
    : ID3D12VirtualizationGuestDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VirtualizationGuestDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12VirtualizationGuestDevice, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VirtualizationGuestDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShareWithHost(ID3D12DeviceChild pObject, HANDLE* pHandle)
    {
        return (
            (delegate* unmanaged<ID3D12VirtualizationGuestDevice, ID3D12DeviceChild, HANDLE*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pObject, pHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateFenceFd(
        ID3D12Fence pFence,
        [NativeTypeName("UINT64")] ulong FenceValue,
        int* pFenceFd
    )
    {
        return (
            (delegate* unmanaged<ID3D12VirtualizationGuestDevice, ID3D12Fence, ulong, int*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pFence, FenceValue, pFenceFd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShareWithHost(ID3D12DeviceChild pObject, HANDLE* pHandle);

        [VtblIndex(4)]
        HRESULT CreateFenceFd(
            ID3D12Fence pFence,
            [NativeTypeName("UINT64")] ulong FenceValue,
            int* pFenceFd
        );
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
        public delegate* unmanaged<TSelf*, ID3D12DeviceChild, HANDLE*, int> ShareWithHost;

        [NativeTypeName("HRESULT (ID3D12Fence *, UINT64, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence, ulong, int*, int> CreateFenceFd;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VirtualizationGuestDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VirtualizationGuestDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12VirtualizationGuestDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12VirtualizationGuestDevice(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12VirtualizationGuestDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VirtualizationGuestDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VirtualizationGuestDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12VirtualizationGuestDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
