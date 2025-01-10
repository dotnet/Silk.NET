// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("597985AB-9B75-4DBB-BE23-0761195BEBEE")]
[NativeTypeName("struct ID3D12GBVDiagnostics : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12GBVDiagnostics : ID3D12GBVDiagnostics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12GBVDiagnostics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12GBVDiagnostics, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12GBVDiagnostics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12GBVDiagnostics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGBVEntireSubresourceStatesData(
        ID3D12Resource pResource,
        int* pData,
        uint DataSize
    )
    {
        return (
            (delegate* unmanaged<ID3D12GBVDiagnostics, ID3D12Resource, int*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pResource, pData, DataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, int* pData)
    {
        return (
            (delegate* unmanaged<ID3D12GBVDiagnostics, ID3D12Resource, uint, int*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pResource, Subresource, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetGBVResourceUniformState(ID3D12Resource pResource, int* pData)
    {
        return (
            (delegate* unmanaged<ID3D12GBVDiagnostics, ID3D12Resource, int*, int>)((*lpVtbl)[5])
        )(this, pResource, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGBVResourceInfo(
        ID3D12Resource pResource,
        D3D12_RESOURCE_DESC* pResourceDesc,
        [NativeTypeName("UINT32 *")] uint* pResourceHash,
        [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12GBVDiagnostics,
                ID3D12Resource,
                D3D12_RESOURCE_DESC*,
                uint*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GBVReserved0()
    {
        ((delegate* unmanaged<ID3D12GBVDiagnostics, void>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GBVReserved1()
    {
        ((delegate* unmanaged<ID3D12GBVDiagnostics, void>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGBVEntireSubresourceStatesData(
            ID3D12Resource pResource,
            int* pData,
            uint DataSize
        );

        [VtblIndex(4)]
        HRESULT GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, int* pData);

        [VtblIndex(5)]
        HRESULT GetGBVResourceUniformState(ID3D12Resource pResource, int* pData);

        [VtblIndex(6)]
        HRESULT GetGBVResourceInfo(
            ID3D12Resource pResource,
            D3D12_RESOURCE_DESC* pResourceDesc,
            [NativeTypeName("UINT32 *")] uint* pResourceHash,
            [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset
        );

        [VtblIndex(7)]
        void GBVReserved0();

        [VtblIndex(8)]
        void GBVReserved1();
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

        [NativeTypeName("HRESULT (ID3D12Resource *, int *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            int*,
            uint,
            int> GetGBVEntireSubresourceStatesData;

        [NativeTypeName("HRESULT (ID3D12Resource *, UINT, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource, uint, int*, int> GetGBVSubresourceState;

        [NativeTypeName("HRESULT (ID3D12Resource *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource, int*, int> GetGBVResourceUniformState;

        [NativeTypeName(
            "HRESULT (ID3D12Resource *, D3D12_RESOURCE_DESC *, UINT32 *, UINT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_RESOURCE_DESC*,
            uint*,
            uint*,
            int> GetGBVResourceInfo;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> GBVReserved0;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> GBVReserved1;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12GBVDiagnostics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12GBVDiagnostics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12GBVDiagnostics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12GBVDiagnostics(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12GBVDiagnostics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GBVDiagnostics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12GBVDiagnostics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
