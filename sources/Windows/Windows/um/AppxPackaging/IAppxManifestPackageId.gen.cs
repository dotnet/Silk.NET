// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId"]/*'/>
[Guid("283CE2D7-7153-4A91-9649-7A0F7240945F")]
[NativeTypeName("struct IAppxManifestPackageId : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestPackageId : IAppxManifestPackageId.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestPackageId));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, uint> )(lpVtbl[1]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, uint> )(lpVtbl[2]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int> )(lpVtbl[3]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetArchitecture"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetArchitecture(APPX_PACKAGE_ARCHITECTURE* architecture)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, APPX_PACKAGE_ARCHITECTURE*, int> )(lpVtbl[4]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), architecture);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetPublisher"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int> )(lpVtbl[5]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), publisher);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetVersion([NativeTypeName("UINT64 *")] ulong* packageVersion)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ulong*, int> )(lpVtbl[6]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), packageVersion);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetResourceId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResourceId([NativeTypeName("LPWSTR *")] ushort** resourceId)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int> )(lpVtbl[7]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), resourceId);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.ComparePublisher"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ComparePublisher([NativeTypeName("LPCWSTR")] ushort* other, BOOL* isSame)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ushort*, BOOL*, int> )(lpVtbl[8]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), other, isSame);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetPackageFullName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPackageFullName([NativeTypeName("LPWSTR *")] ushort** packageFullName)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int> )(lpVtbl[9]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IAppxManifestPackageId.xml' path='doc/member[@name="IAppxManifestPackageId.GetPackageFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int> )(lpVtbl[10]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), packageFamilyName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);
        [VtblIndex(4)]
        HRESULT GetArchitecture(APPX_PACKAGE_ARCHITECTURE* architecture);
        [VtblIndex(5)]
        HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher);
        [VtblIndex(6)]
        HRESULT GetVersion([NativeTypeName("UINT64 *")] ulong* packageVersion);
        [VtblIndex(7)]
        HRESULT GetResourceId([NativeTypeName("LPWSTR *")] ushort** resourceId);
        [VtblIndex(8)]
        HRESULT ComparePublisher([NativeTypeName("LPCWSTR")] ushort* other, BOOL* isSame);
        [VtblIndex(9)]
        HRESULT GetPackageFullName([NativeTypeName("LPWSTR *")] ushort** packageFullName);
        [VtblIndex(10)]
        HRESULT GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;
        [NativeTypeName("HRESULT (APPX_PACKAGE_ARCHITECTURE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_PACKAGE_ARCHITECTURE*, int> GetArchitecture;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPublisher;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetVersion;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetResourceId;
        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> ComparePublisher;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPackageFullName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPackageFamilyName;
    }
}