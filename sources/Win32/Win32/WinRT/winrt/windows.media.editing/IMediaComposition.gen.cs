// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2E06E605-DC71-41D6-B837-2D2BC14A2947")]
[NativeTypeName("struct IMediaComposition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaComposition : IMediaComposition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaComposition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaComposition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaComposition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaComposition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaComposition, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaComposition, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaComposition, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaComposition, TimeSpan*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Clips(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CMediaClip_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IMediaComposition, IVector<IntPtr>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundAudioTracks(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IMediaComposition, IVector<IntPtr>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UserData(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")]
            IMap<HSTRING, HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaComposition, IMap<HSTRING, HSTRING>**, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Clone(
        [NativeTypeName("ABI::Windows::Media::Editing::IMediaComposition **")]
            IMediaComposition* result
    )
    {
        return ((delegate* unmanaged<IMediaComposition, IMediaComposition*, int>)((*lpVtbl)[10]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IMediaComposition, IStorageFile, IAsyncAction*, int>)(
                (*lpVtbl)[11]
            )
        )(this, file, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetThumbnailAsync(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeFromStart,
        [NativeTypeName("INT32")] int scaledWidth,
        [NativeTypeName("INT32")] int scaledHeight,
        [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")]
            VideoFramePrecision framePrecision,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaComposition,
                TimeSpan,
                int,
                int,
                VideoFramePrecision,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, timeFromStart, scaledWidth, scaledHeight, framePrecision, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetThumbnailsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CTimeSpan_t *"
        )]
            IIterable<TimeSpan>* timesFromStart,
        [NativeTypeName("INT32")] int scaledWidth,
        [NativeTypeName("INT32")] int scaledHeight,
        [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")]
            VideoFramePrecision framePrecision,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CGraphics__CImaging__CImageStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaComposition,
                IIterable<TimeSpan>*,
                int,
                int,
                VideoFramePrecision,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, timesFromStart, scaledWidth, scaledHeight, framePrecision, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RenderToFileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **"
        )]
            IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaComposition,
                IStorageFile,
                IAsyncOperationWithProgress<TranscodeFailureReason, double>**,
                int>)((*lpVtbl)[14])
        )(this, destination, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RenderToFileWithTrimmingPreferenceAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
        [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")]
            MediaTrimmingPreference trimmingPreference,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **"
        )]
            IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaComposition,
                IStorageFile,
                MediaTrimmingPreference,
                IAsyncOperationWithProgress<TranscodeFailureReason, double>**,
                int>)((*lpVtbl)[15])
        )(this, destination, trimmingPreference, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RenderToFileWithProfileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
        [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")]
            MediaTrimmingPreference trimmingPreference,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **"
        )]
            IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaComposition,
                IStorageFile,
                MediaTrimmingPreference,
                IMediaEncodingProfile,
                IAsyncOperationWithProgress<TranscodeFailureReason, double>**,
                int>)((*lpVtbl)[16])
        )(this, destination, trimmingPreference, encodingProfile, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateDefaultEncodingProfile(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<IMediaComposition, IMediaEncodingProfile*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GenerateMediaStreamSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
            IMediaStreamSource* value
    )
    {
        return ((delegate* unmanaged<IMediaComposition, IMediaStreamSource*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GenerateMediaStreamSourceWithProfile(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
            IMediaStreamSource* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaComposition,
                IMediaEncodingProfile,
                IMediaStreamSource*,
                int>)((*lpVtbl)[19])
        )(this, encodingProfile, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GeneratePreviewMediaStreamSource(
        [NativeTypeName("INT32")] int scaledWidth,
        [NativeTypeName("INT32")] int scaledHeight,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
            IMediaStreamSource* value
    )
    {
        return (
            (delegate* unmanaged<IMediaComposition, int, int, IMediaStreamSource*, int>)(
                (*lpVtbl)[20]
            )
        )(this, scaledWidth, scaledHeight, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Duration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(7)]
        HRESULT get_Clips(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CMediaClip_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT get_BackgroundAudioTracks(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT get_UserData(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **"
            )]
                IMap<HSTRING, HSTRING>** value
        );

        [VtblIndex(10)]
        HRESULT Clone(
            [NativeTypeName("ABI::Windows::Media::Editing::IMediaComposition **")]
                IMediaComposition* result
        );

        [VtblIndex(11)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(12)]
        HRESULT GetThumbnailAsync(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeFromStart,
            [NativeTypeName("INT32")] int scaledWidth,
            [NativeTypeName("INT32")] int scaledHeight,
            [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")]
                VideoFramePrecision framePrecision,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(13)]
        HRESULT GetThumbnailsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CTimeSpan_t *"
            )]
                IIterable<TimeSpan>* timesFromStart,
            [NativeTypeName("INT32")] int scaledWidth,
            [NativeTypeName("INT32")] int scaledHeight,
            [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")]
                VideoFramePrecision framePrecision,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CGraphics__CImaging__CImageStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(14)]
        HRESULT RenderToFileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **"
            )]
                IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation
        );

        [VtblIndex(15)]
        HRESULT RenderToFileWithTrimmingPreferenceAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
            [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")]
                MediaTrimmingPreference trimmingPreference,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **"
            )]
                IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation
        );

        [VtblIndex(16)]
        HRESULT RenderToFileWithProfileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
            [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")]
                MediaTrimmingPreference trimmingPreference,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **"
            )]
                IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation
        );

        [VtblIndex(17)]
        HRESULT CreateDefaultEncodingProfile(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(18)]
        HRESULT GenerateMediaStreamSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
                IMediaStreamSource* value
        );

        [VtblIndex(19)]
        HRESULT GenerateMediaStreamSourceWithProfile(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
                IMediaStreamSource* value
        );

        [VtblIndex(20)]
        HRESULT GeneratePreviewMediaStreamSource(
            [NativeTypeName("INT32")] int scaledWidth,
            [NativeTypeName("INT32")] int scaledHeight,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
                IMediaStreamSource* value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CMediaClip_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Clips;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_BackgroundAudioTracks;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, HSTRING>**, int> get_UserData;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Editing::IMediaComposition **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaComposition*, int> Clone;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile, IAsyncAction*, int> SaveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::TimeSpan, INT32, INT32, ABI::Windows::Media::Editing::VideoFramePrecision, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            TimeSpan,
            int,
            int,
            VideoFramePrecision,
            IAsyncOperation<IntPtr>**,
            int> GetThumbnailAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CTimeSpan_t *, INT32, INT32, ABI::Windows::Media::Editing::VideoFramePrecision, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<TimeSpan>*,
            int,
            int,
            VideoFramePrecision,
            IAsyncOperation<IntPtr>**,
            int> GetThumbnailsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperationWithProgress<TranscodeFailureReason, double>**,
            int> RenderToFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Editing::MediaTrimmingPreference, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            MediaTrimmingPreference,
            IAsyncOperationWithProgress<TranscodeFailureReason, double>**,
            int> RenderToFileWithTrimmingPreferenceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Editing::MediaTrimmingPreference, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            MediaTrimmingPreference,
            IMediaEncodingProfile,
            IAsyncOperationWithProgress<TranscodeFailureReason, double>**,
            int> RenderToFileWithProfileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile*,
            int> CreateDefaultEncodingProfile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaStreamSource*, int> GenerateMediaStreamSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IMediaStreamSource*,
            int> GenerateMediaStreamSourceWithProfile;

        [NativeTypeName(
            "HRESULT (INT32, INT32, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            IMediaStreamSource*,
            int> GeneratePreviewMediaStreamSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaComposition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaComposition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaComposition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaComposition(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaComposition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaComposition"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaComposition"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaComposition value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaComposition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaComposition(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaComposition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaComposition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaComposition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaComposition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
