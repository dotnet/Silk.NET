// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfContextComposition.xml' path='doc/member[@name="ITfContextComposition"]/*' />
[Guid("D40C8AAE-AC92-4FC7-9A11-0EE0E23AA39B")]
[NativeTypeName("struct ITfContextComposition : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfContextComposition : ITfContextComposition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextComposition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfContextComposition*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextComposition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfContextComposition*, uint>)(lpVtbl[1]))((ITfContextComposition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextComposition*, uint>)(lpVtbl[2]))((ITfContextComposition*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfContextComposition.xml' path='doc/member[@name="ITfContextComposition.StartComposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartComposition([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange* pCompositionRange, ITfCompositionSink* pSink, ITfComposition** ppComposition)
    {
        return ((delegate* unmanaged<ITfContextComposition*, uint, ITfRange*, ITfCompositionSink*, ITfComposition**, int>)(lpVtbl[3]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ecWrite, pCompositionRange, pSink, ppComposition);
    }

    /// <include file='ITfContextComposition.xml' path='doc/member[@name="ITfContextComposition.EnumCompositions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumCompositions(IEnumITfCompositionView** ppEnum)
    {
        return ((delegate* unmanaged<ITfContextComposition*, IEnumITfCompositionView**, int>)(lpVtbl[4]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='ITfContextComposition.xml' path='doc/member[@name="ITfContextComposition.FindComposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindComposition([NativeTypeName("TfEditCookie")] uint ecRead, ITfRange* pTestRange, IEnumITfCompositionView** ppEnum)
    {
        return ((delegate* unmanaged<ITfContextComposition*, uint, ITfRange*, IEnumITfCompositionView**, int>)(lpVtbl[5]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ecRead, pTestRange, ppEnum);
    }

    /// <include file='ITfContextComposition.xml' path='doc/member[@name="ITfContextComposition.TakeOwnership"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TakeOwnership([NativeTypeName("TfEditCookie")] uint ecWrite, ITfCompositionView* pComposition, ITfCompositionSink* pSink, ITfComposition** ppComposition)
    {
        return ((delegate* unmanaged<ITfContextComposition*, uint, ITfCompositionView*, ITfCompositionSink*, ITfComposition**, int>)(lpVtbl[6]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ecWrite, pComposition, pSink, ppComposition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartComposition([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange* pCompositionRange, ITfCompositionSink* pSink, ITfComposition** ppComposition);

        [VtblIndex(4)]
        HRESULT EnumCompositions(IEnumITfCompositionView** ppEnum);

        [VtblIndex(5)]
        HRESULT FindComposition([NativeTypeName("TfEditCookie")] uint ecRead, ITfRange* pTestRange, IEnumITfCompositionView** ppEnum);

        [VtblIndex(6)]
        HRESULT TakeOwnership([NativeTypeName("TfEditCookie")] uint ecWrite, ITfCompositionView* pComposition, ITfCompositionSink* pSink, ITfComposition** ppComposition);
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

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, ITfCompositionSink *, ITfComposition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, ITfCompositionSink*, ITfComposition**, int> StartComposition;

        [NativeTypeName("HRESULT (IEnumITfCompositionView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumITfCompositionView**, int> EnumCompositions;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, IEnumITfCompositionView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, IEnumITfCompositionView**, int> FindComposition;

        [NativeTypeName("HRESULT (TfEditCookie, ITfCompositionView *, ITfCompositionSink *, ITfComposition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfCompositionView*, ITfCompositionSink*, ITfComposition**, int> TakeOwnership;
    }
}
