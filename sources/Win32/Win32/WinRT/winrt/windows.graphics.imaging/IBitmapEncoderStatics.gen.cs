// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A74356A7-A4E4-4EB9-8E40-564DE7E1CCB2")]
[NativeTypeName("struct IBitmapEncoderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapEncoderStatics : IBitmapEncoderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapEncoderStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBitmapEncoderStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BmpEncoderId(Guid* value)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_JpegEncoderId(Guid* value)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PngEncoderId(Guid* value)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TiffEncoderId(Guid* value)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GifEncoderId(Guid* value)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_JpegXREncoderId(Guid* value)
    {
        return ((delegate* unmanaged<IBitmapEncoderStatics, Guid*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetEncoderInformationEnumerator(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **"
        )]
            IVectorView<IntPtr>** encoderInformationEnumerator
    )
    {
        return (
            (delegate* unmanaged<IBitmapEncoderStatics, IVectorView<IntPtr>**, int>)((*lpVtbl)[12])
        )(this, encoderInformationEnumerator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateAsync(
        Guid encoderId,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapEncoderStatics,
                Guid,
                IRandomAccessStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, encoderId, stream, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateWithEncodingOptionsAsync(
        Guid encoderId,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *"
        )]
            IIterable<IntPtr>* encodingOptions,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapEncoderStatics,
                Guid,
                IRandomAccessStream,
                IIterable<IntPtr>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[14])
        )(this, encoderId, stream, encodingOptions, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateForTranscodingAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")]
            IBitmapDecoder bitmapDecoder,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapEncoderStatics,
                IRandomAccessStream,
                IBitmapDecoder,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[15])
        )(this, stream, bitmapDecoder, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateForInPlacePropertyEncodingAsync(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")]
            IBitmapDecoder bitmapDecoder,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapEncoderStatics,
                IBitmapDecoder,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[16])
        )(this, bitmapDecoder, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BmpEncoderId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_JpegEncoderId(Guid* value);

        [VtblIndex(8)]
        HRESULT get_PngEncoderId(Guid* value);

        [VtblIndex(9)]
        HRESULT get_TiffEncoderId(Guid* value);

        [VtblIndex(10)]
        HRESULT get_GifEncoderId(Guid* value);

        [VtblIndex(11)]
        HRESULT get_JpegXREncoderId(Guid* value);

        [VtblIndex(12)]
        HRESULT GetEncoderInformationEnumerator(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **"
            )]
                IVectorView<IntPtr>** encoderInformationEnumerator
        );

        [VtblIndex(13)]
        HRESULT CreateAsync(
            Guid encoderId,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(14)]
        HRESULT CreateWithEncodingOptionsAsync(
            Guid encoderId,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *"
            )]
                IIterable<IntPtr>* encodingOptions,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(15)]
        HRESULT CreateForTranscodingAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")]
                IBitmapDecoder bitmapDecoder,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(16)]
        HRESULT CreateForInPlacePropertyEncodingAsync(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")]
                IBitmapDecoder bitmapDecoder,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_BmpEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_JpegEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_PngEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TiffEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_GifEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_JpegXREncoderId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<IntPtr>**,
            int> GetEncoderInformationEnumerator;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            IRandomAccessStream,
            IAsyncOperation<IntPtr>**,
            int> CreateAsync;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            IRandomAccessStream,
            IIterable<IntPtr>*,
            IAsyncOperation<IntPtr>**,
            int> CreateWithEncodingOptionsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Graphics::Imaging::IBitmapDecoder *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IBitmapDecoder,
            IAsyncOperation<IntPtr>**,
            int> CreateForTranscodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::IBitmapDecoder *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBitmapDecoder,
            IAsyncOperation<IntPtr>**,
            int> CreateForInPlacePropertyEncodingAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBitmapEncoderStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBitmapEncoderStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBitmapEncoderStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBitmapEncoderStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IBitmapEncoderStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapEncoderStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapEncoderStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBitmapEncoderStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBitmapEncoderStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBitmapEncoderStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IBitmapEncoderStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapEncoderStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapEncoderStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBitmapEncoderStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
