// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxManifestHostRuntimeDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestHostRuntimeDependenciesEnumerator"]/*' />
[Guid("6427A646-7F49-433E-B1A6-0DA309F6885A")]
[NativeTypeName("struct IAppxManifestHostRuntimeDependenciesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestHostRuntimeDependenciesEnumerator : IAppxManifestHostRuntimeDependenciesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestHostRuntimeDependenciesEnumerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestHostRuntimeDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestHostRuntimeDependenciesEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestHostRuntimeDependency** hostRuntimeDependency)
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, IAppxManifestHostRuntimeDependency**, int>)(lpVtbl[3]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), hostRuntimeDependency);
    }

    /// <include file='IAppxManifestHostRuntimeDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestHostRuntimeDependenciesEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestHostRuntimeDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestHostRuntimeDependenciesEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestHostRuntimeDependency** hostRuntimeDependency);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
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

        [NativeTypeName("HRESULT (IAppxManifestHostRuntimeDependency **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestHostRuntimeDependency**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}
