// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo"]/*'/>
[Guid("ABA958BF-C672-44D1-8D61-CE6DF2E682C2")]
[NativeTypeName("struct IWICMetadataHandlerInfo : IWICComponentInfo")]
[NativeInheritance("IWICComponentInfo")]
public unsafe partial struct IWICMetadataHandlerInfo : IWICMetadataHandlerInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataHandlerInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, Guid*, void**, int> )(lpVtbl[0]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint> )(lpVtbl[1]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint> )(lpVtbl[2]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetComponentType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, WICComponentType*, int> )(lpVtbl[3]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pType);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetCLSID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, Guid*, int> )(lpVtbl[4]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSigningStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint*, int> )(lpVtbl[5]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetAuthor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int> )(lpVtbl[6]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVendorGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, Guid*, int> )(lpVtbl[7]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pguidVendor);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int> )(lpVtbl[8]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetSpecVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int> )(lpVtbl[9]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
    }

    /// <inheritdoc cref = "IWICComponentInfo.GetFriendlyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int> )(lpVtbl[10]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.GetMetadataFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMetadataFormat(Guid* pguidMetadataFormat)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, Guid*, int> )(lpVtbl[11]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.GetContainerFormats"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, Guid*, uint*, int> )(lpVtbl[12]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.GetDeviceManufacturer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int> )(lpVtbl[13]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.GetDeviceModels"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, uint, ushort*, uint*, int> )(lpVtbl[14]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.DoesRequireFullStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DoesRequireFullStream(BOOL* pfRequiresFullStream)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, BOOL*, int> )(lpVtbl[15]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.DoesSupportPadding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DoesSupportPadding(BOOL* pfSupportsPadding)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, BOOL*, int> )(lpVtbl[16]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
    }

    /// <include file='IWICMetadataHandlerInfo.xml' path='doc/member[@name="IWICMetadataHandlerInfo.DoesRequireFixedSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DoesRequireFixedSize(BOOL* pfFixedSize)
    {
        return ((delegate* unmanaged<IWICMetadataHandlerInfo*, BOOL*, int> )(lpVtbl[17]))((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
    }

    public interface Interface : IWICComponentInfo.Interface
    {
        [VtblIndex(11)]
        HRESULT GetMetadataFormat(Guid* pguidMetadataFormat);
        [VtblIndex(12)]
        HRESULT GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual);
        [VtblIndex(13)]
        HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual);
        [VtblIndex(14)]
        HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual);
        [VtblIndex(15)]
        HRESULT DoesRequireFullStream(BOOL* pfRequiresFullStream);
        [VtblIndex(16)]
        HRESULT DoesSupportPadding(BOOL* pfSupportsPadding);
        [VtblIndex(17)]
        HRESULT DoesRequireFixedSize(BOOL* pfFixedSize);
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
    }
}