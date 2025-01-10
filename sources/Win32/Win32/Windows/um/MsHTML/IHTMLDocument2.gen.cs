// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("332C4425-26CB-11D0-B483-00C04FD90119")]
[NativeTypeName("struct IHTMLDocument2 : IHTMLDocument")]
[NativeInheritance("IHTMLDocument")]
public unsafe partial struct IHTMLDocument2 : IHTMLDocument2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLDocument2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLDocument2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLDocument2,
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
    public HRESULT get_Script(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IDispatch*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_all(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[8]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_body(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElement*, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_activeElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElement*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_images(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[11]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_applets(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[12]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_links(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[13]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_forms(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[14]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_anchors(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[15]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_title([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_title([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_scripts(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[18]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_designMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_designMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_selection(IHTMLSelectionObject* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLSelectionObject*, int>)((*lpVtbl)[21]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_frames(IHTMLFramesCollection2* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLFramesCollection2*, int>)((*lpVtbl)[23]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_embeds(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[24]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_plugins(IHTMLElementCollection* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLElementCollection*, int>)((*lpVtbl)[25]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_alinkColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[26]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_alinkColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[28]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_fgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[30]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_fgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_linkColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[32]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_linkColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[33]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_vlinkColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[34]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_vlinkColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[35]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_referrer([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[36]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_location(IHTMLLocation* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLLocation*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_lastModified([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[38]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_URL([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[39]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[40]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_domain([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[41]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_domain([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[42]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_cookie([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[43]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_cookie([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[44]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_expando([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, short, int>)((*lpVtbl)[45]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_expando([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, short*, int>)((*lpVtbl)[46]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_charset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[47]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[48]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_defaultCharset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, int>)((*lpVtbl)[49]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_defaultCharset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[50]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[51]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[52]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[53]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[54]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[55]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_security([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[56]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[57]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[58]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT write(SAFEARRAY* psarray)
    {
        return ((delegate* unmanaged<IHTMLDocument2, SAFEARRAY*, int>)((*lpVtbl)[59]))(
            this,
            psarray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT writeln(SAFEARRAY* psarray)
    {
        return ((delegate* unmanaged<IHTMLDocument2, SAFEARRAY*, int>)((*lpVtbl)[60]))(
            this,
            psarray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT open(
        [NativeTypeName("BSTR")] ushort* url,
        VARIANT name,
        VARIANT features,
        VARIANT replace,
        IDispatch* pomWindowResult
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLDocument2,
                ushort*,
                VARIANT,
                VARIANT,
                VARIANT,
                IDispatch*,
                int>)((*lpVtbl)[61])
        )(this, url, name, features, replace, pomWindowResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT close()
    {
        return ((delegate* unmanaged<IHTMLDocument2, int>)((*lpVtbl)[62]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT clear()
    {
        return ((delegate* unmanaged<IHTMLDocument2, int>)((*lpVtbl)[63]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT queryCommandSupported(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, short*, int>)((*lpVtbl)[64]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT queryCommandEnabled(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, short*, int>)((*lpVtbl)[65]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT queryCommandState(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, short*, int>)((*lpVtbl)[66]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT queryCommandIndeterm(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, short*, int>)((*lpVtbl)[67]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT queryCommandText(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("BSTR *")] ushort** pcmdText
    )
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, ushort**, int>)((*lpVtbl)[68]))(
            this,
            cmdID,
            pcmdText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, VARIANT*, int>)((*lpVtbl)[69]))(
            this,
            cmdID,
            pcmdValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT execCommand(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL")] short showUI,
        VARIANT value,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument2, ushort*, short, VARIANT, short*, int>)(
                (*lpVtbl)[70]
            )
        )(this, cmdID, showUI, value, pfRet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT execCommandShowHelp(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, short*, int>)((*lpVtbl)[71]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT createElement([NativeTypeName("BSTR")] ushort* eTag, IHTMLElement* newElem)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort*, IHTMLElement*, int>)((*lpVtbl)[72]))(
            this,
            eTag,
            newElem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_onhelp(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[73]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_onhelp(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[74]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_onclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[75]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_onclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[76]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_ondblclick(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[77]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_ondblclick(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[78]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_onkeyup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[79]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_onkeyup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[80]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT put_onkeydown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[81]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_onkeydown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[82]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT put_onkeypress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[83]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_onkeypress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[84]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT put_onmouseup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[85]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_onmouseup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[86]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT put_onmousedown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[87]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_onmousedown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[88]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_onmousemove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[89]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_onmousemove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[90]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT put_onmouseout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[91]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_onmouseout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[92]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT put_onmouseover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[93]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_onmouseover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[94]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[95]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[96]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT put_onafterupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[97]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_onafterupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[98]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT put_onrowexit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[99]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_onrowexit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[100]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT put_onrowenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[101]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_onrowenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[102]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT put_ondragstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[103]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_ondragstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[104]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT put_onselectstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[105]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_onselectstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[106]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT elementFromPoint(
        [NativeTypeName("long")] int x,
        [NativeTypeName("long")] int y,
        IHTMLElement* elementHit
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument2, int, int, IHTMLElement*, int>)((*lpVtbl)[107])
        )(this, x, y, elementHit);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_parentWindow(IHTMLWindow2* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, IHTMLWindow2*, int>)((*lpVtbl)[108]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_styleSheets(IHTMLStyleSheetsCollection* p)
    {
        return (
            (delegate* unmanaged<IHTMLDocument2, IHTMLStyleSheetsCollection*, int>)((*lpVtbl)[109])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT put_onbeforeupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[110]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_onbeforeupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[111]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT put_onerrorupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT, int>)((*lpVtbl)[112]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_onerrorupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument2, VARIANT*, int>)((*lpVtbl)[113]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLDocument2, ushort**, int>)((*lpVtbl)[114]))(this, String);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT createStyleSheet(
        [NativeTypeName("BSTR")] ushort* bstrHref,
        [NativeTypeName("long")] int lIndex,
        IHTMLStyleSheet* ppnewStyleSheet
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument2, ushort*, int, IHTMLStyleSheet*, int>)(
                (*lpVtbl)[115]
            )
        )(this, bstrHref, lIndex, ppnewStyleSheet);
    }

    public interface Interface : IHTMLDocument.Interface
    {
        [VtblIndex(8)]
        HRESULT get_all(IHTMLElementCollection* p);

        [VtblIndex(9)]
        HRESULT get_body(IHTMLElement* p);

        [VtblIndex(10)]
        HRESULT get_activeElement(IHTMLElement* p);

        [VtblIndex(11)]
        HRESULT get_images(IHTMLElementCollection* p);

        [VtblIndex(12)]
        HRESULT get_applets(IHTMLElementCollection* p);

        [VtblIndex(13)]
        HRESULT get_links(IHTMLElementCollection* p);

        [VtblIndex(14)]
        HRESULT get_forms(IHTMLElementCollection* p);

        [VtblIndex(15)]
        HRESULT get_anchors(IHTMLElementCollection* p);

        [VtblIndex(16)]
        HRESULT put_title([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(17)]
        HRESULT get_title([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT get_scripts(IHTMLElementCollection* p);

        [VtblIndex(19)]
        HRESULT put_designMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_designMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT get_selection(IHTMLSelectionObject* p);

        [VtblIndex(22)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(23)]
        HRESULT get_frames(IHTMLFramesCollection2* p);

        [VtblIndex(24)]
        HRESULT get_embeds(IHTMLElementCollection* p);

        [VtblIndex(25)]
        HRESULT get_plugins(IHTMLElementCollection* p);

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
        HRESULT get_location(IHTMLLocation* p);

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
        HRESULT open(
            [NativeTypeName("BSTR")] ushort* url,
            VARIANT name,
            VARIANT features,
            VARIANT replace,
            IDispatch* pomWindowResult
        );

        [VtblIndex(62)]
        HRESULT close();

        [VtblIndex(63)]
        HRESULT clear();

        [VtblIndex(64)]
        HRESULT queryCommandSupported(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(65)]
        HRESULT queryCommandEnabled(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(66)]
        HRESULT queryCommandState(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(67)]
        HRESULT queryCommandIndeterm(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(68)]
        HRESULT queryCommandText(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("BSTR *")] ushort** pcmdText
        );

        [VtblIndex(69)]
        HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue);

        [VtblIndex(70)]
        HRESULT execCommand(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL")] short showUI,
            VARIANT value,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(71)]
        HRESULT execCommandShowHelp(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(72)]
        HRESULT createElement([NativeTypeName("BSTR")] ushort* eTag, IHTMLElement* newElem);

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
        HRESULT elementFromPoint(
            [NativeTypeName("long")] int x,
            [NativeTypeName("long")] int y,
            IHTMLElement* elementHit
        );

        [VtblIndex(108)]
        HRESULT get_parentWindow(IHTMLWindow2* p);

        [VtblIndex(109)]
        HRESULT get_styleSheets(IHTMLStyleSheetsCollection* p);

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
        HRESULT createStyleSheet(
            [NativeTypeName("BSTR")] ushort* bstrHref,
            [NativeTypeName("long")] int lIndex,
            IHTMLStyleSheet* ppnewStyleSheet
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Script;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_all;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_body;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_activeElement;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_images;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_applets;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_links;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_forms;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_anchors;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_title;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_title;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_scripts;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_designMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_designMode;

        [NativeTypeName("HRESULT (IHTMLSelectionObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLSelectionObject*, int> get_selection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;

        [NativeTypeName("HRESULT (IHTMLFramesCollection2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFramesCollection2*, int> get_frames;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_embeds;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection*, int> get_plugins;

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
        public delegate* unmanaged<TSelf*, IHTMLLocation*, int> get_location;

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

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT, VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            VARIANT,
            VARIANT,
            VARIANT,
            IDispatch*,
            int> open;

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

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT_BOOL, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, short, VARIANT, short*, int> execCommand;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> execCommandShowHelp;

        [NativeTypeName("HRESULT (BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement*, int> createElement;

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
        public delegate* unmanaged<TSelf*, int, int, IHTMLElement*, int> elementFromPoint;

        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2*, int> get_parentWindow;

        [NativeTypeName("HRESULT (IHTMLStyleSheetsCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheetsCollection*, int> get_styleSheets;

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
        public delegate* unmanaged<TSelf*, ushort*, int, IHTMLStyleSheet*, int> createStyleSheet;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLDocument2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLDocument2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IHTMLDocument"/> to <see cref = "IHTMLDocument2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IHTMLDocument"/> instance to be converted </param>
    public static explicit operator IHTMLDocument2(Silk.NET.Windows.IHTMLDocument value)
    {
        return new IHTMLDocument2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument2"/> to <see cref = "Silk.NET.Windows.IHTMLDocument"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IHTMLDocument(IHTMLDocument2 value)
    {
        return new Silk.NET.Windows.IHTMLDocument(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLDocument2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLDocument2(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLDocument2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLDocument2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLDocument2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLDocument2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLDocument2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLDocument2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
