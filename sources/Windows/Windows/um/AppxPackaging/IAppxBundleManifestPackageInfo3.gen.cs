// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxBundleManifestPackageInfo3.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo3"]/*' />
[Guid("6BA74B98-BB74-4296-80D0-5F4256A99675")]
[NativeTypeName("struct IAppxBundleManifestPackageInfo3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleManifestPackageInfo3 : IAppxBundleManifestPackageInfo3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestPackageInfo3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestPackageInfo3.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo3.GetTargetDeviceFamilies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTargetDeviceFamilies(IAppxManifestTargetDeviceFamiliesEnumerator** targetDeviceFamilies)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, IAppxManifestTargetDeviceFamiliesEnumerator**, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this), targetDeviceFamilies);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTargetDeviceFamilies(IAppxManifestTargetDeviceFamiliesEnumerator** targetDeviceFamilies);
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

        [NativeTypeName("HRESULT (IAppxManifestTargetDeviceFamiliesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestTargetDeviceFamiliesEnumerator**, int> GetTargetDeviceFamilies;
    }
}
