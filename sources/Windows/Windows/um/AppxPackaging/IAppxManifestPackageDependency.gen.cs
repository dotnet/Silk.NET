// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestPackageDependency.xml' path='doc/member[@name="IAppxManifestPackageDependency"]/*'/>
[Guid("E4946B59-733E-43F0-A724-3BDE4C1285A0")]
[NativeTypeName("struct IAppxManifestPackageDependency : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestPackageDependency : IAppxManifestPackageDependency.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestPackageDependency));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestPackageDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency*, uint> )(lpVtbl[1]))((IAppxManifestPackageDependency*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency*, uint> )(lpVtbl[2]))((IAppxManifestPackageDependency*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestPackageDependency.xml' path='doc/member[@name="IAppxManifestPackageDependency.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency*, ushort**, int> )(lpVtbl[3]))((IAppxManifestPackageDependency*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppxManifestPackageDependency.xml' path='doc/member[@name="IAppxManifestPackageDependency.GetPublisher"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency*, ushort**, int> )(lpVtbl[4]))((IAppxManifestPackageDependency*)Unsafe.AsPointer(ref this), publisher);
    }

    /// <include file='IAppxManifestPackageDependency.xml' path='doc/member[@name="IAppxManifestPackageDependency.GetMinVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency*, ulong*, int> )(lpVtbl[5]))((IAppxManifestPackageDependency*)Unsafe.AsPointer(ref this), minVersion);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);
        [VtblIndex(4)]
        HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher);
        [VtblIndex(5)]
        HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPublisher;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMinVersion;
    }
}