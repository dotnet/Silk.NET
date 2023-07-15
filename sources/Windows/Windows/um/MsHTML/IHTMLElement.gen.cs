// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement"]/*'/>
[Guid("3050F1FF-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElement : IHTMLElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLElement*, uint> )(lpVtbl[1]))((IHTMLElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElement*, uint> )(lpVtbl[2]))((IHTMLElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElement*, uint*, int> )(lpVtbl[3]))((IHTMLElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.setAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, VARIANT, int, int> )(lpVtbl[7]))((IHTMLElement*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue, lFlags);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.getAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int, VARIANT*, int> )(lpVtbl[8]))((IHTMLElement*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.removeAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int, short*, int> )(lpVtbl[9]))((IHTMLElement*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, pfSuccess);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_className"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_className([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[10]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_className"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_className([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[11]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_id"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_id([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[12]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_id"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_id([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[13]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_tagName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[14]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_parentElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_parentElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IHTMLElement**, int> )(lpVtbl[15]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_style"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_style(IHTMLStyle** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IHTMLStyle**, int> )(lpVtbl[16]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onhelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onhelp(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[17]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onhelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onhelp(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[18]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_onclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[19]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_onclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[20]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_ondblclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_ondblclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[21]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_ondblclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ondblclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[22]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onkeydown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onkeydown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[23]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onkeydown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onkeydown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[24]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onkeyup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onkeyup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[25]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onkeyup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onkeyup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[26]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onkeypress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_onkeypress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[27]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onkeypress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_onkeypress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[28]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onmouseout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_onmouseout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[29]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onmouseout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_onmouseout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[30]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onmouseover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onmouseover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[31]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onmouseover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onmouseover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[32]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onmousemove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onmousemove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[33]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onmousemove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onmousemove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[34]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onmousedown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_onmousedown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[35]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onmousedown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_onmousedown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[36]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onmouseup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_onmouseup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[37]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onmouseup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_onmouseup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[38]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_document"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_document(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IDispatch**, int> )(lpVtbl[39]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_title([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[40]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_title([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[41]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_language"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_language([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[42]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_language"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_language([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[43]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onselectstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_onselectstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[44]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onselectstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_onselectstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[45]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.scrollIntoView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT scrollIntoView(VARIANT varargStart)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[46]))((IHTMLElement*)Unsafe.AsPointer(ref this), varargStart);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.contains"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT contains(IHTMLElement* pChild, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
    {
        return ((delegate* unmanaged<IHTMLElement*, IHTMLElement*, short*, int> )(lpVtbl[47]))((IHTMLElement*)Unsafe.AsPointer(ref this), pChild, pfResult);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_sourceIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_sourceIndex([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, int*, int> )(lpVtbl[48]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_recordNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_recordNumber(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[49]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_lang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_lang([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[50]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_lang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_lang([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[51]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_offsetLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_offsetLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, int*, int> )(lpVtbl[52]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_offsetTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_offsetTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, int*, int> )(lpVtbl[53]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_offsetWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_offsetWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, int*, int> )(lpVtbl[54]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_offsetHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_offsetHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, int*, int> )(lpVtbl[55]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_offsetParent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_offsetParent(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IHTMLElement**, int> )(lpVtbl[56]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_innerHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_innerHTML([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[57]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_innerHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_innerHTML([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[58]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_innerText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_innerText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[59]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_innerText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_innerText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[60]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_outerHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_outerHTML([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[61]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_outerHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_outerHTML([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[62]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_outerText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_outerText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, int> )(lpVtbl[63]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_outerText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_outerText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[64]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.insertAdjacentHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT insertAdjacentHTML([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* html)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, ushort*, int> )(lpVtbl[65]))((IHTMLElement*)Unsafe.AsPointer(ref this), where, html);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.insertAdjacentText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT insertAdjacentText([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort*, ushort*, int> )(lpVtbl[66]))((IHTMLElement*)Unsafe.AsPointer(ref this), where, text);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_parentTextEdit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_parentTextEdit(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IHTMLElement**, int> )(lpVtbl[67]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_isTextEdit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_isTextEdit([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, short*, int> )(lpVtbl[68]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.click"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT click()
    {
        return ((delegate* unmanaged<IHTMLElement*, int> )(lpVtbl[69]))((IHTMLElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_filters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_filters(IHTMLFiltersCollection** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IHTMLFiltersCollection**, int> )(lpVtbl[70]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_ondragstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_ondragstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[71]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_ondragstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_ondragstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[72]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLElement*, ushort**, int> )(lpVtbl[73]))((IHTMLElement*)Unsafe.AsPointer(ref this), String);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onbeforeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT put_onbeforeupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[74]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onbeforeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_onbeforeupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[75]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onafterupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT put_onafterupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[76]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onafterupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_onafterupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[77]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onerrorupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT put_onerrorupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[78]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onerrorupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_onerrorupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[79]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onrowexit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT put_onrowexit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[80]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onrowexit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_onrowexit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[81]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onrowenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT put_onrowenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[82]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onrowenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_onrowenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[83]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_ondatasetchanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT put_ondatasetchanged(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[84]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_ondatasetchanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_ondatasetchanged(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[85]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_ondataavailable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT put_ondataavailable(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[86]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_ondataavailable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_ondataavailable(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[87]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_ondatasetcomplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT put_ondatasetcomplete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[88]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_ondatasetcomplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_ondatasetcomplete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[89]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.put_onfilterchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT put_onfilterchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT, int> )(lpVtbl[90]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_onfilterchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_onfilterchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int> )(lpVtbl[91]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_children"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_children(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IDispatch**, int> )(lpVtbl[92]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement.xml' path='doc/member[@name="IHTMLElement.get_all"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_all(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLElement*, IDispatch**, int> )(lpVtbl[93]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1);
        [VtblIndex(8)]
        HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue);
        [VtblIndex(9)]
        HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess);
        [VtblIndex(10)]
        HRESULT put_className([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(11)]
        HRESULT get_className([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT put_id([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(13)]
        HRESULT get_id([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(14)]
        HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT get_parentElement(IHTMLElement** p);
        [VtblIndex(16)]
        HRESULT get_style(IHTMLStyle** p);
        [VtblIndex(17)]
        HRESULT put_onhelp(VARIANT v);
        [VtblIndex(18)]
        HRESULT get_onhelp(VARIANT* p);
        [VtblIndex(19)]
        HRESULT put_onclick(VARIANT v);
        [VtblIndex(20)]
        HRESULT get_onclick(VARIANT* p);
        [VtblIndex(21)]
        HRESULT put_ondblclick(VARIANT v);
        [VtblIndex(22)]
        HRESULT get_ondblclick(VARIANT* p);
        [VtblIndex(23)]
        HRESULT put_onkeydown(VARIANT v);
        [VtblIndex(24)]
        HRESULT get_onkeydown(VARIANT* p);
        [VtblIndex(25)]
        HRESULT put_onkeyup(VARIANT v);
        [VtblIndex(26)]
        HRESULT get_onkeyup(VARIANT* p);
        [VtblIndex(27)]
        HRESULT put_onkeypress(VARIANT v);
        [VtblIndex(28)]
        HRESULT get_onkeypress(VARIANT* p);
        [VtblIndex(29)]
        HRESULT put_onmouseout(VARIANT v);
        [VtblIndex(30)]
        HRESULT get_onmouseout(VARIANT* p);
        [VtblIndex(31)]
        HRESULT put_onmouseover(VARIANT v);
        [VtblIndex(32)]
        HRESULT get_onmouseover(VARIANT* p);
        [VtblIndex(33)]
        HRESULT put_onmousemove(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_onmousemove(VARIANT* p);
        [VtblIndex(35)]
        HRESULT put_onmousedown(VARIANT v);
        [VtblIndex(36)]
        HRESULT get_onmousedown(VARIANT* p);
        [VtblIndex(37)]
        HRESULT put_onmouseup(VARIANT v);
        [VtblIndex(38)]
        HRESULT get_onmouseup(VARIANT* p);
        [VtblIndex(39)]
        HRESULT get_document(IDispatch** p);
        [VtblIndex(40)]
        HRESULT put_title([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(41)]
        HRESULT get_title([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(42)]
        HRESULT put_language([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(43)]
        HRESULT get_language([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(44)]
        HRESULT put_onselectstart(VARIANT v);
        [VtblIndex(45)]
        HRESULT get_onselectstart(VARIANT* p);
        [VtblIndex(46)]
        HRESULT scrollIntoView(VARIANT varargStart);
        [VtblIndex(47)]
        HRESULT contains(IHTMLElement* pChild, [NativeTypeName("VARIANT_BOOL *")] short* pfResult);
        [VtblIndex(48)]
        HRESULT get_sourceIndex([NativeTypeName("long *")] int* p);
        [VtblIndex(49)]
        HRESULT get_recordNumber(VARIANT* p);
        [VtblIndex(50)]
        HRESULT put_lang([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(51)]
        HRESULT get_lang([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(52)]
        HRESULT get_offsetLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(53)]
        HRESULT get_offsetTop([NativeTypeName("long *")] int* p);
        [VtblIndex(54)]
        HRESULT get_offsetWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(55)]
        HRESULT get_offsetHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(56)]
        HRESULT get_offsetParent(IHTMLElement** p);
        [VtblIndex(57)]
        HRESULT put_innerHTML([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(58)]
        HRESULT get_innerHTML([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(59)]
        HRESULT put_innerText([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(60)]
        HRESULT get_innerText([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(61)]
        HRESULT put_outerHTML([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(62)]
        HRESULT get_outerHTML([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(63)]
        HRESULT put_outerText([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(64)]
        HRESULT get_outerText([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(65)]
        HRESULT insertAdjacentHTML([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* html);
        [VtblIndex(66)]
        HRESULT insertAdjacentText([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* text);
        [VtblIndex(67)]
        HRESULT get_parentTextEdit(IHTMLElement** p);
        [VtblIndex(68)]
        HRESULT get_isTextEdit([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(69)]
        HRESULT click();
        [VtblIndex(70)]
        HRESULT get_filters(IHTMLFiltersCollection** p);
        [VtblIndex(71)]
        HRESULT put_ondragstart(VARIANT v);
        [VtblIndex(72)]
        HRESULT get_ondragstart(VARIANT* p);
        [VtblIndex(73)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** String);
        [VtblIndex(74)]
        HRESULT put_onbeforeupdate(VARIANT v);
        [VtblIndex(75)]
        HRESULT get_onbeforeupdate(VARIANT* p);
        [VtblIndex(76)]
        HRESULT put_onafterupdate(VARIANT v);
        [VtblIndex(77)]
        HRESULT get_onafterupdate(VARIANT* p);
        [VtblIndex(78)]
        HRESULT put_onerrorupdate(VARIANT v);
        [VtblIndex(79)]
        HRESULT get_onerrorupdate(VARIANT* p);
        [VtblIndex(80)]
        HRESULT put_onrowexit(VARIANT v);
        [VtblIndex(81)]
        HRESULT get_onrowexit(VARIANT* p);
        [VtblIndex(82)]
        HRESULT put_onrowenter(VARIANT v);
        [VtblIndex(83)]
        HRESULT get_onrowenter(VARIANT* p);
        [VtblIndex(84)]
        HRESULT put_ondatasetchanged(VARIANT v);
        [VtblIndex(85)]
        HRESULT get_ondatasetchanged(VARIANT* p);
        [VtblIndex(86)]
        HRESULT put_ondataavailable(VARIANT v);
        [VtblIndex(87)]
        HRESULT get_ondataavailable(VARIANT* p);
        [VtblIndex(88)]
        HRESULT put_ondatasetcomplete(VARIANT v);
        [VtblIndex(89)]
        HRESULT get_ondatasetcomplete(VARIANT* p);
        [VtblIndex(90)]
        HRESULT put_onfilterchange(VARIANT v);
        [VtblIndex(91)]
        HRESULT get_onfilterchange(VARIANT* p);
        [VtblIndex(92)]
        HRESULT get_children(IDispatch** p);
        [VtblIndex(93)]
        HRESULT get_all(IDispatch** p);
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
        [NativeTypeName("HRESULT (BSTR, VARIANT, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int, int> setAttribute;
        [NativeTypeName("HRESULT (BSTR, LONG, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int> getAttribute;
        [NativeTypeName("HRESULT (BSTR, LONG, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, short*, int> removeAttribute;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_className;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_className;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_id;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_id;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_tagName;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_parentElement;
        [NativeTypeName("HRESULT (IHTMLStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyle**, int> get_style;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onhelp;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onhelp;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onclick;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onclick;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondblclick;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondblclick;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeydown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeydown;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeyup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeyup;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeypress;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeypress;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseout;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseout;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseover;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseover;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousemove;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousemove;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousedown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousedown;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseup;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_document;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_title;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_title;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_language;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_language;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselectstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselectstart;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> scrollIntoView;
        [NativeTypeName("HRESULT (IHTMLElement *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, short*, int> contains;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_sourceIndex;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_recordNumber;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_lang;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lang;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetWidth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetHeight;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_offsetParent;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_innerHTML;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_innerHTML;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_innerText;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_innerText;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_outerHTML;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outerHTML;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_outerText;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outerText;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> insertAdjacentHTML;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> insertAdjacentText;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_parentTextEdit;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isTextEdit;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> click;
        [NativeTypeName("HRESULT (IHTMLFiltersCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFiltersCollection**, int> get_filters;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragstart;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onafterupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onafterupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerrorupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerrorupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onrowexit;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onrowexit;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onrowenter;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onrowenter;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondatasetchanged;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondatasetchanged;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondataavailable;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondataavailable;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondatasetcomplete;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondatasetcomplete;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfilterchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfilterchange;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_children;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_all;
    }
}