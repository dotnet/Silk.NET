// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfContextOwnerCompositionServices.xml' path='doc/member[@name="ITfContextOwnerCompositionServices"]/*' />
[Guid("86462810-593B-4916-9764-19C08E9CE110")]
[NativeTypeName("struct ITfContextOwnerCompositionServices : ITfContextComposition")]
[NativeInheritance("ITfContextComposition")]
public unsafe partial struct ITfContextOwnerCompositionServices : ITfContextOwnerCompositionServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextOwnerCompositionServices));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, uint>)(lpVtbl[1]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, uint>)(lpVtbl[2]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfContextComposition.StartComposition" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartComposition([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange* pCompositionRange, ITfCompositionSink* pSink, ITfComposition** ppComposition)
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, uint, ITfRange*, ITfCompositionSink*, ITfComposition**, int>)(lpVtbl[3]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this), ecWrite, pCompositionRange, pSink, ppComposition);
    }

    /// <inheritdoc cref="ITfContextComposition.EnumCompositions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumCompositions(IEnumITfCompositionView** ppEnum)
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, IEnumITfCompositionView**, int>)(lpVtbl[4]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <inheritdoc cref="ITfContextComposition.FindComposition" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindComposition([NativeTypeName("TfEditCookie")] uint ecRead, ITfRange* pTestRange, IEnumITfCompositionView** ppEnum)
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, uint, ITfRange*, IEnumITfCompositionView**, int>)(lpVtbl[5]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this), ecRead, pTestRange, ppEnum);
    }

    /// <inheritdoc cref="ITfContextComposition.TakeOwnership" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TakeOwnership([NativeTypeName("TfEditCookie")] uint ecWrite, ITfCompositionView* pComposition, ITfCompositionSink* pSink, ITfComposition** ppComposition)
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, uint, ITfCompositionView*, ITfCompositionSink*, ITfComposition**, int>)(lpVtbl[6]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this), ecWrite, pComposition, pSink, ppComposition);
    }

    /// <include file='ITfContextOwnerCompositionServices.xml' path='doc/member[@name="ITfContextOwnerCompositionServices.TerminateComposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TerminateComposition(ITfCompositionView* pComposition)
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices*, ITfCompositionView*, int>)(lpVtbl[7]))((ITfContextOwnerCompositionServices*)Unsafe.AsPointer(ref this), pComposition);
    }

    public interface Interface : ITfContextComposition.Interface
    {
        [VtblIndex(7)]
        HRESULT TerminateComposition(ITfCompositionView* pComposition);
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

        [NativeTypeName("HRESULT (ITfCompositionView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompositionView*, int> TerminateComposition;
    }
}
