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

[Guid("BE36EC3B-EA85-4AEB-A45A-E9D76404A495")]
[NativeTypeName("struct ID3D12Resource2 : ID3D12Resource1")]
[NativeInheritance("ID3D12Resource1")]
public unsafe partial struct ID3D12Resource2 : ID3D12Resource2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Resource2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Resource2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12Resource2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Resource2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Resource2, Guid*, uint*, void*, int>)((*lpVtbl)[3]))(
            this,
            guid,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Resource2, Guid*, uint, void*, int>)((*lpVtbl)[4]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D12Resource2, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12Resource2, ushort*, int>)((*lpVtbl)[6]))(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12Resource2, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppvDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Map(
        uint Subresource,
        [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange,
        void** ppData
    )
    {
        return (
            (delegate* unmanaged<ID3D12Resource2, uint, D3D12_RANGE*, void**, int>)((*lpVtbl)[8])
        )(this, Subresource, pReadRange, ppData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Unmap(
        uint Subresource,
        [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange
    )
    {
        ((delegate* unmanaged<ID3D12Resource2, uint, D3D12_RANGE*, void>)((*lpVtbl)[9]))(
            this,
            Subresource,
            pWrittenRange
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_RESOURCE_DESC GetDesc()
    {
        D3D12_RESOURCE_DESC result;
        return *(
            (delegate* unmanaged<ID3D12Resource2, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_DESC*>)(
                (*lpVtbl)[10]
            )
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong GetGPUVirtualAddress()
    {
        return ((delegate* unmanaged<ID3D12Resource2, ulong>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteToSubresource(
        uint DstSubresource,
        [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox,
        [NativeTypeName("const void *")] void* pSrcData,
        uint SrcRowPitch,
        uint SrcDepthPitch
    )
    {
        return (
            (delegate* unmanaged<ID3D12Resource2, uint, D3D12_BOX*, void*, uint, uint, int>)(
                (*lpVtbl)[12]
            )
        )(this, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadFromSubresource(
        void* pDstData,
        uint DstRowPitch,
        uint DstDepthPitch,
        uint SrcSubresource,
        [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox
    )
    {
        return (
            (delegate* unmanaged<ID3D12Resource2, void*, uint, uint, uint, D3D12_BOX*, int>)(
                (*lpVtbl)[13]
            )
        )(this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetHeapProperties(
        D3D12_HEAP_PROPERTIES* pHeapProperties,
        D3D12_HEAP_FLAGS* pHeapFlags
    )
    {
        return (
            (delegate* unmanaged<ID3D12Resource2, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS*, int>)(
                (*lpVtbl)[14]
            )
        )(this, pHeapProperties, pHeapFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetProtectedResourceSession(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppProtectedSession
    )
    {
        return ((delegate* unmanaged<ID3D12Resource2, Guid*, void**, int>)((*lpVtbl)[15]))(
            this,
            riid,
            ppProtectedSession
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public D3D12_RESOURCE_DESC1 GetDesc1()
    {
        D3D12_RESOURCE_DESC1 result;
        return *(
            (delegate* unmanaged<ID3D12Resource2, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_DESC1*>)(
                (*lpVtbl)[16]
            )
        )(this, &result);
    }

    public interface Interface : ID3D12Resource1.Interface
    {
        [VtblIndex(16)]
        D3D12_RESOURCE_DESC1 GetDesc1();
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

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("HRESULT (UINT, const D3D12_RANGE *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RANGE*, void**, int> Map;

        [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RANGE*, void> Unmap;

        [NativeTypeName("D3D12_RESOURCE_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_DESC*> GetDesc;

        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetGPUVirtualAddress;

        [NativeTypeName(
            "HRESULT (UINT, const D3D12_BOX *, const void *, UINT, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_BOX*,
            void*,
            uint,
            uint,
            int> WriteToSubresource;

        [NativeTypeName(
            "HRESULT (void *, UINT, UINT, UINT, const D3D12_BOX *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            uint,
            uint,
            D3D12_BOX*,
            int> ReadFromSubresource;

        [NativeTypeName(
            "HRESULT (D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_HEAP_PROPERTIES*,
            D3D12_HEAP_FLAGS*,
            int> GetHeapProperties;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetProtectedResourceSession;

        [NativeTypeName("D3D12_RESOURCE_DESC1 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_DESC1*> GetDesc1;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Resource2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Resource2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Resource1"/> to <see cref = "ID3D12Resource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Resource1"/> instance to be converted </param>
    public static explicit operator ID3D12Resource2(Silk.NET.DirectX.ID3D12Resource1 value)
    {
        return new ID3D12Resource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Resource2"/> to <see cref = "Silk.NET.DirectX.ID3D12Resource1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Resource1(ID3D12Resource2 value)
    {
        return new Silk.NET.DirectX.ID3D12Resource1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Resource"/> to <see cref = "ID3D12Resource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Resource"/> instance to be converted </param>
    public static explicit operator ID3D12Resource2(Silk.NET.DirectX.ID3D12Resource value)
    {
        return new ID3D12Resource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Resource2"/> to <see cref = "Silk.NET.DirectX.ID3D12Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Resource(ID3D12Resource2 value)
    {
        return new Silk.NET.DirectX.ID3D12Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> to <see cref = "ID3D12Resource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> instance to be converted </param>
    public static explicit operator ID3D12Resource2(Silk.NET.DirectX.ID3D12Pageable value)
    {
        return new ID3D12Resource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Resource2"/> to <see cref = "Silk.NET.DirectX.ID3D12Pageable"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Pageable(ID3D12Resource2 value)
    {
        return new Silk.NET.DirectX.ID3D12Pageable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12Resource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12Resource2(Silk.NET.DirectX.ID3D12DeviceChild value)
    {
        return new ID3D12Resource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Resource2"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(ID3D12Resource2 value)
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12Resource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12Resource2(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12Resource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Resource2"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12Resource2 value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12Resource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12Resource2(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12Resource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Resource2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12Resource2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
