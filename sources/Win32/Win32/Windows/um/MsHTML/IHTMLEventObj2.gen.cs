// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F48B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEventObj2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLEventObj2 : IHTMLEventObj2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEventObj2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLEventObj2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEventObj2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLEventObj2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLEventObj2,
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
    public HRESULT setAttribute(
        [NativeTypeName("BSTR")] ushort* strAttributeName,
        VARIANT AttributeValue,
        [NativeTypeName("LONG")] int lFlags = 1
    )
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, VARIANT, int, int>)((*lpVtbl)[7]))(
            this,
            strAttributeName,
            AttributeValue,
            lFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT getAttribute(
        [NativeTypeName("BSTR")] ushort* strAttributeName,
        [NativeTypeName("LONG")] int lFlags,
        VARIANT* AttributeValue
    )
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int, VARIANT*, int>)((*lpVtbl)[8]))(
            this,
            strAttributeName,
            lFlags,
            AttributeValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeAttribute(
        [NativeTypeName("BSTR")] ushort* strAttributeName,
        [NativeTypeName("LONG")] int lFlags,
        [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess
    )
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int, short*, int>)((*lpVtbl)[9]))(
            this,
            strAttributeName,
            lFlags,
            pfSuccess
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_propertyName([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int>)((*lpVtbl)[10]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_propertyName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort**, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT putref_bookmarks(IHTMLBookmarkCollection v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLBookmarkCollection, int>)((*lpVtbl)[12]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_bookmarks(IHTMLBookmarkCollection* p)
    {
        return (
            (delegate* unmanaged<IHTMLEventObj2, IHTMLBookmarkCollection*, int>)((*lpVtbl)[13])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT putref_recordset(IDispatch v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IDispatch, int>)((*lpVtbl)[14]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_recordset(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IDispatch*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_dataFld([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_dataFld([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort**, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT putref_boundElements(IHTMLElementCollection v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElementCollection, int>)((*lpVtbl)[18]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_boundElements(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElementCollection*, int>)((*lpVtbl)[19]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_repeat([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short, int>)((*lpVtbl)[20]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_repeat([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_srcUrn([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int>)((*lpVtbl)[22]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_srcUrn([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort**, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT putref_srcElement(IHTMLElement v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElement, int>)((*lpVtbl)[24]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_srcElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElement*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_altKey([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short, int>)((*lpVtbl)[26]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short*, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_ctrlKey([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short, int>)((*lpVtbl)[28]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short*, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_shiftKey([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short, int>)((*lpVtbl)[30]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, short*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT putref_fromElement(IHTMLElement v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElement, int>)((*lpVtbl)[32]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_fromElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElement*, int>)((*lpVtbl)[33]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT putref_toElement(IHTMLElement v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElement, int>)((*lpVtbl)[34]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_toElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLElement*, int>)((*lpVtbl)[35]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_button([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[36]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_button([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int>)((*lpVtbl)[38]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort**, int>)((*lpVtbl)[39]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_qualifier([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort*, int>)((*lpVtbl)[40]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, ushort**, int>)((*lpVtbl)[41]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_reason([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[42]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_reason([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[43]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_x([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[44]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_x([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[45]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_y([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[46]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_y([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[47]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_clientX([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[48]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_clientX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[49]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_clientY([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[50]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_clientY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[51]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT put_offsetX([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[52]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_offsetX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[53]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_offsetY([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[54]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_offsetY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[55]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT put_screenX([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[56]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_screenX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[57]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_screenY([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int, int>)((*lpVtbl)[58]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_screenY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, int*, int>)((*lpVtbl)[59]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT putref_srcFilter(IDispatch v)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IDispatch, int>)((*lpVtbl)[60]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_srcFilter(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IDispatch*, int>)((*lpVtbl)[61]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_dataTransfer(IHTMLDataTransfer* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj2, IHTMLDataTransfer*, int>)((*lpVtbl)[62]))(
            this,
            p
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT setAttribute(
            [NativeTypeName("BSTR")] ushort* strAttributeName,
            VARIANT AttributeValue,
            [NativeTypeName("LONG")] int lFlags = 1
        );

        [VtblIndex(8)]
        HRESULT getAttribute(
            [NativeTypeName("BSTR")] ushort* strAttributeName,
            [NativeTypeName("LONG")] int lFlags,
            VARIANT* AttributeValue
        );

        [VtblIndex(9)]
        HRESULT removeAttribute(
            [NativeTypeName("BSTR")] ushort* strAttributeName,
            [NativeTypeName("LONG")] int lFlags,
            [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess
        );

        [VtblIndex(10)]
        HRESULT put_propertyName([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(11)]
        HRESULT get_propertyName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(12)]
        HRESULT putref_bookmarks(IHTMLBookmarkCollection v);

        [VtblIndex(13)]
        HRESULT get_bookmarks(IHTMLBookmarkCollection* p);

        [VtblIndex(14)]
        HRESULT putref_recordset(IDispatch v);

        [VtblIndex(15)]
        HRESULT get_recordset(IDispatch* p);

        [VtblIndex(16)]
        HRESULT put_dataFld([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(17)]
        HRESULT get_dataFld([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT putref_boundElements(IHTMLElementCollection v);

        [VtblIndex(19)]
        HRESULT get_boundElements(IHTMLElementCollection* p);

        [VtblIndex(20)]
        HRESULT put_repeat([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(21)]
        HRESULT get_repeat([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(22)]
        HRESULT put_srcUrn([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(23)]
        HRESULT get_srcUrn([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(24)]
        HRESULT putref_srcElement(IHTMLElement v);

        [VtblIndex(25)]
        HRESULT get_srcElement(IHTMLElement* p);

        [VtblIndex(26)]
        HRESULT put_altKey([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(27)]
        HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(28)]
        HRESULT put_ctrlKey([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(29)]
        HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(30)]
        HRESULT put_shiftKey([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(31)]
        HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(32)]
        HRESULT putref_fromElement(IHTMLElement v);

        [VtblIndex(33)]
        HRESULT get_fromElement(IHTMLElement* p);

        [VtblIndex(34)]
        HRESULT putref_toElement(IHTMLElement v);

        [VtblIndex(35)]
        HRESULT get_toElement(IHTMLElement* p);

        [VtblIndex(36)]
        HRESULT put_button([NativeTypeName("long")] int v);

        [VtblIndex(37)]
        HRESULT get_button([NativeTypeName("long *")] int* p);

        [VtblIndex(38)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(39)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(40)]
        HRESULT put_qualifier([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(41)]
        HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(42)]
        HRESULT put_reason([NativeTypeName("long")] int v);

        [VtblIndex(43)]
        HRESULT get_reason([NativeTypeName("long *")] int* p);

        [VtblIndex(44)]
        HRESULT put_x([NativeTypeName("long")] int v);

        [VtblIndex(45)]
        HRESULT get_x([NativeTypeName("long *")] int* p);

        [VtblIndex(46)]
        HRESULT put_y([NativeTypeName("long")] int v);

        [VtblIndex(47)]
        HRESULT get_y([NativeTypeName("long *")] int* p);

        [VtblIndex(48)]
        HRESULT put_clientX([NativeTypeName("long")] int v);

        [VtblIndex(49)]
        HRESULT get_clientX([NativeTypeName("long *")] int* p);

        [VtblIndex(50)]
        HRESULT put_clientY([NativeTypeName("long")] int v);

        [VtblIndex(51)]
        HRESULT get_clientY([NativeTypeName("long *")] int* p);

        [VtblIndex(52)]
        HRESULT put_offsetX([NativeTypeName("long")] int v);

        [VtblIndex(53)]
        HRESULT get_offsetX([NativeTypeName("long *")] int* p);

        [VtblIndex(54)]
        HRESULT put_offsetY([NativeTypeName("long")] int v);

        [VtblIndex(55)]
        HRESULT get_offsetY([NativeTypeName("long *")] int* p);

        [VtblIndex(56)]
        HRESULT put_screenX([NativeTypeName("long")] int v);

        [VtblIndex(57)]
        HRESULT get_screenX([NativeTypeName("long *")] int* p);

        [VtblIndex(58)]
        HRESULT put_screenY([NativeTypeName("long")] int v);

        [VtblIndex(59)]
        HRESULT get_screenY([NativeTypeName("long *")] int* p);

        [VtblIndex(60)]
        HRESULT putref_srcFilter(IDispatch v);

        [VtblIndex(61)]
        HRESULT get_srcFilter(IDispatch* p);

        [VtblIndex(62)]
        HRESULT get_dataTransfer(IHTMLDataTransfer* p);
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

        [NativeTypeName("HRESULT (BSTR, VARIANT, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int, int> setAttribute;

        [NativeTypeName("HRESULT (BSTR, LONG, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int> getAttribute;

        [NativeTypeName("HRESULT (BSTR, LONG, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, short*, int> removeAttribute;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_propertyName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_propertyName;

        [NativeTypeName("HRESULT (IHTMLBookmarkCollection *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLBookmarkCollection, int> putref_bookmarks;

        [NativeTypeName("HRESULT (IHTMLBookmarkCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLBookmarkCollection*, int> get_bookmarks;

        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int> putref_recordset;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_recordset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dataFld;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dataFld;

        [NativeTypeName("HRESULT (IHTMLElementCollection *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection, int> putref_boundElements;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_boundElements;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_repeat;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_repeat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_srcUrn;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_srcUrn;

        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, int> putref_srcElement;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_srcElement;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_altKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_altKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_ctrlKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ctrlKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_shiftKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_shiftKey;

        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, int> putref_fromElement;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_fromElement;

        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, int> putref_toElement;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_toElement;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_button;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_button;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_qualifier;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_qualifier;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_reason;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_reason;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_x;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_x;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_y;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_y;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_clientX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientX;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_clientY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientY;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_offsetX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetX;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_offsetY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetY;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_screenX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenX;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_screenY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenY;

        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int> putref_srcFilter;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_srcFilter;

        [NativeTypeName("HRESULT (IHTMLDataTransfer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDataTransfer*, int> get_dataTransfer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLEventObj2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLEventObj2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLEventObj2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLEventObj2(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLEventObj2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEventObj2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEventObj2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLEventObj2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLEventObj2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLEventObj2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLEventObj2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEventObj2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEventObj2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLEventObj2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
