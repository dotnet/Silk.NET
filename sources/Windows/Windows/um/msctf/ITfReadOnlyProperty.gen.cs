// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfReadOnlyProperty.xml' path='doc/member[@name="ITfReadOnlyProperty"]/*' />
[Guid("17D49A3D-F8B8-4B2F-B254-52319DD64C53")]
[NativeTypeName("struct ITfReadOnlyProperty : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfReadOnlyProperty : ITfReadOnlyProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfReadOnlyProperty));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, Guid*, void**, int>)(lpVtbl[0]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, uint>)(lpVtbl[1]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, uint>)(lpVtbl[2]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfReadOnlyProperty.xml' path='doc/member[@name="ITfReadOnlyProperty.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, Guid*, int>)(lpVtbl[3]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <include file='ITfReadOnlyProperty.xml' path='doc/member[@name="ITfReadOnlyProperty.EnumRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumRanges([NativeTypeName("TfEditCookie")] uint ec, IEnumTfRanges** ppEnum, ITfRange* pTargetRange)
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, uint, IEnumTfRanges**, ITfRange*, int>)(lpVtbl[4]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), ec, ppEnum, pTargetRange);
    }

    /// <include file='ITfReadOnlyProperty.xml' path='doc/member[@name="ITfReadOnlyProperty.GetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, uint, ITfRange*, VARIANT*, int>)(lpVtbl[5]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), ec, pRange, pvarValue);
    }

    /// <include file='ITfReadOnlyProperty.xml' path='doc/member[@name="ITfReadOnlyProperty.GetContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetContext(ITfContext** ppContext)
    {
        return ((delegate* unmanaged<ITfReadOnlyProperty*, ITfContext**, int>)(lpVtbl[6]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), ppContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType(Guid* pguid);

        [VtblIndex(4)]
        HRESULT EnumRanges([NativeTypeName("TfEditCookie")] uint ec, IEnumTfRanges** ppEnum, ITfRange* pTargetRange);

        [VtblIndex(5)]
        HRESULT GetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, VARIANT* pvarValue);

        [VtblIndex(6)]
        HRESULT GetContext(ITfContext** ppContext);
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
    }
}
