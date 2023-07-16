// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICPixelFormatInfo.xml' path='doc/member[@name="IWICPixelFormatInfo"]/*'/>
[Guid("E8EDA601-3D48-431A-AB44-69059BE88BBE")]
[NativeTypeName("struct IWICPixelFormatInfo : IWICComponentInfo")]
[NativeInheritance("IWICComponentInfo")]
public unsafe partial struct IWICPixelFormatInfo : IWICPixelFormatInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, Guid*, void**, int> )(lpVtbl[0]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint> )(lpVtbl[1]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint> )(lpVtbl[2]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetComponentType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, WICComponentType*, int> )(lpVtbl[3]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pType);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetCLSID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, Guid*, int> )(lpVtbl[4]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSigningStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint*, int> )(lpVtbl[5]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetAuthor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint, ushort*, uint*, int> )(lpVtbl[6]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVendorGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, Guid*, int> )(lpVtbl[7]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pguidVendor);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint, ushort*, uint*, int> )(lpVtbl[8]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSpecVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint, ushort*, uint*, int> )(lpVtbl[9]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetFriendlyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint, ushort*, uint*, int> )(lpVtbl[10]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
    }

    /// <include file='IWICPixelFormatInfo.xml' path='doc/member[@name="IWICPixelFormatInfo.GetFormatGUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFormatGUID(Guid* pFormat)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, Guid*, int> )(lpVtbl[11]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pFormat);
    }

    /// <include file='IWICPixelFormatInfo.xml' path='doc/member[@name="IWICPixelFormatInfo.GetColorContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetColorContext(IWICColorContext** ppIColorContext)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, IWICColorContext**, int> )(lpVtbl[12]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), ppIColorContext);
    }

    /// <include file='IWICPixelFormatInfo.xml' path='doc/member[@name="IWICPixelFormatInfo.GetBitsPerPixel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBitsPerPixel(uint* puiBitsPerPixel)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint*, int> )(lpVtbl[13]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
    }

    /// <include file='IWICPixelFormatInfo.xml' path='doc/member[@name="IWICPixelFormatInfo.GetChannelCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetChannelCount(uint* puiChannelCount)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint*, int> )(lpVtbl[14]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiChannelCount);
    }

    /// <include file='IWICPixelFormatInfo.xml' path='doc/member[@name="IWICPixelFormatInfo.GetChannelMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo*, uint, uint, byte*, uint*, int> )(lpVtbl[15]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
    }

    public interface Interface : IWICComponentInfo.Interface
    {
        [VtblIndex(11)]
        HRESULT GetFormatGUID(Guid* pFormat);
        [VtblIndex(12)]
        HRESULT GetColorContext(IWICColorContext** ppIColorContext);
        [VtblIndex(13)]
        HRESULT GetBitsPerPixel(uint* puiBitsPerPixel);
        [VtblIndex(14)]
        HRESULT GetChannelCount(uint* puiChannelCount);
        [VtblIndex(15)]
        HRESULT GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual);
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
        public delegate* unmanaged<TSelf*, Guid*, int> GetFormatGUID;
        [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorContext**, int> GetColorContext;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBitsPerPixel;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;
        [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, int> GetChannelMask;
    }
}