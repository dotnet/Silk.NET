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

[Guid("2BC468E3-E1F8-4B54-95E8-32919551CE62")]
[NativeTypeName("struct IBitmapEncoder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapEncoder : IBitmapEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapEncoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBitmapEncoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBitmapEncoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapEncoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBitmapEncoder, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBitmapEncoder, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EncoderInformation(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **")]
            IBitmapCodecInformation* value
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, IBitmapCodecInformation*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BitmapProperties(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")]
            IBitmapProperties* value
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, IBitmapProperties*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BitmapContainerProperties(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")]
            IBitmapProperties* value
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, IBitmapProperties*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsThumbnailGenerated([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBitmapEncoder, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsThumbnailGenerated([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IBitmapEncoder, byte, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_GeneratedThumbnailWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapEncoder, uint*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_GeneratedThumbnailWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IBitmapEncoder, uint, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GeneratedThumbnailHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapEncoder, uint*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_GeneratedThumbnailHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IBitmapEncoder, uint, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_BitmapTransform(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform **")]
            IBitmapTransform* value
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, IBitmapTransform*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetPixelData(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat pixelFormat,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
            BitmapAlphaMode alphaMode,
        [NativeTypeName("UINT32")] uint width,
        [NativeTypeName("UINT32")] uint height,
        double dpiX,
        double dpiY,
        [NativeTypeName("UINT32")] uint pixelsLength,
        byte* pixels
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapEncoder,
                BitmapPixelFormat,
                BitmapAlphaMode,
                uint,
                uint,
                double,
                double,
                uint,
                byte*,
                int>)((*lpVtbl)[16])
        )(this, pixelFormat, alphaMode, width, height, dpiX, dpiY, pixelsLength, pixels);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GoToNextFrameAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, IAsyncAction*, int>)((*lpVtbl)[17]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GoToNextFrameWithEncodingOptionsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *"
        )]
            IIterable<IntPtr>* encodingOptions,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IBitmapEncoder, IIterable<IntPtr>*, IAsyncAction*, int>)(
                (*lpVtbl)[18]
            )
        )(this, encodingOptions, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FlushAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IBitmapEncoder, IAsyncAction*, int>)((*lpVtbl)[19]))(
            this,
            asyncInfo
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EncoderInformation(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **")]
                IBitmapCodecInformation* value
        );

        [VtblIndex(7)]
        HRESULT get_BitmapProperties(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")]
                IBitmapProperties* value
        );

        [VtblIndex(8)]
        HRESULT get_BitmapContainerProperties(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")]
                IBitmapProperties* value
        );

        [VtblIndex(9)]
        HRESULT get_IsThumbnailGenerated([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsThumbnailGenerated([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_GeneratedThumbnailWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_GeneratedThumbnailWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_GeneratedThumbnailHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_GeneratedThumbnailHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_BitmapTransform(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform **")]
                IBitmapTransform* value
        );

        [VtblIndex(16)]
        HRESULT SetPixelData(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat pixelFormat,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alphaMode,
            [NativeTypeName("UINT32")] uint width,
            [NativeTypeName("UINT32")] uint height,
            double dpiX,
            double dpiY,
            [NativeTypeName("UINT32")] uint pixelsLength,
            byte* pixels
        );

        [VtblIndex(17)]
        HRESULT GoToNextFrameAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(18)]
        HRESULT GoToNextFrameWithEncodingOptionsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *"
            )]
                IIterable<IntPtr>* encodingOptions,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(19)]
        HRESULT FlushAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
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
            "HRESULT (ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBitmapCodecInformation*, int> get_EncoderInformation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::IBitmapProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBitmapProperties*, int> get_BitmapProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::IBitmapProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBitmapProperties*, int> get_BitmapContainerProperties;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsThumbnailGenerated;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsThumbnailGenerated;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_GeneratedThumbnailWidth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_GeneratedThumbnailWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_GeneratedThumbnailHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_GeneratedThumbnailHeight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::IBitmapTransform **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBitmapTransform*, int> get_BitmapTransform;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, UINT32, UINT32, DOUBLE, DOUBLE, UINT32, BYTE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BitmapPixelFormat,
            BitmapAlphaMode,
            uint,
            uint,
            double,
            double,
            uint,
            byte*,
            int> SetPixelData;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> GoToNextFrameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncAction*,
            int> GoToNextFrameWithEncodingOptionsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> FlushAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBitmapEncoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBitmapEncoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBitmapEncoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBitmapEncoder(Silk.NET.WinRT.IInspectable value)
    {
        return new IBitmapEncoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapEncoder"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapEncoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBitmapEncoder value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBitmapEncoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBitmapEncoder(Silk.NET.Windows.IUnknown value)
    {
        return new IBitmapEncoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapEncoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapEncoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBitmapEncoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
