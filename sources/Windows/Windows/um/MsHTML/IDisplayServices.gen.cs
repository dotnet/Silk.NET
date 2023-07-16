// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices"]/*'/>
[Guid("3050F69D-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDisplayServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDisplayServices : IDisplayServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayServices));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDisplayServices*, Guid*, void**, int> )(lpVtbl[0]))((IDisplayServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDisplayServices*, uint> )(lpVtbl[1]))((IDisplayServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayServices*, uint> )(lpVtbl[2]))((IDisplayServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.CreateDisplayPointer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDisplayPointer(IDisplayPointer** ppDispPointer)
    {
        return ((delegate* unmanaged<IDisplayServices*, IDisplayPointer**, int> )(lpVtbl[3]))((IDisplayServices*)Unsafe.AsPointer(ref this), ppDispPointer);
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.TransformRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TransformRect(RECT* pRect, COORD_SYSTEM eSource, COORD_SYSTEM eDestination, IHTMLElement* pIElement)
    {
        return ((delegate* unmanaged<IDisplayServices*, RECT*, COORD_SYSTEM, COORD_SYSTEM, IHTMLElement*, int> )(lpVtbl[4]))((IDisplayServices*)Unsafe.AsPointer(ref this), pRect, eSource, eDestination, pIElement);
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.TransformPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TransformPoint(POINT* pPoint, COORD_SYSTEM eSource, COORD_SYSTEM eDestination, IHTMLElement* pIElement)
    {
        return ((delegate* unmanaged<IDisplayServices*, POINT*, COORD_SYSTEM, COORD_SYSTEM, IHTMLElement*, int> )(lpVtbl[5]))((IDisplayServices*)Unsafe.AsPointer(ref this), pPoint, eSource, eDestination, pIElement);
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.GetCaret"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCaret(IHTMLCaret** ppCaret)
    {
        return ((delegate* unmanaged<IDisplayServices*, IHTMLCaret**, int> )(lpVtbl[6]))((IDisplayServices*)Unsafe.AsPointer(ref this), ppCaret);
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.GetComputedStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetComputedStyle(IMarkupPointer* pPointer, IHTMLComputedStyle** ppComputedStyle)
    {
        return ((delegate* unmanaged<IDisplayServices*, IMarkupPointer*, IHTMLComputedStyle**, int> )(lpVtbl[7]))((IDisplayServices*)Unsafe.AsPointer(ref this), pPointer, ppComputedStyle);
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.ScrollRectIntoView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ScrollRectIntoView(IHTMLElement* pIElement, RECT rect)
    {
        return ((delegate* unmanaged<IDisplayServices*, IHTMLElement*, RECT, int> )(lpVtbl[8]))((IDisplayServices*)Unsafe.AsPointer(ref this), pIElement, rect);
    }

    /// <include file='IDisplayServices.xml' path='doc/member[@name="IDisplayServices.HasFlowLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT HasFlowLayout(IHTMLElement* pIElement, BOOL* pfHasFlowLayout)
    {
        return ((delegate* unmanaged<IDisplayServices*, IHTMLElement*, BOOL*, int> )(lpVtbl[9]))((IDisplayServices*)Unsafe.AsPointer(ref this), pIElement, pfHasFlowLayout);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDisplayPointer(IDisplayPointer** ppDispPointer);
        [VtblIndex(4)]
        HRESULT TransformRect(RECT* pRect, COORD_SYSTEM eSource, COORD_SYSTEM eDestination, IHTMLElement* pIElement);
        [VtblIndex(5)]
        HRESULT TransformPoint(POINT* pPoint, COORD_SYSTEM eSource, COORD_SYSTEM eDestination, IHTMLElement* pIElement);
        [VtblIndex(6)]
        HRESULT GetCaret(IHTMLCaret** ppCaret);
        [VtblIndex(7)]
        HRESULT GetComputedStyle(IMarkupPointer* pPointer, IHTMLComputedStyle** ppComputedStyle);
        [VtblIndex(8)]
        HRESULT ScrollRectIntoView(IHTMLElement* pIElement, RECT rect);
        [VtblIndex(9)]
        HRESULT HasFlowLayout(IHTMLElement* pIElement, BOOL* pfHasFlowLayout);
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
        [NativeTypeName("HRESULT (IDisplayPointer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer**, int> CreateDisplayPointer;
        [NativeTypeName("HRESULT (RECT *, COORD_SYSTEM, COORD_SYSTEM, IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, COORD_SYSTEM, COORD_SYSTEM, IHTMLElement*, int> TransformRect;
        [NativeTypeName("HRESULT (POINT *, COORD_SYSTEM, COORD_SYSTEM, IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, COORD_SYSTEM, COORD_SYSTEM, IHTMLElement*, int> TransformPoint;
        [NativeTypeName("HRESULT (IHTMLCaret **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLCaret**, int> GetCaret;
        [NativeTypeName("HRESULT (IMarkupPointer *, IHTMLComputedStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IHTMLComputedStyle**, int> GetComputedStyle;
        [NativeTypeName("HRESULT (IHTMLElement *, RECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, RECT, int> ScrollRectIntoView;
        [NativeTypeName("HRESULT (IHTMLElement *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, BOOL*, int> HasFlowLayout;
    }
}