// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxBundleManifestReader2.xml' path='doc/member[@name="IAppxBundleManifestReader2"]/*'/>
[Guid("5517DF70-033F-4AF2-8213-87D766805C02")]
[NativeTypeName("struct IAppxBundleManifestReader2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestReader2 : IAppxBundleManifestReader2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestReader2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, uint> )(lpVtbl[1]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, uint> )(lpVtbl[2]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestReader2.xml' path='doc/member[@name="IAppxBundleManifestReader2.GetOptionalBundles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOptionalBundles(IAppxBundleManifestOptionalBundleInfoEnumerator** optionalBundles)
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, IAppxBundleManifestOptionalBundleInfoEnumerator**, int> )(lpVtbl[3]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this), optionalBundles);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOptionalBundles(IAppxBundleManifestOptionalBundleInfoEnumerator** optionalBundles);
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
        [NativeTypeName("HRESULT (IAppxBundleManifestOptionalBundleInfoEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestOptionalBundleInfoEnumerator**, int> GetOptionalBundles;
    }
}