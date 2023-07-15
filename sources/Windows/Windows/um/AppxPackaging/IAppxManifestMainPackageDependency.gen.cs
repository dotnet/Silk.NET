// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestMainPackageDependency.xml' path='doc/member[@name="IAppxManifestMainPackageDependency"]/*'/>
[Guid("05D0611C-BC29-46D5-97E2-84B9C79BD8AE")]
[NativeTypeName("struct IAppxManifestMainPackageDependency : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxManifestMainPackageDependency : IAppxManifestMainPackageDependency.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestMainPackageDependency));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, uint> )(lpVtbl[1]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, uint> )(lpVtbl[2]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestMainPackageDependency.xml' path='doc/member[@name="IAppxManifestMainPackageDependency.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, ushort**, int> )(lpVtbl[3]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppxManifestMainPackageDependency.xml' path='doc/member[@name="IAppxManifestMainPackageDependency.GetPublisher"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, ushort**, int> )(lpVtbl[4]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), publisher);
    }

    /// <include file='IAppxManifestMainPackageDependency.xml' path='doc/member[@name="IAppxManifestMainPackageDependency.GetPackageFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, ushort**, int> )(lpVtbl[5]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), packageFamilyName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);
        [VtblIndex(4)]
        HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher);
        [VtblIndex(5)]
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPublisher;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPackageFamilyName;
    }
}