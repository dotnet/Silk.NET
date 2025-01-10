// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("332C4427-26CB-11D0-B483-00C04FD90119")]
[NativeTypeName("struct IHTMLWindow2 : IHTMLFramesCollection2")]
[NativeInheritance("IHTMLFramesCollection2")]
public unsafe partial struct IHTMLWindow2 : IHTMLWindow2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLWindow2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLWindow2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLWindow2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLWindow2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLWindow2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLWindow2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLWindow2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLWindow2,
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
    public HRESULT item(VARIANT* pvarIndex, VARIANT* pvarResult)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, VARIANT*, int>)((*lpVtbl)[7]))(
            this,
            pvarIndex,
            pvarResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_frames(IHTMLFramesCollection2* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLFramesCollection2*, int>)((*lpVtbl)[9]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_defaultStatus([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, int>)((*lpVtbl)[10]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_defaultStatus([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort**, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_status([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, int>)((*lpVtbl)[12]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_status([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort**, int>)((*lpVtbl)[13]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT setTimeout(
        [NativeTypeName("BSTR")] ushort* expression,
        [NativeTypeName("long")] int msec,
        VARIANT* language,
        [NativeTypeName("long *")] int* timerID
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow2, ushort*, int, VARIANT*, int*, int>)((*lpVtbl)[14])
        )(this, expression, msec, language, timerID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT clearTimeout([NativeTypeName("long")] int timerID)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int>)((*lpVtbl)[15]))(this, timerID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT alert([NativeTypeName("BSTR")] ushort* message = null)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, int>)((*lpVtbl)[16]))(this, message);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT confirm(
        [NativeTypeName("BSTR")] ushort* message,
        [NativeTypeName("VARIANT_BOOL *")] short* confirmed
    )
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, short*, int>)((*lpVtbl)[17]))(
            this,
            message,
            confirmed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT prompt(
        [NativeTypeName("BSTR")] ushort* message,
        [NativeTypeName("BSTR")] ushort* defstr,
        VARIANT* textdata
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow2, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[18])
        )(this, message, defstr, textdata);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Image(IHTMLImageElementFactory* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLImageElementFactory*, int>)((*lpVtbl)[19]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_location(IHTMLLocation* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLLocation*, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_history(IOmHistory* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IOmHistory*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT close()
    {
        return ((delegate* unmanaged<IHTMLWindow2, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_opener(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[23]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_opener(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_navigator(IOmNavigator* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IOmNavigator*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, int>)((*lpVtbl)[26]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort**, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_parent(IHTMLWindow2* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLWindow2*, int>)((*lpVtbl)[28]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT open(
        [NativeTypeName("BSTR")] ushort* url,
        [NativeTypeName("BSTR")] ushort* name,
        [NativeTypeName("BSTR")] ushort* features,
        [NativeTypeName("VARIANT_BOOL")] short replace,
        IHTMLWindow2* pomWindowResult
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLWindow2,
                ushort*,
                ushort*,
                ushort*,
                short,
                IHTMLWindow2*,
                int>)((*lpVtbl)[29])
        )(this, url, name, features, replace, pomWindowResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_self(IHTMLWindow2* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLWindow2*, int>)((*lpVtbl)[30]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_top(IHTMLWindow2* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLWindow2*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_window(IHTMLWindow2* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLWindow2*, int>)((*lpVtbl)[32]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT navigate([NativeTypeName("BSTR")] ushort* url)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, int>)((*lpVtbl)[33]))(this, url);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_onfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[34]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_onfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[35]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_onblur(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[36]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_onblur(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[38]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[39]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_onbeforeunload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[40]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_onbeforeunload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[41]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_onunload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[42]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_onunload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[43]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_onhelp(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[44]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_onhelp(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[45]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[46]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[47]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_onresize(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[48]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_onresize(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[49]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_onscroll(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[50]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_onscroll(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[51]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_document(IHTMLDocument2* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLDocument2*, int>)((*lpVtbl)[52]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_event(IHTMLEventObj* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLEventObj*, int>)((*lpVtbl)[53]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get__newEnum(IUnknown* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IUnknown*, int>)((*lpVtbl)[54]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT showModalDialog(
        [NativeTypeName("BSTR")] ushort* dialog,
        VARIANT* varArgIn,
        VARIANT* varOptions,
        VARIANT* varArgOut
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow2, ushort*, VARIANT*, VARIANT*, VARIANT*, int>)(
                (*lpVtbl)[55]
            )
        )(this, dialog, varArgIn, varOptions, varArgOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT showHelp(
        [NativeTypeName("BSTR")] ushort* helpURL,
        VARIANT helpArg,
        [NativeTypeName("BSTR")] ushort* features = null
    )
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort*, VARIANT, ushort*, int>)((*lpVtbl)[56]))(
            this,
            helpURL,
            helpArg,
            features
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_screen(IHTMLScreen* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IHTMLScreen*, int>)((*lpVtbl)[57]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_Option(IHTMLOptionElementFactory* p)
    {
        return (
            (delegate* unmanaged<IHTMLWindow2, IHTMLOptionElementFactory*, int>)((*lpVtbl)[58])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT focus()
    {
        return ((delegate* unmanaged<IHTMLWindow2, int>)((*lpVtbl)[59]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_closed([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, short*, int>)((*lpVtbl)[60]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT blur()
    {
        return ((delegate* unmanaged<IHTMLWindow2, int>)((*lpVtbl)[61]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT scroll([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[62]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_clientInformation(IOmNavigator* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IOmNavigator*, int>)((*lpVtbl)[63]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT setInterval(
        [NativeTypeName("BSTR")] ushort* expression,
        [NativeTypeName("long")] int msec,
        VARIANT* language,
        [NativeTypeName("long *")] int* timerID
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow2, ushort*, int, VARIANT*, int*, int>)((*lpVtbl)[64])
        )(this, expression, msec, language, timerID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT clearInterval([NativeTypeName("long")] int timerID)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int>)((*lpVtbl)[65]))(this, timerID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_offscreenBuffering(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT, int>)((*lpVtbl)[66]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_offscreenBuffering(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, VARIANT*, int>)((*lpVtbl)[67]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT execScript(
        [NativeTypeName("BSTR")] ushort* code,
        [NativeTypeName("BSTR")] ushort* language,
        VARIANT* pvarRet
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow2, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[68])
        )(this, code, language, pvarRet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLWindow2, ushort**, int>)((*lpVtbl)[69]))(this, String);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT scrollBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[70]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT scrollTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[71]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT moveTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[72]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT moveBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[73]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT resizeTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[74]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT resizeBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLWindow2, int, int, int>)((*lpVtbl)[75]))(this, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_external(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLWindow2, IDispatch*, int>)((*lpVtbl)[76]))(this, p);
    }

    public interface Interface : IHTMLFramesCollection2.Interface
    {
        [VtblIndex(9)]
        HRESULT get_frames(IHTMLFramesCollection2* p);

        [VtblIndex(10)]
        HRESULT put_defaultStatus([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(11)]
        HRESULT get_defaultStatus([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(12)]
        HRESULT put_status([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(13)]
        HRESULT get_status([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(14)]
        HRESULT setTimeout(
            [NativeTypeName("BSTR")] ushort* expression,
            [NativeTypeName("long")] int msec,
            VARIANT* language,
            [NativeTypeName("long *")] int* timerID
        );

        [VtblIndex(15)]
        HRESULT clearTimeout([NativeTypeName("long")] int timerID);

        [VtblIndex(16)]
        HRESULT alert([NativeTypeName("BSTR")] ushort* message = null);

        [VtblIndex(17)]
        HRESULT confirm(
            [NativeTypeName("BSTR")] ushort* message,
            [NativeTypeName("VARIANT_BOOL *")] short* confirmed
        );

        [VtblIndex(18)]
        HRESULT prompt(
            [NativeTypeName("BSTR")] ushort* message,
            [NativeTypeName("BSTR")] ushort* defstr,
            VARIANT* textdata
        );

        [VtblIndex(19)]
        HRESULT get_Image(IHTMLImageElementFactory* p);

        [VtblIndex(20)]
        HRESULT get_location(IHTMLLocation* p);

        [VtblIndex(21)]
        HRESULT get_history(IOmHistory* p);

        [VtblIndex(22)]
        HRESULT close();

        [VtblIndex(23)]
        HRESULT put_opener(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_opener(VARIANT* p);

        [VtblIndex(25)]
        HRESULT get_navigator(IOmNavigator* p);

        [VtblIndex(26)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(27)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(28)]
        HRESULT get_parent(IHTMLWindow2* p);

        [VtblIndex(29)]
        HRESULT open(
            [NativeTypeName("BSTR")] ushort* url,
            [NativeTypeName("BSTR")] ushort* name,
            [NativeTypeName("BSTR")] ushort* features,
            [NativeTypeName("VARIANT_BOOL")] short replace,
            IHTMLWindow2* pomWindowResult
        );

        [VtblIndex(30)]
        HRESULT get_self(IHTMLWindow2* p);

        [VtblIndex(31)]
        HRESULT get_top(IHTMLWindow2* p);

        [VtblIndex(32)]
        HRESULT get_window(IHTMLWindow2* p);

        [VtblIndex(33)]
        HRESULT navigate([NativeTypeName("BSTR")] ushort* url);

        [VtblIndex(34)]
        HRESULT put_onfocus(VARIANT v);

        [VtblIndex(35)]
        HRESULT get_onfocus(VARIANT* p);

        [VtblIndex(36)]
        HRESULT put_onblur(VARIANT v);

        [VtblIndex(37)]
        HRESULT get_onblur(VARIANT* p);

        [VtblIndex(38)]
        HRESULT put_onload(VARIANT v);

        [VtblIndex(39)]
        HRESULT get_onload(VARIANT* p);

        [VtblIndex(40)]
        HRESULT put_onbeforeunload(VARIANT v);

        [VtblIndex(41)]
        HRESULT get_onbeforeunload(VARIANT* p);

        [VtblIndex(42)]
        HRESULT put_onunload(VARIANT v);

        [VtblIndex(43)]
        HRESULT get_onunload(VARIANT* p);

        [VtblIndex(44)]
        HRESULT put_onhelp(VARIANT v);

        [VtblIndex(45)]
        HRESULT get_onhelp(VARIANT* p);

        [VtblIndex(46)]
        HRESULT put_onerror(VARIANT v);

        [VtblIndex(47)]
        HRESULT get_onerror(VARIANT* p);

        [VtblIndex(48)]
        HRESULT put_onresize(VARIANT v);

        [VtblIndex(49)]
        HRESULT get_onresize(VARIANT* p);

        [VtblIndex(50)]
        HRESULT put_onscroll(VARIANT v);

        [VtblIndex(51)]
        HRESULT get_onscroll(VARIANT* p);

        [VtblIndex(52)]
        HRESULT get_document(IHTMLDocument2* p);

        [VtblIndex(53)]
        HRESULT get_event(IHTMLEventObj* p);

        [VtblIndex(54)]
        HRESULT get__newEnum(IUnknown* p);

        [VtblIndex(55)]
        HRESULT showModalDialog(
            [NativeTypeName("BSTR")] ushort* dialog,
            VARIANT* varArgIn,
            VARIANT* varOptions,
            VARIANT* varArgOut
        );

        [VtblIndex(56)]
        HRESULT showHelp(
            [NativeTypeName("BSTR")] ushort* helpURL,
            VARIANT helpArg,
            [NativeTypeName("BSTR")] ushort* features = null
        );

        [VtblIndex(57)]
        HRESULT get_screen(IHTMLScreen* p);

        [VtblIndex(58)]
        HRESULT get_Option(IHTMLOptionElementFactory* p);

        [VtblIndex(59)]
        HRESULT focus();

        [VtblIndex(60)]
        HRESULT get_closed([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(61)]
        HRESULT blur();

        [VtblIndex(62)]
        HRESULT scroll([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(63)]
        HRESULT get_clientInformation(IOmNavigator* p);

        [VtblIndex(64)]
        HRESULT setInterval(
            [NativeTypeName("BSTR")] ushort* expression,
            [NativeTypeName("long")] int msec,
            VARIANT* language,
            [NativeTypeName("long *")] int* timerID
        );

        [VtblIndex(65)]
        HRESULT clearInterval([NativeTypeName("long")] int timerID);

        [VtblIndex(66)]
        HRESULT put_offscreenBuffering(VARIANT v);

        [VtblIndex(67)]
        HRESULT get_offscreenBuffering(VARIANT* p);

        [VtblIndex(68)]
        HRESULT execScript(
            [NativeTypeName("BSTR")] ushort* code,
            [NativeTypeName("BSTR")] ushort* language,
            VARIANT* pvarRet
        );

        [VtblIndex(69)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** String);

        [VtblIndex(70)]
        HRESULT scrollBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(71)]
        HRESULT scrollTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(72)]
        HRESULT moveTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(73)]
        HRESULT moveBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(74)]
        HRESULT resizeTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(75)]
        HRESULT resizeBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(76)]
        HRESULT get_external(IDispatch* p);
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

        [NativeTypeName("HRESULT (VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, VARIANT*, int> item;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (IHTMLFramesCollection2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFramesCollection2*, int> get_frames;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_defaultStatus;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_defaultStatus;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_status;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_status;

        [NativeTypeName("HRESULT (BSTR, long, VARIANT *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int*, int> setTimeout;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> clearTimeout;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> alert;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> confirm;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> prompt;

        [NativeTypeName("HRESULT (IHTMLImageElementFactory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLImageElementFactory*, int> get_Image;

        [NativeTypeName("HRESULT (IHTMLLocation **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLLocation*, int> get_location;

        [NativeTypeName("HRESULT (IOmHistory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOmHistory*, int> get_history;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> close;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_opener;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_opener;

        [NativeTypeName("HRESULT (IOmNavigator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOmNavigator*, int> get_navigator;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2*, int> get_parent;

        [NativeTypeName(
            "HRESULT (BSTR, BSTR, BSTR, VARIANT_BOOL, IHTMLWindow2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            short,
            IHTMLWindow2*,
            int> open;

        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2*, int> get_self;

        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2*, int> get_top;

        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2*, int> get_window;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> navigate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocus;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocus;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onblur;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onblur;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeunload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeunload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onunload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onunload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onhelp;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onhelp;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onresize;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onresize;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onscroll;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onscroll;

        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2*, int> get_document;

        [NativeTypeName("HRESULT (IHTMLEventObj **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLEventObj*, int> get_event;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get__newEnum;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            VARIANT*,
            VARIANT*,
            VARIANT*,
            int> showModalDialog;

        [NativeTypeName("HRESULT (BSTR, VARIANT, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, ushort*, int> showHelp;

        [NativeTypeName("HRESULT (IHTMLScreen **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLScreen*, int> get_screen;

        [NativeTypeName("HRESULT (IHTMLOptionElementFactory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLOptionElementFactory*, int> get_Option;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> focus;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_closed;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> blur;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> scroll;

        [NativeTypeName("HRESULT (IOmNavigator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOmNavigator*, int> get_clientInformation;

        [NativeTypeName("HRESULT (BSTR, long, VARIANT *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int*, int> setInterval;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> clearInterval;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_offscreenBuffering;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_offscreenBuffering;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> execScript;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> scrollBy;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> scrollTo;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> moveTo;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> moveBy;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> resizeTo;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> resizeBy;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_external;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLWindow2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLWindow2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IHTMLFramesCollection2"/> to <see cref = "IHTMLWindow2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IHTMLFramesCollection2"/> instance to be converted </param>
    public static explicit operator IHTMLWindow2(Silk.NET.Windows.IHTMLFramesCollection2 value)
    {
        return new IHTMLWindow2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLWindow2"/> to <see cref = "Silk.NET.Windows.IHTMLFramesCollection2"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLWindow2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IHTMLFramesCollection2(IHTMLWindow2 value)
    {
        return new Silk.NET.Windows.IHTMLFramesCollection2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLWindow2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLWindow2(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLWindow2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLWindow2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLWindow2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLWindow2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLWindow2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLWindow2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLWindow2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLWindow2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLWindow2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLWindow2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
