// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxBundleManifestOptionalBundleInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfoEnumerator"]/*'/>
[Guid("9A178793-F97E-46AC-AACA-DD5BA4C177C8")]
[NativeTypeName("struct IAppxBundleManifestOptionalBundleInfoEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestOptionalBundleInfoEnumerator : IAppxBundleManifestOptionalBundleInfoEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestOptionalBundleInfoEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, uint> )(lpVtbl[1]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, uint> )(lpVtbl[2]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestOptionalBundleInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfoEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxBundleManifestOptionalBundleInfo** optionalBundle)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, IAppxBundleManifestOptionalBundleInfo**, int> )(lpVtbl[3]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), optionalBundle);
    }

    /// <include file='IAppxBundleManifestOptionalBundleInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfoEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxBundleManifestOptionalBundleInfoEnumerator.xml' path='doc/member[@name="IAppxBundleManifestOptionalBundleInfoEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxBundleManifestOptionalBundleInfo** optionalBundle);
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
        [NativeTypeName("HRESULT (IAppxBundleManifestOptionalBundleInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestOptionalBundleInfo**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}