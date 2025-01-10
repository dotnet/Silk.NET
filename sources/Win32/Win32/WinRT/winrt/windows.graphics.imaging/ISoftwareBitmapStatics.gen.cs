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

[Guid("DF0385DB-672F-4A9D-806E-C2442F343E86")]
[NativeTypeName("struct ISoftwareBitmapStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmapStatics : ISoftwareBitmapStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmapStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISoftwareBitmapStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISoftwareBitmapStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftwareBitmapStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmapStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISoftwareBitmapStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISoftwareBitmapStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Copy(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap source,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<ISoftwareBitmapStatics, ISoftwareBitmap, ISoftwareBitmap*, int>)(
                (*lpVtbl)[6]
            )
        )(this, source, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Convert(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap source,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat format,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapStatics,
                ISoftwareBitmap,
                BitmapPixelFormat,
                ISoftwareBitmap*,
                int>)((*lpVtbl)[7])
        )(this, source, format, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertWithAlpha(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap source,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat format,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapStatics,
                ISoftwareBitmap,
                BitmapPixelFormat,
                BitmapAlphaMode,
                ISoftwareBitmap*,
                int>)((*lpVtbl)[8])
        )(this, source, format, alpha, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateCopyFromBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer source,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat format,
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapStatics,
                IBuffer,
                BitmapPixelFormat,
                int,
                int,
                ISoftwareBitmap*,
                int>)((*lpVtbl)[9])
        )(this, source, format, width, height, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateCopyWithAlphaFromBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer source,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat format,
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapStatics,
                IBuffer,
                BitmapPixelFormat,
                int,
                int,
                BitmapAlphaMode,
                ISoftwareBitmap*,
                int>)((*lpVtbl)[10])
        )(this, source, format, width, height, alpha, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateCopyFromSurfaceAsync(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
            IDirect3DSurface surface,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapStatics,
                IDirect3DSurface,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, surface, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCopyWithAlphaFromSurfaceAsync(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
            IDirect3DSurface surface,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapStatics,
                IDirect3DSurface,
                BitmapAlphaMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, surface, alpha, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Copy(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap source,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(7)]
        HRESULT Convert(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap source,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat format,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(8)]
        HRESULT ConvertWithAlpha(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap source,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat format,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alpha,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(9)]
        HRESULT CreateCopyFromBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer source,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat format,
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(10)]
        HRESULT CreateCopyWithAlphaFromBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer source,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat format,
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alpha,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(11)]
        HRESULT CreateCopyFromSurfaceAsync(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
                IDirect3DSurface surface,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT CreateCopyWithAlphaFromSurfaceAsync(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
                IDirect3DSurface surface,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alpha,
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
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISoftwareBitmap, ISoftwareBitmap*, int> Copy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISoftwareBitmap,
            BitmapPixelFormat,
            ISoftwareBitmap*,
            int> Convert;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISoftwareBitmap,
            BitmapPixelFormat,
            BitmapAlphaMode,
            ISoftwareBitmap*,
            int> ConvertWithAlpha;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, INT32, INT32, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            BitmapPixelFormat,
            int,
            int,
            ISoftwareBitmap*,
            int> CreateCopyFromBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, INT32, INT32, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            BitmapPixelFormat,
            int,
            int,
            BitmapAlphaMode,
            ISoftwareBitmap*,
            int> CreateCopyWithAlphaFromBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface,
            IAsyncOperation<IntPtr>**,
            int> CreateCopyFromSurfaceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface,
            BitmapAlphaMode,
            IAsyncOperation<IntPtr>**,
            int> CreateCopyWithAlphaFromSurfaceAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISoftwareBitmapStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISoftwareBitmapStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISoftwareBitmapStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmapStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ISoftwareBitmapStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmapStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmapStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISoftwareBitmapStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISoftwareBitmapStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmapStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ISoftwareBitmapStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmapStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmapStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISoftwareBitmapStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
