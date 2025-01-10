// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A6BBA433-176B-48B2-B375-53AA03473207")]
[NativeTypeName("struct IMFCaptureEngine : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFCaptureEngine : IMFCaptureEngine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureEngine));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureEngine, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFCaptureEngine, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureEngine, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        IMFCaptureEngineOnEventCallback pEventCallback,
        IMFAttributes pAttributes,
        IUnknown pAudioSource,
        IUnknown pVideoSource
    )
    {
        return (
            (delegate* unmanaged<
                IMFCaptureEngine,
                IMFCaptureEngineOnEventCallback,
                IMFAttributes,
                IUnknown,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(this, pEventCallback, pAttributes, pAudioSource, pVideoSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT StartPreview()
    {
        return ((delegate* unmanaged<IMFCaptureEngine, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT StopPreview()
    {
        return ((delegate* unmanaged<IMFCaptureEngine, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartRecord()
    {
        return ((delegate* unmanaged<IMFCaptureEngine, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StopRecord(BOOL bFinalize, BOOL bFlushUnprocessedSamples)
    {
        return ((delegate* unmanaged<IMFCaptureEngine, BOOL, BOOL, int>)((*lpVtbl)[7]))(
            this,
            bFinalize,
            bFlushUnprocessedSamples
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TakePhoto()
    {
        return ((delegate* unmanaged<IMFCaptureEngine, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSink(
        MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType,
        IMFCaptureSink* ppSink
    )
    {
        return (
            (delegate* unmanaged<
                IMFCaptureEngine,
                MF_CAPTURE_ENGINE_SINK_TYPE,
                IMFCaptureSink*,
                int>)((*lpVtbl)[9])
        )(this, mfCaptureEngineSinkType, ppSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSource(IMFCaptureSource* ppSource)
    {
        return ((delegate* unmanaged<IMFCaptureEngine, IMFCaptureSource*, int>)((*lpVtbl)[10]))(
            this,
            ppSource
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            IMFCaptureEngineOnEventCallback pEventCallback,
            IMFAttributes pAttributes,
            IUnknown pAudioSource,
            IUnknown pVideoSource
        );

        [VtblIndex(4)]
        HRESULT StartPreview();

        [VtblIndex(5)]
        HRESULT StopPreview();

        [VtblIndex(6)]
        HRESULT StartRecord();

        [VtblIndex(7)]
        HRESULT StopRecord(BOOL bFinalize, BOOL bFlushUnprocessedSamples);

        [VtblIndex(8)]
        HRESULT TakePhoto();

        [VtblIndex(9)]
        HRESULT GetSink(
            MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType,
            IMFCaptureSink* ppSink
        );

        [VtblIndex(10)]
        HRESULT GetSource(IMFCaptureSource* ppSource);
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

        [NativeTypeName(
            "HRESULT (IMFCaptureEngineOnEventCallback *, IMFAttributes *, IUnknown *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFCaptureEngineOnEventCallback,
            IMFAttributes,
            IUnknown,
            IUnknown,
            int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StartPreview;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopPreview;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StartRecord;

        [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, BOOL, int> StopRecord;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TakePhoto;

        [NativeTypeName(
            "HRESULT (MF_CAPTURE_ENGINE_SINK_TYPE, IMFCaptureSink **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_CAPTURE_ENGINE_SINK_TYPE,
            IMFCaptureSink*,
            int> GetSink;

        [NativeTypeName("HRESULT (IMFCaptureSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCaptureSource*, int> GetSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCaptureEngine"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCaptureEngine(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCaptureEngine"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCaptureEngine(Silk.NET.Windows.IUnknown value)
    {
        return new IMFCaptureEngine(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCaptureEngine"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCaptureEngine"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFCaptureEngine value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
