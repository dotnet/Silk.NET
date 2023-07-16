// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo"]/*'/>
[Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
[NativeTypeName("struct IWICBitmapDecoderInfo : IWICBitmapCodecInfo")]
[NativeInheritance("IWICBitmapCodecInfo")]
public unsafe partial struct IWICBitmapDecoderInfo : IWICBitmapDecoderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoderInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint> )(lpVtbl[1]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint> )(lpVtbl[2]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetComponentType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, WICComponentType*, int> )(lpVtbl[3]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pType);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetCLSID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, Guid*, int> )(lpVtbl[4]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSigningStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint*, int> )(lpVtbl[5]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetAuthor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[6]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVendorGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, Guid*, int> )(lpVtbl[7]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[8]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSpecVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[9]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetFriendlyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[10]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetContainerFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, Guid*, int> )(lpVtbl[11]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetPixelFormats"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int> )(lpVtbl[12]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetColorManagementVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[13]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetDeviceManufacturer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[14]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetDeviceModels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[15]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetMimeTypes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[16]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetFileExtensions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[17]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportAnimation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DoesSupportAnimation(BOOL* pfSupportAnimation)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, BOOL*, int> )(lpVtbl[18]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportChromakey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DoesSupportChromakey(BOOL* pfSupportChromakey)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, BOOL*, int> )(lpVtbl[19]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportLossless"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DoesSupportLossless(BOOL* pfSupportLossless)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, BOOL*, int> )(lpVtbl[20]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportMultiframe"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DoesSupportMultiframe(BOOL* pfSupportMultiframe)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, BOOL*, int> )(lpVtbl[21]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.MatchesMimeType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, BOOL* pfMatches)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, ushort*, BOOL*, int> )(lpVtbl[22]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
    }

    /// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo.GetPatterns"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, uint, WICBitmapPattern*, uint*, uint*, int> )(lpVtbl[23]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
    }

    /// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo.MatchesPattern"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT MatchesPattern(IStream* pIStream, BOOL* pfMatches)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, IStream*, BOOL*, int> )(lpVtbl[24]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pIStream, pfMatches);
    }

    /// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder)
    {
        return ((delegate* unmanaged<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int> )(lpVtbl[25]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapDecoder);
    }

    public interface Interface : IWICBitmapCodecInfo.Interface
    {
        [VtblIndex(23)]
        HRESULT GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual);
        [VtblIndex(24)]
        HRESULT MatchesPattern(IStream* pIStream, BOOL* pfMatches);
        [VtblIndex(25)]
        HRESULT CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder);
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
        [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICComponentType*, int> GetComponentType;
        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetCLSID;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSigningStatus;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetAuthor;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetVendorGUID;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetVersion;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetSpecVersion;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetFriendlyName;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerFormat;
        [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetColorManagementVersion;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceManufacturer;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceModels;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetMimeTypes;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetFileExtensions;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportAnimation;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportChromakey;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportLossless;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportMultiframe;
        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> MatchesMimeType;
        [NativeTypeName("HRESULT (UINT, WICBitmapPattern *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WICBitmapPattern*, uint*, uint*, int> GetPatterns;
        [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, BOOL*, int> MatchesPattern;
        [NativeTypeName("HRESULT (IWICBitmapDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapDecoder**, int> CreateInstance;
    }
}