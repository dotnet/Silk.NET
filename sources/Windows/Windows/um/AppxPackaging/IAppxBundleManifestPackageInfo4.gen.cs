// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxBundleManifestPackageInfo4.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo4"]/*'/>
[Guid("5DA6F13D-A8A7-4532-857C-1393D659371D")]
[NativeTypeName("struct IAppxBundleManifestPackageInfo4 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleManifestPackageInfo4 : IAppxBundleManifestPackageInfo4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestPackageInfo4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, uint> )(lpVtbl[1]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, uint> )(lpVtbl[2]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleManifestPackageInfo4.xml' path='doc/member[@name="IAppxBundleManifestPackageInfo4.GetIsStub"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIsStub(BOOL* isStub)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, BOOL*, int> )(lpVtbl[3]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this), isStub);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIsStub(BOOL* isStub);
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
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsStub;
    }
}