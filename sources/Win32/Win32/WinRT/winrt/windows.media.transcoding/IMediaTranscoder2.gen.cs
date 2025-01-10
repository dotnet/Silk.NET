// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("40531D74-35E0-4F04-8574-CA8BC4E5A082")]
[NativeTypeName("struct IMediaTranscoder2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTranscoder2 : IMediaTranscoder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaTranscoder2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaTranscoder2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaTranscoder2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaTranscoder2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaTranscoder2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaTranscoder2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaTranscoder2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PrepareMediaStreamSourceTranscodeAsync(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource source,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream destination,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile profile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaTranscoder2,
                IMediaSource,
                IRandomAccessStream,
                IMediaEncodingProfile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, source, destination, profile, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_VideoProcessingAlgorithm(
        [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")]
            MediaVideoProcessingAlgorithm value
    )
    {
        return (
            (delegate* unmanaged<IMediaTranscoder2, MediaVideoProcessingAlgorithm, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoProcessingAlgorithm(
        [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")]
            MediaVideoProcessingAlgorithm* value
    )
    {
        return (
            (delegate* unmanaged<IMediaTranscoder2, MediaVideoProcessingAlgorithm*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PrepareMediaStreamSourceTranscodeAsync(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource source,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream destination,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile profile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT put_VideoProcessingAlgorithm(
            [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")]
                MediaVideoProcessingAlgorithm value
        );

        [VtblIndex(8)]
        HRESULT get_VideoProcessingAlgorithm(
            [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")]
                MediaVideoProcessingAlgorithm* value
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
            "HRESULT (ABI::Windows::Media::Core::IMediaSource *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaSource,
            IRandomAccessStream,
            IMediaEncodingProfile,
            IAsyncOperation<IntPtr>**,
            int> PrepareMediaStreamSourceTranscodeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaVideoProcessingAlgorithm,
            int> put_VideoProcessingAlgorithm;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaVideoProcessingAlgorithm*,
            int> get_VideoProcessingAlgorithm;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaTranscoder2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaTranscoder2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaTranscoder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaTranscoder2(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaTranscoder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaTranscoder2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaTranscoder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaTranscoder2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaTranscoder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaTranscoder2(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaTranscoder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaTranscoder2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaTranscoder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaTranscoder2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
