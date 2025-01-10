// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AB2A556F-6111-4B33-8EC3-2B209A02E17A")]
[NativeTypeName("struct IVideoFrameStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoFrameStatics : IVideoFrameStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoFrameStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoFrameStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoFrameStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoFrameStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVideoFrameStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoFrameStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoFrameStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAsDirect3D11SurfaceBacked(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
            DirectXPixelFormat format,
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
    )
    {
        return (
            (delegate* unmanaged<
                IVideoFrameStatics,
                DirectXPixelFormat,
                int,
                int,
                IVideoFrame*,
                int>)((*lpVtbl)[6])
        )(this, format, width, height, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAsDirect3D11SurfaceBackedWithDevice(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
            DirectXPixelFormat format,
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")]
            IDirect3DDevice device,
        [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
    )
    {
        return (
            (delegate* unmanaged<
                IVideoFrameStatics,
                DirectXPixelFormat,
                int,
                int,
                IDirect3DDevice,
                IVideoFrame*,
                int>)((*lpVtbl)[7])
        )(this, format, width, height, device, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithSoftwareBitmap(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap bitmap,
        [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
    )
    {
        return (
            (delegate* unmanaged<IVideoFrameStatics, ISoftwareBitmap, IVideoFrame*, int>)(
                (*lpVtbl)[8]
            )
        )(this, bitmap, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateWithDirect3D11Surface(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
            IDirect3DSurface surface,
        [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
    )
    {
        return (
            (delegate* unmanaged<IVideoFrameStatics, IDirect3DSurface, IVideoFrame*, int>)(
                (*lpVtbl)[9]
            )
        )(this, surface, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAsDirect3D11SurfaceBacked(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
                DirectXPixelFormat format,
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
        );

        [VtblIndex(7)]
        HRESULT CreateAsDirect3D11SurfaceBackedWithDevice(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
                DirectXPixelFormat format,
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")]
                IDirect3DDevice device,
            [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
        );

        [VtblIndex(8)]
        HRESULT CreateWithSoftwareBitmap(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap bitmap,
            [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
        );

        [VtblIndex(9)]
        HRESULT CreateWithDirect3D11Surface(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
                IDirect3DSurface surface,
            [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* result
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
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat, INT32, INT32, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DirectXPixelFormat,
            int,
            int,
            IVideoFrame*,
            int> CreateAsDirect3D11SurfaceBacked;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat, INT32, INT32, ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DirectXPixelFormat,
            int,
            int,
            IDirect3DDevice,
            IVideoFrame*,
            int> CreateAsDirect3D11SurfaceBackedWithDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISoftwareBitmap,
            IVideoFrame*,
            int> CreateWithSoftwareBitmap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface,
            IVideoFrame*,
            int> CreateWithDirect3D11Surface;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoFrameStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoFrameStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoFrameStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoFrameStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IVideoFrameStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoFrameStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoFrameStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVideoFrameStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoFrameStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoFrameStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoFrameStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoFrameStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoFrameStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoFrameStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
