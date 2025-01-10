// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E4FBCF03-223D-4E81-9333-D635556DD1B5")]
[NativeTypeName("struct IWICBitmapClipper : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmapClipper : IWICBitmapClipper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapClipper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapClipper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICBitmapClipper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapClipper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICBitmapClipper, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            puiWidth,
            puiHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICBitmapClipper, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pPixelFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICBitmapClipper, double*, double*, int>)((*lpVtbl)[5]))(
            this,
            pDpiX,
            pDpiY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapClipper, IWICPalette, int>)((*lpVtbl)[6]))(
            this,
            pIPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels(
        [NativeTypeName("const WICRect *")] WICRect* prc,
        uint cbStride,
        uint cbBufferSize,
        byte* pbBuffer
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapClipper, WICRect*, uint, uint, byte*, int>)((*lpVtbl)[7])
        )(this, prc, cbStride, cbBufferSize, pbBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Initialize(
        IWICBitmapSource pISource,
        [NativeTypeName("const WICRect *")] WICRect* prc
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapClipper, IWICBitmapSource, WICRect*, int>)((*lpVtbl)[8])
        )(this, pISource, prc);
    }

    public interface Interface : IWICBitmapSource.Interface
    {
        [VtblIndex(8)]
        HRESULT Initialize(
            IWICBitmapSource pISource,
            [NativeTypeName("const WICRect *")] WICRect* prc
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

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, double*, int> GetResolution;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette, int> CopyPalette;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

        [NativeTypeName("HRESULT (IWICBitmapSource *, const WICRect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource, WICRect*, int> Initialize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICBitmapClipper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICBitmapClipper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICBitmapSource"/> to <see cref = "IWICBitmapClipper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICBitmapSource"/> instance to be converted </param>
    public static explicit operator IWICBitmapClipper(Silk.NET.Windows.IWICBitmapSource value)
    {
        return new IWICBitmapClipper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapClipper"/> to <see cref = "Silk.NET.Windows.IWICBitmapSource"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapClipper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICBitmapSource(IWICBitmapClipper value)
    {
        return new Silk.NET.Windows.IWICBitmapSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICBitmapClipper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICBitmapClipper(Silk.NET.Windows.IUnknown value)
    {
        return new IWICBitmapClipper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapClipper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapClipper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICBitmapClipper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
