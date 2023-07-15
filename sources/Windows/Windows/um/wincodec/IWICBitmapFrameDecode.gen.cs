// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWICBitmapFrameDecode.xml' path='doc/member[@name="IWICBitmapFrameDecode"]/*'/>
[Guid("3B16811B-6A43-4EC9-A813-3D930C13B940")]
[NativeTypeName("struct IWICBitmapFrameDecode : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmapFrameDecode : IWICBitmapFrameDecode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameDecode));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint> )(lpVtbl[1]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint> )(lpVtbl[2]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint*, uint*, int> )(lpVtbl[3]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetPixelFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, Guid*, int> )(lpVtbl[4]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetResolution"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, double*, double*, int> )(lpVtbl[5]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
    }

    /// <inheritdoc cref = "IWICBitmapSource.CopyPalette"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, IWICPalette*, int> )(lpVtbl[6]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <inheritdoc cref = "IWICBitmapSource.CopyPixels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, WICRect*, uint, uint, byte*, int> )(lpVtbl[7]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
    }

    /// <include file='IWICBitmapFrameDecode.xml' path='doc/member[@name="IWICBitmapFrameDecode.GetMetadataQueryReader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int> )(lpVtbl[8]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
    }

    /// <include file='IWICBitmapFrameDecode.xml' path='doc/member[@name="IWICBitmapFrameDecode.GetColorContexts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int> )(lpVtbl[9]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
    }

    /// <include file='IWICBitmapFrameDecode.xml' path='doc/member[@name="IWICBitmapFrameDecode.GetThumbnail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetThumbnail(IWICBitmapSource** ppIThumbnail)
    {
        return ((delegate* unmanaged<IWICBitmapFrameDecode*, IWICBitmapSource**, int> )(lpVtbl[10]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIThumbnail);
    }

    public interface Interface : IWICBitmapSource.Interface
    {
        [VtblIndex(8)]
        HRESULT GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);
        [VtblIndex(9)]
        HRESULT GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);
        [VtblIndex(10)]
        HRESULT GetThumbnail(IWICBitmapSource** ppIThumbnail);
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
        [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;
        [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICColorContext**, uint*, int> GetColorContexts;
        [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource**, int> GetThumbnail;
    }
}