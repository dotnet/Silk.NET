// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent"]/*'/>
[Guid("305106CE-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMMouseEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMMouseEvent : IDOMMouseEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMMouseEvent));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, Guid*, void**, int> )(lpVtbl[0]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, uint> )(lpVtbl[1]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, uint> )(lpVtbl[2]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, uint*, int> )(lpVtbl[3]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_screenX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_screenX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[7]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_screenY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_screenY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[8]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_clientX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_clientX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[9]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_clientY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_clientY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[10]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_ctrlKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, short*, int> )(lpVtbl[11]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_shiftKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, short*, int> )(lpVtbl[12]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_altKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, short*, int> )(lpVtbl[13]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_metaKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_metaKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, short*, int> )(lpVtbl[14]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_button"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_button(ushort* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, int> )(lpVtbl[15]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_relatedTarget"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_relatedTarget(IEventTarget** p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, IEventTarget**, int> )(lpVtbl[16]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.initMouseEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT initMouseEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, [NativeTypeName("VARIANT_BOOL")] short ctrlKeyArg, [NativeTypeName("VARIANT_BOOL")] short altKeyArg, [NativeTypeName("VARIANT_BOOL")] short shiftKeyArg, [NativeTypeName("VARIANT_BOOL")] short metaKeyArg, ushort buttonArg, IEventTarget* relatedTargetArg)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, short, short, short, short, ushort, IEventTarget*, int> )(lpVtbl[17]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.getModifierState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT getModifierState([NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("VARIANT_BOOL *")] short* activated)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, short*, int> )(lpVtbl[18]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), keyArg, activated);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_buttons"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_buttons(ushort* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, int> )(lpVtbl[19]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_fromElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_fromElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, IHTMLElement**, int> )(lpVtbl[20]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_toElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_toElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, IHTMLElement**, int> )(lpVtbl[21]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_x([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[22]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_y([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[23]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_offsetX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_offsetX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[24]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_offsetY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_offsetY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[25]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_pageX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_pageX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[26]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_pageY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_pageY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[27]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_layerX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_layerX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[28]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_layerY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_layerY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, int*, int> )(lpVtbl[29]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseEvent.xml' path='doc/member[@name="IDOMMouseEvent.get_which"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_which(ushort* p)
    {
        return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, int> )(lpVtbl[30]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_screenX([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT get_screenY([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT get_clientX([NativeTypeName("long *")] int* p);
        [VtblIndex(10)]
        HRESULT get_clientY([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(12)]
        HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(13)]
        HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(14)]
        HRESULT get_metaKey([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(15)]
        HRESULT get_button(ushort* p);
        [VtblIndex(16)]
        HRESULT get_relatedTarget(IEventTarget** p);
        [VtblIndex(17)]
        HRESULT initMouseEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, [NativeTypeName("VARIANT_BOOL")] short ctrlKeyArg, [NativeTypeName("VARIANT_BOOL")] short altKeyArg, [NativeTypeName("VARIANT_BOOL")] short shiftKeyArg, [NativeTypeName("VARIANT_BOOL")] short metaKeyArg, ushort buttonArg, IEventTarget* relatedTargetArg);
        [VtblIndex(18)]
        HRESULT getModifierState([NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("VARIANT_BOOL *")] short* activated);
        [VtblIndex(19)]
        HRESULT get_buttons(ushort* p);
        [VtblIndex(20)]
        HRESULT get_fromElement(IHTMLElement** p);
        [VtblIndex(21)]
        HRESULT get_toElement(IHTMLElement** p);
        [VtblIndex(22)]
        HRESULT get_x([NativeTypeName("long *")] int* p);
        [VtblIndex(23)]
        HRESULT get_y([NativeTypeName("long *")] int* p);
        [VtblIndex(24)]
        HRESULT get_offsetX([NativeTypeName("long *")] int* p);
        [VtblIndex(25)]
        HRESULT get_offsetY([NativeTypeName("long *")] int* p);
        [VtblIndex(26)]
        HRESULT get_pageX([NativeTypeName("long *")] int* p);
        [VtblIndex(27)]
        HRESULT get_pageY([NativeTypeName("long *")] int* p);
        [VtblIndex(28)]
        HRESULT get_layerX([NativeTypeName("long *")] int* p);
        [VtblIndex(29)]
        HRESULT get_layerY([NativeTypeName("long *")] int* p);
        [VtblIndex(30)]
        HRESULT get_which(ushort* p);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenY;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientY;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ctrlKey;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_shiftKey;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_altKey;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_metaKey;
        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_button;
        [NativeTypeName("HRESULT (IEventTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEventTarget**, int> get_relatedTarget;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, IHTMLWindow2 *, long, long, long, long, long, VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL, USHORT, IEventTarget *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, short, short, short, short, ushort, IEventTarget*, int> initMouseEvent;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> getModifierState;
        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_buttons;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_fromElement;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_toElement;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_x;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_y;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetY;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pageX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pageY;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_layerX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_layerY;
        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_which;
    }
}