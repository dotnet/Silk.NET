// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo"]/*'/>
[Guid("54CD06C1-268F-40BB-8ED2-757A9EBAEC8D")]
[NativeTypeName("struct IAppxBundleManifestPackageInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IAppxBundleManifestPackageInfo : IAppxBundleManifestPackageInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestPackageInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint> )(lpVtbl[1]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint> )(lpVtbl[2]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo.GetPackageType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageType(APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE* packageType)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE*, int> )(lpVtbl[3]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), packageType);
    }

    /// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo.GetPackageId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPackageId(IAppxManifestPackageId** packageId)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestPackageId**, int> )(lpVtbl[4]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), packageId);
    }

    /// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo.GetFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ushort**, int> )(lpVtbl[5]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), fileName);
    }

    /// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo.GetOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOffset([NativeTypeName("UINT64 *")] ulong* offset)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int> )(lpVtbl[6]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), offset);
    }

    /// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo.GetSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int> )(lpVtbl[7]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), size);
    }

    /// <include file='IAppxBundleManifestPackageInfo.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo.GetResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetResources(IAppxManifestQualifiedResourcesEnumerator** resources)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestQualifiedResourcesEnumerator**, int> )(lpVtbl[8]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), resources);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageType(APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE* packageType);
        [VtblIndex(4)]
        HRESULT GetPackageId(IAppxManifestPackageId** packageId);
        [VtblIndex(5)]
        HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName);
        [VtblIndex(6)]
        HRESULT GetOffset([NativeTypeName("UINT64 *")] ulong* offset);
        [VtblIndex(7)]
        HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size);
        [VtblIndex(8)]
        HRESULT GetResources(IAppxManifestQualifiedResourcesEnumerator** resources);
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
        [NativeTypeName("HRESULT (APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE*, int> GetPackageType;
        [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageId**, int> GetPackageId;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetFileName;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetOffset;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetSize;
        [NativeTypeName("HRESULT (IAppxManifestQualifiedResourcesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestQualifiedResourcesEnumerator**, int> GetResources;
    }
}