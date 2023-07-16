// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7"]/*'/>
[Guid("305104B7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLWindow7 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLWindow7 : IHTMLWindow7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLWindow7));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLWindow7*, uint> )(lpVtbl[1]))((IHTMLWindow7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLWindow7*, uint> )(lpVtbl[2]))((IHTMLWindow7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, uint*, int> )(lpVtbl[3]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.getSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getSelection(IHTMLSelection** ppIHTMLSelection)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, IHTMLSelection**, int> )(lpVtbl[7]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), ppIHTMLSelection);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.getComputedStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT getComputedStyle(IHTMLDOMNode* varArgIn, [NativeTypeName("BSTR")] ushort* bstrPseudoElt, IHTMLCSSStyleDeclaration** ppComputedStyle)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, IHTMLDOMNode*, ushort*, IHTMLCSSStyleDeclaration**, int> )(lpVtbl[8]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), varArgIn, bstrPseudoElt, ppComputedStyle);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_styleMedia"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_styleMedia(IHTMLStyleMedia** p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, IHTMLStyleMedia**, int> )(lpVtbl[9]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_performance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_performance(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[10]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_performance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_performance(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[11]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_innerWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_innerWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[12]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_innerHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_innerHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[13]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_pageXOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_pageXOffset([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[14]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_pageYOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_pageYOffset([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[15]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_screenX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_screenX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[16]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_screenY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_screenY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[17]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_outerWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_outerWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[18]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_outerHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_outerHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, int*, int> )(lpVtbl[19]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onabort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_onabort(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[20]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onabort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_onabort(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[21]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_oncanplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_oncanplay(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[22]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_oncanplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_oncanplay(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[23]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_oncanplaythrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_oncanplaythrough(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[24]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_oncanplaythrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_oncanplaythrough(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[25]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[26]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[27]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_onclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[28]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_onclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[29]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_oncontextmenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_oncontextmenu(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[30]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_oncontextmenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_oncontextmenu(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[31]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondblclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_ondblclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[32]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondblclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_ondblclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[33]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_ondrag(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[34]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_ondrag(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[35]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondragend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_ondragend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[36]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondragend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_ondragend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[37]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondragenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_ondragenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[38]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondragenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_ondragenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[39]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondragleave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_ondragleave(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[40]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondragleave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_ondragleave(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[41]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondragover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_ondragover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[42]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondragover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_ondragover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[43]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondragstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_ondragstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[44]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondragstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_ondragstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[45]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondrop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_ondrop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[46]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondrop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_ondrop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[47]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ondurationchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_ondurationchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[48]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ondurationchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_ondurationchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[49]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onfocusin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_onfocusin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[50]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onfocusin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_onfocusin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[51]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onfocusout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT put_onfocusout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[52]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onfocusout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_onfocusout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[53]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_oninput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_oninput(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[54]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_oninput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_oninput(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[55]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onemptied"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT put_onemptied(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[56]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onemptied"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_onemptied(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[57]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onended"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_onended(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[58]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onended"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_onended(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[59]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onkeydown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_onkeydown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[60]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onkeydown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_onkeydown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[61]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onkeypress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_onkeypress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[62]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onkeypress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_onkeypress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[63]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onkeyup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT put_onkeyup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[64]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onkeyup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_onkeyup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[65]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onloadeddata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_onloadeddata(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[66]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onloadeddata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_onloadeddata(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[67]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onloadedmetadata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_onloadedmetadata(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[68]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onloadedmetadata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_onloadedmetadata(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[69]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onloadstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT put_onloadstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[70]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onloadstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_onloadstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[71]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmousedown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT put_onmousedown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[72]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmousedown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_onmousedown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[73]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmouseenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT put_onmouseenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[74]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmouseenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_onmouseenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[75]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmouseleave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT put_onmouseleave(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[76]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmouseleave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_onmouseleave(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[77]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmousemove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT put_onmousemove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[78]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmousemove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_onmousemove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[79]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmouseout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT put_onmouseout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[80]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmouseout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_onmouseout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[81]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmouseover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT put_onmouseover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[82]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmouseover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_onmouseover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[83]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmouseup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT put_onmouseup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[84]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmouseup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_onmouseup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[85]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onmousewheel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT put_onmousewheel(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[86]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onmousewheel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_onmousewheel(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[87]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onoffline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT put_onoffline(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[88]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onoffline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_onoffline(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[89]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ononline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT put_ononline(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[90]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ononline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_ononline(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[91]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onprogress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT put_onprogress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[92]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onprogress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_onprogress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[93]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onratechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT put_onratechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[94]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onratechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_onratechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[95]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[96]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[97]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onreset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT put_onreset(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[98]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onreset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_onreset(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[99]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onseeked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT put_onseeked(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[100]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onseeked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_onseeked(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[101]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onseeking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT put_onseeking(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[102]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onseeking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_onseeking(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[103]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[104]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[105]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onstalled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT put_onstalled(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[106]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onstalled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_onstalled(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[107]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onstorage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT put_onstorage(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[108]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onstorage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_onstorage(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[109]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onsubmit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT put_onsubmit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[110]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onsubmit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_onsubmit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[111]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onsuspend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT put_onsuspend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[112]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onsuspend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_onsuspend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[113]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_ontimeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT put_ontimeupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[114]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_ontimeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT get_ontimeupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[115]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onpause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT put_onpause(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[116]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onpause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT get_onpause(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[117]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT put_onplay(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[118]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT get_onplay(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[119]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onplaying"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT put_onplaying(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[120]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onplaying"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT get_onplaying(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[121]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onvolumechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT put_onvolumechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[122]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onvolumechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT get_onvolumechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[123]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.put_onwaiting"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT put_onwaiting(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int> )(lpVtbl[124]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow7.xml' path='doc/member[@name="IHTMLWindow7.get_onwaiting"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT get_onwaiting(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int> )(lpVtbl[125]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getSelection(IHTMLSelection** ppIHTMLSelection);
        [VtblIndex(8)]
        HRESULT getComputedStyle(IHTMLDOMNode* varArgIn, [NativeTypeName("BSTR")] ushort* bstrPseudoElt, IHTMLCSSStyleDeclaration** ppComputedStyle);
        [VtblIndex(9)]
        HRESULT get_styleMedia(IHTMLStyleMedia** p);
        [VtblIndex(10)]
        HRESULT put_performance(VARIANT v);
        [VtblIndex(11)]
        HRESULT get_performance(VARIANT* p);
        [VtblIndex(12)]
        HRESULT get_innerWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(13)]
        HRESULT get_innerHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(14)]
        HRESULT get_pageXOffset([NativeTypeName("long *")] int* p);
        [VtblIndex(15)]
        HRESULT get_pageYOffset([NativeTypeName("long *")] int* p);
        [VtblIndex(16)]
        HRESULT get_screenX([NativeTypeName("long *")] int* p);
        [VtblIndex(17)]
        HRESULT get_screenY([NativeTypeName("long *")] int* p);
        [VtblIndex(18)]
        HRESULT get_outerWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(19)]
        HRESULT get_outerHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(20)]
        HRESULT put_onabort(VARIANT v);
        [VtblIndex(21)]
        HRESULT get_onabort(VARIANT* p);
        [VtblIndex(22)]
        HRESULT put_oncanplay(VARIANT v);
        [VtblIndex(23)]
        HRESULT get_oncanplay(VARIANT* p);
        [VtblIndex(24)]
        HRESULT put_oncanplaythrough(VARIANT v);
        [VtblIndex(25)]
        HRESULT get_oncanplaythrough(VARIANT* p);
        [VtblIndex(26)]
        HRESULT put_onchange(VARIANT v);
        [VtblIndex(27)]
        HRESULT get_onchange(VARIANT* p);
        [VtblIndex(28)]
        HRESULT put_onclick(VARIANT v);
        [VtblIndex(29)]
        HRESULT get_onclick(VARIANT* p);
        [VtblIndex(30)]
        HRESULT put_oncontextmenu(VARIANT v);
        [VtblIndex(31)]
        HRESULT get_oncontextmenu(VARIANT* p);
        [VtblIndex(32)]
        HRESULT put_ondblclick(VARIANT v);
        [VtblIndex(33)]
        HRESULT get_ondblclick(VARIANT* p);
        [VtblIndex(34)]
        HRESULT put_ondrag(VARIANT v);
        [VtblIndex(35)]
        HRESULT get_ondrag(VARIANT* p);
        [VtblIndex(36)]
        HRESULT put_ondragend(VARIANT v);
        [VtblIndex(37)]
        HRESULT get_ondragend(VARIANT* p);
        [VtblIndex(38)]
        HRESULT put_ondragenter(VARIANT v);
        [VtblIndex(39)]
        HRESULT get_ondragenter(VARIANT* p);
        [VtblIndex(40)]
        HRESULT put_ondragleave(VARIANT v);
        [VtblIndex(41)]
        HRESULT get_ondragleave(VARIANT* p);
        [VtblIndex(42)]
        HRESULT put_ondragover(VARIANT v);
        [VtblIndex(43)]
        HRESULT get_ondragover(VARIANT* p);
        [VtblIndex(44)]
        HRESULT put_ondragstart(VARIANT v);
        [VtblIndex(45)]
        HRESULT get_ondragstart(VARIANT* p);
        [VtblIndex(46)]
        HRESULT put_ondrop(VARIANT v);
        [VtblIndex(47)]
        HRESULT get_ondrop(VARIANT* p);
        [VtblIndex(48)]
        HRESULT put_ondurationchange(VARIANT v);
        [VtblIndex(49)]
        HRESULT get_ondurationchange(VARIANT* p);
        [VtblIndex(50)]
        HRESULT put_onfocusin(VARIANT v);
        [VtblIndex(51)]
        HRESULT get_onfocusin(VARIANT* p);
        [VtblIndex(52)]
        HRESULT put_onfocusout(VARIANT v);
        [VtblIndex(53)]
        HRESULT get_onfocusout(VARIANT* p);
        [VtblIndex(54)]
        HRESULT put_oninput(VARIANT v);
        [VtblIndex(55)]
        HRESULT get_oninput(VARIANT* p);
        [VtblIndex(56)]
        HRESULT put_onemptied(VARIANT v);
        [VtblIndex(57)]
        HRESULT get_onemptied(VARIANT* p);
        [VtblIndex(58)]
        HRESULT put_onended(VARIANT v);
        [VtblIndex(59)]
        HRESULT get_onended(VARIANT* p);
        [VtblIndex(60)]
        HRESULT put_onkeydown(VARIANT v);
        [VtblIndex(61)]
        HRESULT get_onkeydown(VARIANT* p);
        [VtblIndex(62)]
        HRESULT put_onkeypress(VARIANT v);
        [VtblIndex(63)]
        HRESULT get_onkeypress(VARIANT* p);
        [VtblIndex(64)]
        HRESULT put_onkeyup(VARIANT v);
        [VtblIndex(65)]
        HRESULT get_onkeyup(VARIANT* p);
        [VtblIndex(66)]
        HRESULT put_onloadeddata(VARIANT v);
        [VtblIndex(67)]
        HRESULT get_onloadeddata(VARIANT* p);
        [VtblIndex(68)]
        HRESULT put_onloadedmetadata(VARIANT v);
        [VtblIndex(69)]
        HRESULT get_onloadedmetadata(VARIANT* p);
        [VtblIndex(70)]
        HRESULT put_onloadstart(VARIANT v);
        [VtblIndex(71)]
        HRESULT get_onloadstart(VARIANT* p);
        [VtblIndex(72)]
        HRESULT put_onmousedown(VARIANT v);
        [VtblIndex(73)]
        HRESULT get_onmousedown(VARIANT* p);
        [VtblIndex(74)]
        HRESULT put_onmouseenter(VARIANT v);
        [VtblIndex(75)]
        HRESULT get_onmouseenter(VARIANT* p);
        [VtblIndex(76)]
        HRESULT put_onmouseleave(VARIANT v);
        [VtblIndex(77)]
        HRESULT get_onmouseleave(VARIANT* p);
        [VtblIndex(78)]
        HRESULT put_onmousemove(VARIANT v);
        [VtblIndex(79)]
        HRESULT get_onmousemove(VARIANT* p);
        [VtblIndex(80)]
        HRESULT put_onmouseout(VARIANT v);
        [VtblIndex(81)]
        HRESULT get_onmouseout(VARIANT* p);
        [VtblIndex(82)]
        HRESULT put_onmouseover(VARIANT v);
        [VtblIndex(83)]
        HRESULT get_onmouseover(VARIANT* p);
        [VtblIndex(84)]
        HRESULT put_onmouseup(VARIANT v);
        [VtblIndex(85)]
        HRESULT get_onmouseup(VARIANT* p);
        [VtblIndex(86)]
        HRESULT put_onmousewheel(VARIANT v);
        [VtblIndex(87)]
        HRESULT get_onmousewheel(VARIANT* p);
        [VtblIndex(88)]
        HRESULT put_onoffline(VARIANT v);
        [VtblIndex(89)]
        HRESULT get_onoffline(VARIANT* p);
        [VtblIndex(90)]
        HRESULT put_ononline(VARIANT v);
        [VtblIndex(91)]
        HRESULT get_ononline(VARIANT* p);
        [VtblIndex(92)]
        HRESULT put_onprogress(VARIANT v);
        [VtblIndex(93)]
        HRESULT get_onprogress(VARIANT* p);
        [VtblIndex(94)]
        HRESULT put_onratechange(VARIANT v);
        [VtblIndex(95)]
        HRESULT get_onratechange(VARIANT* p);
        [VtblIndex(96)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(97)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(98)]
        HRESULT put_onreset(VARIANT v);
        [VtblIndex(99)]
        HRESULT get_onreset(VARIANT* p);
        [VtblIndex(100)]
        HRESULT put_onseeked(VARIANT v);
        [VtblIndex(101)]
        HRESULT get_onseeked(VARIANT* p);
        [VtblIndex(102)]
        HRESULT put_onseeking(VARIANT v);
        [VtblIndex(103)]
        HRESULT get_onseeking(VARIANT* p);
        [VtblIndex(104)]
        HRESULT put_onselect(VARIANT v);
        [VtblIndex(105)]
        HRESULT get_onselect(VARIANT* p);
        [VtblIndex(106)]
        HRESULT put_onstalled(VARIANT v);
        [VtblIndex(107)]
        HRESULT get_onstalled(VARIANT* p);
        [VtblIndex(108)]
        HRESULT put_onstorage(VARIANT v);
        [VtblIndex(109)]
        HRESULT get_onstorage(VARIANT* p);
        [VtblIndex(110)]
        HRESULT put_onsubmit(VARIANT v);
        [VtblIndex(111)]
        HRESULT get_onsubmit(VARIANT* p);
        [VtblIndex(112)]
        HRESULT put_onsuspend(VARIANT v);
        [VtblIndex(113)]
        HRESULT get_onsuspend(VARIANT* p);
        [VtblIndex(114)]
        HRESULT put_ontimeupdate(VARIANT v);
        [VtblIndex(115)]
        HRESULT get_ontimeupdate(VARIANT* p);
        [VtblIndex(116)]
        HRESULT put_onpause(VARIANT v);
        [VtblIndex(117)]
        HRESULT get_onpause(VARIANT* p);
        [VtblIndex(118)]
        HRESULT put_onplay(VARIANT v);
        [VtblIndex(119)]
        HRESULT get_onplay(VARIANT* p);
        [VtblIndex(120)]
        HRESULT put_onplaying(VARIANT v);
        [VtblIndex(121)]
        HRESULT get_onplaying(VARIANT* p);
        [VtblIndex(122)]
        HRESULT put_onvolumechange(VARIANT v);
        [VtblIndex(123)]
        HRESULT get_onvolumechange(VARIANT* p);
        [VtblIndex(124)]
        HRESULT put_onwaiting(VARIANT v);
        [VtblIndex(125)]
        HRESULT get_onwaiting(VARIANT* p);
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
        [NativeTypeName("HRESULT (IHTMLSelection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLSelection**, int> getSelection;
        [NativeTypeName("HRESULT (IHTMLDOMNode *, BSTR, IHTMLCSSStyleDeclaration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, ushort*, IHTMLCSSStyleDeclaration**, int> getComputedStyle;
        [NativeTypeName("HRESULT (IHTMLStyleMedia **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleMedia**, int> get_styleMedia;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_performance;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_performance;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_innerWidth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_innerHeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pageXOffset;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pageYOffset;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenY;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_outerWidth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_outerHeight;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onabort;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onabort;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncanplay;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncanplay;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncanplaythrough;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncanplaythrough;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onchange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onclick;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onclick;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncontextmenu;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncontextmenu;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondblclick;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondblclick;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondrag;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondrag;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragend;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragend;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragenter;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragenter;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragleave;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragleave;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragover;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragover;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragstart;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondrop;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondrop;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondurationchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondurationchange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocusin;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocusin;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocusout;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocusout;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oninput;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oninput;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onemptied;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onemptied;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onended;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onended;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeydown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeydown;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeypress;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeypress;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeyup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeyup;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onloadeddata;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onloadeddata;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onloadedmetadata;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onloadedmetadata;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onloadstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onloadstart;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousedown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousedown;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseenter;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseenter;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseleave;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseleave;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousemove;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousemove;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseout;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseout;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseover;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseover;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseup;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousewheel;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousewheel;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onoffline;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onoffline;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ononline;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ononline;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onprogress;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onprogress;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onratechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onratechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreset;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreset;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onseeked;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onseeked;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onseeking;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onseeking;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselect;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselect;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstalled;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstalled;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstorage;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstorage;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onsubmit;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onsubmit;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onsuspend;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onsuspend;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ontimeupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ontimeupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpause;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpause;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onplay;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onplay;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onplaying;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onplaying;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onvolumechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onvolumechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onwaiting;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onwaiting;
    }
}