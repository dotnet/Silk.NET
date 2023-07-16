// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICBitmapSource.xml' path='doc/member[@name="IWICBitmapSource"]/*'/>
[Guid("00000120-A8F2-4877-BA0A-FD2B6645FB94")]
[NativeTypeName("struct IWICBitmapSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapSource : IWICBitmapSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapSource*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapSource*, uint> )(lpVtbl[1]))((IWICBitmapSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapSource*, uint> )(lpVtbl[2]))((IWICBitmapSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapSource.xml' path='doc/member[@name="IWICBitmapSource.GetSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICBitmapSource*, uint*, uint*, int> )(lpVtbl[3]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    /// <include file='IWICBitmapSource.xml' path='doc/member[@name="IWICBitmapSource.GetPixelFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICBitmapSource*, Guid*, int> )(lpVtbl[4]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    /// <include file='IWICBitmapSource.xml' path='doc/member[@name="IWICBitmapSource.GetResolution"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICBitmapSource*, double*, double*, int> )(lpVtbl[5]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
    }

    /// <include file='IWICBitmapSource.xml' path='doc/member[@name="IWICBitmapSource.CopyPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapSource*, IWICPalette*, int> )(lpVtbl[6]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <include file='IWICBitmapSource.xml' path='doc/member[@name="IWICBitmapSource.CopyPixels"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICBitmapSource*, WICRect*, uint, uint, byte*, int> )(lpVtbl[7]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSize(uint* puiWidth, uint* puiHeight);
        [VtblIndex(4)]
        HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);
        [VtblIndex(5)]
        HRESULT GetResolution(double* pDpiX, double* pDpiY);
        [VtblIndex(6)]
        HRESULT CopyPalette(IWICPalette* pIPalette);
        [VtblIndex(7)]
        HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer);
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
        public delegate* unmanaged<TSelf*, IWICPalette*, int> CopyPalette;
        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;
    }
}