// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7"]/*'/>
[Guid("305104B8-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument7 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument7 : IHTMLDocument7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument7));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDocument7*, uint> )(lpVtbl[1]))((IHTMLDocument7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument7*, uint> )(lpVtbl[2]))((IHTMLDocument7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, uint*, int> )(lpVtbl[3]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_defaultView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_defaultView(IHTMLWindow2** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLWindow2**, int> )(lpVtbl[7]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.createCDATASection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT createCDATASection([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode** newCDATASectionNode)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLDOMNode**, int> )(lpVtbl[8]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), text, newCDATASectionNode);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.getSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT getSelection(IHTMLSelection** ppIHTMLSelection)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLSelection**, int> )(lpVtbl[9]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), ppIHTMLSelection);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.getElementsByTagNameNS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getElementsByTagNameNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrLocalName, IHTMLElementCollection** pelColl)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, ushort*, IHTMLElementCollection**, int> )(lpVtbl[10]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pvarNS, bstrLocalName, pelColl);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.createElementNS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT createElementNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrTag, IHTMLElement** newElem)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, ushort*, IHTMLElement**, int> )(lpVtbl[11]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pvarNS, bstrTag, newElem);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.createAttributeNS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT createAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrAttrName, IHTMLDOMAttribute** ppAttribute)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, ushort*, IHTMLDOMAttribute**, int> )(lpVtbl[12]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pvarNS, bstrAttrName, ppAttribute);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onmsthumbnailclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onmsthumbnailclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[13]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onmsthumbnailclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onmsthumbnailclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[14]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_characterSet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_characterSet([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int> )(lpVtbl[15]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.createElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT createElement([NativeTypeName("BSTR")] ushort* bstrTag, IHTMLElement** newElem)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLElement**, int> )(lpVtbl[16]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), bstrTag, newElem);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.createAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT createAttribute([NativeTypeName("BSTR")] ushort* bstrAttrName, IHTMLDOMAttribute** ppAttribute)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLDOMAttribute**, int> )(lpVtbl[17]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), bstrAttrName, ppAttribute);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.getElementsByClassName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT getElementsByClassName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pel)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLElementCollection**, int> )(lpVtbl[18]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v, pel);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.createProcessingInstruction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT createProcessingInstruction([NativeTypeName("BSTR")] ushort* bstrTarget, [NativeTypeName("BSTR")] ushort* bstrData, IDOMProcessingInstruction** newProcessingInstruction)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort*, ushort*, IDOMProcessingInstruction**, int> )(lpVtbl[19]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), bstrTarget, bstrData, newProcessingInstruction);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.adoptNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT adoptNode(IHTMLDOMNode* pNodeSource, IHTMLDOMNode3** ppNodeDest)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLDOMNode*, IHTMLDOMNode3**, int> )(lpVtbl[20]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pNodeSource, ppNodeDest);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onmssitemodejumplistitemremoved"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_onmssitemodejumplistitemremoved(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[21]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onmssitemodejumplistitemremoved"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_onmssitemodejumplistitemremoved(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[22]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_all"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_all(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElementCollection**, int> )(lpVtbl[23]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_inputEncoding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_inputEncoding([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int> )(lpVtbl[24]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_xmlEncoding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_xmlEncoding([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int> )(lpVtbl[25]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_xmlStandalone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_xmlStandalone([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, short, int> )(lpVtbl[26]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_xmlStandalone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_xmlStandalone([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, short*, int> )(lpVtbl[27]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_xmlVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_xmlVersion([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort*, int> )(lpVtbl[28]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_xmlVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_xmlVersion([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int> )(lpVtbl[29]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.hasAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, short*, int> )(lpVtbl[30]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pfHasAttributes);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onabort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onabort(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[31]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onabort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onabort(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[32]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onblur"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onblur(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[33]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onblur"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onblur(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[34]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_oncanplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_oncanplay(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[35]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_oncanplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_oncanplay(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[36]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_oncanplaythrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_oncanplaythrough(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[37]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_oncanplaythrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_oncanplaythrough(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[38]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[39]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[40]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_ondrag(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[41]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_ondrag(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[42]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondragend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_ondragend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[43]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondragend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_ondragend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[44]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondragenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_ondragenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[45]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondragenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_ondragenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[46]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondragleave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_ondragleave(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[47]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondragleave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_ondragleave(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[48]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondragover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_ondragover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[49]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondragover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_ondragover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[50]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondrop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_ondrop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[51]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondrop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_ondrop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[52]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ondurationchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_ondurationchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[53]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ondurationchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_ondurationchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[54]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onemptied"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_onemptied(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[55]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onemptied"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_onemptied(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[56]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onended"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_onended(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[57]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onended"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_onended(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[58]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[59]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[60]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onfocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_onfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[61]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onfocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_onfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[62]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_oninput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_oninput(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[63]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_oninput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_oninput(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[64]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[65]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[66]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onloadeddata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT put_onloadeddata(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[67]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onloadeddata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_onloadeddata(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[68]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onloadedmetadata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT put_onloadedmetadata(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[69]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onloadedmetadata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_onloadedmetadata(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[70]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onloadstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_onloadstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[71]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onloadstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_onloadstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[72]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onpause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_onpause(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[73]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onpause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_onpause(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[74]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_onplay(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[75]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_onplay(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[76]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onplaying"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_onplaying(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[77]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onplaying"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_onplaying(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[78]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onprogress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_onprogress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[79]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onprogress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_onprogress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[80]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onratechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT put_onratechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[81]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onratechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_onratechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[82]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onreset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT put_onreset(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[83]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onreset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_onreset(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[84]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onscroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT put_onscroll(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[85]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onscroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_onscroll(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[86]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onseeked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT put_onseeked(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[87]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onseeked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_onseeked(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[88]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onseeking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_onseeking(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[89]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onseeking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_onseeking(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[90]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[91]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[92]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onstalled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT put_onstalled(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[93]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onstalled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_onstalled(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[94]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onsubmit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT put_onsubmit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[95]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onsubmit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_onsubmit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[96]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onsuspend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT put_onsuspend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[97]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onsuspend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_onsuspend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[98]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_ontimeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT put_ontimeupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[99]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_ontimeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_ontimeupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[100]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onvolumechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT put_onvolumechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[101]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onvolumechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_onvolumechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[102]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.put_onwaiting"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT put_onwaiting(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int> )(lpVtbl[103]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_onwaiting"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_onwaiting(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int> )(lpVtbl[104]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.normalize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT normalize()
    {
        return ((delegate* unmanaged<IHTMLDocument7*, int> )(lpVtbl[105]))((IHTMLDocument7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.importNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT importNode(IHTMLDOMNode* pNodeSource, [NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode3** ppNodeDest)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLDOMNode*, short, IHTMLDOMNode3**, int> )(lpVtbl[106]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pNodeSource, fDeep, ppNodeDest);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_parentWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_parentWindow(IHTMLWindow2** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLWindow2**, int> )(lpVtbl[107]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.putref_body"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT putref_body(IHTMLElement* v)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElement*, int> )(lpVtbl[108]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_body"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_body(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElement**, int> )(lpVtbl[109]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument7.xml' path='doc/member[@name="IHTMLDocument7.get_head"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_head(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElement**, int> )(lpVtbl[110]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_defaultView(IHTMLWindow2** p);
        [VtblIndex(8)]
        HRESULT createCDATASection([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode** newCDATASectionNode);
        [VtblIndex(9)]
        HRESULT getSelection(IHTMLSelection** ppIHTMLSelection);
        [VtblIndex(10)]
        HRESULT getElementsByTagNameNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrLocalName, IHTMLElementCollection** pelColl);
        [VtblIndex(11)]
        HRESULT createElementNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrTag, IHTMLElement** newElem);
        [VtblIndex(12)]
        HRESULT createAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrAttrName, IHTMLDOMAttribute** ppAttribute);
        [VtblIndex(13)]
        HRESULT put_onmsthumbnailclick(VARIANT v);
        [VtblIndex(14)]
        HRESULT get_onmsthumbnailclick(VARIANT* p);
        [VtblIndex(15)]
        HRESULT get_characterSet([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(16)]
        HRESULT createElement([NativeTypeName("BSTR")] ushort* bstrTag, IHTMLElement** newElem);
        [VtblIndex(17)]
        HRESULT createAttribute([NativeTypeName("BSTR")] ushort* bstrAttrName, IHTMLDOMAttribute** ppAttribute);
        [VtblIndex(18)]
        HRESULT getElementsByClassName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pel);
        [VtblIndex(19)]
        HRESULT createProcessingInstruction([NativeTypeName("BSTR")] ushort* bstrTarget, [NativeTypeName("BSTR")] ushort* bstrData, IDOMProcessingInstruction** newProcessingInstruction);
        [VtblIndex(20)]
        HRESULT adoptNode(IHTMLDOMNode* pNodeSource, IHTMLDOMNode3** ppNodeDest);
        [VtblIndex(21)]
        HRESULT put_onmssitemodejumplistitemremoved(VARIANT v);
        [VtblIndex(22)]
        HRESULT get_onmssitemodejumplistitemremoved(VARIANT* p);
        [VtblIndex(23)]
        HRESULT get_all(IHTMLElementCollection** p);
        [VtblIndex(24)]
        HRESULT get_inputEncoding([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(25)]
        HRESULT get_xmlEncoding([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(26)]
        HRESULT put_xmlStandalone([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(27)]
        HRESULT get_xmlStandalone([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(28)]
        HRESULT put_xmlVersion([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(29)]
        HRESULT get_xmlVersion([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(30)]
        HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes);
        [VtblIndex(31)]
        HRESULT put_onabort(VARIANT v);
        [VtblIndex(32)]
        HRESULT get_onabort(VARIANT* p);
        [VtblIndex(33)]
        HRESULT put_onblur(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_onblur(VARIANT* p);
        [VtblIndex(35)]
        HRESULT put_oncanplay(VARIANT v);
        [VtblIndex(36)]
        HRESULT get_oncanplay(VARIANT* p);
        [VtblIndex(37)]
        HRESULT put_oncanplaythrough(VARIANT v);
        [VtblIndex(38)]
        HRESULT get_oncanplaythrough(VARIANT* p);
        [VtblIndex(39)]
        HRESULT put_onchange(VARIANT v);
        [VtblIndex(40)]
        HRESULT get_onchange(VARIANT* p);
        [VtblIndex(41)]
        HRESULT put_ondrag(VARIANT v);
        [VtblIndex(42)]
        HRESULT get_ondrag(VARIANT* p);
        [VtblIndex(43)]
        HRESULT put_ondragend(VARIANT v);
        [VtblIndex(44)]
        HRESULT get_ondragend(VARIANT* p);
        [VtblIndex(45)]
        HRESULT put_ondragenter(VARIANT v);
        [VtblIndex(46)]
        HRESULT get_ondragenter(VARIANT* p);
        [VtblIndex(47)]
        HRESULT put_ondragleave(VARIANT v);
        [VtblIndex(48)]
        HRESULT get_ondragleave(VARIANT* p);
        [VtblIndex(49)]
        HRESULT put_ondragover(VARIANT v);
        [VtblIndex(50)]
        HRESULT get_ondragover(VARIANT* p);
        [VtblIndex(51)]
        HRESULT put_ondrop(VARIANT v);
        [VtblIndex(52)]
        HRESULT get_ondrop(VARIANT* p);
        [VtblIndex(53)]
        HRESULT put_ondurationchange(VARIANT v);
        [VtblIndex(54)]
        HRESULT get_ondurationchange(VARIANT* p);
        [VtblIndex(55)]
        HRESULT put_onemptied(VARIANT v);
        [VtblIndex(56)]
        HRESULT get_onemptied(VARIANT* p);
        [VtblIndex(57)]
        HRESULT put_onended(VARIANT v);
        [VtblIndex(58)]
        HRESULT get_onended(VARIANT* p);
        [VtblIndex(59)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(60)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(61)]
        HRESULT put_onfocus(VARIANT v);
        [VtblIndex(62)]
        HRESULT get_onfocus(VARIANT* p);
        [VtblIndex(63)]
        HRESULT put_oninput(VARIANT v);
        [VtblIndex(64)]
        HRESULT get_oninput(VARIANT* p);
        [VtblIndex(65)]
        HRESULT put_onload(VARIANT v);
        [VtblIndex(66)]
        HRESULT get_onload(VARIANT* p);
        [VtblIndex(67)]
        HRESULT put_onloadeddata(VARIANT v);
        [VtblIndex(68)]
        HRESULT get_onloadeddata(VARIANT* p);
        [VtblIndex(69)]
        HRESULT put_onloadedmetadata(VARIANT v);
        [VtblIndex(70)]
        HRESULT get_onloadedmetadata(VARIANT* p);
        [VtblIndex(71)]
        HRESULT put_onloadstart(VARIANT v);
        [VtblIndex(72)]
        HRESULT get_onloadstart(VARIANT* p);
        [VtblIndex(73)]
        HRESULT put_onpause(VARIANT v);
        [VtblIndex(74)]
        HRESULT get_onpause(VARIANT* p);
        [VtblIndex(75)]
        HRESULT put_onplay(VARIANT v);
        [VtblIndex(76)]
        HRESULT get_onplay(VARIANT* p);
        [VtblIndex(77)]
        HRESULT put_onplaying(VARIANT v);
        [VtblIndex(78)]
        HRESULT get_onplaying(VARIANT* p);
        [VtblIndex(79)]
        HRESULT put_onprogress(VARIANT v);
        [VtblIndex(80)]
        HRESULT get_onprogress(VARIANT* p);
        [VtblIndex(81)]
        HRESULT put_onratechange(VARIANT v);
        [VtblIndex(82)]
        HRESULT get_onratechange(VARIANT* p);
        [VtblIndex(83)]
        HRESULT put_onreset(VARIANT v);
        [VtblIndex(84)]
        HRESULT get_onreset(VARIANT* p);
        [VtblIndex(85)]
        HRESULT put_onscroll(VARIANT v);
        [VtblIndex(86)]
        HRESULT get_onscroll(VARIANT* p);
        [VtblIndex(87)]
        HRESULT put_onseeked(VARIANT v);
        [VtblIndex(88)]
        HRESULT get_onseeked(VARIANT* p);
        [VtblIndex(89)]
        HRESULT put_onseeking(VARIANT v);
        [VtblIndex(90)]
        HRESULT get_onseeking(VARIANT* p);
        [VtblIndex(91)]
        HRESULT put_onselect(VARIANT v);
        [VtblIndex(92)]
        HRESULT get_onselect(VARIANT* p);
        [VtblIndex(93)]
        HRESULT put_onstalled(VARIANT v);
        [VtblIndex(94)]
        HRESULT get_onstalled(VARIANT* p);
        [VtblIndex(95)]
        HRESULT put_onsubmit(VARIANT v);
        [VtblIndex(96)]
        HRESULT get_onsubmit(VARIANT* p);
        [VtblIndex(97)]
        HRESULT put_onsuspend(VARIANT v);
        [VtblIndex(98)]
        HRESULT get_onsuspend(VARIANT* p);
        [VtblIndex(99)]
        HRESULT put_ontimeupdate(VARIANT v);
        [VtblIndex(100)]
        HRESULT get_ontimeupdate(VARIANT* p);
        [VtblIndex(101)]
        HRESULT put_onvolumechange(VARIANT v);
        [VtblIndex(102)]
        HRESULT get_onvolumechange(VARIANT* p);
        [VtblIndex(103)]
        HRESULT put_onwaiting(VARIANT v);
        [VtblIndex(104)]
        HRESULT get_onwaiting(VARIANT* p);
        [VtblIndex(105)]
        HRESULT normalize();
        [VtblIndex(106)]
        HRESULT importNode(IHTMLDOMNode* pNodeSource, [NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode3** ppNodeDest);
        [VtblIndex(107)]
        HRESULT get_parentWindow(IHTMLWindow2** p);
        [VtblIndex(108)]
        HRESULT putref_body(IHTMLElement* v);
        [VtblIndex(109)]
        HRESULT get_body(IHTMLElement** p);
        [VtblIndex(110)]
        HRESULT get_head(IHTMLElement** p);
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
        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2**, int> get_defaultView;
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMNode**, int> createCDATASection;
        [NativeTypeName("HRESULT (IHTMLSelection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLSelection**, int> getSelection;
        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLElementCollection**, int> getElementsByTagNameNS;
        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLElement**, int> createElementNS;
        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLDOMAttribute**, int> createAttributeNS;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsthumbnailclick;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsthumbnailclick;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_characterSet;
        [NativeTypeName("HRESULT (BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement**, int> createElement;
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute**, int> createAttribute;
        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElementCollection**, int> getElementsByClassName;
        [NativeTypeName("HRESULT (BSTR, BSTR, IDOMProcessingInstruction **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IDOMProcessingInstruction**, int> createProcessingInstruction;
        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode3 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode3**, int> adoptNode;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmssitemodejumplistitemremoved;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmssitemodejumplistitemremoved;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_all;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_inputEncoding;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_xmlEncoding;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_xmlStandalone;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_xmlStandalone;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_xmlVersion;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_xmlVersion;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasAttributes;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onabort;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onabort;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onblur;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onblur;
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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondrop;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondrop;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondurationchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondurationchange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onemptied;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onemptied;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onended;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onended;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocus;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocus;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oninput;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oninput;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;
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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onprogress;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onprogress;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onratechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onratechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreset;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreset;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onscroll;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onscroll;
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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onvolumechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onvolumechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onwaiting;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onwaiting;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> normalize;
        [NativeTypeName("HRESULT (IHTMLDOMNode *, VARIANT_BOOL, IHTMLDOMNode3 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, short, IHTMLDOMNode3**, int> importNode;
        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2**, int> get_parentWindow;
        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> putref_body;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_body;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_head;
    }
}