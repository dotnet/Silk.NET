// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("197F352C-2EDE-4A45-A896-817A4854F8FE")]
[NativeTypeName("struct IMediaEncodingProfileStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfileStatics
    : IMediaEncodingProfileStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfileStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfileStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaEncodingProfileStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEncodingProfileStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfileStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaEncodingProfileStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfileStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateM4a(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
            AudioEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                AudioEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[6])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMp3(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
            AudioEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                AudioEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[7])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWma(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
            AudioEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                AudioEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[8])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateMp4(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")]
            VideoEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                VideoEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[9])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateWmv(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")]
            VideoEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                VideoEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[10])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFromFileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                IStorageFile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, file, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFromStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics,
                IRandomAccessStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, stream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateM4a(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
                AudioEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(7)]
        HRESULT CreateMp3(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
                AudioEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(8)]
        HRESULT CreateWma(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
                AudioEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(9)]
        HRESULT CreateMp4(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")]
                VideoEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(10)]
        HRESULT CreateWmv(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")]
                VideoEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(11)]
        HRESULT CreateFromFileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT CreateFromStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **"
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
            "HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateM4a;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateMp3;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateWma;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::VideoEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VideoEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateMp4;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::VideoEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VideoEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateWmv;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> CreateFromFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IAsyncOperation<IntPtr>**,
            int> CreateFromStreamAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaEncodingProfileStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaEncodingProfileStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaEncodingProfileStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaEncodingProfileStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaEncodingProfileStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingProfileStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingProfileStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaEncodingProfileStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaEncodingProfileStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaEncodingProfileStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaEncodingProfileStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingProfileStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingProfileStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaEncodingProfileStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
