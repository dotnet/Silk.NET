// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305104A3-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ITemplatePrinter3 : ITemplatePrinter2")]
[NativeInheritance("ITemplatePrinter2")]
public unsafe partial struct ITemplatePrinter3 : ITemplatePrinter3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITemplatePrinter3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITemplatePrinter3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITemplatePrinter3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ITemplatePrinter3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<ITemplatePrinter3, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ITemplatePrinter3,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT startDoc(
        [NativeTypeName("BSTR")] ushort* bstrTitle,
        [NativeTypeName("VARIANT_BOOL *")] short* p
    )
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, short*, int>)((*lpVtbl)[7]))(
            this,
            bstrTitle,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT stopDoc()
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT printBlankPage()
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT printPage(IDispatch pElemDisp)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IDispatch, int>)((*lpVtbl)[10]))(
            this,
            pElemDisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ensurePrintDialogDefaults([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT showPrintDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT showPageSetupDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[13]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT printNonNative(IUnknown pMarkup, [NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IUnknown, short*, int>)((*lpVtbl)[14]))(
            this,
            pMarkup,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT printNonNativeFrames(
        IUnknown pMarkup,
        [NativeTypeName("VARIANT_BOOL")] short fActiveFrame
    )
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IUnknown, short, int>)((*lpVtbl)[15]))(
            this,
            pMarkup,
            fActiveFrame
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_framesetDocument([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_framesetDocument([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_frameActive([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[18]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_frameActive([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[19]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_frameAsShown([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[20]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_frameAsShown([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_selection([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[22]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_selection([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_selectedPages([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[24]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_selectedPages([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_currentPage([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[26]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_currentPage([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_currentPageAvail([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[28]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_currentPageAvail([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_collate([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[30]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_collate([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_duplex([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[32]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_copies(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort, int>)((*lpVtbl)[33]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_copies(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[34]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_pageFrom(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort, int>)((*lpVtbl)[35]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_pageFrom(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[36]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_pageTo(ushort v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort, int>)((*lpVtbl)[37]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_pageTo(ushort* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[38]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_tableOfLinks([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[39]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_tableOfLinks([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[40]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_allLinkedDocuments([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[41]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_allLinkedDocuments([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[42]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_header([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[43]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_header([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort**, int>)((*lpVtbl)[44]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_footer([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[45]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_footer([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort**, int>)((*lpVtbl)[46]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_marginLeft([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int, int>)((*lpVtbl)[47]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_marginLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[48]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_marginRight([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int, int>)((*lpVtbl)[49]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_marginRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[50]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_marginTop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int, int>)((*lpVtbl)[51]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_marginTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[52]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_marginBottom([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int, int>)((*lpVtbl)[53]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_marginBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[54]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_pageWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[55]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_pageHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[56]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_unprintableLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[57]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_unprintableTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[58]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_unprintableRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[59]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_unprintableBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[60]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT updatePageStatus([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, int*, int>)((*lpVtbl)[61]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_selectionEnabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[62]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_selectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[63]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT put_frameActiveEnabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[64]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_frameActiveEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[65]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_orientation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[66]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_orientation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort**, int>)((*lpVtbl)[67]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short, int>)((*lpVtbl)[68]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, short*, int>)((*lpVtbl)[69]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT deviceSupports([NativeTypeName("BSTR")] ushort* bstrProperty, VARIANT* pvar)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, VARIANT*, int>)((*lpVtbl)[70]))(
            this,
            bstrProperty,
            pvar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_headerFooterFont([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort*, int>)((*lpVtbl)[71]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_headerFooterFont([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ITemplatePrinter3, ushort**, int>)((*lpVtbl)[72]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT getPageMarginTop(
        IDispatch pageRule,
        [NativeTypeName("long")] int pageWidth,
        [NativeTypeName("long")] int pageHeight,
        VARIANT* pMargin
    )
    {
        return (
            (delegate* unmanaged<ITemplatePrinter3, IDispatch, int, int, VARIANT*, int>)(
                (*lpVtbl)[73]
            )
        )(this, pageRule, pageWidth, pageHeight, pMargin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT getPageMarginRight(
        IDispatch pageRule,
        [NativeTypeName("long")] int pageWidth,
        [NativeTypeName("long")] int pageHeight,
        VARIANT* pMargin
    )
    {
        return (
            (delegate* unmanaged<ITemplatePrinter3, IDispatch, int, int, VARIANT*, int>)(
                (*lpVtbl)[74]
            )
        )(this, pageRule, pageWidth, pageHeight, pMargin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT getPageMarginBottom(
        IDispatch pageRule,
        [NativeTypeName("long")] int pageWidth,
        [NativeTypeName("long")] int pageHeight,
        VARIANT* pMargin
    )
    {
        return (
            (delegate* unmanaged<ITemplatePrinter3, IDispatch, int, int, VARIANT*, int>)(
                (*lpVtbl)[75]
            )
        )(this, pageRule, pageWidth, pageHeight, pMargin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT getPageMarginLeft(
        IDispatch pageRule,
        [NativeTypeName("long")] int pageWidth,
        [NativeTypeName("long")] int pageHeight,
        VARIANT* pMargin
    )
    {
        return (
            (delegate* unmanaged<ITemplatePrinter3, IDispatch, int, int, VARIANT*, int>)(
                (*lpVtbl)[76]
            )
        )(this, pageRule, pageWidth, pageHeight, pMargin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT getPageMarginTopImportant(
        IDispatch pageRule,
        [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
    )
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IDispatch, short*, int>)((*lpVtbl)[77]))(
            this,
            pageRule,
            pbImportant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT getPageMarginRightImportant(
        IDispatch pageRule,
        [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
    )
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IDispatch, short*, int>)((*lpVtbl)[78]))(
            this,
            pageRule,
            pbImportant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT getPageMarginBottomImportant(
        IDispatch pageRule,
        [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
    )
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IDispatch, short*, int>)((*lpVtbl)[79]))(
            this,
            pageRule,
            pbImportant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT getPageMarginLeftImportant(
        IDispatch pageRule,
        [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
    )
    {
        return ((delegate* unmanaged<ITemplatePrinter3, IDispatch, short*, int>)((*lpVtbl)[80]))(
            this,
            pageRule,
            pbImportant
        );
    }

    public interface Interface : ITemplatePrinter2.Interface
    {
        [VtblIndex(71)]
        HRESULT put_headerFooterFont([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(72)]
        HRESULT get_headerFooterFont([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(73)]
        HRESULT getPageMarginTop(
            IDispatch pageRule,
            [NativeTypeName("long")] int pageWidth,
            [NativeTypeName("long")] int pageHeight,
            VARIANT* pMargin
        );

        [VtblIndex(74)]
        HRESULT getPageMarginRight(
            IDispatch pageRule,
            [NativeTypeName("long")] int pageWidth,
            [NativeTypeName("long")] int pageHeight,
            VARIANT* pMargin
        );

        [VtblIndex(75)]
        HRESULT getPageMarginBottom(
            IDispatch pageRule,
            [NativeTypeName("long")] int pageWidth,
            [NativeTypeName("long")] int pageHeight,
            VARIANT* pMargin
        );

        [VtblIndex(76)]
        HRESULT getPageMarginLeft(
            IDispatch pageRule,
            [NativeTypeName("long")] int pageWidth,
            [NativeTypeName("long")] int pageHeight,
            VARIANT* pMargin
        );

        [VtblIndex(77)]
        HRESULT getPageMarginTopImportant(
            IDispatch pageRule,
            [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
        );

        [VtblIndex(78)]
        HRESULT getPageMarginRightImportant(
            IDispatch pageRule,
            [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
        );

        [VtblIndex(79)]
        HRESULT getPageMarginBottomImportant(
            IDispatch pageRule,
            [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
        );

        [VtblIndex(80)]
        HRESULT getPageMarginLeftImportant(
            IDispatch pageRule,
            [NativeTypeName("VARIANT_BOOL *")] short* pbImportant
        );
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> startDoc;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> stopDoc;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> printBlankPage;

        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int> printPage;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> ensurePrintDialogDefaults;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> showPrintDialog;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> showPageSetupDialog;

        [NativeTypeName("HRESULT (IUnknown *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, short*, int> printNonNative;

        [NativeTypeName("HRESULT (IUnknown *, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, short, int> printNonNativeFrames;

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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_headerFooterFont;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_headerFooterFont;

        [NativeTypeName("HRESULT (IDispatch *, long, long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int, int, VARIANT*, int> getPageMarginTop;

        [NativeTypeName("HRESULT (IDispatch *, long, long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int, int, VARIANT*, int> getPageMarginRight;

        [NativeTypeName("HRESULT (IDispatch *, long, long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int, int, VARIANT*, int> getPageMarginBottom;

        [NativeTypeName("HRESULT (IDispatch *, long, long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int, int, VARIANT*, int> getPageMarginLeft;

        [NativeTypeName("HRESULT (IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, short*, int> getPageMarginTopImportant;

        [NativeTypeName("HRESULT (IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, short*, int> getPageMarginRightImportant;

        [NativeTypeName("HRESULT (IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, short*, int> getPageMarginBottomImportant;

        [NativeTypeName("HRESULT (IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, short*, int> getPageMarginLeftImportant;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITemplatePrinter3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITemplatePrinter3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITemplatePrinter2"/> to <see cref = "ITemplatePrinter3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITemplatePrinter2"/> instance to be converted </param>
    public static explicit operator ITemplatePrinter3(Silk.NET.Windows.ITemplatePrinter2 value)
    {
        return new ITemplatePrinter3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITemplatePrinter3"/> to <see cref = "Silk.NET.Windows.ITemplatePrinter2"/>.</summary>
    /// <param name = "value">The <see cref = "ITemplatePrinter3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITemplatePrinter2(ITemplatePrinter3 value)
    {
        return new Silk.NET.Windows.ITemplatePrinter2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITemplatePrinter"/> to <see cref = "ITemplatePrinter3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITemplatePrinter"/> instance to be converted </param>
    public static explicit operator ITemplatePrinter3(Silk.NET.Windows.ITemplatePrinter value)
    {
        return new ITemplatePrinter3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITemplatePrinter3"/> to <see cref = "Silk.NET.Windows.ITemplatePrinter"/>.</summary>
    /// <param name = "value">The <see cref = "ITemplatePrinter3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITemplatePrinter(ITemplatePrinter3 value)
    {
        return new Silk.NET.Windows.ITemplatePrinter(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ITemplatePrinter3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ITemplatePrinter3(Silk.NET.Windows.IDispatch value)
    {
        return new ITemplatePrinter3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITemplatePrinter3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ITemplatePrinter3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ITemplatePrinter3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITemplatePrinter3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITemplatePrinter3(Silk.NET.Windows.IUnknown value)
    {
        return new ITemplatePrinter3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITemplatePrinter3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITemplatePrinter3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITemplatePrinter3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
