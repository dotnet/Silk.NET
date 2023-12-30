// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice"]/*'/>
[Guid("1F052807-0B46-4ACC-8A89-364F793718A4")]
[NativeTypeName("struct ID3D12VideoDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VideoDevice : ID3D12VideoDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDevice));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoDevice*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12VideoDevice*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VideoDevice*, uint>)(lpVtbl[1]))(
            (ID3D12VideoDevice*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoDevice*, uint>)(lpVtbl[2]))(
            (ID3D12VideoDevice*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CheckFeatureSupport"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckFeatureSupport(
        D3D12_FEATURE_VIDEO FeatureVideo,
        void* pFeatureSupportData,
        uint FeatureSupportDataSize
    )
    {
        return (
            (delegate* unmanaged<ID3D12VideoDevice*, D3D12_FEATURE_VIDEO, void*, uint, int>)(
                lpVtbl[3]
            )
        )(
            (ID3D12VideoDevice*)Unsafe.AsPointer(ref this),
            FeatureVideo,
            pFeatureSupportData,
            FeatureSupportDataSize
        );
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoDecoder"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateVideoDecoder(
        [NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoDecoder
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice*,
                D3D12_VIDEO_DECODER_DESC*,
                Guid*,
                void**,
                int>)(lpVtbl[4])
        )((ID3D12VideoDevice*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoDecoderHeap"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateVideoDecoderHeap(
        [NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")]
            D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoDecoderHeap
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice*,
                D3D12_VIDEO_DECODER_HEAP_DESC*,
                Guid*,
                void**,
                int>)(lpVtbl[5])
        )(
            (ID3D12VideoDevice*)Unsafe.AsPointer(ref this),
            pVideoDecoderHeapDesc,
            riid,
            ppVideoDecoderHeap
        );
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoProcessor"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVideoProcessor(
        uint NodeMask,
        [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
            D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc,
        uint NumInputStreamDescs,
        [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
            D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoProcessor
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice*,
                uint,
                D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*,
                uint,
                D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*,
                Guid*,
                void**,
                int>)(lpVtbl[6])
        )(
            (ID3D12VideoDevice*)Unsafe.AsPointer(ref this),
            NodeMask,
            pOutputStreamDesc,
            NumInputStreamDescs,
            pInputStreamDescs,
            riid,
            ppVideoProcessor
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CheckFeatureSupport(
            D3D12_FEATURE_VIDEO FeatureVideo,
            void* pFeatureSupportData,
            uint FeatureSupportDataSize
        );

        [VtblIndex(4)]
        HRESULT CreateVideoDecoder(
            [NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppVideoDecoder
        );

        [VtblIndex(5)]
        HRESULT CreateVideoDecoderHeap(
            [NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")]
                D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppVideoDecoderHeap
        );

        [VtblIndex(6)]
        HRESULT CreateVideoProcessor(
            uint NodeMask,
            [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
                D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc,
            uint NumInputStreamDescs,
            [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
                D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppVideoProcessor
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

        [NativeTypeName("HRESULT (D3D12_FEATURE_VIDEO, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_FEATURE_VIDEO,
            void*,
            uint,
            int> CheckFeatureSupport;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_DECODER_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_DECODER_DESC*,
            Guid*,
            void**,
            int> CreateVideoDecoder;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_DECODER_HEAP_DESC*,
            Guid*,
            void**,
            int> CreateVideoDecoderHeap;

        [NativeTypeName(
            "HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*,
            uint,
            D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*,
            Guid*,
            void**,
            int> CreateVideoProcessor;
    }
}
