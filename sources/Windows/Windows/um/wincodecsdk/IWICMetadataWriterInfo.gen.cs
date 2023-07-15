// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWICMetadataWriterInfo.xml' path='doc/member[@name="IWICMetadataWriterInfo"]/*'/>
[Guid("B22E3FBA-3925-4323-B5C1-9EBFC430F236")]
[NativeTypeName("struct IWICMetadataWriterInfo : IWICMetadataHandlerInfo")]
[NativeInheritance("IWICMetadataHandlerInfo")]
public unsafe partial struct IWICMetadataWriterInfo : IWICMetadataWriterInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataWriterInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, void**, int> )(lpVtbl[0]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint> )(lpVtbl[1]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint> )(lpVtbl[2]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetComponentType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, WICComponentType*, int> )(lpVtbl[3]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pType);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetCLSID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, int> )(lpVtbl[4]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSigningStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint*, int> )(lpVtbl[5]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetAuthor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> )(lpVtbl[6]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVendorGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, int> )(lpVtbl[7]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> )(lpVtbl[8]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSpecVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> )(lpVtbl[9]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetFriendlyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> )(lpVtbl[10]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.GetMetadataFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMetadataFormat(Guid* pguidMetadataFormat)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, int> )(lpVtbl[11]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.GetContainerFormats"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, Guid*, uint*, int> )(lpVtbl[12]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.GetDeviceManufacturer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> )(lpVtbl[13]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.GetDeviceModels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> )(lpVtbl[14]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.DoesRequireFullStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DoesRequireFullStream(BOOL* pfRequiresFullStream)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, BOOL*, int> )(lpVtbl[15]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.DoesSupportPadding"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DoesSupportPadding(BOOL* pfSupportsPadding)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, BOOL*, int> )(lpVtbl[16]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
    }

    /// <inheritdoc cref = "IWICMetadataHandlerInfo.DoesRequireFixedSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DoesRequireFixedSize(BOOL* pfFixedSize)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, BOOL*, int> )(lpVtbl[17]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
    }

    /// <include file='IWICMetadataWriterInfo.xml' path='doc/member[@name="IWICMetadataWriterInfo.GetHeader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataHeader* pHeader, uint* pcbActual)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, uint, WICMetadataHeader*, uint*, int> )(lpVtbl[18]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pHeader, pcbActual);
    }

    /// <include file='IWICMetadataWriterInfo.xml' path='doc/member[@name="IWICMetadataWriterInfo.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateInstance(IWICMetadataWriter** ppIWriter)
    {
        return ((delegate* unmanaged<IWICMetadataWriterInfo*, IWICMetadataWriter**, int> )(lpVtbl[19]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), ppIWriter);
    }

    public interface Interface : IWICMetadataHandlerInfo.Interface
    {
        [VtblIndex(18)]
        HRESULT GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataHeader* pHeader, uint* pcbActual);
        [VtblIndex(19)]
        HRESULT CreateInstance(IWICMetadataWriter** ppIWriter);
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
        public delegate* unmanaged<TSelf*, Guid*, int> GetMetadataFormat;
        [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, uint*, int> GetContainerFormats;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceManufacturer;
        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceModels;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesRequireFullStream;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportPadding;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesRequireFixedSize;
        [NativeTypeName("HRESULT (const GUID &, UINT, WICMetadataHeader *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, WICMetadataHeader*, uint*, int> GetHeader;
        [NativeTypeName("HRESULT (IWICMetadataWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataWriter**, int> CreateInstance;
    }
}