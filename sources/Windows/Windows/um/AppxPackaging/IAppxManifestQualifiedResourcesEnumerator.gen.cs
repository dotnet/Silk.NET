// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestQualifiedResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestQualifiedResourcesEnumerator"]/*'/>
[Guid("8EF6ADFE-3762-4A8F-9373-2FC5D444C8D2")]
[NativeTypeName("struct IAppxManifestQualifiedResourcesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestQualifiedResourcesEnumerator : IAppxManifestQualifiedResourcesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestQualifiedResourcesEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint> )(lpVtbl[1]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint> )(lpVtbl[2]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestQualifiedResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestQualifiedResourcesEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestQualifiedResource** resource)
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, IAppxManifestQualifiedResource**, int> )(lpVtbl[3]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), resource);
    }

    /// <include file='IAppxManifestQualifiedResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestQualifiedResourcesEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestQualifiedResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestQualifiedResourcesEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestQualifiedResource** resource);
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
        [NativeTypeName("HRESULT (IAppxManifestQualifiedResource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestQualifiedResource**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}