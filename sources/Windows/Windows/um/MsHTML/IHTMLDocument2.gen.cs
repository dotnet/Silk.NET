// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2"]/*'/>
[Guid("332C4425-26CB-11D0-B483-00C04FD90119")]
[NativeTypeName("struct IHTMLDocument2 : IHTMLDocument")]
[NativeInheritance("IHTMLDocument")]
public unsafe partial struct IHTMLDocument2 : IHTMLDocument2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDocument2*, uint> )(lpVtbl[1]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument2*, uint> )(lpVtbl[2]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, uint*, int> )(lpVtbl[3]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IHTMLDocument.get_Script"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Script(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IDispatch**, int> )(lpVtbl[7]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_all"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_all(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[8]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_body"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_body(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElement**, int> )(lpVtbl[9]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_activeElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_activeElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElement**, int> )(lpVtbl[10]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_images"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_images(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[11]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_applets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_applets(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[12]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_links"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_links(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[13]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_forms"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_forms(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[14]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_anchors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_anchors(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[15]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_title([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[16]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_title([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[17]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_scripts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_scripts(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[18]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_designMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_designMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[19]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_designMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_designMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[20]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_selection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_selection(IHTMLSelectionObject** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLSelectionObject**, int> )(lpVtbl[21]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[22]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_frames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_frames(IHTMLFramesCollection2** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLFramesCollection2**, int> )(lpVtbl[23]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_embeds"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_embeds(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[24]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_plugins"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_plugins(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int> )(lpVtbl[25]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_alinkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_alinkColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[26]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_alinkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_alinkColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[27]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[28]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[29]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_fgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_fgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[30]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_fgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_fgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[31]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_linkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_linkColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[32]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_linkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_linkColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[33]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_vlinkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_vlinkColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[34]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_vlinkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_vlinkColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[35]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_referrer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_referrer([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[36]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_location"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_location(IHTMLLocation** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLLocation**, int> )(lpVtbl[37]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_lastModified"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_lastModified([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[38]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_URL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_URL([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[39]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_URL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[40]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_domain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_domain([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[41]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_domain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_domain([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[42]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_cookie"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_cookie([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[43]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_cookie"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_cookie([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[44]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_expando"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_expando([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, short, int> )(lpVtbl[45]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_expando"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_expando([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, short*, int> )(lpVtbl[46]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_charset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_charset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[47]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_charset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[48]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_defaultCharset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_defaultCharset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int> )(lpVtbl[49]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_defaultCharset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_defaultCharset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[50]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_mimeType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[51]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_fileSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[52]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_fileCreatedDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[53]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_fileModifiedDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[54]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_fileUpdatedDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[55]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_security"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_security([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[56]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_protocol"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[57]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_nameProp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[58]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.write"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT write(SAFEARRAY* psarray)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, SAFEARRAY*, int> )(lpVtbl[59]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), psarray);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.writeln"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT writeln(SAFEARRAY* psarray)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, SAFEARRAY*, int> )(lpVtbl[60]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), psarray);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT open([NativeTypeName("BSTR")] ushort* url, VARIANT name, VARIANT features, VARIANT replace, IDispatch** pomWindowResult)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, VARIANT, VARIANT, VARIANT, IDispatch**, int> )(lpVtbl[61]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), url, name, features, replace, pomWindowResult);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT close()
    {
        return ((delegate* unmanaged<IHTMLDocument2*, int> )(lpVtbl[62]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.clear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT clear()
    {
        return ((delegate* unmanaged<IHTMLDocument2*, int> )(lpVtbl[63]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.queryCommandSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int> )(lpVtbl[64]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.queryCommandEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int> )(lpVtbl[65]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.queryCommandState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int> )(lpVtbl[66]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.queryCommandIndeterm"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int> )(lpVtbl[67]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.queryCommandText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, ushort**, int> )(lpVtbl[68]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.queryCommandValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, VARIANT*, int> )(lpVtbl[69]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.execCommand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short, VARIANT, short*, int> )(lpVtbl[70]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.execCommandShowHelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int> )(lpVtbl[71]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.createElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT createElement([NativeTypeName("BSTR")] ushort* eTag, IHTMLElement** newElem)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, IHTMLElement**, int> )(lpVtbl[72]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), eTag, newElem);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onhelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_onhelp(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[73]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onhelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_onhelp(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[74]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_onclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[75]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_onclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[76]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_ondblclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_ondblclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[77]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_ondblclick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_ondblclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[78]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onkeyup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_onkeyup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[79]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onkeyup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_onkeyup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[80]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onkeydown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT put_onkeydown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[81]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onkeydown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_onkeydown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[82]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onkeypress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT put_onkeypress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[83]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onkeypress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_onkeypress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[84]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onmouseup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT put_onmouseup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[85]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onmouseup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_onmouseup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[86]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onmousedown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT put_onmousedown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[87]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onmousedown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_onmousedown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[88]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onmousemove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_onmousemove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[89]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onmousemove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_onmousemove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[90]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onmouseout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT put_onmouseout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[91]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onmouseout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_onmouseout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[92]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onmouseover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT put_onmouseover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[93]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onmouseover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_onmouseover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[94]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[95]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[96]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onafterupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT put_onafterupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[97]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onafterupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_onafterupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[98]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onrowexit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT put_onrowexit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[99]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onrowexit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_onrowexit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[100]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onrowenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT put_onrowenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[101]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onrowenter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_onrowenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[102]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_ondragstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT put_ondragstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[103]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_ondragstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_ondragstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[104]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onselectstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT put_onselectstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[105]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onselectstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_onselectstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[106]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.elementFromPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT elementFromPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y, IHTMLElement** elementHit)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, int, int, IHTMLElement**, int> )(lpVtbl[107]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), x, y, elementHit);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_parentWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_parentWindow(IHTMLWindow2** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLWindow2**, int> )(lpVtbl[108]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_styleSheets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_styleSheets(IHTMLStyleSheetsCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, IHTMLStyleSheetsCollection**, int> )(lpVtbl[109]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onbeforeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT put_onbeforeupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[110]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onbeforeupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_onbeforeupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[111]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.put_onerrorupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT put_onerrorupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int> )(lpVtbl[112]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.get_onerrorupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_onerrorupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int> )(lpVtbl[113]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int> )(lpVtbl[114]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), String);
    }

    /// <include file='IHTMLDocument2.xml' path='doc/member[@name="IHTMLDocument2.createStyleSheet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT createStyleSheet([NativeTypeName("BSTR")] ushort* bstrHref, [NativeTypeName("long")] int lIndex, IHTMLStyleSheet** ppnewStyleSheet)
    {
        return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int, IHTMLStyleSheet**, int> )(lpVtbl[115]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), bstrHref, lIndex, ppnewStyleSheet);
    }

    public interface Interface : IHTMLDocument.Interface
    {
        [VtblIndex(8)]
        HRESULT get_all(IHTMLElementCollection** p);
        [VtblIndex(9)]
        HRESULT get_body(IHTMLElement** p);
        [VtblIndex(10)]
        HRESULT get_activeElement(IHTMLElement** p);
        [VtblIndex(11)]
        HRESULT get_images(IHTMLElementCollection** p);
        [VtblIndex(12)]
        HRESULT get_applets(IHTMLElementCollection** p);
        [VtblIndex(13)]
        HRESULT get_links(IHTMLElementCollection** p);
        [VtblIndex(14)]
        HRESULT get_forms(IHTMLElementCollection** p);
        [VtblIndex(15)]
        HRESULT get_anchors(IHTMLElementCollection** p);
        [VtblIndex(16)]
        HRESULT put_title([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(17)]
        HRESULT get_title([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(18)]
        HRESULT get_scripts(IHTMLElementCollection** p);
        [VtblIndex(19)]
        HRESULT put_designMode([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(20)]
        HRESULT get_designMode([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(21)]
        HRESULT get_selection(IHTMLSelectionObject** p);
        [VtblIndex(22)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT get_frames(IHTMLFramesCollection2** p);
        [VtblIndex(24)]
        HRESULT get_embeds(IHTMLElementCollection** p);
        [VtblIndex(25)]
        HRESULT get_plugins(IHTMLElementCollection** p);
        [VtblIndex(26)]
        HRESULT put_alinkColor(VARIANT v);
        [VtblIndex(27)]
        HRESULT get_alinkColor(VARIANT* p);
        [VtblIndex(28)]
        HRESULT put_bgColor(VARIANT v);
        [VtblIndex(29)]
        HRESULT get_bgColor(VARIANT* p);
        [VtblIndex(30)]
        HRESULT put_fgColor(VARIANT v);
        [VtblIndex(31)]
        HRESULT get_fgColor(VARIANT* p);
        [VtblIndex(32)]
        HRESULT put_linkColor(VARIANT v);
        [VtblIndex(33)]
        HRESULT get_linkColor(VARIANT* p);
        [VtblIndex(34)]
        HRESULT put_vlinkColor(VARIANT v);
        [VtblIndex(35)]
        HRESULT get_vlinkColor(VARIANT* p);
        [VtblIndex(36)]
        HRESULT get_referrer([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(37)]
        HRESULT get_location(IHTMLLocation** p);
        [VtblIndex(38)]
        HRESULT get_lastModified([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(39)]
        HRESULT put_URL([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(40)]
        HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(41)]
        HRESULT put_domain([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(42)]
        HRESULT get_domain([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(43)]
        HRESULT put_cookie([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(44)]
        HRESULT get_cookie([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(45)]
        HRESULT put_expando([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(46)]
        HRESULT get_expando([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(47)]
        HRESULT put_charset([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(48)]
        HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(49)]
        HRESULT put_defaultCharset([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(50)]
        HRESULT get_defaultCharset([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(51)]
        HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(52)]
        HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(53)]
        HRESULT get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(54)]
        HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(55)]
        HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(56)]
        HRESULT get_security([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(57)]
        HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(58)]
        HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(59)]
        HRESULT write(SAFEARRAY* psarray);
        [VtblIndex(60)]
        HRESULT writeln(SAFEARRAY* psarray);
        [VtblIndex(61)]
        HRESULT open([NativeTypeName("BSTR")] ushort* url, VARIANT name, VARIANT features, VARIANT replace, IDispatch** pomWindowResult);
        [VtblIndex(62)]
        HRESULT close();
        [VtblIndex(63)]
        HRESULT clear();
        [VtblIndex(64)]
        HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
        [VtblIndex(65)]
        HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
        [VtblIndex(66)]
        HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
        [VtblIndex(67)]
        HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
        [VtblIndex(68)]
        HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText);
        [VtblIndex(69)]
        HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue);
        [VtblIndex(70)]
        HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
        [VtblIndex(71)]
        HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
        [VtblIndex(72)]
        HRESULT createElement([NativeTypeName("BSTR")] ushort* eTag, IHTMLElement** newElem);
        [VtblIndex(73)]
        HRESULT put_onhelp(VARIANT v);
        [VtblIndex(74)]
        HRESULT get_onhelp(VARIANT* p);
        [VtblIndex(75)]
        HRESULT put_onclick(VARIANT v);
        [VtblIndex(76)]
        HRESULT get_onclick(VARIANT* p);
        [VtblIndex(77)]
        HRESULT put_ondblclick(VARIANT v);
        [VtblIndex(78)]
        HRESULT get_ondblclick(VARIANT* p);
        [VtblIndex(79)]
        HRESULT put_onkeyup(VARIANT v);
        [VtblIndex(80)]
        HRESULT get_onkeyup(VARIANT* p);
        [VtblIndex(81)]
        HRESULT put_onkeydown(VARIANT v);
        [VtblIndex(82)]
        HRESULT get_onkeydown(VARIANT* p);
        [VtblIndex(83)]
        HRESULT put_onkeypress(VARIANT v);
        [VtblIndex(84)]
        HRESULT get_onkeypress(VARIANT* p);
        [VtblIndex(85)]
        HRESULT put_onmouseup(VARIANT v);
        [VtblIndex(86)]
        HRESULT get_onmouseup(VARIANT* p);
        [VtblIndex(87)]
        HRESULT put_onmousedown(VARIANT v);
        [VtblIndex(88)]
        HRESULT get_onmousedown(VARIANT* p);
        [VtblIndex(89)]
        HRESULT put_onmousemove(VARIANT v);
        [VtblIndex(90)]
        HRESULT get_onmousemove(VARIANT* p);
        [VtblIndex(91)]
        HRESULT put_onmouseout(VARIANT v);
        [VtblIndex(92)]
        HRESULT get_onmouseout(VARIANT* p);
        [VtblIndex(93)]
        HRESULT put_onmouseover(VARIANT v);
        [VtblIndex(94)]
        HRESULT get_onmouseover(VARIANT* p);
        [VtblIndex(95)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(96)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(97)]
        HRESULT put_onafterupdate(VARIANT v);
        [VtblIndex(98)]
        HRESULT get_onafterupdate(VARIANT* p);
        [VtblIndex(99)]
        HRESULT put_onrowexit(VARIANT v);
        [VtblIndex(100)]
        HRESULT get_onrowexit(VARIANT* p);
        [VtblIndex(101)]
        HRESULT put_onrowenter(VARIANT v);
        [VtblIndex(102)]
        HRESULT get_onrowenter(VARIANT* p);
        [VtblIndex(103)]
        HRESULT put_ondragstart(VARIANT v);
        [VtblIndex(104)]
        HRESULT get_ondragstart(VARIANT* p);
        [VtblIndex(105)]
        HRESULT put_onselectstart(VARIANT v);
        [VtblIndex(106)]
        HRESULT get_onselectstart(VARIANT* p);
        [VtblIndex(107)]
        HRESULT elementFromPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y, IHTMLElement** elementHit);
        [VtblIndex(108)]
        HRESULT get_parentWindow(IHTMLWindow2** p);
        [VtblIndex(109)]
        HRESULT get_styleSheets(IHTMLStyleSheetsCollection** p);
        [VtblIndex(110)]
        HRESULT put_onbeforeupdate(VARIANT v);
        [VtblIndex(111)]
        HRESULT get_onbeforeupdate(VARIANT* p);
        [VtblIndex(112)]
        HRESULT put_onerrorupdate(VARIANT v);
        [VtblIndex(113)]
        HRESULT get_onerrorupdate(VARIANT* p);
        [VtblIndex(114)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** String);
        [VtblIndex(115)]
        HRESULT createStyleSheet([NativeTypeName("BSTR")] ushort* bstrHref, [NativeTypeName("long")] int lIndex, IHTMLStyleSheet** ppnewStyleSheet);
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
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Script;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_all;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_body;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_activeElement;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_images;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_applets;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_links;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_forms;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_anchors;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_title;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_title;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_scripts;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_designMode;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_designMode;
        [NativeTypeName("HRESULT (IHTMLSelectionObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLSelectionObject**, int> get_selection;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;
        [NativeTypeName("HRESULT (IHTMLFramesCollection2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFramesCollection2**, int> get_frames;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_embeds;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_plugins;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_alinkColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_alinkColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_fgColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_fgColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_linkColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_linkColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_vlinkColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_vlinkColor;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_referrer;
        [NativeTypeName("HRESULT (IHTMLLocation **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLLocation**, int> get_location;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lastModified;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_URL;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_URL;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_domain;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_domain;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cookie;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cookie;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_expando;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_expando;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_charset;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_charset;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_defaultCharset;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_defaultCharset;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_mimeType;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileSize;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileCreatedDate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileModifiedDate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileUpdatedDate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_security;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_protocol;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nameProp;
        [NativeTypeName("HRESULT (SAFEARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY*, int> write;
        [NativeTypeName("HRESULT (SAFEARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY*, int> writeln;
        [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, VARIANT, VARIANT, IDispatch**, int> open;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> close;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clear;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandSupported;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandEnabled;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandState;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandIndeterm;
        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> queryCommandText;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> queryCommandValue;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, VARIANT, short*, int> execCommand;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> execCommandShowHelp;
        [NativeTypeName("HRESULT (BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement**, int> createElement;
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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeyup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeyup;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeydown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeydown;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onkeypress;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onkeypress;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseup;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousedown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousedown;
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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onafterupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onafterupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onrowexit;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onrowexit;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onrowenter;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onrowenter;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragstart;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselectstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselectstart;
        [NativeTypeName("HRESULT (long, long, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, IHTMLElement**, int> elementFromPoint;
        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2**, int> get_parentWindow;
        [NativeTypeName("HRESULT (IHTMLStyleSheetsCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheetsCollection**, int> get_styleSheets;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerrorupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerrorupdate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
        [NativeTypeName("HRESULT (BSTR, long, IHTMLStyleSheet **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, IHTMLStyleSheet**, int> createStyleSheet;
    }
}