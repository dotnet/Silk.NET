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

[Guid("FE287C9A-420C-4963-87AD-691436E08383")]
[NativeTypeName("struct IBitmapFrameWithSoftwareBitmap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapFrameWithSoftwareBitmap
    : IBitmapFrameWithSoftwareBitmap.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapFrameWithSoftwareBitmap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSoftwareBitmapAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IBitmapFrameWithSoftwareBitmap, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSoftwareBitmapConvertedAsync(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat pixelFormat,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
            BitmapAlphaMode alphaMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapFrameWithSoftwareBitmap,
                BitmapPixelFormat,
                BitmapAlphaMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, pixelFormat, alphaMode, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSoftwareBitmapTransformedAsync(
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
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IBitmapFrameWithSoftwareBitmap,
                BitmapPixelFormat,
                BitmapAlphaMode,
                IBitmapTransform,
                ExifOrientationMode,
                ColorManagementMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, pixelFormat, alphaMode, transform, exifOrientationMode, colorManagementMode, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSoftwareBitmapAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT GetSoftwareBitmapConvertedAsync(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat pixelFormat,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alphaMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT GetSoftwareBitmapTransformedAsync(
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
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetSoftwareBitmapAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BitmapPixelFormat,
            BitmapAlphaMode,
            IAsyncOperation<IntPtr>**,
            int> GetSoftwareBitmapConvertedAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::IBitmapTransform *, ABI::Windows::Graphics::Imaging::ExifOrientationMode, ABI::Windows::Graphics::Imaging::ColorManagementMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BitmapPixelFormat,
            BitmapAlphaMode,
            IBitmapTransform,
            ExifOrientationMode,
            ColorManagementMode,
            IAsyncOperation<IntPtr>**,
            int> GetSoftwareBitmapTransformedAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBitmapFrameWithSoftwareBitmap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBitmapFrameWithSoftwareBitmap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBitmapFrameWithSoftwareBitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBitmapFrameWithSoftwareBitmap(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBitmapFrameWithSoftwareBitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapFrameWithSoftwareBitmap"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapFrameWithSoftwareBitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBitmapFrameWithSoftwareBitmap value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBitmapFrameWithSoftwareBitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBitmapFrameWithSoftwareBitmap(Silk.NET.Windows.IUnknown value)
    {
        return new IBitmapFrameWithSoftwareBitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapFrameWithSoftwareBitmap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapFrameWithSoftwareBitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBitmapFrameWithSoftwareBitmap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
