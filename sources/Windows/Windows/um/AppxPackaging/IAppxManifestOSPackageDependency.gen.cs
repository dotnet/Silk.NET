// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxManifestOSPackageDependency.xml' path='doc/member[@name="IAppxManifestOSPackageDependency"]/*' />
[Guid("154995EE-54A6-4F14-AC97-D8CF0519644B")]
[NativeTypeName("struct IAppxManifestOSPackageDependency : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestOSPackageDependency : IAppxManifestOSPackageDependency.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestOSPackageDependency));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, uint>)(lpVtbl[1]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, uint>)(lpVtbl[2]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestOSPackageDependency.xml' path='doc/member[@name="IAppxManifestOSPackageDependency.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, ushort**, int>)(lpVtbl[3]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppxManifestOSPackageDependency.xml' path='doc/member[@name="IAppxManifestOSPackageDependency.GetVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetVersion([NativeTypeName("UINT64 *")] ulong* version)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, ulong*, int>)(lpVtbl[4]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this), version);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

        [VtblIndex(4)]
        HRESULT GetVersion([NativeTypeName("UINT64 *")] ulong* version);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetVersion;
    }
}
