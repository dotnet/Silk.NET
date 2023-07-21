// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfProperty.xml' path='doc/member[@name="ITfProperty"]/*' />
[Guid("E2449660-9542-11D2-BF46-00105A2799B5")]
[NativeTypeName("struct ITfProperty : ITfReadOnlyProperty")]
[NativeInheritance("ITfReadOnlyProperty")]
public unsafe partial struct ITfProperty : ITfProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfProperty));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfProperty*, Guid*, void**, int>)(lpVtbl[0]))((ITfProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfProperty*, uint>)(lpVtbl[1]))((ITfProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfProperty*, uint>)(lpVtbl[2]))((ITfProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfReadOnlyProperty.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfProperty*, Guid*, int>)(lpVtbl[3]))((ITfProperty*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <inheritdoc cref="ITfReadOnlyProperty.EnumRanges" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumRanges([NativeTypeName("TfEditCookie")] uint ec, IEnumTfRanges** ppEnum, ITfRange* pTargetRange)
    {
        return ((delegate* unmanaged<ITfProperty*, uint, IEnumTfRanges**, ITfRange*, int>)(lpVtbl[4]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, ppEnum, pTargetRange);
    }

    /// <inheritdoc cref="ITfReadOnlyProperty.GetValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, VARIANT*, int>)(lpVtbl[5]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, pvarValue);
    }

    /// <inheritdoc cref="ITfReadOnlyProperty.GetContext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetContext(ITfContext** ppContext)
    {
        return ((delegate* unmanaged<ITfProperty*, ITfContext**, int>)(lpVtbl[6]))((ITfProperty*)Unsafe.AsPointer(ref this), ppContext);
    }

    /// <include file='ITfProperty.xml' path='doc/member[@name="ITfProperty.FindRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfRange** ppRange, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, ITfRange**, TfAnchor, int>)(lpVtbl[7]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, ppRange, aPos);
    }

    /// <include file='ITfProperty.xml' path='doc/member[@name="ITfProperty.SetValueStore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetValueStore([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfPropertyStore* pPropStore)
    {
        return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, ITfPropertyStore*, int>)(lpVtbl[8]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, pPropStore);
    }

    /// <include file='ITfProperty.xml' path='doc/member[@name="ITfProperty.SetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, [NativeTypeName("const VARIANT *")] VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, VARIANT*, int>)(lpVtbl[9]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, pvarValue);
    }

    /// <include file='ITfProperty.xml' path='doc/member[@name="ITfProperty.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Clear([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange)
    {
        return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, int>)(lpVtbl[10]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange);
    }

    public interface Interface : ITfReadOnlyProperty.Interface
    {
        [VtblIndex(7)]
        HRESULT FindRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfRange** ppRange, TfAnchor aPos);

        [VtblIndex(8)]
        HRESULT SetValueStore([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfPropertyStore* pPropStore);

        [VtblIndex(9)]
        HRESULT SetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, [NativeTypeName("const VARIANT *")] VARIANT* pvarValue);

        [VtblIndex(10)]
        HRESULT Clear([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, Guid*, int> GetType;

        [NativeTypeName("HRESULT (TfEditCookie, IEnumTfRanges **, ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumTfRanges**, ITfRange*, int> EnumRanges;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, VARIANT*, int> GetValue;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext**, int> GetContext;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, ITfRange **, TfAnchor) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, ITfRange**, TfAnchor, int> FindRange;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, ITfPropertyStore *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, ITfPropertyStore*, int> SetValueStore;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, const VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, VARIANT*, int> SetValue;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, int> Clear;
    }
}
