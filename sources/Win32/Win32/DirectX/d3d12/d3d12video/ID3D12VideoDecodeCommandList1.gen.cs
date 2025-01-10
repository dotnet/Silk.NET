// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("D52F011B-B56E-453C-A05A-A7F311C8F472")]
[NativeTypeName("struct ID3D12VideoDecodeCommandList1 : ID3D12VideoDecodeCommandList")]
[NativeInheritance("ID3D12VideoDecodeCommandList")]
public unsafe partial struct ID3D12VideoDecodeCommandList1
    : ID3D12VideoDecodeCommandList1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDecodeCommandList1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList1, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, Guid*, uint*, void*, int>)(
                (*lpVtbl)[3]
            )
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
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, Guid*, uint, void*, int>)(
                (*lpVtbl)[4]
            )
        )(this, guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, Guid*, IUnknown, int>)((*lpVtbl)[5])
        )(this, guid, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList1, ushort*, int>)((*lpVtbl)[6]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, Guid*, void**, int>)((*lpVtbl)[7])
        )(this, riid, ppvDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public new D3D12_COMMAND_LIST_TYPE GetType()
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, D3D12_COMMAND_LIST_TYPE>)(
                (*lpVtbl)[8]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList1, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reset(ID3D12CommandAllocator pAllocator)
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, ID3D12CommandAllocator, int>)(
                (*lpVtbl)[10]
            )
        )(this, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState()
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList1, void>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ResourceBarrier(
        uint NumBarriers,
        [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                uint,
                D3D12_RESOURCE_BARRIER*,
                void>)((*lpVtbl)[12])
        )(this, NumBarriers, pBarriers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DiscardResource(
        ID3D12Resource pResource,
        [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12Resource,
                D3D12_DISCARD_REGION*,
                void>)((*lpVtbl)[13])
        )(this, pResource, pRegion);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12QueryHeap,
                D3D12_QUERY_TYPE,
                uint,
                void>)((*lpVtbl)[14])
        )(this, pQueryHeap, Type, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12QueryHeap,
                D3D12_QUERY_TYPE,
                uint,
                void>)((*lpVtbl)[15])
        )(this, pQueryHeap, Type, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void ResolveQueryData(
        ID3D12QueryHeap pQueryHeap,
        D3D12_QUERY_TYPE Type,
        uint StartIndex,
        uint NumQueries,
        ID3D12Resource pDestinationBuffer,
        [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12QueryHeap,
                D3D12_QUERY_TYPE,
                uint,
                uint,
                ID3D12Resource,
                ulong,
                void>)((*lpVtbl)[16])
        )(
            this,
            pQueryHeap,
            Type,
            StartIndex,
            NumQueries,
            pDestinationBuffer,
            AlignedDestinationBufferOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void SetPredication(
        ID3D12Resource pBuffer,
        [NativeTypeName("UINT64")] ulong AlignedBufferOffset,
        D3D12_PREDICATION_OP Operation
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12Resource,
                ulong,
                D3D12_PREDICATION_OP,
                void>)((*lpVtbl)[17])
        )(this, pBuffer, AlignedBufferOffset, Operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, uint, void*, uint, void>)(
                (*lpVtbl)[18]
            )
        )(this, Metadata, pData, Size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        (
            (delegate* unmanaged<ID3D12VideoDecodeCommandList1, uint, void*, uint, void>)(
                (*lpVtbl)[19]
            )
        )(this, Metadata, pData, Size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void EndEvent()
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList1, void>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void DecodeFrame(
        ID3D12VideoDecoder pDecoder,
        [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")]
            D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS* pOutputArguments,
        [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")]
            D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12VideoDecoder,
                D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS*,
                D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*,
                void>)((*lpVtbl)[21])
        )(this, pDecoder, pOutputArguments, pInputArguments);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void WriteBufferImmediate(
        uint Count,
        [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")]
            D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams,
        [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")]
            D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                uint,
                D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*,
                D3D12_WRITEBUFFERIMMEDIATE_MODE*,
                void>)((*lpVtbl)[22])
        )(this, Count, pParams, pModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void DecodeFrame1(
        ID3D12VideoDecoder pDecoder,
        [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1 *")]
            D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1* pOutputArguments,
        [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")]
            D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments
    )
    {
        (
            (delegate* unmanaged<
                ID3D12VideoDecodeCommandList1,
                ID3D12VideoDecoder,
                D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1*,
                D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*,
                void>)((*lpVtbl)[23])
        )(this, pDecoder, pOutputArguments, pInputArguments);
    }

    public interface Interface : ID3D12VideoDecodeCommandList.Interface
    {
        [VtblIndex(23)]
        void DecodeFrame1(
            ID3D12VideoDecoder pDecoder,
            [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1 *")]
                D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1* pOutputArguments,
            [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")]
                D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments
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

        [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D12_COMMAND_LIST_TYPE> GetType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;

        [NativeTypeName("HRESULT (ID3D12CommandAllocator *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12CommandAllocator, int> Reset;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearState;

        [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_DISCARD_REGION*,
            void> DiscardResource;

        [NativeTypeName(
            "void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12QueryHeap,
            D3D12_QUERY_TYPE,
            uint,
            void> BeginQuery;

        [NativeTypeName(
            "void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap, D3D12_QUERY_TYPE, uint, void> EndQuery;

        [NativeTypeName(
            "void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12QueryHeap,
            D3D12_QUERY_TYPE,
            uint,
            uint,
            ID3D12Resource,
            ulong,
            void> ResolveQueryData;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ulong,
            D3D12_PREDICATION_OP,
            void> SetPredication;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndEvent;

        [NativeTypeName(
            "void (ID3D12VideoDecoder *, const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *, const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12VideoDecoder,
            D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS*,
            D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*,
            void> DecodeFrame;

        [NativeTypeName(
            "void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*,
            D3D12_WRITEBUFFERIMMEDIATE_MODE*,
            void> WriteBufferImmediate;

        [NativeTypeName(
            "void (ID3D12VideoDecoder *, const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1 *, const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12VideoDecoder,
            D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1*,
            D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*,
            void> DecodeFrame1;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDecodeCommandList1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDecodeCommandList1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12VideoDecodeCommandList"/> to <see cref = "ID3D12VideoDecodeCommandList1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12VideoDecodeCommandList"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList1(
        Silk.NET.DirectX.ID3D12VideoDecodeCommandList value
    )
    {
        return new ID3D12VideoDecodeCommandList1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecodeCommandList1"/> to <see cref = "Silk.NET.DirectX.ID3D12VideoDecodeCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12VideoDecodeCommandList(
        ID3D12VideoDecodeCommandList1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12VideoDecodeCommandList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12CommandList"/> to <see cref = "ID3D12VideoDecodeCommandList1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12CommandList"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList1(
        Silk.NET.DirectX.ID3D12CommandList value
    )
    {
        return new ID3D12VideoDecodeCommandList1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecodeCommandList1"/> to <see cref = "Silk.NET.DirectX.ID3D12CommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12CommandList(
        ID3D12VideoDecodeCommandList1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12CommandList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12VideoDecodeCommandList1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList1(
        Silk.NET.DirectX.ID3D12DeviceChild value
    )
    {
        return new ID3D12VideoDecodeCommandList1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecodeCommandList1"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(
        ID3D12VideoDecodeCommandList1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12VideoDecodeCommandList1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList1(
        Silk.NET.DirectX.ID3D12Object value
    )
    {
        return new ID3D12VideoDecodeCommandList1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecodeCommandList1"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(
        ID3D12VideoDecodeCommandList1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12VideoDecodeCommandList1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12VideoDecodeCommandList1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecodeCommandList1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12VideoDecodeCommandList1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
