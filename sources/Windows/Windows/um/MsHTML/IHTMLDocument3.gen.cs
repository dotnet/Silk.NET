// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3"]/*'/>
[Guid("3050F485-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument3 : IHTMLDocument3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDocument3*, uint> )(lpVtbl[1]))((IHTMLDocument3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument3*, uint> )(lpVtbl[2]))((IHTMLDocument3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, uint*, int> )(lpVtbl[3]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.releaseCapture"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT releaseCapture()
    {
        return ((delegate* unmanaged<IHTMLDocument3*, int> )(lpVtbl[7]))((IHTMLDocument3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.recalc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT recalc([NativeTypeName("VARIANT_BOOL")] short fForce = 0)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, short, int> )(lpVtbl[8]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), fForce);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.createTextNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT createTextNode([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode** newTextNode)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLDOMNode**, int> )(lpVtbl[9]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), text, newTextNode);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_documentElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_documentElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, IHTMLElement**, int> )(lpVtbl[10]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_uniqueID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_uniqueID([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort**, int> )(lpVtbl[11]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.attachEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IDispatch*, short*, int> )(lpVtbl[12]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), @event, pDisp, pfResult);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.detachEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IDispatch*, int> )(lpVtbl[13]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), @event, pDisp);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_onrowsdelete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onrowsdelete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[14]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_onrowsdelete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onrowsdelete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[15]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_onrowsinserted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onrowsinserted(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[16]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_onrowsinserted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onrowsinserted(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[17]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_oncellchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_oncellchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[18]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_oncellchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_oncellchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[19]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_ondatasetchanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ondatasetchanged(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[20]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_ondatasetchanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ondatasetchanged(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[21]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_ondataavailable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_ondataavailable(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[22]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_ondataavailable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ondataavailable(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[23]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_ondatasetcomplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_ondatasetcomplete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[24]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_ondatasetcomplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ondatasetcomplete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[25]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_onpropertychange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_onpropertychange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[26]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_onpropertychange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_onpropertychange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[27]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_dir"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_dir([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, int> )(lpVtbl[28]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_dir"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort**, int> )(lpVtbl[29]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_oncontextmenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_oncontextmenu(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[30]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_oncontextmenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_oncontextmenu(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[31]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_onstop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_onstop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[32]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_onstop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_onstop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[33]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.createDocumentFragment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT createDocumentFragment(IHTMLDocument2** pNewDoc)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, IHTMLDocument2**, int> )(lpVtbl[34]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), pNewDoc);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_parentDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_parentDocument(IHTMLDocument2** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, IHTMLDocument2**, int> )(lpVtbl[35]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_enableDownload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_enableDownload([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, short, int> )(lpVtbl[36]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_enableDownload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_enableDownload([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, short*, int> )(lpVtbl[37]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_baseUrl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_baseUrl([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, int> )(lpVtbl[38]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_baseUrl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_baseUrl([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort**, int> )(lpVtbl[39]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_childNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_childNodes(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, IDispatch**, int> )(lpVtbl[40]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_inheritStyleSheets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_inheritStyleSheets([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, short, int> )(lpVtbl[41]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_inheritStyleSheets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_inheritStyleSheets([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, short*, int> )(lpVtbl[42]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.put_onbeforeeditfocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_onbeforeeditfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int> )(lpVtbl[43]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.get_onbeforeeditfocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_onbeforeeditfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int> )(lpVtbl[44]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.getElementsByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT getElementsByName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLElementCollection**, int> )(lpVtbl[45]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v, pelColl);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.getElementById"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT getElementById([NativeTypeName("BSTR")] ushort* v, IHTMLElement** pel)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLElement**, int> )(lpVtbl[46]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v, pel);
    }

    /// <include file='IHTMLDocument3.xml' path='doc/member[@name="IHTMLDocument3.getElementsByTagName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT getElementsByTagName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl)
    {
        return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLElementCollection**, int> )(lpVtbl[47]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v, pelColl);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT releaseCapture();
        [VtblIndex(8)]
        HRESULT recalc([NativeTypeName("VARIANT_BOOL")] short fForce = 0);
        [VtblIndex(9)]
        HRESULT createTextNode([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode** newTextNode);
        [VtblIndex(10)]
        HRESULT get_documentElement(IHTMLElement** p);
        [VtblIndex(11)]
        HRESULT get_uniqueID([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult);
        [VtblIndex(13)]
        HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp);
        [VtblIndex(14)]
        HRESULT put_onrowsdelete(VARIANT v);
        [VtblIndex(15)]
        HRESULT get_onrowsdelete(VARIANT* p);
        [VtblIndex(16)]
        HRESULT put_onrowsinserted(VARIANT v);
        [VtblIndex(17)]
        HRESULT get_onrowsinserted(VARIANT* p);
        [VtblIndex(18)]
        HRESULT put_oncellchange(VARIANT v);
        [VtblIndex(19)]
        HRESULT get_oncellchange(VARIANT* p);
        [VtblIndex(20)]
        HRESULT put_ondatasetchanged(VARIANT v);
        [VtblIndex(21)]
        HRESULT get_ondatasetchanged(VARIANT* p);
        [VtblIndex(22)]
        HRESULT put_ondataavailable(VARIANT v);
        [VtblIndex(23)]
        HRESULT get_ondataavailable(VARIANT* p);
        [VtblIndex(24)]
        HRESULT put_ondatasetcomplete(VARIANT v);
        [VtblIndex(25)]
        HRESULT get_ondatasetcomplete(VARIANT* p);
        [VtblIndex(26)]
        HRESULT put_onpropertychange(VARIANT v);
        [VtblIndex(27)]
        HRESULT get_onpropertychange(VARIANT* p);
        [VtblIndex(28)]
        HRESULT put_dir([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(29)]
        HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(30)]
        HRESULT put_oncontextmenu(VARIANT v);
        [VtblIndex(31)]
        HRESULT get_oncontextmenu(VARIANT* p);
        [VtblIndex(32)]
        HRESULT put_onstop(VARIANT v);
        [VtblIndex(33)]
        HRESULT get_onstop(VARIANT* p);
        [VtblIndex(34)]
        HRESULT createDocumentFragment(IHTMLDocument2** pNewDoc);
        [VtblIndex(35)]
        HRESULT get_parentDocument(IHTMLDocument2** p);
        [VtblIndex(36)]
        HRESULT put_enableDownload([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(37)]
        HRESULT get_enableDownload([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(38)]
        HRESULT put_baseUrl([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(39)]
        HRESULT get_baseUrl([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(40)]
        HRESULT get_childNodes(IDispatch** p);
        [VtblIndex(41)]
        HRESULT put_inheritStyleSheets([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(42)]
        HRESULT get_inheritStyleSheets([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(43)]
        HRESULT put_onbeforeeditfocus(VARIANT v);
        [VtblIndex(44)]
        HRESULT get_onbeforeeditfocus(VARIANT* p);
        [VtblIndex(45)]
        HRESULT getElementsByName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl);
        [VtblIndex(46)]
        HRESULT getElementById([NativeTypeName("BSTR")] ushort* v, IHTMLElement** pel);
        [VtblIndex(47)]
        HRESULT getElementsByTagName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> releaseCapture;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> recalc;
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMNode**, int> createTextNode;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_documentElement;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_uniqueID;
        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch*, short*, int> attachEvent;
        [NativeTypeName("HRESULT (BSTR, IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch*, int> detachEvent;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onrowsdelete;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onrowsdelete;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onrowsinserted;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onrowsinserted;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncellchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncellchange;
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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpropertychange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpropertychange;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dir;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dir;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncontextmenu;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncontextmenu;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstop;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstop;
        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2**, int> createDocumentFragment;
        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2**, int> get_parentDocument;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_enableDownload;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_enableDownload;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_baseUrl;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_baseUrl;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_childNodes;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_inheritStyleSheets;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_inheritStyleSheets;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeeditfocus;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeeditfocus;
        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElementCollection**, int> getElementsByName;
        [NativeTypeName("HRESULT (BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement**, int> getElementById;
        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElementCollection**, int> getElementsByTagName;
    }
}