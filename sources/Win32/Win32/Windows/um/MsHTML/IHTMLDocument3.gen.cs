// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F485-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument3 : IHTMLDocument3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLDocument3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
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
            (delegate* unmanaged<IHTMLDocument3, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLDocument3,
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
    public HRESULT releaseCapture()
    {
        return ((delegate* unmanaged<IHTMLDocument3, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT recalc([NativeTypeName("VARIANT_BOOL")] short fForce = 0)
    {
        return ((delegate* unmanaged<IHTMLDocument3, short, int>)((*lpVtbl)[8]))(this, fForce);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT createTextNode([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode* newTextNode)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort*, IHTMLDOMNode*, int>)((*lpVtbl)[9]))(
            this,
            text,
            newTextNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_documentElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, IHTMLElement*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_uniqueID([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort**, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT attachEvent(
        [NativeTypeName("BSTR")] ushort* @event,
        IDispatch pDisp,
        [NativeTypeName("VARIANT_BOOL *")] short* pfResult
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument3, ushort*, IDispatch, short*, int>)((*lpVtbl)[12])
        )(this, @event, pDisp, pfResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch pDisp)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort*, IDispatch, int>)((*lpVtbl)[13]))(
            this,
            @event,
            pDisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onrowsdelete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[14]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onrowsdelete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onrowsinserted(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onrowsinserted(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_oncellchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[18]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_oncellchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[19]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ondatasetchanged(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[20]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ondatasetchanged(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_ondataavailable(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[22]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ondataavailable(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_ondatasetcomplete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[24]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ondatasetcomplete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_onpropertychange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[26]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_onpropertychange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_dir([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort*, int>)((*lpVtbl)[28]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort**, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_oncontextmenu(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[30]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_oncontextmenu(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_onstop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[32]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_onstop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[33]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT createDocumentFragment(IHTMLDocument2* pNewDoc)
    {
        return ((delegate* unmanaged<IHTMLDocument3, IHTMLDocument2*, int>)((*lpVtbl)[34]))(
            this,
            pNewDoc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_parentDocument(IHTMLDocument2* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, IHTMLDocument2*, int>)((*lpVtbl)[35]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_enableDownload([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, short, int>)((*lpVtbl)[36]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_enableDownload([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, short*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_baseUrl([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort*, int>)((*lpVtbl)[38]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_baseUrl([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort**, int>)((*lpVtbl)[39]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_childNodes(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, IDispatch*, int>)((*lpVtbl)[40]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_inheritStyleSheets([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, short, int>)((*lpVtbl)[41]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_inheritStyleSheets([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, short*, int>)((*lpVtbl)[42]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_onbeforeeditfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT, int>)((*lpVtbl)[43]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_onbeforeeditfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument3, VARIANT*, int>)((*lpVtbl)[44]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT getElementsByName(
        [NativeTypeName("BSTR")] ushort* v,
        IHTMLElementCollection* pelColl
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument3, ushort*, IHTMLElementCollection*, int>)(
                (*lpVtbl)[45]
            )
        )(this, v, pelColl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT getElementById([NativeTypeName("BSTR")] ushort* v, IHTMLElement* pel)
    {
        return ((delegate* unmanaged<IHTMLDocument3, ushort*, IHTMLElement*, int>)((*lpVtbl)[46]))(
            this,
            v,
            pel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT getElementsByTagName(
        [NativeTypeName("BSTR")] ushort* v,
        IHTMLElementCollection* pelColl
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument3, ushort*, IHTMLElementCollection*, int>)(
                (*lpVtbl)[47]
            )
        )(this, v, pelColl);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT releaseCapture();

        [VtblIndex(8)]
        HRESULT recalc([NativeTypeName("VARIANT_BOOL")] short fForce = 0);

        [VtblIndex(9)]
        HRESULT createTextNode([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode* newTextNode);

        [VtblIndex(10)]
        HRESULT get_documentElement(IHTMLElement* p);

        [VtblIndex(11)]
        HRESULT get_uniqueID([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(12)]
        HRESULT attachEvent(
            [NativeTypeName("BSTR")] ushort* @event,
            IDispatch pDisp,
            [NativeTypeName("VARIANT_BOOL *")] short* pfResult
        );

        [VtblIndex(13)]
        HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch pDisp);

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
        HRESULT createDocumentFragment(IHTMLDocument2* pNewDoc);

        [VtblIndex(35)]
        HRESULT get_parentDocument(IHTMLDocument2* p);

        [VtblIndex(36)]
        HRESULT put_enableDownload([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(37)]
        HRESULT get_enableDownload([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(38)]
        HRESULT put_baseUrl([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(39)]
        HRESULT get_baseUrl([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(40)]
        HRESULT get_childNodes(IDispatch* p);

        [VtblIndex(41)]
        HRESULT put_inheritStyleSheets([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(42)]
        HRESULT get_inheritStyleSheets([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(43)]
        HRESULT put_onbeforeeditfocus(VARIANT v);

        [VtblIndex(44)]
        HRESULT get_onbeforeeditfocus(VARIANT* p);

        [VtblIndex(45)]
        HRESULT getElementsByName(
            [NativeTypeName("BSTR")] ushort* v,
            IHTMLElementCollection* pelColl
        );

        [VtblIndex(46)]
        HRESULT getElementById([NativeTypeName("BSTR")] ushort* v, IHTMLElement* pel);

        [VtblIndex(47)]
        HRESULT getElementsByTagName(
            [NativeTypeName("BSTR")] ushort* v,
            IHTMLElementCollection* pelColl
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> releaseCapture;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> recalc;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMNode*, int> createTextNode;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_documentElement;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_uniqueID;

        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch, short*, int> attachEvent;

        [NativeTypeName("HRESULT (BSTR, IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch, int> detachEvent;

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
        public delegate* unmanaged<TSelf*, IHTMLDocument2*, int> createDocumentFragment;

        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2*, int> get_parentDocument;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_enableDownload;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_enableDownload;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_baseUrl;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_baseUrl;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_childNodes;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_inheritStyleSheets;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_inheritStyleSheets;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeeditfocus;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeeditfocus;

        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElementCollection*, int> getElementsByName;

        [NativeTypeName("HRESULT (BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement*, int> getElementById;

        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IHTMLElementCollection*,
            int> getElementsByTagName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLDocument3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLDocument3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLDocument3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLDocument3(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLDocument3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLDocument3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLDocument3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLDocument3(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLDocument3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLDocument3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
