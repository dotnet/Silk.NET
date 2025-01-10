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

[Guid("9CC68260-7DA1-4043-B652-21B8878DAFF9")]
[NativeTypeName("struct IMediaCapture2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture2 : IMediaCapture2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaCapture2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaCapture2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCapture2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaCapture2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaCapture2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaCapture2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PrepareLowLagRecordToStorageFileAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                IMediaEncodingProfile,
                IStorageFile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, encodingProfile, file, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PrepareLowLagRecordToStreamAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                IMediaEncodingProfile,
                IRandomAccessStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, encodingProfile, stream, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PrepareLowLagRecordToCustomSinkAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension customMediaSink,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                IMediaEncodingProfile,
                IMediaExtension,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, encodingProfile, customMediaSink, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PrepareLowLagRecordToCustomSinkIdAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        HSTRING customSinkActivationId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet customSinkSettings,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                IMediaEncodingProfile,
                HSTRING,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, encodingProfile, customSinkActivationId, customSinkSettings, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PrepareLowLagPhotoCaptureAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
            IImageEncodingProperties type,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoCapture_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                IImageEncodingProperties,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, type, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PrepareLowLagPhotoSequenceCaptureAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
            IImageEncodingProperties type,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                IImageEncodingProperties,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, type, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetEncodingPropertiesAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
            IMediaEncodingProperties mediaEncodingProperties,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t *")]
            IMap<Guid, IntPtr>* encoderProperties,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCapture2,
                MediaStreamType,
                IMediaEncodingProperties,
                IMap<Guid, IntPtr>*,
                IAsyncAction*,
                int>)((*lpVtbl)[12])
        )(this, mediaStreamType, mediaEncodingProperties, encoderProperties, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PrepareLowLagRecordToStorageFileAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT PrepareLowLagRecordToStreamAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT PrepareLowLagRecordToCustomSinkAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Media::IMediaExtension *")]
                IMediaExtension customMediaSink,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT PrepareLowLagRecordToCustomSinkIdAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            HSTRING customSinkActivationId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet customSinkSettings,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(10)]
        HRESULT PrepareLowLagPhotoCaptureAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
                IImageEncodingProperties type,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoCapture_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT PrepareLowLagPhotoSequenceCaptureAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")]
                IImageEncodingProperties type,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT SetEncodingPropertiesAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
                IMediaEncodingProperties mediaEncodingProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t *"
            )]
                IMap<Guid, IntPtr>* encoderProperties,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> PrepareLowLagRecordToStorageFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IRandomAccessStream,
            IAsyncOperation<IntPtr>**,
            int> PrepareLowLagRecordToStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IMediaExtension,
            IAsyncOperation<IntPtr>**,
            int> PrepareLowLagRecordToCustomSinkAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            HSTRING,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> PrepareLowLagRecordToCustomSinkIdAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoCapture_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImageEncodingProperties,
            IAsyncOperation<IntPtr>**,
            int> PrepareLowLagPhotoCaptureAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImageEncodingProperties,
            IAsyncOperation<IntPtr>**,
            int> PrepareLowLagPhotoSequenceCaptureAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            IMediaEncodingProperties,
            IMap<Guid, IntPtr>*,
            IAsyncAction*,
            int> SetEncodingPropertiesAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCapture2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCapture2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCapture2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCapture2(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaCapture2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaCapture2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCapture2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCapture2(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCapture2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCapture2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCapture2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCapture2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
