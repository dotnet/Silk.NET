// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestPackageId2.xml' path='doc/member[@name="IAppxManifestPackageId2"]/*'/>
[Guid("2256999D-D617-42F1-880E-0BA4542319D5")]
[NativeTypeName("struct IAppxManifestPackageId2 : IAppxManifestPackageId")]
[NativeInheritance("IAppxManifestPackageId")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxManifestPackageId2 : IAppxManifestPackageId2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestPackageId2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, uint> )(lpVtbl[1]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, uint> )(lpVtbl[2]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int> )(lpVtbl[3]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetArchitecture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetArchitecture(APPX_PACKAGE_ARCHITECTURE* architecture)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, APPX_PACKAGE_ARCHITECTURE*, int> )(lpVtbl[4]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), architecture);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetPublisher"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int> )(lpVtbl[5]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), publisher);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetVersion([NativeTypeName("UINT64 *")] ulong* packageVersion)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ulong*, int> )(lpVtbl[6]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), packageVersion);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetResourceId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResourceId([NativeTypeName("LPWSTR *")] ushort** resourceId)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int> )(lpVtbl[7]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), resourceId);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.ComparePublisher"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ComparePublisher([NativeTypeName("LPCWSTR")] ushort* other, BOOL* isSame)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort*, BOOL*, int> )(lpVtbl[8]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), other, isSame);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetPackageFullName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPackageFullName([NativeTypeName("LPWSTR *")] ushort** packageFullName)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int> )(lpVtbl[9]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IAppxManifestPackageId.GetPackageFamilyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int> )(lpVtbl[10]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), packageFamilyName);
    }

    /// <include file='IAppxManifestPackageId2.xml' path='doc/member[@name="IAppxManifestPackageId2.GetArchitecture2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArchitecture2(APPX_PACKAGE_ARCHITECTURE2* architecture)
    {
        return ((delegate* unmanaged<IAppxManifestPackageId2*, APPX_PACKAGE_ARCHITECTURE2*, int> )(lpVtbl[11]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), architecture);
    }

    public interface Interface : IAppxManifestPackageId.Interface
    {
        [VtblIndex(11)]
        HRESULT GetArchitecture2(APPX_PACKAGE_ARCHITECTURE2* architecture);
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
        [NativeTypeName("HRESULT (APPX_PACKAGE_ARCHITECTURE2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_PACKAGE_ARCHITECTURE2*, int> GetArchitecture2;
    }
}