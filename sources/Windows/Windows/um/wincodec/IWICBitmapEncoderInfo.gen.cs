// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICBitmapEncoderInfo.xml' path='doc/member[@name="IWICBitmapEncoderInfo"]/*'/>
[Guid("94C9B4EE-A09F-4F92-8A1E-4A9BCE7E76FB")]
[NativeTypeName("struct IWICBitmapEncoderInfo : IWICBitmapCodecInfo")]
[NativeInheritance("IWICBitmapCodecInfo")]
public unsafe partial struct IWICBitmapEncoderInfo : IWICBitmapEncoderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoderInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint> )(lpVtbl[1]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint> )(lpVtbl[2]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetComponentType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, WICComponentType*, int> )(lpVtbl[3]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pType);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetCLSID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, int> )(lpVtbl[4]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSigningStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint*, int> )(lpVtbl[5]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetAuthor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[6]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVendorGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, int> )(lpVtbl[7]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[8]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSpecVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[9]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetFriendlyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[10]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetContainerFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, int> )(lpVtbl[11]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetPixelFormats"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int> )(lpVtbl[12]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetColorManagementVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[13]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetDeviceManufacturer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[14]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetDeviceModels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[15]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetMimeTypes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[16]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.GetFileExtensions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int> )(lpVtbl[17]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportAnimation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DoesSupportAnimation(BOOL* pfSupportAnimation)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, BOOL*, int> )(lpVtbl[18]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportChromakey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DoesSupportChromakey(BOOL* pfSupportChromakey)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, BOOL*, int> )(lpVtbl[19]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportLossless"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DoesSupportLossless(BOOL* pfSupportLossless)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, BOOL*, int> )(lpVtbl[20]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.DoesSupportMultiframe"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DoesSupportMultiframe(BOOL* pfSupportMultiframe)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, BOOL*, int> )(lpVtbl[21]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
    }

    /// <inheritdoc cref = "IWICBitmapCodecInfo.MatchesMimeType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, BOOL* pfMatches)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, ushort*, BOOL*, int> )(lpVtbl[22]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
    }

    /// <include file='IWICBitmapEncoderInfo.xml' path='doc/member[@name="IWICBitmapEncoderInfo.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo*, IWICBitmapEncoder**, int> )(lpVtbl[23]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapEncoder);
    }

    public interface Interface : IWICBitmapCodecInfo.Interface
    {
        [VtblIndex(23)]
        HRESULT CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder);
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
        [NativeTypeName("HRESULT (IWICBitmapEncoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapEncoder**, int> CreateInstance;
    }
}