// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumTfDocumentMgrs.xml' path='doc/member[@name="IEnumTfDocumentMgrs"]/*' />
[Guid("AA80E808-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct IEnumTfDocumentMgrs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfDocumentMgrs : IEnumTfDocumentMgrs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfDocumentMgrs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint>)(lpVtbl[1]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint>)(lpVtbl[2]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfDocumentMgrs.xml' path='doc/member[@name="IEnumTfDocumentMgrs.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfDocumentMgrs** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, IEnumTfDocumentMgrs**, int>)(lpVtbl[3]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfDocumentMgrs.xml' path='doc/member[@name="IEnumTfDocumentMgrs.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfDocumentMgr** rgDocumentMgr, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint, ITfDocumentMgr**, uint*, int>)(lpVtbl[4]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), ulCount, rgDocumentMgr, pcFetched);
    }

    /// <include file='IEnumTfDocumentMgrs.xml' path='doc/member[@name="IEnumTfDocumentMgrs.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, int>)(lpVtbl[5]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfDocumentMgrs.xml' path='doc/member[@name="IEnumTfDocumentMgrs.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint, int>)(lpVtbl[6]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfDocumentMgrs** ppEnum);

        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfDocumentMgr** rgDocumentMgr, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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

        [NativeTypeName("HRESULT (IEnumTfDocumentMgrs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfDocumentMgrs**, int> Clone;

        [NativeTypeName("HRESULT (ULONG, ITfDocumentMgr **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfDocumentMgr**, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}
