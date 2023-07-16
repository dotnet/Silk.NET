// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxManifestResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestResourcesEnumerator"]/*'/>
[Guid("DE4DFBBD-881A-48BB-858C-D6F2BAEAE6ED")]
[NativeTypeName("struct IAppxManifestResourcesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestResourcesEnumerator : IAppxManifestResourcesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestResourcesEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, uint> )(lpVtbl[1]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, uint> )(lpVtbl[2]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestResourcesEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent([NativeTypeName("LPWSTR *")] ushort** resource)
    {
        return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, ushort**, int> )(lpVtbl[3]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), resource);
    }

    /// <include file='IAppxManifestResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestResourcesEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestResourcesEnumerator.xml' path='doc/member[@name="IAppxManifestResourcesEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent([NativeTypeName("LPWSTR *")] ushort** resource);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}