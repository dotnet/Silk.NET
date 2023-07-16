// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader"]/*'/>
[Guid("4E1BD148-55A0-4480-A3D1-15544710637C")]
[NativeTypeName("struct IAppxManifestReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestReader : IAppxManifestReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestReader*, uint> )(lpVtbl[1]))((IAppxManifestReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestReader*, uint> )(lpVtbl[2]))((IAppxManifestReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetPackageId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageId(IAppxManifestPackageId** packageId)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IAppxManifestPackageId**, int> )(lpVtbl[3]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), packageId);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(IAppxManifestProperties** packageProperties)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IAppxManifestProperties**, int> )(lpVtbl[4]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), packageProperties);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetPackageDependencies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPackageDependencies(IAppxManifestPackageDependenciesEnumerator** dependencies)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IAppxManifestPackageDependenciesEnumerator**, int> )(lpVtbl[5]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), dependencies);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCapabilities(APPX_CAPABILITIES* capabilities)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, APPX_CAPABILITIES*, int> )(lpVtbl[6]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), capabilities);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResources(IAppxManifestResourcesEnumerator** resources)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IAppxManifestResourcesEnumerator**, int> )(lpVtbl[7]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), resources);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetDeviceCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceCapabilities(IAppxManifestDeviceCapabilitiesEnumerator** deviceCapabilities)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IAppxManifestDeviceCapabilitiesEnumerator**, int> )(lpVtbl[8]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), deviceCapabilities);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetPrerequisite"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrerequisite([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, ushort*, ulong*, int> )(lpVtbl[9]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetApplications"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetApplications(IAppxManifestApplicationsEnumerator** applications)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IAppxManifestApplicationsEnumerator**, int> )(lpVtbl[10]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), applications);
    }

    /// <include file='IAppxManifestReader.xml' path='doc/member[@name="IAppxManifestReader.GetStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStream(IStream** manifestStream)
    {
        return ((delegate* unmanaged<IAppxManifestReader*, IStream**, int> )(lpVtbl[11]))((IAppxManifestReader*)Unsafe.AsPointer(ref this), manifestStream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageId(IAppxManifestPackageId** packageId);
        [VtblIndex(4)]
        HRESULT GetProperties(IAppxManifestProperties** packageProperties);
        [VtblIndex(5)]
        HRESULT GetPackageDependencies(IAppxManifestPackageDependenciesEnumerator** dependencies);
        [VtblIndex(6)]
        HRESULT GetCapabilities(APPX_CAPABILITIES* capabilities);
        [VtblIndex(7)]
        HRESULT GetResources(IAppxManifestResourcesEnumerator** resources);
        [VtblIndex(8)]
        HRESULT GetDeviceCapabilities(IAppxManifestDeviceCapabilitiesEnumerator** deviceCapabilities);
        [VtblIndex(9)]
        HRESULT GetPrerequisite([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT64 *")] ulong* value);
        [VtblIndex(10)]
        HRESULT GetApplications(IAppxManifestApplicationsEnumerator** applications);
        [VtblIndex(11)]
        HRESULT GetStream(IStream** manifestStream);
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
        [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageId**, int> GetPackageId;
        [NativeTypeName("HRESULT (IAppxManifestProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestProperties**, int> GetProperties;
        [NativeTypeName("HRESULT (IAppxManifestPackageDependenciesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageDependenciesEnumerator**, int> GetPackageDependencies;
        [NativeTypeName("HRESULT (APPX_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_CAPABILITIES*, int> GetCapabilities;
        [NativeTypeName("HRESULT (IAppxManifestResourcesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestResourcesEnumerator**, int> GetResources;
        [NativeTypeName("HRESULT (IAppxManifestDeviceCapabilitiesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestDeviceCapabilitiesEnumerator**, int> GetDeviceCapabilities;
        [NativeTypeName("HRESULT (LPCWSTR, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong*, int> GetPrerequisite;
        [NativeTypeName("HRESULT (IAppxManifestApplicationsEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestApplicationsEnumerator**, int> GetApplications;
        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, int> GetStream;
    }
}