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

[Guid("C64226A8-9201-46AF-B4CC-53FB9FF7414F")]
[NativeTypeName("struct ID3D12PipelineLibrary : ID3D12DeviceChild")]
[NativeInheritance("ID3D12DeviceChild")]
public unsafe partial struct ID3D12PipelineLibrary : ID3D12PipelineLibrary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12PipelineLibrary));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12PipelineLibrary, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12PipelineLibrary, Guid*, uint*, void*, int>)((*lpVtbl)[3])
        )(this, guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12PipelineLibrary, Guid*, uint, void*, int>)((*lpVtbl)[4])
        )(this, guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, ushort*, int>)((*lpVtbl)[6]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppvDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StorePipeline(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        ID3D12PipelineState pPipeline
    )
    {
        return (
            (delegate* unmanaged<ID3D12PipelineLibrary, ushort*, ID3D12PipelineState, int>)(
                (*lpVtbl)[8]
            )
        )(this, pName, pPipeline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LoadGraphicsPipeline(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")]
            D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppPipelineState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12PipelineLibrary,
                ushort*,
                D3D12_GRAPHICS_PIPELINE_STATE_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[9])
        )(this, pName, pDesc, riid, ppPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LoadComputePipeline(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")]
            D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppPipelineState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12PipelineLibrary,
                ushort*,
                D3D12_COMPUTE_PIPELINE_STATE_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[10])
        )(this, pName, pDesc, riid, ppPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSerializedSize()
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, nuint>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary, void*, nuint, int>)((*lpVtbl)[12]))(
            this,
            pData,
            DataSizeInBytes
        );
    }

    public interface Interface : ID3D12DeviceChild.Interface
    {
        [VtblIndex(8)]
        HRESULT StorePipeline(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            ID3D12PipelineState pPipeline
        );

        [VtblIndex(9)]
        HRESULT LoadGraphicsPipeline(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")]
                D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppPipelineState
        );

        [VtblIndex(10)]
        HRESULT LoadComputePipeline(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")]
                D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppPipelineState
        );

        [VtblIndex(11)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetSerializedSize();

        [VtblIndex(12)]
        HRESULT Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes);
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

        [NativeTypeName("HRESULT (LPCWSTR, ID3D12PipelineState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ID3D12PipelineState, int> StorePipeline;

        [NativeTypeName(
            "HRESULT (LPCWSTR, const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            D3D12_GRAPHICS_PIPELINE_STATE_DESC*,
            Guid*,
            void**,
            int> LoadGraphicsPipeline;

        [NativeTypeName(
            "HRESULT (LPCWSTR, const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            D3D12_COMPUTE_PIPELINE_STATE_DESC*,
            Guid*,
            void**,
            int> LoadComputePipeline;

        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetSerializedSize;

        [NativeTypeName("HRESULT (void *, SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, int> Serialize;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12PipelineLibrary"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12PipelineLibrary(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(Silk.NET.DirectX.ID3D12DeviceChild value)
    {
        return new ID3D12PipelineLibrary(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(ID3D12PipelineLibrary value)
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12PipelineLibrary(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12PipelineLibrary value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12PipelineLibrary(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12PipelineLibrary value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
