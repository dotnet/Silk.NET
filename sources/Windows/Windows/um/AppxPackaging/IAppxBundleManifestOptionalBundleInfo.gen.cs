// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxBundleManifestOptionalBundleInfo.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfo"]/*'/>
[Guid("515BF2E8-BCB0-4D69-8C48-E383147B6E12")]
[NativeTypeName("struct IAppxBundleManifestOptionalBundleInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestOptionalBundleInfo : IAppxBundleManifestOptionalBundleInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestOptionalBundleInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, uint> )(lpVtbl[1]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, uint> )(lpVtbl[2]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestOptionalBundleInfo.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfo.GetPackageId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageId(IAppxManifestPackageId** packageId)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, IAppxManifestPackageId**, int> )(lpVtbl[3]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), packageId);
    }

    /// <include file='IAppxBundleManifestOptionalBundleInfo.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfo.GetFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, ushort**, int> )(lpVtbl[4]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), fileName);
    }

    /// <include file='IAppxBundleManifestOptionalBundleInfo.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfo.GetPackageInfoItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator** packageInfoItems)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, IAppxBundleManifestPackageInfoEnumerator**, int> )(lpVtbl[5]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), packageInfoItems);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageId(IAppxManifestPackageId** packageId);
        [VtblIndex(4)]
        HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName);
        [VtblIndex(5)]
        HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator** packageInfoItems);
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
        [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageId**, int> GetPackageId;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetFileName;
        [NativeTypeName("HRESULT (IAppxBundleManifestPackageInfoEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestPackageInfoEnumerator**, int> GetPackageInfoItems;
    }
}