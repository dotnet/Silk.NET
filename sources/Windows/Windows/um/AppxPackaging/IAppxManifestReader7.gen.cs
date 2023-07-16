// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxManifestReader7.xml' path='doc/member[@name="IAppxManifestReader7"]/*'/>
[Guid("8EFE6F27-0CE0-4988-B32D-738EB63DB3B7")]
[NativeTypeName("struct IAppxManifestReader7 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestReader7 : IAppxManifestReader7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestReader7));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestReader7*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestReader7*, uint> )(lpVtbl[1]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestReader7*, uint> )(lpVtbl[2]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestReader7.xml' path='doc/member[@name="IAppxManifestReader7.GetDriverDependencies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDriverDependencies(IAppxManifestDriverDependenciesEnumerator** driverDependencies)
    {
        return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestDriverDependenciesEnumerator**, int> )(lpVtbl[3]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), driverDependencies);
    }

    /// <include file='IAppxManifestReader7.xml' path='doc/member[@name="IAppxManifestReader7.GetOSPackageDependencies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOSPackageDependencies(IAppxManifestOSPackageDependenciesEnumerator** osPackageDependencies)
    {
        return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestOSPackageDependenciesEnumerator**, int> )(lpVtbl[4]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), osPackageDependencies);
    }

    /// <include file='IAppxManifestReader7.xml' path='doc/member[@name="IAppxManifestReader7.GetHostRuntimeDependencies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHostRuntimeDependencies(IAppxManifestHostRuntimeDependenciesEnumerator** hostRuntimeDependencies)
    {
        return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestHostRuntimeDependenciesEnumerator**, int> )(lpVtbl[5]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), hostRuntimeDependencies);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDriverDependencies(IAppxManifestDriverDependenciesEnumerator** driverDependencies);
        [VtblIndex(4)]
        HRESULT GetOSPackageDependencies(IAppxManifestOSPackageDependenciesEnumerator** osPackageDependencies);
        [VtblIndex(5)]
        HRESULT GetHostRuntimeDependencies(IAppxManifestHostRuntimeDependenciesEnumerator** hostRuntimeDependencies);
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
        [NativeTypeName("HRESULT (IAppxManifestDriverDependenciesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestDriverDependenciesEnumerator**, int> GetDriverDependencies;
        [NativeTypeName("HRESULT (IAppxManifestOSPackageDependenciesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestOSPackageDependenciesEnumerator**, int> GetOSPackageDependencies;
        [NativeTypeName("HRESULT (IAppxManifestHostRuntimeDependenciesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestHostRuntimeDependenciesEnumerator**, int> GetHostRuntimeDependencies;
    }
}