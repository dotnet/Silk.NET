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

[Guid("C61AFBB4-FB10-4A34-AC18-CA80D9C8E7EE")]
[NativeTypeName("struct IMediaCapture : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture : IMediaCapture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaCapture, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaCapture, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCapture, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaCapture, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaCapture, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaCapture, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IMediaCapture, IAsyncAction*, int>)((*lpVtbl)[6]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InitializeWithSettingsAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureInitializationSettings *")]
            IMediaCaptureInitializationSettings mediaCaptureInitializationSettings,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IMediaCaptureInitializationSettings,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(this, mediaCaptureInitializationSettings, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartRecordToStorageFileAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IMediaEncodingProfile,
                IStorageFile,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, encodingProfile, file, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartRecordToStreamAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IMediaEncodingProfile,
                IRandomAccessStream,
                IAsyncAction*,
                int>)((*lpVtbl)[9])
        )(this, encodingProfile, stream, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StartRecordToCustomSinkAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension customMediaSink,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IMediaEncodingProfile,
                IMediaExtension,
                IAsyncAction*,
                int>)((*lpVtbl)[10])
        )(this, encodingProfile, customMediaSink, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartRecordToCustomSinkIdAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        HSTRING customSinkActivationId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet customSinkSettings,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IMediaEncodingProfile,
                HSTRING,
                IPropertySet,
                IAsyncAction*,
                int>)((*lpVtbl)[11])
        )(this, encodingProfile, customSinkActivationId, customSinkSettings, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopRecordAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IMediaCapture, IAsyncAction*, int>)((*lpVtbl)[12]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CapturePhotoToStorageFileAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
            IImageEncodingProperties type,
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IImageEncodingProperties,
                IStorageFile,
                IAsyncAction*,
                int>)((*lpVtbl)[13])
        )(this, type, file, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CapturePhotoToStreamAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
            IImageEncodingProperties type,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IImageEncodingProperties,
                IRandomAccessStream,
                IAsyncAction*,
                int>)((*lpVtbl)[14])
        )(this, type, stream, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead"
    )]
    public HRESULT AddEffectAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        HSTRING effectActivationID,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet effectSettings,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                MediaStreamType,
                HSTRING,
                IPropertySet,
                IAsyncAction*,
                int>)((*lpVtbl)[15])
        )(this, mediaStreamType, effectActivationID, effectSettings, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ClearEffectsAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture, MediaStreamType, IAsyncAction*, int>)((*lpVtbl)[16])
        )(this, mediaStreamType, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetEncoderProperty(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        Guid propertyId,
        IInspectable propertyValue
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture, MediaStreamType, Guid, IInspectable, int>)(
                (*lpVtbl)[17]
            )
        )(this, mediaStreamType, propertyId, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetEncoderProperty(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        Guid propertyId,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IMediaCapture, MediaStreamType, Guid, IInspectable*, int>)(
                (*lpVtbl)[18]
            )
        )(this, mediaStreamType, propertyId, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_Failed(
        [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureFailedEventHandler *")]
            IMediaCaptureFailedEventHandler errorEventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IMediaCaptureFailedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[19])
        )(this, errorEventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_Failed(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<IMediaCapture, EventRegistrationToken, int>)((*lpVtbl)[20]))(
            this,
            eventCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_RecordLimitationExceeded(
        [NativeTypeName("ABI::Windows::Media::Capture::IRecordLimitationExceededEventHandler *")]
            IRecordLimitationExceededEventHandler recordLimitationExceededEventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture,
                IRecordLimitationExceededEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[21])
        )(this, recordLimitationExceededEventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_RecordLimitationExceeded(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<IMediaCapture, EventRegistrationToken, int>)((*lpVtbl)[22]))(
            this,
            eventCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_MediaCaptureSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureSettings **")]
            IMediaCaptureSettings* value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, IMediaCaptureSettings*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_AudioDeviceController(
        [NativeTypeName("ABI::Windows::Media::Devices::IAudioDeviceController **")]
            IAudioDeviceController* value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, IAudioDeviceController*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_VideoDeviceController(
        [NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceController **")]
            IVideoDeviceController* value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, IVideoDeviceController*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetPreviewMirroring([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaCapture, byte, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetPreviewMirroring([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaCapture, byte*, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetPreviewRotation(
        [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation")] VideoRotation value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, VideoRotation, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetPreviewRotation(
        [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation *")] VideoRotation* value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, VideoRotation*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetRecordRotation(
        [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation")] VideoRotation value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, VideoRotation, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetRecordRotation(
        [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation *")] VideoRotation* value
    )
    {
        return ((delegate* unmanaged<IMediaCapture, VideoRotation*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InitializeAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        HRESULT InitializeWithSettingsAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureInitializationSettings *")]
                IMediaCaptureInitializationSettings mediaCaptureInitializationSettings,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(8)]
        HRESULT StartRecordToStorageFileAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(9)]
        HRESULT StartRecordToStreamAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(10)]
        HRESULT StartRecordToCustomSinkAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Media::IMediaExtension *")]
                IMediaExtension customMediaSink,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(11)]
        HRESULT StartRecordToCustomSinkIdAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            HSTRING customSinkActivationId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet customSinkSettings,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(12)]
        HRESULT StopRecordAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(13)]
        HRESULT CapturePhotoToStorageFileAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
                IImageEncodingProperties type,
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(14)]
        HRESULT CapturePhotoToStreamAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
                IImageEncodingProperties type,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(15)]
        [Obsolete(
            "AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead"
        )]
        HRESULT AddEffectAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            HSTRING effectActivationID,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet effectSettings,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(16)]
        HRESULT ClearEffectsAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(17)]
        HRESULT SetEncoderProperty(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            Guid propertyId,
            IInspectable propertyValue
        );

        [VtblIndex(18)]
        HRESULT GetEncoderProperty(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            Guid propertyId,
            IInspectable* propertyValue
        );

        [VtblIndex(19)]
        HRESULT add_Failed(
            [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureFailedEventHandler *")]
                IMediaCaptureFailedEventHandler errorEventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(20)]
        HRESULT remove_Failed(EventRegistrationToken eventCookie);

        [VtblIndex(21)]
        HRESULT add_RecordLimitationExceeded(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::IRecordLimitationExceededEventHandler *"
            )]
                IRecordLimitationExceededEventHandler recordLimitationExceededEventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(22)]
        HRESULT remove_RecordLimitationExceeded(EventRegistrationToken eventCookie);

        [VtblIndex(23)]
        HRESULT get_MediaCaptureSettings(
            [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureSettings **")]
                IMediaCaptureSettings* value
        );

        [VtblIndex(24)]
        HRESULT get_AudioDeviceController(
            [NativeTypeName("ABI::Windows::Media::Devices::IAudioDeviceController **")]
                IAudioDeviceController* value
        );

        [VtblIndex(25)]
        HRESULT get_VideoDeviceController(
            [NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceController **")]
                IVideoDeviceController* value
        );

        [VtblIndex(26)]
        HRESULT SetPreviewMirroring([NativeTypeName("boolean")] byte value);

        [VtblIndex(27)]
        HRESULT GetPreviewMirroring([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(28)]
        HRESULT SetPreviewRotation(
            [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation")] VideoRotation value
        );

        [VtblIndex(29)]
        HRESULT GetPreviewRotation(
            [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation *")] VideoRotation* value
        );

        [VtblIndex(30)]
        HRESULT SetRecordRotation(
            [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation")] VideoRotation value
        );

        [VtblIndex(31)]
        HRESULT GetRecordRotation(
            [NativeTypeName("ABI::Windows::Media::Capture::VideoRotation *")] VideoRotation* value
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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> InitializeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IMediaCaptureInitializationSettings *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaCaptureInitializationSettings,
            IAsyncAction*,
            int> InitializeWithSettingsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IStorageFile,
            IAsyncAction*,
            int> StartRecordToStorageFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IRandomAccessStream,
            IAsyncAction*,
            int> StartRecordToStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IMediaExtension,
            IAsyncAction*,
            int> StartRecordToCustomSinkAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            HSTRING,
            IPropertySet,
            IAsyncAction*,
            int> StartRecordToCustomSinkIdAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StopRecordAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImageEncodingProperties,
            IStorageFile,
            IAsyncAction*,
            int> CapturePhotoToStorageFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImageEncodingProperties,
            IRandomAccessStream,
            IAsyncAction*,
            int> CapturePhotoToStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            HSTRING,
            IPropertySet,
            IAsyncAction*,
            int> AddEffectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaStreamType, IAsyncAction*, int> ClearEffectsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, GUID, IInspectable *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            Guid,
            IInspectable,
            int> SetEncoderProperty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, GUID, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            Guid,
            IInspectable*,
            int> GetEncoderProperty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IMediaCaptureFailedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaCaptureFailedEventHandler,
            EventRegistrationToken*,
            int> add_Failed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Failed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IRecordLimitationExceededEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRecordLimitationExceededEventHandler,
            EventRegistrationToken*,
            int> add_RecordLimitationExceeded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RecordLimitationExceeded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IMediaCaptureSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaCaptureSettings*, int> get_MediaCaptureSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IAudioDeviceController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioDeviceController*, int> get_AudioDeviceController;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IVideoDeviceController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoDeviceController*, int> get_VideoDeviceController;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> SetPreviewMirroring;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> GetPreviewMirroring;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::VideoRotation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VideoRotation, int> SetPreviewRotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::VideoRotation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VideoRotation*, int> GetPreviewRotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::VideoRotation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VideoRotation, int> SetRecordRotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::VideoRotation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VideoRotation*, int> GetRecordRotation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCapture"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCapture(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCapture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCapture(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaCapture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaCapture value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCapture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCapture(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCapture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCapture value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
