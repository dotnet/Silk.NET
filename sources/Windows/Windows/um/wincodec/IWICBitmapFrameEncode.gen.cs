// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode"]/*'/>
[Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
[NativeTypeName("struct IWICBitmapFrameEncode : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapFrameEncode : IWICBitmapFrameEncode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameEncode));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint> )(lpVtbl[1]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint> )(lpVtbl[2]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IPropertyBag2* pIEncoderOptions)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, IPropertyBag2*, int> )(lpVtbl[3]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIEncoderOptions);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.SetSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSize(uint uiWidth, uint uiHeight)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint, uint, int> )(lpVtbl[4]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), uiWidth, uiHeight);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.SetResolution"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetResolution(double dpiX, double dpiY)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, double, double, int> )(lpVtbl[5]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.SetPixelFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, Guid*, int> )(lpVtbl[6]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.SetColorContexts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetColorContexts(uint cCount, IWICColorContext** ppIColorContext)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint, IWICColorContext**, int> )(lpVtbl[7]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.SetPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICPalette*, int> )(lpVtbl[8]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.SetThumbnail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetThumbnail(IWICBitmapSource* pIThumbnail)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICBitmapSource*, int> )(lpVtbl[9]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIThumbnail);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.WritePixels"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int> )(lpVtbl[10]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, cbStride, cbBufferSize, pbPixels);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.WriteSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteSource(IWICBitmapSource* pIBitmapSource, WICRect* prc)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICBitmapSource*, WICRect*, int> )(lpVtbl[11]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIBitmapSource, prc);
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.Commit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, int> )(lpVtbl[12]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapFrameEncode.xml' path='doc/member[@name="IWICBitmapFrameEncode.GetMetadataQueryWriter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
    {
        return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int> )(lpVtbl[13]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IPropertyBag2* pIEncoderOptions);
        [VtblIndex(4)]
        HRESULT SetSize(uint uiWidth, uint uiHeight);
        [VtblIndex(5)]
        HRESULT SetResolution(double dpiX, double dpiY);
        [VtblIndex(6)]
        HRESULT SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);
        [VtblIndex(7)]
        HRESULT SetColorContexts(uint cCount, IWICColorContext** ppIColorContext);
        [VtblIndex(8)]
        HRESULT SetPalette(IWICPalette* pIPalette);
        [VtblIndex(9)]
        HRESULT SetThumbnail(IWICBitmapSource* pIThumbnail);
        [VtblIndex(10)]
        HRESULT WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels);
        [VtblIndex(11)]
        HRESULT WriteSource(IWICBitmapSource* pIBitmapSource, WICRect* prc);
        [VtblIndex(12)]
        HRESULT Commit();
        [VtblIndex(13)]
        HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter);
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
        [NativeTypeName("HRESULT (IPropertyBag2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyBag2*, int> Initialize;
        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetSize;
        [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, int> SetResolution;
        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetPixelFormat;
        [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICColorContext**, int> SetColorContexts;
        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette*, int> SetPalette;
        [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, int> SetThumbnail;
        [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, byte*, int> WritePixels;
        [NativeTypeName("HRESULT (IWICBitmapSource *, WICRect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, WICRect*, int> WriteSource;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;
        [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
    }
}