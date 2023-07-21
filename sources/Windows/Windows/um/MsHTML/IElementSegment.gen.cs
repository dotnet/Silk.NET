// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IElementSegment.xml' path='doc/member[@name="IElementSegment"]/*' />
[Guid("3050F68F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementSegment : ISegment")]
[NativeInheritance("ISegment")]
public unsafe partial struct IElementSegment : IElementSegment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementSegment));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementSegment*, Guid*, void**, int>)(lpVtbl[0]))((IElementSegment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementSegment*, uint>)(lpVtbl[1]))((IElementSegment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementSegment*, uint>)(lpVtbl[2]))((IElementSegment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISegment.GetPointers" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPointers(IMarkupPointer* pIStart, IMarkupPointer* pIEnd)
    {
        return ((delegate* unmanaged<IElementSegment*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[3]))((IElementSegment*)Unsafe.AsPointer(ref this), pIStart, pIEnd);
    }

    /// <include file='IElementSegment.xml' path='doc/member[@name="IElementSegment.GetElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetElement(IHTMLElement** ppIElement)
    {
        return ((delegate* unmanaged<IElementSegment*, IHTMLElement**, int>)(lpVtbl[4]))((IElementSegment*)Unsafe.AsPointer(ref this), ppIElement);
    }

    /// <include file='IElementSegment.xml' path='doc/member[@name="IElementSegment.SetPrimary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrimary(BOOL fPrimary)
    {
        return ((delegate* unmanaged<IElementSegment*, BOOL, int>)(lpVtbl[5]))((IElementSegment*)Unsafe.AsPointer(ref this), fPrimary);
    }

    /// <include file='IElementSegment.xml' path='doc/member[@name="IElementSegment.IsPrimary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsPrimary(BOOL* pfPrimary)
    {
        return ((delegate* unmanaged<IElementSegment*, BOOL*, int>)(lpVtbl[6]))((IElementSegment*)Unsafe.AsPointer(ref this), pfPrimary);
    }

    public interface Interface : ISegment.Interface
    {
        [VtblIndex(4)]
        HRESULT GetElement(IHTMLElement** ppIElement);

        [VtblIndex(5)]
        HRESULT SetPrimary(BOOL fPrimary);

        [VtblIndex(6)]
        HRESULT IsPrimary(BOOL* pfPrimary);
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

        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, int> GetPointers;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> GetElement;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetPrimary;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsPrimary;
    }
}
