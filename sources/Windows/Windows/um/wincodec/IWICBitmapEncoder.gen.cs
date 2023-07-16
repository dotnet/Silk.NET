// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder"]/*'/>
[Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
[NativeTypeName("struct IWICBitmapEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapEncoder : IWICBitmapEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, uint> )(lpVtbl[1]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, uint> )(lpVtbl[2]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IStream*, WICBitmapEncoderCacheOption, int> )(lpVtbl[3]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIStream, cacheOption);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.GetContainerFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, Guid*, int> )(lpVtbl[4]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.GetEncoderInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEncoderInfo(IWICBitmapEncoderInfo** ppIEncoderInfo)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int> )(lpVtbl[5]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIEncoderInfo);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.SetColorContexts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetColorContexts(uint cCount, IWICColorContext** ppIColorContext)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, uint, IWICColorContext**, int> )(lpVtbl[6]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.SetPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IWICPalette*, int> )(lpVtbl[7]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.SetThumbnail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetThumbnail(IWICBitmapSource* pIThumbnail)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IWICBitmapSource*, int> )(lpVtbl[8]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIThumbnail);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.SetPreview"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPreview(IWICBitmapSource* pIPreview)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IWICBitmapSource*, int> )(lpVtbl[9]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPreview);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.CreateNewFrame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IWICBitmapFrameEncode**, IPropertyBag2**, int> )(lpVtbl[10]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, ppIEncoderOptions);
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.Commit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, int> )(lpVtbl[11]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapEncoder.xml' path='doc/member[@name="IWICBitmapEncoder.GetMetadataQueryWriter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
    {
        return ((delegate* unmanaged<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int> )(lpVtbl[12]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IStream* pIStream, WICBitmapEncoderCacheOption cacheOption);
        [VtblIndex(4)]
        HRESULT GetContainerFormat(Guid* pguidContainerFormat);
        [VtblIndex(5)]
        HRESULT GetEncoderInfo(IWICBitmapEncoderInfo** ppIEncoderInfo);
        [VtblIndex(6)]
        HRESULT SetColorContexts(uint cCount, IWICColorContext** ppIColorContext);
        [VtblIndex(7)]
        HRESULT SetPalette(IWICPalette* pIPalette);
        [VtblIndex(8)]
        HRESULT SetThumbnail(IWICBitmapSource* pIThumbnail);
        [VtblIndex(9)]
        HRESULT SetPreview(IWICBitmapSource* pIPreview);
        [VtblIndex(10)]
        HRESULT CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions);
        [VtblIndex(11)]
        HRESULT Commit();
        [VtblIndex(12)]
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
        [NativeTypeName("HRESULT (IStream *, WICBitmapEncoderCacheOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, WICBitmapEncoderCacheOption, int> Initialize;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerFormat;
        [NativeTypeName("HRESULT (IWICBitmapEncoderInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapEncoderInfo**, int> GetEncoderInfo;
        [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICColorContext**, int> SetColorContexts;
        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette*, int> SetPalette;
        [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, int> SetThumbnail;
        [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, int> SetPreview;
        [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, IPropertyBag2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapFrameEncode**, IPropertyBag2**, int> CreateNewFrame;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;
        [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
    }
}