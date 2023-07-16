// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxManifestDriverConstraintsEnumerator.xml' path='doc/member[@name="IAppxManifestDriverConstraintsEnumerator"]/*'/>
[Guid("D402B2D1-F600-49E0-95E6-975D8DA13D89")]
[NativeTypeName("struct IAppxManifestDriverConstraintsEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestDriverConstraintsEnumerator : IAppxManifestDriverConstraintsEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestDriverConstraintsEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, uint> )(lpVtbl[1]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, uint> )(lpVtbl[2]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestDriverConstraintsEnumerator.xml' path='doc/member[@name="IAppxManifestDriverConstraintsEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestDriverConstraint** driverConstraint)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, IAppxManifestDriverConstraint**, int> )(lpVtbl[3]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), driverConstraint);
    }

    /// <include file='IAppxManifestDriverConstraintsEnumerator.xml' path='doc/member[@name="IAppxManifestDriverConstraintsEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestDriverConstraintsEnumerator.xml' path='doc/member[@name="IAppxManifestDriverConstraintsEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestDriverConstraint** driverConstraint);
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
        [NativeTypeName("HRESULT (IAppxManifestDriverConstraint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestDriverConstraint**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}