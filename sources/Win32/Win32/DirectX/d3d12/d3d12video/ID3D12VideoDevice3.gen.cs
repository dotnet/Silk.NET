// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("4243ADB4-3A32-4666-973C-0CCC5625DC44")]
[NativeTypeName("struct ID3D12VideoDevice3 : ID3D12VideoDevice2")]
[NativeInheritance("ID3D12VideoDevice2")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct ID3D12VideoDevice3 : ID3D12VideoDevice3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDevice3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoDevice3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12VideoDevice3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoDevice3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckFeatureSupport(
        D3D12_FEATURE_VIDEO FeatureVideo,
        void* pFeatureSupportData,
        uint FeatureSupportDataSize
    )
    {
        return (
            (delegate* unmanaged<ID3D12VideoDevice3, D3D12_FEATURE_VIDEO, void*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
    }

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
                ID3D12VideoDevice3,
                D3D12_VIDEO_DECODER_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[4])
        )(this, pDesc, riid, ppVideoDecoder);
    }

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
                ID3D12VideoDevice3,
                D3D12_VIDEO_DECODER_HEAP_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[5])
        )(this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
    }

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
                ID3D12VideoDevice3,
                uint,
                D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*,
                uint,
                D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[6])
        )(
            this,
            NodeMask,
            pOutputStreamDesc,
            NumInputStreamDescs,
            pInputStreamDescs,
            riid,
            ppVideoProcessor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateVideoMotionEstimator(
        [NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")]
            D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc,
        ID3D12ProtectedResourceSession pProtectedResourceSession,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoMotionEstimator
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_MOTION_ESTIMATOR_DESC*,
                ID3D12ProtectedResourceSession,
                Guid*,
                void**,
                int>)((*lpVtbl)[7])
        )(this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateVideoMotionVectorHeap(
        [NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")]
            D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc,
        ID3D12ProtectedResourceSession pProtectedResourceSession,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoMotionVectorHeap
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC*,
                ID3D12ProtectedResourceSession,
                Guid*,
                void**,
                int>)((*lpVtbl)[8])
        )(this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVideoDecoder1(
        [NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc,
        ID3D12ProtectedResourceSession pProtectedResourceSession,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoDecoder
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_DECODER_DESC*,
                ID3D12ProtectedResourceSession,
                Guid*,
                void**,
                int>)((*lpVtbl)[9])
        )(this, pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateVideoDecoderHeap1(
        [NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")]
            D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc,
        ID3D12ProtectedResourceSession pProtectedResourceSession,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoDecoderHeap
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_DECODER_HEAP_DESC*,
                ID3D12ProtectedResourceSession,
                Guid*,
                void**,
                int>)((*lpVtbl)[10])
        )(this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateVideoProcessor1(
        uint NodeMask,
        [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
            D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc,
        uint NumInputStreamDescs,
        [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
            D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs,
        ID3D12ProtectedResourceSession pProtectedResourceSession,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoProcessor
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                uint,
                D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*,
                uint,
                D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*,
                ID3D12ProtectedResourceSession,
                Guid*,
                void**,
                int>)((*lpVtbl)[11])
        )(
            this,
            NodeMask,
            pOutputStreamDesc,
            NumInputStreamDescs,
            pInputStreamDescs,
            pProtectedResourceSession,
            riid,
            ppVideoProcessor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateVideoExtensionCommand(
        [NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")]
            D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc,
        [NativeTypeName("const void *")] void* pCreationParameters,
        [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes,
        ID3D12ProtectedResourceSession pProtectedResourceSession,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoExtensionCommand
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_EXTENSION_COMMAND_DESC*,
                void*,
                nuint,
                ID3D12ProtectedResourceSession,
                Guid*,
                void**,
                int>)((*lpVtbl)[12])
        )(
            this,
            pDesc,
            pCreationParameters,
            CreationParametersDataSizeInBytes,
            pProtectedResourceSession,
            riid,
            ppVideoExtensionCommand
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ExecuteExtensionCommand(
        ID3D12VideoExtensionCommand pExtensionCommand,
        [NativeTypeName("const void *")] void* pExecutionParameters,
        [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes,
        void* pOutputData,
        [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                ID3D12VideoExtensionCommand,
                void*,
                nuint,
                void*,
                nuint,
                int>)((*lpVtbl)[13])
        )(
            this,
            pExtensionCommand,
            pExecutionParameters,
            ExecutionParametersSizeInBytes,
            pOutputData,
            OutputDataSizeInBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateVideoEncoder(
        [NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] D3D12_VIDEO_ENCODER_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoEncoder
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_ENCODER_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[14])
        )(this, pDesc, riid, ppVideoEncoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateVideoEncoderHeap(
        [NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")]
            D3D12_VIDEO_ENCODER_HEAP_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppVideoEncoderHeap
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoDevice3,
                D3D12_VIDEO_ENCODER_HEAP_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[15])
        )(this, pDesc, riid, ppVideoEncoderHeap);
    }

    public interface Interface : ID3D12VideoDevice2.Interface
    {
        [VtblIndex(14)]
        HRESULT CreateVideoEncoder(
            [NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] D3D12_VIDEO_ENCODER_DESC* pDesc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppVideoEncoder
        );

        [VtblIndex(15)]
        HRESULT CreateVideoEncoderHeap(
            [NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")]
                D3D12_VIDEO_ENCODER_HEAP_DESC* pDesc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppVideoEncoderHeap
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

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_MOTION_ESTIMATOR_DESC*,
            ID3D12ProtectedResourceSession,
            Guid*,
            void**,
            int> CreateVideoMotionEstimator;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC*,
            ID3D12ProtectedResourceSession,
            Guid*,
            void**,
            int> CreateVideoMotionVectorHeap;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_DECODER_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_DECODER_DESC*,
            ID3D12ProtectedResourceSession,
            Guid*,
            void**,
            int> CreateVideoDecoder1;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_DECODER_HEAP_DESC*,
            ID3D12ProtectedResourceSession,
            Guid*,
            void**,
            int> CreateVideoDecoderHeap1;

        [NativeTypeName(
            "HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*,
            uint,
            D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*,
            ID3D12ProtectedResourceSession,
            Guid*,
            void**,
            int> CreateVideoProcessor1;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_EXTENSION_COMMAND_DESC *, const void *, SIZE_T, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_EXTENSION_COMMAND_DESC*,
            void*,
            nuint,
            ID3D12ProtectedResourceSession,
            Guid*,
            void**,
            int> CreateVideoExtensionCommand;

        [NativeTypeName(
            "HRESULT (ID3D12VideoExtensionCommand *, const void *, SIZE_T, void *, SIZE_T) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12VideoExtensionCommand,
            void*,
            nuint,
            void*,
            nuint,
            int> ExecuteExtensionCommand;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_ENCODER_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_ENCODER_DESC*,
            Guid*,
            void**,
            int> CreateVideoEncoder;

        [NativeTypeName(
            "HRESULT (const D3D12_VIDEO_ENCODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_ENCODER_HEAP_DESC*,
            Guid*,
            void**,
            int> CreateVideoEncoderHeap;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12VideoDevice2"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12VideoDevice2"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(Silk.NET.DirectX.ID3D12VideoDevice2 value)
    {
        return new ID3D12VideoDevice3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDevice3"/> to <see cref = "Silk.NET.DirectX.ID3D12VideoDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12VideoDevice2(ID3D12VideoDevice3 value)
    {
        return new Silk.NET.DirectX.ID3D12VideoDevice2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12VideoDevice1"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12VideoDevice1"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(Silk.NET.DirectX.ID3D12VideoDevice1 value)
    {
        return new ID3D12VideoDevice3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDevice3"/> to <see cref = "Silk.NET.DirectX.ID3D12VideoDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12VideoDevice1(ID3D12VideoDevice3 value)
    {
        return new Silk.NET.DirectX.ID3D12VideoDevice1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12VideoDevice"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12VideoDevice"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(Silk.NET.DirectX.ID3D12VideoDevice value)
    {
        return new ID3D12VideoDevice3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDevice3"/> to <see cref = "Silk.NET.DirectX.ID3D12VideoDevice"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12VideoDevice(ID3D12VideoDevice3 value)
    {
        return new Silk.NET.DirectX.ID3D12VideoDevice(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12VideoDevice3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDevice3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12VideoDevice3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
