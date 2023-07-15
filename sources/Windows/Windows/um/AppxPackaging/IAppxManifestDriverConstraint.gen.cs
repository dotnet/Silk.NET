// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestDriverConstraint.xml' path='doc/member[@name="IAppxManifestDriverConstraint"]/*'/>
[Guid("C031BEE4-BBCC-48EA-A237-C34045C80A07")]
[NativeTypeName("struct IAppxManifestDriverConstraint : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestDriverConstraint : IAppxManifestDriverConstraint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestDriverConstraint));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraint*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraint*, uint> )(lpVtbl[1]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraint*, uint> )(lpVtbl[2]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestDriverConstraint.xml' path='doc/member[@name="IAppxManifestDriverConstraint.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraint*, ushort**, int> )(lpVtbl[3]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppxManifestDriverConstraint.xml' path='doc/member[@name="IAppxManifestDriverConstraint.GetMinVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraint*, ulong*, int> )(lpVtbl[4]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), minVersion);
    }

    /// <include file='IAppxManifestDriverConstraint.xml' path='doc/member[@name="IAppxManifestDriverConstraint.GetMinDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMinDate([NativeTypeName("LPWSTR *")] ushort** minDate)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraint*, ushort**, int> )(lpVtbl[5]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), minDate);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);
        [VtblIndex(4)]
        HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion);
        [VtblIndex(5)]
        HRESULT GetMinDate([NativeTypeName("LPWSTR *")] ushort** minDate);
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
        public delegate* unmanaged<TSelf*, ulong*, int> GetMinVersion;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMinDate;
    }
}