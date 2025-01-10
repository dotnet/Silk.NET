// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F21E-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTable : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTable : IHTMLTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTable, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLTable, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTable, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTable, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTable, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLTable, Guid*, ushort**, uint, uint, int*, int>)((*lpVtbl)[5])
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
                IHTMLTable,
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
    public HRESULT put_cols([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTable, int, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_cols([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTable, int*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_border(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[9]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_border(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_frame([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort*, int>)((*lpVtbl)[11]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_frame([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort**, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_rules([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort*, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_rules([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort**, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_cellSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[15]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_cellSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_cellPadding(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[17]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_cellPadding(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort*, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort**, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[21]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_borderColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[23]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_borderColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_borderColorLight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[25]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_borderColorLight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[26]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_borderColorDark(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[27]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_borderColorDark(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[28]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort*, int>)((*lpVtbl)[29]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort**, int>)((*lpVtbl)[30]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT refresh()
    {
        return ((delegate* unmanaged<IHTMLTable, int>)((*lpVtbl)[31]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_rows(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLTable, IHTMLElementCollection*, int>)((*lpVtbl)[32]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[33]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[34]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[35]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[36]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_dataPageSize([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTable, int, int>)((*lpVtbl)[37]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_dataPageSize([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTable, int*, int>)((*lpVtbl)[38]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT nextPage()
    {
        return ((delegate* unmanaged<IHTMLTable, int>)((*lpVtbl)[39]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT previousPage()
    {
        return ((delegate* unmanaged<IHTMLTable, int>)((*lpVtbl)[40]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_tHead(IHTMLTableSection* p)
    {
        return ((delegate* unmanaged<IHTMLTable, IHTMLTableSection*, int>)((*lpVtbl)[41]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_tFoot(IHTMLTableSection* p)
    {
        return ((delegate* unmanaged<IHTMLTable, IHTMLTableSection*, int>)((*lpVtbl)[42]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_tBodies(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLTable, IHTMLElementCollection*, int>)((*lpVtbl)[43]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_caption(IHTMLTableCaption* p)
    {
        return ((delegate* unmanaged<IHTMLTable, IHTMLTableCaption*, int>)((*lpVtbl)[44]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT createTHead(IDispatch* head)
    {
        return ((delegate* unmanaged<IHTMLTable, IDispatch*, int>)((*lpVtbl)[45]))(this, head);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT deleteTHead()
    {
        return ((delegate* unmanaged<IHTMLTable, int>)((*lpVtbl)[46]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT createTFoot(IDispatch* foot)
    {
        return ((delegate* unmanaged<IHTMLTable, IDispatch*, int>)((*lpVtbl)[47]))(this, foot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT deleteTFoot()
    {
        return ((delegate* unmanaged<IHTMLTable, int>)((*lpVtbl)[48]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT createCaption(IHTMLTableCaption* caption)
    {
        return ((delegate* unmanaged<IHTMLTable, IHTMLTableCaption*, int>)((*lpVtbl)[49]))(
            this,
            caption
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT deleteCaption()
    {
        return ((delegate* unmanaged<IHTMLTable, int>)((*lpVtbl)[50]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT insertRow([NativeTypeName("long")] int index, IDispatch* row)
    {
        return ((delegate* unmanaged<IHTMLTable, int, IDispatch*, int>)((*lpVtbl)[51]))(
            this,
            index,
            row
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT deleteRow([NativeTypeName("long")] int index = -1)
    {
        return ((delegate* unmanaged<IHTMLTable, int, int>)((*lpVtbl)[52]))(this, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable, ushort**, int>)((*lpVtbl)[53]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT, int>)((*lpVtbl)[54]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable, VARIANT*, int>)((*lpVtbl)[55]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_cols([NativeTypeName("long")] int v);

        [VtblIndex(8)]
        HRESULT get_cols([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT put_border(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_border(VARIANT* p);

        [VtblIndex(11)]
        HRESULT put_frame([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_frame([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_rules([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_rules([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_cellSpacing(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_cellSpacing(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_cellPadding(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_cellPadding(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_bgColor(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_bgColor(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_borderColor(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_borderColor(VARIANT* p);

        [VtblIndex(25)]
        HRESULT put_borderColorLight(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_borderColorLight(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_borderColorDark(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_borderColorDark(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(30)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(31)]
        HRESULT refresh();

        [VtblIndex(32)]
        HRESULT get_rows(IHTMLElementCollection* p);

        [VtblIndex(33)]
        HRESULT put_width(VARIANT v);

        [VtblIndex(34)]
        HRESULT get_width(VARIANT* p);

        [VtblIndex(35)]
        HRESULT put_height(VARIANT v);

        [VtblIndex(36)]
        HRESULT get_height(VARIANT* p);

        [VtblIndex(37)]
        HRESULT put_dataPageSize([NativeTypeName("long")] int v);

        [VtblIndex(38)]
        HRESULT get_dataPageSize([NativeTypeName("long *")] int* p);

        [VtblIndex(39)]
        HRESULT nextPage();

        [VtblIndex(40)]
        HRESULT previousPage();

        [VtblIndex(41)]
        HRESULT get_tHead(IHTMLTableSection* p);

        [VtblIndex(42)]
        HRESULT get_tFoot(IHTMLTableSection* p);

        [VtblIndex(43)]
        HRESULT get_tBodies(IHTMLElementCollection* p);

        [VtblIndex(44)]
        HRESULT get_caption(IHTMLTableCaption* p);

        [VtblIndex(45)]
        HRESULT createTHead(IDispatch* head);

        [VtblIndex(46)]
        HRESULT deleteTHead();

        [VtblIndex(47)]
        HRESULT createTFoot(IDispatch* foot);

        [VtblIndex(48)]
        HRESULT deleteTFoot();

        [VtblIndex(49)]
        HRESULT createCaption(IHTMLTableCaption* caption);

        [VtblIndex(50)]
        HRESULT deleteCaption();

        [VtblIndex(51)]
        HRESULT insertRow([NativeTypeName("long")] int index, IDispatch* row);

        [VtblIndex(52)]
        HRESULT deleteRow([NativeTypeName("long")] int index = -1);

        [VtblIndex(53)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(54)]
        HRESULT put_onreadystatechange(VARIANT v);

        [VtblIndex(55)]
        HRESULT get_onreadystatechange(VARIANT* p);
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

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_cols;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_cols;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_border;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_border;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_frame;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_frame;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rules;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rules;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_cellSpacing;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_cellSpacing;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_cellPadding;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_cellPadding;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorLight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorLight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorDark;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorDark;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> refresh;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_rows;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_dataPageSize;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_dataPageSize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> nextPage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> previousPage;

        [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableSection*, int> get_tHead;

        [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableSection*, int> get_tFoot;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_tBodies;

        [NativeTypeName("HRESULT (IHTMLTableCaption **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableCaption*, int> get_caption;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> createTHead;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteTHead;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> createTFoot;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteTFoot;

        [NativeTypeName("HRESULT (IHTMLTableCaption **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableCaption*, int> createCaption;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteCaption;

        [NativeTypeName("HRESULT (long, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IDispatch*, int> insertRow;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> deleteRow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLTable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLTable(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLTable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLTable(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLTable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLTable"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLTable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLTable value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLTable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLTable(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLTable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLTable"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLTable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLTable value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
