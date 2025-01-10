// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("86CA3B85-49AD-4B6E-AED5-EDDB18540F41")]
[NativeTypeName("struct ID3D12ManualWriteTrackingResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ManualWriteTrackingResource
    : ID3D12ManualWriteTrackingResource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ManualWriteTrackingResource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12ManualWriteTrackingResource, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12ManualWriteTrackingResource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12ManualWriteTrackingResource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void TrackWrite(
        uint Subresource,
        [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange
    )
    {
        (
            (delegate* unmanaged<ID3D12ManualWriteTrackingResource, uint, D3D12_RANGE*, void>)(
                (*lpVtbl)[3]
            )
        )(this, Subresource, pWrittenRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void TrackWrite(
            uint Subresource,
            [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange
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

        [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RANGE*, void> TrackWrite;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ManualWriteTrackingResource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ManualWriteTrackingResource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12ManualWriteTrackingResource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12ManualWriteTrackingResource(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ID3D12ManualWriteTrackingResource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12ManualWriteTrackingResource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ManualWriteTrackingResource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ID3D12ManualWriteTrackingResource value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
