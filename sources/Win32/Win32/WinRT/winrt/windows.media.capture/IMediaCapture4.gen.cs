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

[Guid("BACD6FD6-FB08-4947-AEA2-CE14EFF0CE13")]
[NativeTypeName("struct IMediaCapture4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture4 : IMediaCapture4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaCapture4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaCapture4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCapture4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaCapture4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaCapture4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaCapture4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddAudioEffectAsync(
        [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")]
            IAudioEffectDefinition definition,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CIMediaExtension_t **"
        )]
            IAsyncOperation<IntPtr>** op
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture4,
                IAudioEffectDefinition,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, definition, op);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddVideoEffectAsync(
        [NativeTypeName("ABI::Windows::Media::Effects::IVideoEffectDefinition *")]
            IVideoEffectDefinition definition,
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CIMediaExtension_t **"
        )]
            IAsyncOperation<IntPtr>** op
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture4,
                IVideoEffectDefinition,
                MediaStreamType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, definition, mediaStreamType, op);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PauseRecordAsync(
        [NativeTypeName("ABI::Windows::Media::Devices::MediaCapturePauseBehavior")]
            MediaCapturePauseBehavior behavior,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture4, MediaCapturePauseBehavior, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, behavior, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ResumeRecordAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IMediaCapture4, IAsyncAction*, int>)((*lpVtbl)[9]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_CameraStreamStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture4,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_CameraStreamStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaCapture4, EventRegistrationToken, int>)((*lpVtbl)[11]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CameraStreamState(
        [NativeTypeName("ABI::Windows::Media::Devices::CameraStreamState *")]
            CameraStreamState* streamState
    )
    {
        return ((delegate* unmanaged<IMediaCapture4, CameraStreamState*, int>)((*lpVtbl)[12]))(
            this,
            streamState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPreviewFrameAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CVideoFrame_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture4, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[13])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetPreviewFrameCopyAsync(
        [NativeTypeName("ABI::Windows::Media::IVideoFrame *")] IVideoFrame destination,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CVideoFrame_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture4, IVideoFrame, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, destination, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_ThermalStatusChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture4,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_ThermalStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaCapture4, EventRegistrationToken, int>)((*lpVtbl)[16]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ThermalStatus(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureThermalStatus *")]
            MediaCaptureThermalStatus* value
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture4, MediaCaptureThermalStatus*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT PrepareAdvancedPhotoCaptureAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
            IImageEncodingProperties encodingProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedPhotoCapture_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture4,
                IImageEncodingProperties,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[18])
        )(this, encodingProperties, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddAudioEffectAsync(
            [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")]
                IAudioEffectDefinition definition,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CIMediaExtension_t **"
            )]
                IAsyncOperation<IntPtr>** op
        );

        [VtblIndex(7)]
        HRESULT AddVideoEffectAsync(
            [NativeTypeName("ABI::Windows::Media::Effects::IVideoEffectDefinition *")]
                IVideoEffectDefinition definition,
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CIMediaExtension_t **"
            )]
                IAsyncOperation<IntPtr>** op
        );

        [VtblIndex(8)]
        HRESULT PauseRecordAsync(
            [NativeTypeName("ABI::Windows::Media::Devices::MediaCapturePauseBehavior")]
                MediaCapturePauseBehavior behavior,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(9)]
        HRESULT ResumeRecordAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(10)]
        HRESULT add_CameraStreamStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_CameraStreamStateChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_CameraStreamState(
            [NativeTypeName("ABI::Windows::Media::Devices::CameraStreamState *")]
                CameraStreamState* streamState
        );

        [VtblIndex(13)]
        HRESULT GetPreviewFrameAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CVideoFrame_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(14)]
        HRESULT GetPreviewFrameCopyAsync(
            [NativeTypeName("ABI::Windows::Media::IVideoFrame *")] IVideoFrame destination,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CVideoFrame_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(15)]
        HRESULT add_ThermalStatusChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_ThermalStatusChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT get_ThermalStatus(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureThermalStatus *")]
                MediaCaptureThermalStatus* value
        );

        [VtblIndex(18)]
        HRESULT PrepareAdvancedPhotoCaptureAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
                IImageEncodingProperties encodingProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedPhotoCapture_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::Media::Effects::IAudioEffectDefinition *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CIMediaExtension_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEffectDefinition,
            IAsyncOperation<IntPtr>**,
            int> AddAudioEffectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::IVideoEffectDefinition *, ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CIMediaExtension_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVideoEffectDefinition,
            MediaStreamType,
            IAsyncOperation<IntPtr>**,
            int> AddVideoEffectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::MediaCapturePauseBehavior, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCapturePauseBehavior,
            IAsyncAction*,
            int> PauseRecordAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> ResumeRecordAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CameraStreamStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_CameraStreamStateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::CameraStreamState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CameraStreamState*, int> get_CameraStreamState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CVideoFrame_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetPreviewFrameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::IVideoFrame *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CVideoFrame_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVideoFrame,
            IAsyncOperation<IntPtr>**,
            int> GetPreviewFrameCopyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ThermalStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ThermalStatusChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCaptureThermalStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCaptureThermalStatus*, int> get_ThermalStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedPhotoCapture_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImageEncodingProperties,
            IAsyncOperation<IntPtr>**,
            int> PrepareAdvancedPhotoCaptureAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCapture4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCapture4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCapture4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCapture4(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaCapture4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaCapture4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCapture4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCapture4(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCapture4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCapture4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
