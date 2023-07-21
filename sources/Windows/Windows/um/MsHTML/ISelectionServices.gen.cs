// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices"]/*' />
[Guid("3050F684-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISelectionServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISelectionServices : ISelectionServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISelectionServices));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISelectionServices*, Guid*, void**, int>)(lpVtbl[0]))((ISelectionServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISelectionServices*, uint>)(lpVtbl[1]))((ISelectionServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISelectionServices*, uint>)(lpVtbl[2]))((ISelectionServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices.SetSelectionType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSelectionType(SELECTION_TYPE eType, ISelectionServicesListener* pIListener)
    {
        return ((delegate* unmanaged<ISelectionServices*, SELECTION_TYPE, ISelectionServicesListener*, int>)(lpVtbl[3]))((ISelectionServices*)Unsafe.AsPointer(ref this), eType, pIListener);
    }

    /// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices.GetMarkupContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMarkupContainer(IMarkupContainer** ppIContainer)
    {
        return ((delegate* unmanaged<ISelectionServices*, IMarkupContainer**, int>)(lpVtbl[4]))((ISelectionServices*)Unsafe.AsPointer(ref this), ppIContainer);
    }

    /// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices.AddSegment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddSegment(IMarkupPointer* pIStart, IMarkupPointer* pIEnd, ISegment** ppISegmentAdded)
    {
        return ((delegate* unmanaged<ISelectionServices*, IMarkupPointer*, IMarkupPointer*, ISegment**, int>)(lpVtbl[5]))((ISelectionServices*)Unsafe.AsPointer(ref this), pIStart, pIEnd, ppISegmentAdded);
    }

    /// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices.AddElementSegment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddElementSegment(IHTMLElement* pIElement, IElementSegment** ppISegmentAdded)
    {
        return ((delegate* unmanaged<ISelectionServices*, IHTMLElement*, IElementSegment**, int>)(lpVtbl[6]))((ISelectionServices*)Unsafe.AsPointer(ref this), pIElement, ppISegmentAdded);
    }

    /// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices.RemoveSegment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveSegment(ISegment* pISegment)
    {
        return ((delegate* unmanaged<ISelectionServices*, ISegment*, int>)(lpVtbl[7]))((ISelectionServices*)Unsafe.AsPointer(ref this), pISegment);
    }

    /// <include file='ISelectionServices.xml' path='doc/member[@name="ISelectionServices.GetSelectionServicesListener"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSelectionServicesListener(ISelectionServicesListener** ppISelectionServicesListener)
    {
        return ((delegate* unmanaged<ISelectionServices*, ISelectionServicesListener**, int>)(lpVtbl[8]))((ISelectionServices*)Unsafe.AsPointer(ref this), ppISelectionServicesListener);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSelectionType(SELECTION_TYPE eType, ISelectionServicesListener* pIListener);

        [VtblIndex(4)]
        HRESULT GetMarkupContainer(IMarkupContainer** ppIContainer);

        [VtblIndex(5)]
        HRESULT AddSegment(IMarkupPointer* pIStart, IMarkupPointer* pIEnd, ISegment** ppISegmentAdded);

        [VtblIndex(6)]
        HRESULT AddElementSegment(IHTMLElement* pIElement, IElementSegment** ppISegmentAdded);

        [VtblIndex(7)]
        HRESULT RemoveSegment(ISegment* pISegment);

        [VtblIndex(8)]
        HRESULT GetSelectionServicesListener(ISelectionServicesListener** ppISelectionServicesListener);
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

        [NativeTypeName("HRESULT (SELECTION_TYPE, ISelectionServicesListener *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SELECTION_TYPE, ISelectionServicesListener*, int> SetSelectionType;

        [NativeTypeName("HRESULT (IMarkupContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupContainer**, int> GetMarkupContainer;

        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, ISegment **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, ISegment**, int> AddSegment;

        [NativeTypeName("HRESULT (IHTMLElement *, IElementSegment **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, IElementSegment**, int> AddElementSegment;

        [NativeTypeName("HRESULT (ISegment *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISegment*, int> RemoveSegment;

        [NativeTypeName("HRESULT (ISelectionServicesListener **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISelectionServicesListener**, int> GetSelectionServicesListener;
    }
}
