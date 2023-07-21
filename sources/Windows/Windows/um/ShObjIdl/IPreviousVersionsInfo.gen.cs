// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPreviousVersionsInfo.xml' path='doc/member[@name="IPreviousVersionsInfo"]/*' />
[Guid("76E54780-AD74-48E3-A695-3BA9A0AFF10D")]
[NativeTypeName("struct IPreviousVersionsInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPreviousVersionsInfo : IPreviousVersionsInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreviousVersionsInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPreviousVersionsInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPreviousVersionsInfo*, uint>)(lpVtbl[1]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPreviousVersionsInfo*, uint>)(lpVtbl[2]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPreviousVersionsInfo.xml' path='doc/member[@name="IPreviousVersionsInfo.AreSnapshotsAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AreSnapshotsAvailable([NativeTypeName("LPCWSTR")] ushort* pszPath, BOOL fOkToBeSlow, BOOL* pfAvailable)
    {
        return ((delegate* unmanaged<IPreviousVersionsInfo*, ushort*, BOOL, BOOL*, int>)(lpVtbl[3]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this), pszPath, fOkToBeSlow, pfAvailable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AreSnapshotsAvailable([NativeTypeName("LPCWSTR")] ushort* pszPath, BOOL fOkToBeSlow, BOOL* pfAvailable);
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

        [NativeTypeName("HRESULT (LPCWSTR, BOOL, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, BOOL*, int> AreSnapshotsAvailable;
    }
}
