// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2"]/*' />
[Guid("3050F83F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ITemplatePrinter2 : ITemplatePrinter")]
[NativeInheritance("ITemplatePrinter")]
public unsafe partial struct ITemplatePrinter2 : ITemplatePrinter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITemplatePrinter2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, Guid*, void**, int>)(lpVtbl[0]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, uint>)(lpVtbl[1]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, uint>)(lpVtbl[2]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, uint*, int>)(lpVtbl[3]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="ITemplatePrinter.startDoc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT startDoc([NativeTypeName("BSTR")] ushort* bstrTitle, [NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, short*, int>)(lpVtbl[7]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), bstrTitle, p);
    }

    /// <inheritdoc cref="ITemplatePrinter.stopDoc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT stopDoc()
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int>)(lpVtbl[8]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITemplatePrinter.printBlankPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT printBlankPage()
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int>)(lpVtbl[9]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITemplatePrinter.printPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT printPage(IDispatch* pElemDisp)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, IDispatch*, int>)(lpVtbl[10]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), pElemDisp);
    }

    /// <inheritdoc cref="ITemplatePrinter.ensurePrintDialogDefaults" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ensurePrintDialogDefaults([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[11]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.showPrintDialog" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT showPrintDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[12]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.showPageSetupDialog" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT showPageSetupDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[13]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.printNonNative" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT printNonNative(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, IUnknown*, short*, int>)(lpVtbl[14]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), pMarkup, p);
    }

    /// <inheritdoc cref="ITemplatePrinter.printNonNativeFrames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT printNonNativeFrames(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL")] short fActiveFrame)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, IUnknown*, short, int>)(lpVtbl[15]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), pMarkup, fActiveFrame);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_framesetDocument" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_framesetDocument([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[16]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_framesetDocument" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_framesetDocument([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[17]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_frameActive" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_frameActive([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[18]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_frameActive" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_frameActive([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[19]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_frameAsShown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_frameAsShown([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[20]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_frameAsShown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_frameAsShown([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[21]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_selection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_selection([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[22]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_selection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_selection([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[23]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_selectedPages" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_selectedPages([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[24]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_selectedPages" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_selectedPages([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[25]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_currentPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_currentPage([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[26]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_currentPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_currentPage([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[27]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_currentPageAvail" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_currentPageAvail([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[28]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_currentPageAvail" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_currentPageAvail([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[29]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_collate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_collate([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[30]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_collate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_collate([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[31]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_duplex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_duplex([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[32]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_copies" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_copies(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort, int>)(lpVtbl[33]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_copies" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_copies(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, int>)(lpVtbl[34]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_pageFrom" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_pageFrom(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort, int>)(lpVtbl[35]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_pageFrom" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_pageFrom(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, int>)(lpVtbl[36]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_pageTo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_pageTo(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort, int>)(lpVtbl[37]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_pageTo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_pageTo(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, int>)(lpVtbl[38]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_tableOfLinks" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_tableOfLinks([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[39]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_tableOfLinks" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_tableOfLinks([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[40]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_allLinkedDocuments" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_allLinkedDocuments([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[41]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_allLinkedDocuments" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_allLinkedDocuments([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[42]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_header" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_header([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, int>)(lpVtbl[43]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_header" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_header([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort**, int>)(lpVtbl[44]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_footer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_footer([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, int>)(lpVtbl[45]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_footer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_footer([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort**, int>)(lpVtbl[46]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_marginLeft" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_marginLeft([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int, int>)(lpVtbl[47]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_marginLeft" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_marginLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[48]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_marginRight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_marginRight([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int, int>)(lpVtbl[49]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_marginRight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_marginRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[50]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_marginTop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_marginTop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int, int>)(lpVtbl[51]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_marginTop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_marginTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[52]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.put_marginBottom" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_marginBottom([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int, int>)(lpVtbl[53]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_marginBottom" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_marginBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[54]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_pageWidth" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_pageWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[55]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_pageHeight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_pageHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[56]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_unprintableLeft" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_unprintableLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[57]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_unprintableTop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_unprintableTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[58]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_unprintableRight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_unprintableRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[59]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.get_unprintableBottom" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_unprintableBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[60]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <inheritdoc cref="ITemplatePrinter.updatePageStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT updatePageStatus([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, int*, int>)(lpVtbl[61]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.put_selectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_selectionEnabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[62]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.get_selectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_selectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[63]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.put_frameActiveEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT put_frameActiveEnabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[64]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.get_frameActiveEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_frameActiveEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[65]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.put_orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_orientation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, int>)(lpVtbl[66]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.get_orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_orientation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort**, int>)(lpVtbl[67]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.put_usePrinterCopyCollate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short, int>)(lpVtbl[68]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.get_usePrinterCopyCollate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, short*, int>)(lpVtbl[69]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ITemplatePrinter2.xml' path='doc/member[@name="ITemplatePrinter2.deviceSupports"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT deviceSupports([NativeTypeName("BSTR")] ushort* bstrProperty, VARIANT* pvar)
    {
        return ((delegate* unmanaged<ITemplatePrinter2*, ushort*, VARIANT*, int>)(lpVtbl[70]))((ITemplatePrinter2*)Unsafe.AsPointer(ref this), bstrProperty, pvar);
    }

    public interface Interface : ITemplatePrinter.Interface
    {
        [VtblIndex(62)]
        HRESULT put_selectionEnabled([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(63)]
        HRESULT get_selectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(64)]
        HRESULT put_frameActiveEnabled([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(65)]
        HRESULT get_frameActiveEnabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(66)]
        HRESULT put_orientation([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(67)]
        HRESULT get_orientation([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(68)]
        HRESULT put_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(69)]
        HRESULT get_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(70)]
        HRESULT deviceSupports([NativeTypeName("BSTR")] ushort* bstrProperty, VARIANT* pvar);
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

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_selectionEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_selectionEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_frameActiveEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_frameActiveEnabled;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_orientation;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_orientation;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_usePrinterCopyCollate;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_usePrinterCopyCollate;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> deviceSupports;
    }
}
