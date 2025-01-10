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

[Guid("72A49A1C-8081-438D-91BC-94ECFC8185C6")]
[NativeTypeName("struct IBitmapFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapFrame : IBitmapFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBitmapFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBitmapFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBitmapFrame, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBitmapFrame, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBitmapFrame, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetThumbnailAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return ((delegate* unmanaged<IBitmapFrame, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[6]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BitmapProperties(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **")]
            IBitmapPropertiesView* value
    )
    {
        return ((delegate* unmanaged<IBitmapFrame, IBitmapPropertiesView*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BitmapPixelFormat(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")]
            BitmapPixelFormat* value
    )
    {
        return ((delegate* unmanaged<IBitmapFrame, BitmapPixelFormat*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BitmapAlphaMode(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")]
            BitmapAlphaMode* value
    )
    {
        return ((delegate* unmanaged<IBitmapFrame, BitmapAlphaMode*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DpiX(double* value)
    {
        return ((delegate* unmanaged<IBitmapFrame, double*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DpiY(double* value)
    {
        return ((delegate* unmanaged<IBitmapFrame, double*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PixelWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapFrame, uint*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PixelHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapFrame, uint*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_OrientedPixelWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapFrame, uint*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_OrientedPixelHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapFrame, uint*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPixelDataAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return ((delegate* unmanaged<IBitmapFrame, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[16]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPixelDataTransformedAsync(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat pixelFormat,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
            BitmapAlphaMode alphaMode,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform *")]
            IBitmapTransform transform,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ExifOrientationMode")]
            ExifOrientationMode exifOrientationMode,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ColorManagementMode")]
            ColorManagementMode colorManagementMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapFrame,
                BitmapPixelFormat,
                BitmapAlphaMode,
                IBitmapTransform,
                ExifOrientationMode,
                ColorManagementMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[17])
        )(
            this,
            pixelFormat,
            alphaMode,
            transform,
            exifOrientationMode,
            colorManagementMode,
            asyncInfo
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetThumbnailAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(7)]
        HRESULT get_BitmapProperties(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **")]
                IBitmapPropertiesView* value
        );

        [VtblIndex(8)]
        HRESULT get_BitmapPixelFormat(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")]
                BitmapPixelFormat* value
        );

        [VtblIndex(9)]
        HRESULT get_BitmapAlphaMode(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")]
                BitmapAlphaMode* value
        );

        [VtblIndex(10)]
        HRESULT get_DpiX(double* value);

        [VtblIndex(11)]
        HRESULT get_DpiY(double* value);

        [VtblIndex(12)]
        HRESULT get_PixelWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_PixelHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT get_OrientedPixelWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(15)]
        HRESULT get_OrientedPixelHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT GetPixelDataAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(17)]
        HRESULT GetPixelDataTransformedAsync(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat pixelFormat,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alphaMode,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform *")]
                IBitmapTransform transform,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ExifOrientationMode")]
                ExifOrientationMode exifOrientationMode,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ColorManagementMode")]
                ColorManagementMode colorManagementMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **"
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetThumbnailAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBitmapPropertiesView*, int> get_BitmapProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapPixelFormat*, int> get_BitmapPixelFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapAlphaMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapAlphaMode*, int> get_BitmapAlphaMode;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DpiX;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DpiY;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_PixelWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_PixelHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_OrientedPixelWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_OrientedPixelHeight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetPixelDataAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::IBitmapTransform *, ABI::Windows::Graphics::Imaging::ExifOrientationMode, ABI::Windows::Graphics::Imaging::ColorManagementMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BitmapPixelFormat,
            BitmapAlphaMode,
            IBitmapTransform,
            ExifOrientationMode,
            ColorManagementMode,
            IAsyncOperation<IntPtr>**,
            int> GetPixelDataTransformedAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBitmapFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBitmapFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBitmapFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBitmapFrame(Silk.NET.WinRT.IInspectable value)
    {
        return new IBitmapFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapFrame"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBitmapFrame value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBitmapFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBitmapFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IBitmapFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBitmapFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
