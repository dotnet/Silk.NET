// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAddrExclusionControl.xml' path='doc/member[@name="IAddrExclusionControl"]/*' />
[Guid("00000148-0000-0000-C000-000000000046")]
[NativeTypeName("struct IAddrExclusionControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAddrExclusionControl : IAddrExclusionControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAddrExclusionControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAddrExclusionControl*, Guid*, void**, int>)(lpVtbl[0]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAddrExclusionControl*, uint>)(lpVtbl[1]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAddrExclusionControl*, uint>)(lpVtbl[2]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAddrExclusionControl.xml' path='doc/member[@name="IAddrExclusionControl.GetCurrentAddrExclusionList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentAddrExclusionList([NativeTypeName("const IID &")] Guid* riid, void** ppEnumerator)
    {
        return ((delegate* unmanaged<IAddrExclusionControl*, Guid*, void**, int>)(lpVtbl[3]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppEnumerator);
    }

    /// <include file='IAddrExclusionControl.xml' path='doc/member[@name="IAddrExclusionControl.UpdateAddrExclusionList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateAddrExclusionList(IUnknown* pEnumerator)
    {
        return ((delegate* unmanaged<IAddrExclusionControl*, IUnknown*, int>)(lpVtbl[4]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this), pEnumerator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentAddrExclusionList([NativeTypeName("const IID &")] Guid* riid, void** ppEnumerator);

        [VtblIndex(4)]
        HRESULT UpdateAddrExclusionList(IUnknown* pEnumerator);
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

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCurrentAddrExclusionList;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> UpdateAddrExclusionList;
    }
}
