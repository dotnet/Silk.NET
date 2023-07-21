// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxBundleManifestPackageInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestPackageInfoEnumerator"]/*' />
[Guid("F9B856EE-49A6-4E19-B2B0-6A2406D63A32")]
[NativeTypeName("struct IAppxBundleManifestPackageInfoEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IAppxBundleManifestPackageInfoEnumerator : IAppxBundleManifestPackageInfoEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestPackageInfoEnumerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestPackageInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestPackageInfoEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxBundleManifestPackageInfo** packageInfo)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, IAppxBundleManifestPackageInfo**, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), packageInfo);
    }

    /// <include file='IAppxBundleManifestPackageInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestPackageInfoEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxBundleManifestPackageInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestPackageInfoEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxBundleManifestPackageInfo** packageInfo);

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

        [NativeTypeName("HRESULT (IAppxBundleManifestPackageInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestPackageInfo**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}
