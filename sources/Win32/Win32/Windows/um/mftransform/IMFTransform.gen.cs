// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BF94C121-5B05-4E6F-8000-BA598961414D")]
[NativeTypeName("struct IMFTransform : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTransform : IMFTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamLimits(
        [NativeTypeName("DWORD *")] uint* pdwInputMinimum,
        [NativeTypeName("DWORD *")] uint* pdwInputMaximum,
        [NativeTypeName("DWORD *")] uint* pdwOutputMinimum,
        [NativeTypeName("DWORD *")] uint* pdwOutputMaximum
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint*, uint*, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwInputMinimum,
            pdwInputMaximum,
            pdwOutputMinimum,
            pdwOutputMaximum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStreamCount(
        [NativeTypeName("DWORD *")] uint* pcInputStreams,
        [NativeTypeName("DWORD *")] uint* pcOutputStreams
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint*, uint*, int>)((*lpVtbl)[4]))(
            this,
            pcInputStreams,
            pcOutputStreams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamIDs(
        [NativeTypeName("DWORD")] uint dwInputIDArraySize,
        [NativeTypeName("DWORD *")] uint* pdwInputIDs,
        [NativeTypeName("DWORD")] uint dwOutputIDArraySize,
        [NativeTypeName("DWORD *")] uint* pdwOutputIDs
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, uint*, uint, uint*, int>)((*lpVtbl)[5]))(
            this,
            dwInputIDArraySize,
            pdwInputIDs,
            dwOutputIDArraySize,
            pdwOutputIDs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetInputStreamInfo(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        MFT_INPUT_STREAM_INFO* pStreamInfo
    )
    {
        return (
            (delegate* unmanaged<IMFTransform, uint, MFT_INPUT_STREAM_INFO*, int>)((*lpVtbl)[6])
        )(this, dwInputStreamID, pStreamInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutputStreamInfo(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        MFT_OUTPUT_STREAM_INFO* pStreamInfo
    )
    {
        return (
            (delegate* unmanaged<IMFTransform, uint, MFT_OUTPUT_STREAM_INFO*, int>)((*lpVtbl)[7])
        )(this, dwOutputStreamID, pStreamInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAttributes(IMFAttributes* pAttributes)
    {
        return ((delegate* unmanaged<IMFTransform, IMFAttributes*, int>)((*lpVtbl)[8]))(
            this,
            pAttributes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInputStreamAttributes(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        IMFAttributes* pAttributes
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFAttributes*, int>)((*lpVtbl)[9]))(
            this,
            dwInputStreamID,
            pAttributes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOutputStreamAttributes(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        IMFAttributes* pAttributes
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFAttributes*, int>)((*lpVtbl)[10]))(
            this,
            dwOutputStreamID,
            pAttributes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteInputStream([NativeTypeName("DWORD")] uint dwStreamID)
    {
        return ((delegate* unmanaged<IMFTransform, uint, int>)((*lpVtbl)[11]))(this, dwStreamID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddInputStreams(
        [NativeTypeName("DWORD")] uint cStreams,
        [NativeTypeName("DWORD *")] uint* adwStreamIDs
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, uint*, int>)((*lpVtbl)[12]))(
            this,
            cStreams,
            adwStreamIDs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInputAvailableType(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        [NativeTypeName("DWORD")] uint dwTypeIndex,
        IMFMediaType* ppType
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, uint, IMFMediaType*, int>)((*lpVtbl)[13]))(
            this,
            dwInputStreamID,
            dwTypeIndex,
            ppType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetOutputAvailableType(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        [NativeTypeName("DWORD")] uint dwTypeIndex,
        IMFMediaType* ppType
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, uint, IMFMediaType*, int>)((*lpVtbl)[14]))(
            this,
            dwOutputStreamID,
            dwTypeIndex,
            ppType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetInputType(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        IMFMediaType pType,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFMediaType, uint, int>)((*lpVtbl)[15]))(
            this,
            dwInputStreamID,
            pType,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetOutputType(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        IMFMediaType pType,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFMediaType, uint, int>)((*lpVtbl)[16]))(
            this,
            dwOutputStreamID,
            pType,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetInputCurrentType(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        IMFMediaType* ppType
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFMediaType*, int>)((*lpVtbl)[17]))(
            this,
            dwInputStreamID,
            ppType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetOutputCurrentType(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        IMFMediaType* ppType
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFMediaType*, int>)((*lpVtbl)[18]))(
            this,
            dwOutputStreamID,
            ppType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetInputStatus(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, uint*, int>)((*lpVtbl)[19]))(
            this,
            dwInputStreamID,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetOutputStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IMFTransform, uint*, int>)((*lpVtbl)[20]))(this, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetOutputBounds(
        [NativeTypeName("LONGLONG")] long hnsLowerBound,
        [NativeTypeName("LONGLONG")] long hnsUpperBound
    )
    {
        return ((delegate* unmanaged<IMFTransform, long, long, int>)((*lpVtbl)[21]))(
            this,
            hnsLowerBound,
            hnsUpperBound
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ProcessEvent(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        IMFMediaEvent pEvent
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFMediaEvent, int>)((*lpVtbl)[22]))(
            this,
            dwInputStreamID,
            pEvent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ProcessMessage(
        MFT_MESSAGE_TYPE eMessage,
        [NativeTypeName("ULONG_PTR")] nuint ulParam
    )
    {
        return ((delegate* unmanaged<IMFTransform, MFT_MESSAGE_TYPE, nuint, int>)((*lpVtbl)[23]))(
            this,
            eMessage,
            ulParam
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ProcessInput(
        [NativeTypeName("DWORD")] uint dwInputStreamID,
        IMFSample pSample,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IMFTransform, uint, IMFSample, uint, int>)((*lpVtbl)[24]))(
            this,
            dwInputStreamID,
            pSample,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ProcessOutput(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint cOutputBufferCount,
        MFT_OUTPUT_DATA_BUFFER* pOutputSamples,
        [NativeTypeName("DWORD *")] uint* pdwStatus
    )
    {
        return (
            (delegate* unmanaged<IMFTransform, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int>)(
                (*lpVtbl)[25]
            )
        )(this, dwFlags, cOutputBufferCount, pOutputSamples, pdwStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamLimits(
            [NativeTypeName("DWORD *")] uint* pdwInputMinimum,
            [NativeTypeName("DWORD *")] uint* pdwInputMaximum,
            [NativeTypeName("DWORD *")] uint* pdwOutputMinimum,
            [NativeTypeName("DWORD *")] uint* pdwOutputMaximum
        );

        [VtblIndex(4)]
        HRESULT GetStreamCount(
            [NativeTypeName("DWORD *")] uint* pcInputStreams,
            [NativeTypeName("DWORD *")] uint* pcOutputStreams
        );

        [VtblIndex(5)]
        HRESULT GetStreamIDs(
            [NativeTypeName("DWORD")] uint dwInputIDArraySize,
            [NativeTypeName("DWORD *")] uint* pdwInputIDs,
            [NativeTypeName("DWORD")] uint dwOutputIDArraySize,
            [NativeTypeName("DWORD *")] uint* pdwOutputIDs
        );

        [VtblIndex(6)]
        HRESULT GetInputStreamInfo(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            MFT_INPUT_STREAM_INFO* pStreamInfo
        );

        [VtblIndex(7)]
        HRESULT GetOutputStreamInfo(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            MFT_OUTPUT_STREAM_INFO* pStreamInfo
        );

        [VtblIndex(8)]
        HRESULT GetAttributes(IMFAttributes* pAttributes);

        [VtblIndex(9)]
        HRESULT GetInputStreamAttributes(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            IMFAttributes* pAttributes
        );

        [VtblIndex(10)]
        HRESULT GetOutputStreamAttributes(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            IMFAttributes* pAttributes
        );

        [VtblIndex(11)]
        HRESULT DeleteInputStream([NativeTypeName("DWORD")] uint dwStreamID);

        [VtblIndex(12)]
        HRESULT AddInputStreams(
            [NativeTypeName("DWORD")] uint cStreams,
            [NativeTypeName("DWORD *")] uint* adwStreamIDs
        );

        [VtblIndex(13)]
        HRESULT GetInputAvailableType(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            [NativeTypeName("DWORD")] uint dwTypeIndex,
            IMFMediaType* ppType
        );

        [VtblIndex(14)]
        HRESULT GetOutputAvailableType(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            [NativeTypeName("DWORD")] uint dwTypeIndex,
            IMFMediaType* ppType
        );

        [VtblIndex(15)]
        HRESULT SetInputType(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            IMFMediaType pType,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(16)]
        HRESULT SetOutputType(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            IMFMediaType pType,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(17)]
        HRESULT GetInputCurrentType(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            IMFMediaType* ppType
        );

        [VtblIndex(18)]
        HRESULT GetOutputCurrentType(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            IMFMediaType* ppType
        );

        [VtblIndex(19)]
        HRESULT GetInputStatus(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            [NativeTypeName("DWORD *")] uint* pdwFlags
        );

        [VtblIndex(20)]
        HRESULT GetOutputStatus([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(21)]
        HRESULT SetOutputBounds(
            [NativeTypeName("LONGLONG")] long hnsLowerBound,
            [NativeTypeName("LONGLONG")] long hnsUpperBound
        );

        [VtblIndex(22)]
        HRESULT ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaEvent pEvent);

        [VtblIndex(23)]
        HRESULT ProcessMessage(
            MFT_MESSAGE_TYPE eMessage,
            [NativeTypeName("ULONG_PTR")] nuint ulParam
        );

        [VtblIndex(24)]
        HRESULT ProcessInput(
            [NativeTypeName("DWORD")] uint dwInputStreamID,
            IMFSample pSample,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(25)]
        HRESULT ProcessOutput(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD")] uint cOutputBufferCount,
            MFT_OUTPUT_DATA_BUFFER* pOutputSamples,
            [NativeTypeName("DWORD *")] uint* pdwStatus
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

        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, uint*, int> GetStreamLimits;

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetStreamCount;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint, uint*, int> GetStreamIDs;

        [NativeTypeName("HRESULT (DWORD, MFT_INPUT_STREAM_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MFT_INPUT_STREAM_INFO*, int> GetInputStreamInfo;

        [NativeTypeName("HRESULT (DWORD, MFT_OUTPUT_STREAM_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MFT_OUTPUT_STREAM_INFO*, int> GetOutputStreamInfo;

        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> GetAttributes;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes*, int> GetInputStreamAttributes;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes*, int> GetOutputStreamAttributes;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DeleteInputStream;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> AddInputStreams;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType*, int> GetInputAvailableType;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType*, int> GetOutputAvailableType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType, uint, int> SetInputType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType, uint, int> SetOutputType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> GetInputCurrentType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> GetOutputCurrentType;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetInputStatus;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOutputStatus;

        [NativeTypeName("HRESULT (LONGLONG, LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, long, int> SetOutputBounds;

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent, int> ProcessEvent;

        [NativeTypeName("HRESULT (MFT_MESSAGE_TYPE, ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFT_MESSAGE_TYPE, nuint, int> ProcessMessage;

        [NativeTypeName("HRESULT (DWORD, IMFSample *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSample, uint, int> ProcessInput;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, MFT_OUTPUT_DATA_BUFFER *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            MFT_OUTPUT_DATA_BUFFER*,
            uint*,
            int> ProcessOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
