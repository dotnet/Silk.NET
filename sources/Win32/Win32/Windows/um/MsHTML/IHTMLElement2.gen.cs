// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F434-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElement2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElement2 : IHTMLElement2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElement2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElement2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLElement2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElement2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElement2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElement2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLElement2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLElement2,
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
    public HRESULT get_scopeName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort**, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setCapture([NativeTypeName("VARIANT_BOOL")] short containerCapture = -1)
    {
        return ((delegate* unmanaged<IHTMLElement2, short, int>)((*lpVtbl)[8]))(
            this,
            containerCapture
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT releaseCapture()
    {
        return ((delegate* unmanaged<IHTMLElement2, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_onlosecapture(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[10]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_onlosecapture(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT componentFromPoint(
        [NativeTypeName("long")] int x,
        [NativeTypeName("long")] int y,
        [NativeTypeName("BSTR *")] ushort** component
    )
    {
        return ((delegate* unmanaged<IHTMLElement2, int, int, ushort**, int>)((*lpVtbl)[12]))(
            this,
            x,
            y,
            component
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT doScroll(VARIANT component)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[13]))(this, component);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onscroll(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[14]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onscroll(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ondrag(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ondrag(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ondragend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[18]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ondragend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[19]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ondragenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[20]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ondragenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_ondragover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[22]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ondragover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_ondragleave(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[24]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ondragleave(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_ondrop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[26]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ondrop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_onbeforecut(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[28]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_onbeforecut(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_oncut(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[30]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_oncut(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_onbeforecopy(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[32]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_onbeforecopy(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[33]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_oncopy(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[34]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_oncopy(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[35]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_onbeforepaste(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[36]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_onbeforepaste(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_onpaste(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[38]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_onpaste(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[39]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_currentStyle(IHTMLCurrentStyle* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, IHTMLCurrentStyle*, int>)((*lpVtbl)[40]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_onpropertychange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[41]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_onpropertychange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[42]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT getClientRects(IHTMLRectCollection* pRectCol)
    {
        return ((delegate* unmanaged<IHTMLElement2, IHTMLRectCollection*, int>)((*lpVtbl)[43]))(
            this,
            pRectCol
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT getBoundingClientRect(IHTMLRect* pRect)
    {
        return ((delegate* unmanaged<IHTMLElement2, IHTMLRect*, int>)((*lpVtbl)[44]))(this, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT setExpression(
        [NativeTypeName("BSTR")] ushort* propname,
        [NativeTypeName("BSTR")] ushort* expression,
        [NativeTypeName("BSTR")] ushort* language = null
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement2, ushort*, ushort*, ushort*, int>)((*lpVtbl)[45])
        )(this, propname, expression, language);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT getExpression([NativeTypeName("BSTR")] ushort* propname, VARIANT* expression)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, VARIANT*, int>)((*lpVtbl)[46]))(
            this,
            propname,
            expression
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT removeExpression(
        [NativeTypeName("BSTR")] ushort* propname,
        [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess
    )
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, short*, int>)((*lpVtbl)[47]))(
            this,
            propname,
            pfSuccess
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_tabIndex(short v)
    {
        return ((delegate* unmanaged<IHTMLElement2, short, int>)((*lpVtbl)[48]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_tabIndex(short* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, short*, int>)((*lpVtbl)[49]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT focus()
    {
        return ((delegate* unmanaged<IHTMLElement2, int>)((*lpVtbl)[50]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_accessKey([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, int>)((*lpVtbl)[51]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_accessKey([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort**, int>)((*lpVtbl)[52]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_onblur(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[53]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_onblur(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[54]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_onfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[55]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_onfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[56]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_onresize(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[57]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_onresize(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[58]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT blur()
    {
        return ((delegate* unmanaged<IHTMLElement2, int>)((*lpVtbl)[59]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT addFilter(IUnknown pUnk)
    {
        return ((delegate* unmanaged<IHTMLElement2, IUnknown, int>)((*lpVtbl)[60]))(this, pUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT removeFilter(IUnknown pUnk)
    {
        return ((delegate* unmanaged<IHTMLElement2, IUnknown, int>)((*lpVtbl)[61]))(this, pUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_clientHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[62]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_clientWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[63]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_clientTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[64]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_clientLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[65]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT attachEvent(
        [NativeTypeName("BSTR")] ushort* @event,
        IDispatch pDisp,
        [NativeTypeName("VARIANT_BOOL *")] short* pfResult
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement2, ushort*, IDispatch, short*, int>)((*lpVtbl)[66])
        )(this, @event, pDisp, pfResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch pDisp)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, IDispatch, int>)((*lpVtbl)[67]))(
            this,
            @event,
            pDisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_readyState(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[68]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[69]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[70]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_onrowsdelete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[71]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_onrowsdelete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[72]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_onrowsinserted(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[73]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_onrowsinserted(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[74]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_oncellchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[75]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_oncellchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[76]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_dir([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, int>)((*lpVtbl)[77]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort**, int>)((*lpVtbl)[78]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT createControlRange(IDispatch* range)
    {
        return ((delegate* unmanaged<IHTMLElement2, IDispatch*, int>)((*lpVtbl)[79]))(this, range);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_scrollHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[80]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_scrollWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[81]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT put_scrollTop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLElement2, int, int>)((*lpVtbl)[82]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_scrollTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[83]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT put_scrollLeft([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLElement2, int, int>)((*lpVtbl)[84]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_scrollLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[85]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT clearAttributes()
    {
        return ((delegate* unmanaged<IHTMLElement2, int>)((*lpVtbl)[86]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT mergeAttributes(IHTMLElement mergeThis)
    {
        return ((delegate* unmanaged<IHTMLElement2, IHTMLElement, int>)((*lpVtbl)[87]))(
            this,
            mergeThis
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT put_oncontextmenu(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[88]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_oncontextmenu(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[89]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT insertAdjacentElement(
        [NativeTypeName("BSTR")] ushort* where,
        IHTMLElement insertedElement,
        IHTMLElement* inserted
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement2, ushort*, IHTMLElement, IHTMLElement*, int>)(
                (*lpVtbl)[90]
            )
        )(this, where, insertedElement, inserted);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT applyElement(
        IHTMLElement apply,
        [NativeTypeName("BSTR")] ushort* where,
        IHTMLElement* applied
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement2, IHTMLElement, ushort*, IHTMLElement*, int>)(
                (*lpVtbl)[91]
            )
        )(this, apply, where, applied);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT getAdjacentText(
        [NativeTypeName("BSTR")] ushort* where,
        [NativeTypeName("BSTR *")] ushort** text
    )
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, ushort**, int>)((*lpVtbl)[92]))(
            this,
            where,
            text
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT replaceAdjacentText(
        [NativeTypeName("BSTR")] ushort* where,
        [NativeTypeName("BSTR")] ushort* newText,
        [NativeTypeName("BSTR *")] ushort** oldText
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement2, ushort*, ushort*, ushort**, int>)((*lpVtbl)[93])
        )(this, where, newText, oldText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_canHaveChildren([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, short*, int>)((*lpVtbl)[94]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT addBehavior(
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        VARIANT* pvarFactory,
        [NativeTypeName("long *")] int* pCookie
    )
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, VARIANT*, int*, int>)((*lpVtbl)[95]))(
            this,
            bstrUrl,
            pvarFactory,
            pCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT removeBehavior(
        [NativeTypeName("long")] int cookie,
        [NativeTypeName("VARIANT_BOOL *")] short* pfResult
    )
    {
        return ((delegate* unmanaged<IHTMLElement2, int, short*, int>)((*lpVtbl)[96]))(
            this,
            cookie,
            pfResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_runtimeStyle(IHTMLStyle* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, IHTMLStyle*, int>)((*lpVtbl)[97]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_behaviorUrns(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, IDispatch*, int>)((*lpVtbl)[98]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT put_tagUrn([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort*, int>)((*lpVtbl)[99]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_tagUrn([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement2, ushort**, int>)((*lpVtbl)[100]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT put_onbeforeeditfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT, int>)((*lpVtbl)[101]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_onbeforeeditfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, VARIANT*, int>)((*lpVtbl)[102]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_readyStateValue([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement2, int*, int>)((*lpVtbl)[103]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT getElementsByTagName(
        [NativeTypeName("BSTR")] ushort* v,
        IHTMLElementCollection* pelColl
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement2, ushort*, IHTMLElementCollection*, int>)(
                (*lpVtbl)[104]
            )
        )(this, v, pelColl);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_scopeName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT setCapture([NativeTypeName("VARIANT_BOOL")] short containerCapture = -1);

        [VtblIndex(9)]
        HRESULT releaseCapture();

        [VtblIndex(10)]
        HRESULT put_onlosecapture(VARIANT v);

        [VtblIndex(11)]
        HRESULT get_onlosecapture(VARIANT* p);

        [VtblIndex(12)]
        HRESULT componentFromPoint(
            [NativeTypeName("long")] int x,
            [NativeTypeName("long")] int y,
            [NativeTypeName("BSTR *")] ushort** component
        );

        [VtblIndex(13)]
        HRESULT doScroll(VARIANT component);

        [VtblIndex(14)]
        HRESULT put_onscroll(VARIANT v);

        [VtblIndex(15)]
        HRESULT get_onscroll(VARIANT* p);

        [VtblIndex(16)]
        HRESULT put_ondrag(VARIANT v);

        [VtblIndex(17)]
        HRESULT get_ondrag(VARIANT* p);

        [VtblIndex(18)]
        HRESULT put_ondragend(VARIANT v);

        [VtblIndex(19)]
        HRESULT get_ondragend(VARIANT* p);

        [VtblIndex(20)]
        HRESULT put_ondragenter(VARIANT v);

        [VtblIndex(21)]
        HRESULT get_ondragenter(VARIANT* p);

        [VtblIndex(22)]
        HRESULT put_ondragover(VARIANT v);

        [VtblIndex(23)]
        HRESULT get_ondragover(VARIANT* p);

        [VtblIndex(24)]
        HRESULT put_ondragleave(VARIANT v);

        [VtblIndex(25)]
        HRESULT get_ondragleave(VARIANT* p);

        [VtblIndex(26)]
        HRESULT put_ondrop(VARIANT v);

        [VtblIndex(27)]
        HRESULT get_ondrop(VARIANT* p);

        [VtblIndex(28)]
        HRESULT put_onbeforecut(VARIANT v);

        [VtblIndex(29)]
        HRESULT get_onbeforecut(VARIANT* p);

        [VtblIndex(30)]
        HRESULT put_oncut(VARIANT v);

        [VtblIndex(31)]
        HRESULT get_oncut(VARIANT* p);

        [VtblIndex(32)]
        HRESULT put_onbeforecopy(VARIANT v);

        [VtblIndex(33)]
        HRESULT get_onbeforecopy(VARIANT* p);

        [VtblIndex(34)]
        HRESULT put_oncopy(VARIANT v);

        [VtblIndex(35)]
        HRESULT get_oncopy(VARIANT* p);

        [VtblIndex(36)]
        HRESULT put_onbeforepaste(VARIANT v);

        [VtblIndex(37)]
        HRESULT get_onbeforepaste(VARIANT* p);

        [VtblIndex(38)]
        HRESULT put_onpaste(VARIANT v);

        [VtblIndex(39)]
        HRESULT get_onpaste(VARIANT* p);

        [VtblIndex(40)]
        HRESULT get_currentStyle(IHTMLCurrentStyle* p);

        [VtblIndex(41)]
        HRESULT put_onpropertychange(VARIANT v);

        [VtblIndex(42)]
        HRESULT get_onpropertychange(VARIANT* p);

        [VtblIndex(43)]
        HRESULT getClientRects(IHTMLRectCollection* pRectCol);

        [VtblIndex(44)]
        HRESULT getBoundingClientRect(IHTMLRect* pRect);

        [VtblIndex(45)]
        HRESULT setExpression(
            [NativeTypeName("BSTR")] ushort* propname,
            [NativeTypeName("BSTR")] ushort* expression,
            [NativeTypeName("BSTR")] ushort* language = null
        );

        [VtblIndex(46)]
        HRESULT getExpression([NativeTypeName("BSTR")] ushort* propname, VARIANT* expression);

        [VtblIndex(47)]
        HRESULT removeExpression(
            [NativeTypeName("BSTR")] ushort* propname,
            [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess
        );

        [VtblIndex(48)]
        HRESULT put_tabIndex(short v);

        [VtblIndex(49)]
        HRESULT get_tabIndex(short* p);

        [VtblIndex(50)]
        HRESULT focus();

        [VtblIndex(51)]
        HRESULT put_accessKey([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(52)]
        HRESULT get_accessKey([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(53)]
        HRESULT put_onblur(VARIANT v);

        [VtblIndex(54)]
        HRESULT get_onblur(VARIANT* p);

        [VtblIndex(55)]
        HRESULT put_onfocus(VARIANT v);

        [VtblIndex(56)]
        HRESULT get_onfocus(VARIANT* p);

        [VtblIndex(57)]
        HRESULT put_onresize(VARIANT v);

        [VtblIndex(58)]
        HRESULT get_onresize(VARIANT* p);

        [VtblIndex(59)]
        HRESULT blur();

        [VtblIndex(60)]
        HRESULT addFilter(IUnknown pUnk);

        [VtblIndex(61)]
        HRESULT removeFilter(IUnknown pUnk);

        [VtblIndex(62)]
        HRESULT get_clientHeight([NativeTypeName("long *")] int* p);

        [VtblIndex(63)]
        HRESULT get_clientWidth([NativeTypeName("long *")] int* p);

        [VtblIndex(64)]
        HRESULT get_clientTop([NativeTypeName("long *")] int* p);

        [VtblIndex(65)]
        HRESULT get_clientLeft([NativeTypeName("long *")] int* p);

        [VtblIndex(66)]
        HRESULT attachEvent(
            [NativeTypeName("BSTR")] ushort* @event,
            IDispatch pDisp,
            [NativeTypeName("VARIANT_BOOL *")] short* pfResult
        );

        [VtblIndex(67)]
        HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch pDisp);

        [VtblIndex(68)]
        HRESULT get_readyState(VARIANT* p);

        [VtblIndex(69)]
        HRESULT put_onreadystatechange(VARIANT v);

        [VtblIndex(70)]
        HRESULT get_onreadystatechange(VARIANT* p);

        [VtblIndex(71)]
        HRESULT put_onrowsdelete(VARIANT v);

        [VtblIndex(72)]
        HRESULT get_onrowsdelete(VARIANT* p);

        [VtblIndex(73)]
        HRESULT put_onrowsinserted(VARIANT v);

        [VtblIndex(74)]
        HRESULT get_onrowsinserted(VARIANT* p);

        [VtblIndex(75)]
        HRESULT put_oncellchange(VARIANT v);

        [VtblIndex(76)]
        HRESULT get_oncellchange(VARIANT* p);

        [VtblIndex(77)]
        HRESULT put_dir([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(78)]
        HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(79)]
        HRESULT createControlRange(IDispatch* range);

        [VtblIndex(80)]
        HRESULT get_scrollHeight([NativeTypeName("long *")] int* p);

        [VtblIndex(81)]
        HRESULT get_scrollWidth([NativeTypeName("long *")] int* p);

        [VtblIndex(82)]
        HRESULT put_scrollTop([NativeTypeName("long")] int v);

        [VtblIndex(83)]
        HRESULT get_scrollTop([NativeTypeName("long *")] int* p);

        [VtblIndex(84)]
        HRESULT put_scrollLeft([NativeTypeName("long")] int v);

        [VtblIndex(85)]
        HRESULT get_scrollLeft([NativeTypeName("long *")] int* p);

        [VtblIndex(86)]
        HRESULT clearAttributes();

        [VtblIndex(87)]
        HRESULT mergeAttributes(IHTMLElement mergeThis);

        [VtblIndex(88)]
        HRESULT put_oncontextmenu(VARIANT v);

        [VtblIndex(89)]
        HRESULT get_oncontextmenu(VARIANT* p);

        [VtblIndex(90)]
        HRESULT insertAdjacentElement(
            [NativeTypeName("BSTR")] ushort* where,
            IHTMLElement insertedElement,
            IHTMLElement* inserted
        );

        [VtblIndex(91)]
        HRESULT applyElement(
            IHTMLElement apply,
            [NativeTypeName("BSTR")] ushort* where,
            IHTMLElement* applied
        );

        [VtblIndex(92)]
        HRESULT getAdjacentText(
            [NativeTypeName("BSTR")] ushort* where,
            [NativeTypeName("BSTR *")] ushort** text
        );

        [VtblIndex(93)]
        HRESULT replaceAdjacentText(
            [NativeTypeName("BSTR")] ushort* where,
            [NativeTypeName("BSTR")] ushort* newText,
            [NativeTypeName("BSTR *")] ushort** oldText
        );

        [VtblIndex(94)]
        HRESULT get_canHaveChildren([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(95)]
        HRESULT addBehavior(
            [NativeTypeName("BSTR")] ushort* bstrUrl,
            VARIANT* pvarFactory,
            [NativeTypeName("long *")] int* pCookie
        );

        [VtblIndex(96)]
        HRESULT removeBehavior(
            [NativeTypeName("long")] int cookie,
            [NativeTypeName("VARIANT_BOOL *")] short* pfResult
        );

        [VtblIndex(97)]
        HRESULT get_runtimeStyle(IHTMLStyle* p);

        [VtblIndex(98)]
        HRESULT get_behaviorUrns(IDispatch* p);

        [VtblIndex(99)]
        HRESULT put_tagUrn([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(100)]
        HRESULT get_tagUrn([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(101)]
        HRESULT put_onbeforeeditfocus(VARIANT v);

        [VtblIndex(102)]
        HRESULT get_onbeforeeditfocus(VARIANT* p);

        [VtblIndex(103)]
        HRESULT get_readyStateValue([NativeTypeName("long *")] int* p);

        [VtblIndex(104)]
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_scopeName;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> setCapture;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> releaseCapture;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onlosecapture;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onlosecapture;

        [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort**, int> componentFromPoint;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> doScroll;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onscroll;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onscroll;

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
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragover;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragover;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondragleave;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondragleave;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondrop;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondrop;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforecut;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforecut;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncut;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncut;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforecopy;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforecopy;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncopy;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncopy;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforepaste;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforepaste;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpaste;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpaste;

        [NativeTypeName("HRESULT (IHTMLCurrentStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLCurrentStyle*, int> get_currentStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpropertychange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpropertychange;

        [NativeTypeName("HRESULT (IHTMLRectCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLRectCollection*, int> getClientRects;

        [NativeTypeName("HRESULT (IHTMLRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLRect*, int> getBoundingClientRect;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> setExpression;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getExpression;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> removeExpression;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_tabIndex;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_tabIndex;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> focus;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_accessKey;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_accessKey;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onblur;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onblur;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocus;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocus;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onresize;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onresize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> blur;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> addFilter;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> removeFilter;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientHeight;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientTop;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientLeft;

        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch, short*, int> attachEvent;

        [NativeTypeName("HRESULT (BSTR, IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch, int> detachEvent;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_readyState;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;

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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dir;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dir;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> createControlRange;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollHeight;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollWidth;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollTop;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollTop;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollLeft;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollLeft;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clearAttributes;

        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, int> mergeAttributes;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncontextmenu;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncontextmenu;

        [NativeTypeName("HRESULT (BSTR, IHTMLElement *, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IHTMLElement,
            IHTMLElement*,
            int> insertAdjacentElement;

        [NativeTypeName("HRESULT (IHTMLElement *, BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, ushort*, IHTMLElement*, int> applyElement;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> getAdjacentText;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort**, int> replaceAdjacentText;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_canHaveChildren;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int*, int> addBehavior;

        [NativeTypeName("HRESULT (long, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, short*, int> removeBehavior;

        [NativeTypeName("HRESULT (IHTMLStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyle*, int> get_runtimeStyle;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_behaviorUrns;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_tagUrn;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_tagUrn;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeeditfocus;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeeditfocus;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyStateValue;

        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IHTMLElementCollection*,
            int> getElementsByTagName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLElement2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLElement2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLElement2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLElement2(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLElement2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLElement2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLElement2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLElement2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLElement2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLElement2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLElement2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLElement2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLElement2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLElement2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
