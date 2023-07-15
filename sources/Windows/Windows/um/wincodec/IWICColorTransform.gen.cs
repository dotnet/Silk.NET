// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWICColorTransform.xml' path='doc/member[@name="IWICColorTransform"]/*'/>
[Guid("B66F034F-D0E2-40AB-B436-6DE39E321A94")]
[NativeTypeName("struct IWICColorTransform : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICColorTransform : IWICColorTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICColorTransform*, Guid*, void**, int> )(lpVtbl[0]))((IWICColorTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICColorTransform*, uint> )(lpVtbl[1]))((IWICColorTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICColorTransform*, uint> )(lpVtbl[2]))((IWICColorTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICColorTransform*, uint*, uint*, int> )(lpVtbl[3]))((IWICColorTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetPixelFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICColorTransform*, Guid*, int> )(lpVtbl[4]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetResolution"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICColorTransform*, double*, double*, int> )(lpVtbl[5]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
    }

    /// <inheritdoc cref = "IWICBitmapSource.CopyPalette"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICColorTransform*, IWICPalette*, int> )(lpVtbl[6]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <inheritdoc cref = "IWICBitmapSource.CopyPixels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICColorTransform*, WICRect*, uint, uint, byte*, int> )(lpVtbl[7]))((IWICColorTransform*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
    }

    /// <include file='IWICColorTransform.xml' path='doc/member[@name="IWICColorTransform.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFmtDest)
    {
        return ((delegate* unmanaged<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int> )(lpVtbl[8]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
    }

    public interface Interface : IWICBitmapSource.Interface
    {
        [VtblIndex(8)]
        HRESULT Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFmtDest);
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
        [NativeTypeName("HRESULT (IWICBitmapSource *, IWICColorContext *, IWICColorContext *, REFWICPixelFormatGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int> Initialize;
    }
}