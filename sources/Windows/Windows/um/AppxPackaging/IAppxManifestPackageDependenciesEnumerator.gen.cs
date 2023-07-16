// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxManifestPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestPackageDependenciesEnumerator"]/*'/>
[Guid("B43BBCF9-65A6-42DD-BAC0-8C6741E7F5A4")]
[NativeTypeName("struct IAppxManifestPackageDependenciesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestPackageDependenciesEnumerator : IAppxManifestPackageDependenciesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestPackageDependenciesEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint> )(lpVtbl[1]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint> )(lpVtbl[2]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestPackageDependenciesEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestPackageDependency** dependency)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, IAppxManifestPackageDependency**, int> )(lpVtbl[3]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), dependency);
    }

    /// <include file='IAppxManifestPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestPackageDependenciesEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestPackageDependenciesEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestPackageDependency** dependency);
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
        [NativeTypeName("HRESULT (IAppxManifestPackageDependency **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageDependency**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}