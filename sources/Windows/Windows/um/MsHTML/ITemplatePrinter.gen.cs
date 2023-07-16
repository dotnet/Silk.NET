// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter"]/*'/>
[Guid("3050F6B4-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ITemplatePrinter : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ITemplatePrinter : ITemplatePrinter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITemplatePrinter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, Guid*, void**, int> )(lpVtbl[0]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITemplatePrinter*, uint> )(lpVtbl[1]))((ITemplatePrinter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITemplatePrinter*, uint> )(lpVtbl[2]))((ITemplatePrinter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, uint*, int> )(lpVtbl[3]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.startDoc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT startDoc([NativeTypeName("BSTR")] ushort* bstrTitle, [NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort*, short*, int> )(lpVtbl[7]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), bstrTitle, p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.stopDoc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT stopDoc()
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int> )(lpVtbl[8]))((ITemplatePrinter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.printBlankPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT printBlankPage()
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int> )(lpVtbl[9]))((ITemplatePrinter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.printPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT printPage(IDispatch* pElemDisp)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, IDispatch*, int> )(lpVtbl[10]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), pElemDisp);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.ensurePrintDialogDefaults"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ensurePrintDialogDefaults([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[11]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.showPrintDialog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT showPrintDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[12]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.showPageSetupDialog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT showPageSetupDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[13]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.printNonNative"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT printNonNative(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, IUnknown*, short*, int> )(lpVtbl[14]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), pMarkup, p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.printNonNativeFrames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT printNonNativeFrames(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL")] short fActiveFrame)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, IUnknown*, short, int> )(lpVtbl[15]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), pMarkup, fActiveFrame);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_framesetDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_framesetDocument([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[16]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_framesetDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_framesetDocument([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[17]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_frameActive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_frameActive([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[18]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_frameActive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_frameActive([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[19]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_frameAsShown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_frameAsShown([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[20]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_frameAsShown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_frameAsShown([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[21]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_selection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_selection([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[22]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_selection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_selection([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[23]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_selectedPages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_selectedPages([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[24]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_selectedPages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_selectedPages([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[25]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_currentPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_currentPage([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[26]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_currentPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_currentPage([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[27]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_currentPageAvail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_currentPageAvail([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[28]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_currentPageAvail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_currentPageAvail([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[29]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_collate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_collate([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[30]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_collate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_collate([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[31]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_duplex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_duplex([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[32]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_copies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_copies(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort, int> )(lpVtbl[33]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_copies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_copies(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort*, int> )(lpVtbl[34]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_pageFrom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_pageFrom(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort, int> )(lpVtbl[35]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_pageFrom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_pageFrom(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort*, int> )(lpVtbl[36]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_pageTo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_pageTo(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort, int> )(lpVtbl[37]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_pageTo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_pageTo(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort*, int> )(lpVtbl[38]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_tableOfLinks"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_tableOfLinks([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[39]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_tableOfLinks"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_tableOfLinks([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[40]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_allLinkedDocuments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_allLinkedDocuments([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short, int> )(lpVtbl[41]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_allLinkedDocuments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_allLinkedDocuments([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, short*, int> )(lpVtbl[42]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_header"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_header([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort*, int> )(lpVtbl[43]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_header"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_header([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort**, int> )(lpVtbl[44]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_footer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_footer([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort*, int> )(lpVtbl[45]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_footer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_footer([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, ushort**, int> )(lpVtbl[46]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_marginLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_marginLeft([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int, int> )(lpVtbl[47]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_marginLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_marginLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[48]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_marginRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_marginRight([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int, int> )(lpVtbl[49]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_marginRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_marginRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[50]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_marginTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_marginTop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int, int> )(lpVtbl[51]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_marginTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_marginTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[52]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.put_marginBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_marginBottom([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int, int> )(lpVtbl[53]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_marginBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_marginBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[54]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_pageWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_pageWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[55]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_pageHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_pageHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[56]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_unprintableLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_unprintableLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[57]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_unprintableTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_unprintableTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[58]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_unprintableRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_unprintableRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[59]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.get_unprintableBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_unprintableBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[60]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter.xml' path='doc/member[@name="ITemplatePrinter.updatePageStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT updatePageStatus([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter*, int*, int> )(lpVtbl[61]))((ITemplatePrinter*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT startDoc([NativeTypeName("BSTR")] ushort* bstrTitle, [NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(8)]
        HRESULT stopDoc();
        [VtblIndex(9)]
        HRESULT printBlankPage();
        [VtblIndex(10)]
        HRESULT printPage(IDispatch* pElemDisp);
        [VtblIndex(11)]
        HRESULT ensurePrintDialogDefaults([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(12)]
        HRESULT showPrintDialog([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(13)]
        HRESULT showPageSetupDialog([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(14)]
        HRESULT printNonNative(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(15)]
        HRESULT printNonNativeFrames(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL")] short fActiveFrame);
        [VtblIndex(16)]
        HRESULT put_framesetDocument([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(17)]
        HRESULT get_framesetDocument([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(18)]
        HRESULT put_frameActive([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(19)]
        HRESULT get_frameActive([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(20)]
        HRESULT put_frameAsShown([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(21)]
        HRESULT get_frameAsShown([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(22)]
        HRESULT put_selection([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(23)]
        HRESULT get_selection([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(24)]
        HRESULT put_selectedPages([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(25)]
        HRESULT get_selectedPages([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(26)]
        HRESULT put_currentPage([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(27)]
        HRESULT get_currentPage([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(28)]
        HRESULT put_currentPageAvail([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(29)]
        HRESULT get_currentPageAvail([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(30)]
        HRESULT put_collate([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(31)]
        HRESULT get_collate([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(32)]
        HRESULT get_duplex([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(33)]
        HRESULT put_copies(ushort v);
        [VtblIndex(34)]
        HRESULT get_copies(ushort* p);
        [VtblIndex(35)]
        HRESULT put_pageFrom(ushort v);
        [VtblIndex(36)]
        HRESULT get_pageFrom(ushort* p);
        [VtblIndex(37)]
        HRESULT put_pageTo(ushort v);
        [VtblIndex(38)]
        HRESULT get_pageTo(ushort* p);
        [VtblIndex(39)]
        HRESULT put_tableOfLinks([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(40)]
        HRESULT get_tableOfLinks([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(41)]
        HRESULT put_allLinkedDocuments([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(42)]
        HRESULT get_allLinkedDocuments([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(43)]
        HRESULT put_header([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(44)]
        HRESULT get_header([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(45)]
        HRESULT put_footer([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(46)]
        HRESULT get_footer([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(47)]
        HRESULT put_marginLeft([NativeTypeName("long")] int v);
        [VtblIndex(48)]
        HRESULT get_marginLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(49)]
        HRESULT put_marginRight([NativeTypeName("long")] int v);
        [VtblIndex(50)]
        HRESULT get_marginRight([NativeTypeName("long *")] int* p);
        [VtblIndex(51)]
        HRESULT put_marginTop([NativeTypeName("long")] int v);
        [VtblIndex(52)]
        HRESULT get_marginTop([NativeTypeName("long *")] int* p);
        [VtblIndex(53)]
        HRESULT put_marginBottom([NativeTypeName("long")] int v);
        [VtblIndex(54)]
        HRESULT get_marginBottom([NativeTypeName("long *")] int* p);
        [VtblIndex(55)]
        HRESULT get_pageWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(56)]
        HRESULT get_pageHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(57)]
        HRESULT get_unprintableLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(58)]
        HRESULT get_unprintableTop([NativeTypeName("long *")] int* p);
        [VtblIndex(59)]
        HRESULT get_unprintableRight([NativeTypeName("long *")] int* p);
        [VtblIndex(60)]
        HRESULT get_unprintableBottom([NativeTypeName("long *")] int* p);
        [VtblIndex(61)]
        HRESULT updatePageStatus([NativeTypeName("long *")] int* p);
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
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> startDoc;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> stopDoc;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> printBlankPage;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> printPage;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> ensurePrintDialogDefaults;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> showPrintDialog;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> showPageSetupDialog;
        [NativeTypeName("HRESULT (IUnknown *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, short*, int> printNonNative;
        [NativeTypeName("HRESULT (IUnknown *, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, short, int> printNonNativeFrames;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_framesetDocument;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_framesetDocument;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_frameActive;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_frameActive;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_frameAsShown;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_frameAsShown;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_selection;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_selection;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_selectedPages;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_selectedPages;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_currentPage;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_currentPage;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_currentPageAvail;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_currentPageAvail;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_collate;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_collate;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_duplex;
        [NativeTypeName("HRESULT (USHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> put_copies;
        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_copies;
        [NativeTypeName("HRESULT (USHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> put_pageFrom;
        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_pageFrom;
        [NativeTypeName("HRESULT (USHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> put_pageTo;
        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_pageTo;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_tableOfLinks;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_tableOfLinks;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_allLinkedDocuments;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_allLinkedDocuments;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_header;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_header;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_footer;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_footer;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_marginLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_marginLeft;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_marginRight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_marginRight;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_marginTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_marginTop;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_marginBottom;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_marginBottom;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pageWidth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pageHeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_unprintableLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_unprintableTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_unprintableRight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_unprintableBottom;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> updatePageStatus;
    }
}