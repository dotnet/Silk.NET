// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestDriverDependency.xml' path='doc/member[@name="IAppxManifestDriverDependency"]/*'/>
[Guid("1210CB94-5A92-4602-BE24-79F318AF4AF9")]
[NativeTypeName("struct IAppxManifestDriverDependency : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestDriverDependency : IAppxManifestDriverDependency.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestDriverDependency));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestDriverDependency*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestDriverDependency*, uint> )(lpVtbl[1]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestDriverDependency*, uint> )(lpVtbl[2]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestDriverDependency.xml' path='doc/member[@name="IAppxManifestDriverDependency.GetDriverConstraints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDriverConstraints(IAppxManifestDriverConstraintsEnumerator** driverConstraints)
    {
        return ((delegate* unmanaged<IAppxManifestDriverDependency*, IAppxManifestDriverConstraintsEnumerator**, int> )(lpVtbl[3]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this), driverConstraints);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDriverConstraints(IAppxManifestDriverConstraintsEnumerator** driverConstraints);
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
        [NativeTypeName("HRESULT (IAppxManifestDriverConstraintsEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestDriverConstraintsEnumerator**, int> GetDriverConstraints;
    }
}