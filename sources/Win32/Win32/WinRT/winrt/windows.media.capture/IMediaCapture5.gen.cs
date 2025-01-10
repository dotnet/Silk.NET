// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DA787C22-3A9B-4720-A71E-97900A316E5A")]
[NativeTypeName("struct IMediaCapture5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture5 : IMediaCapture5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaCapture5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaCapture5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCapture5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaCapture5, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaCapture5, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaCapture5, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveEffectAsync(
        [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension effect,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture5, IMediaExtension, IAsyncAction*, int>)((*lpVtbl)[6])
        )(this, effect, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PauseRecordWithResultAsync(
        [NativeTypeName("ABI::Windows::Media::Devices::MediaCapturePauseBehavior")]
            MediaCapturePauseBehavior behavior,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCapturePauseResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture5,
                MediaCapturePauseBehavior,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, behavior, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StopRecordWithResultAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCaptureStopResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture5, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[8])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FrameSources(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t **"
        )]
            IMapView<HSTRING, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture5, IMapView<HSTRING, IntPtr>**, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFrameReaderAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")]
            IMediaFrameSource inputSource,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture5,
                IMediaFrameSource,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, inputSource, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFrameReaderWithSubtypeAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")]
            IMediaFrameSource inputSource,
        HSTRING outputSubtype,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture5,
                IMediaFrameSource,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, inputSource, outputSubtype, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFrameReaderWithSubtypeAndSizeAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")]
            IMediaFrameSource inputSource,
        HSTRING outputSubtype,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize outputSize,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture5,
                IMediaFrameSource,
                HSTRING,
                BitmapSize,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, inputSource, outputSubtype, outputSize, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RemoveEffectAsync(
            [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension effect,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        HRESULT PauseRecordWithResultAsync(
            [NativeTypeName("ABI::Windows::Media::Devices::MediaCapturePauseBehavior")]
                MediaCapturePauseBehavior behavior,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCapturePauseResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT StopRecordWithResultAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCaptureStopResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT get_FrameSources(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t **"
            )]
                IMapView<HSTRING, IntPtr>** value
        );

        [VtblIndex(10)]
        HRESULT CreateFrameReaderAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")]
                IMediaFrameSource inputSource,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT CreateFrameReaderWithSubtypeAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")]
                IMediaFrameSource inputSource,
            HSTRING outputSubtype,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT CreateFrameReaderWithSubtypeAndSizeAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")]
                IMediaFrameSource inputSource,
            HSTRING outputSubtype,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize outputSize,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **"
            )]
                IAsyncOperation<IntPtr>** value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaExtension, IAsyncAction*, int> RemoveEffectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::MediaCapturePauseBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCapturePauseResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCapturePauseBehavior,
            IAsyncOperation<IntPtr>**,
            int> PauseRecordWithResultAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCaptureStopResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> StopRecordWithResultAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMapView<HSTRING, IntPtr>**, int> get_FrameSources;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSource *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaFrameSource,
            IAsyncOperation<IntPtr>**,
            int> CreateFrameReaderAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSource *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaFrameSource,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFrameReaderWithSubtypeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSource *, HSTRING, ABI::Windows::Graphics::Imaging::BitmapSize, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaFrameSource,
            HSTRING,
            BitmapSize,
            IAsyncOperation<IntPtr>**,
            int> CreateFrameReaderWithSubtypeAndSizeAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCapture5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCapture5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCapture5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCapture5(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaCapture5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture5"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture5"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaCapture5 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCapture5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCapture5(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCapture5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCapture5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
