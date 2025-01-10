// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F673-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElement3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElement3 : IHTMLElement3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElement3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElement3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLElement3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElement3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElement3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElement3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLElement3, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLElement3,
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
    public HRESULT mergeAttributes(IHTMLElement mergeThis, VARIANT* pvarFlags)
    {
        return ((delegate* unmanaged<IHTMLElement3, IHTMLElement, VARIANT*, int>)((*lpVtbl)[7]))(
            this,
            mergeThis,
            pvarFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_isMultiLine([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_canHaveHTML([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_onlayoutcomplete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[10]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_onlayoutcomplete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_onpage(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[12]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_onpage(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[13]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_inflateBlock([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElement3, short, int>)((*lpVtbl)[14]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_inflateBlock([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onbeforedeactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onbeforedeactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT setActive()
    {
        return ((delegate* unmanaged<IHTMLElement3, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_contentEditable([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement3, ushort*, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_contentEditable([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement3, ushort**, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_isContentEditable([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_hideFocus([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElement3, short, int>)((*lpVtbl)[22]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_hideFocus([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElement3, short, int>)((*lpVtbl)[24]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_isDisabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[26]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_onmove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[27]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_onmove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[28]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_oncontrolselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[29]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_oncontrolselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[30]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT fireEvent(
        [NativeTypeName("BSTR")] ushort* bstrEventName,
        VARIANT* pvarEventObject,
        [NativeTypeName("VARIANT_BOOL *")] short* pfCancelled
    )
    {
        return (
            (delegate* unmanaged<IHTMLElement3, ushort*, VARIANT*, short*, int>)((*lpVtbl)[31])
        )(this, bstrEventName, pvarEventObject, pfCancelled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_onresizestart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[32]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_onresizestart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[33]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_onresizeend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[34]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_onresizeend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[35]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_onmovestart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[36]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_onmovestart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_onmoveend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[38]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_onmoveend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[39]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_onmouseenter(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[40]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_onmouseenter(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[41]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_onmouseleave(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[42]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_onmouseleave(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[43]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_onactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[44]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_onactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[45]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_ondeactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT, int>)((*lpVtbl)[46]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_ondeactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, VARIANT*, int>)((*lpVtbl)[47]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT dragDrop([NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLElement3, short*, int>)((*lpVtbl)[48]))(this, pfRet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_glyphMode([NativeTypeName("LONG *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElement3, int*, int>)((*lpVtbl)[49]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT mergeAttributes(IHTMLElement mergeThis, VARIANT* pvarFlags);

        [VtblIndex(8)]
        HRESULT get_isMultiLine([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(9)]
        HRESULT get_canHaveHTML([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(10)]
        HRESULT put_onlayoutcomplete(VARIANT v);

        [VtblIndex(11)]
        HRESULT get_onlayoutcomplete(VARIANT* p);

        [VtblIndex(12)]
        HRESULT put_onpage(VARIANT v);

        [VtblIndex(13)]
        HRESULT get_onpage(VARIANT* p);

        [VtblIndex(14)]
        HRESULT put_inflateBlock([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(15)]
        HRESULT get_inflateBlock([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(16)]
        HRESULT put_onbeforedeactivate(VARIANT v);

        [VtblIndex(17)]
        HRESULT get_onbeforedeactivate(VARIANT* p);

        [VtblIndex(18)]
        HRESULT setActive();

        [VtblIndex(19)]
        HRESULT put_contentEditable([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_contentEditable([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT get_isContentEditable([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(22)]
        HRESULT put_hideFocus([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(23)]
        HRESULT get_hideFocus([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(24)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(25)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(26)]
        HRESULT get_isDisabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(27)]
        HRESULT put_onmove(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_onmove(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_oncontrolselect(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_oncontrolselect(VARIANT* p);

        [VtblIndex(31)]
        HRESULT fireEvent(
            [NativeTypeName("BSTR")] ushort* bstrEventName,
            VARIANT* pvarEventObject,
            [NativeTypeName("VARIANT_BOOL *")] short* pfCancelled
        );

        [VtblIndex(32)]
        HRESULT put_onresizestart(VARIANT v);

        [VtblIndex(33)]
        HRESULT get_onresizestart(VARIANT* p);

        [VtblIndex(34)]
        HRESULT put_onresizeend(VARIANT v);

        [VtblIndex(35)]
        HRESULT get_onresizeend(VARIANT* p);

        [VtblIndex(36)]
        HRESULT put_onmovestart(VARIANT v);

        [VtblIndex(37)]
        HRESULT get_onmovestart(VARIANT* p);

        [VtblIndex(38)]
        HRESULT put_onmoveend(VARIANT v);

        [VtblIndex(39)]
        HRESULT get_onmoveend(VARIANT* p);

        [VtblIndex(40)]
        HRESULT put_onmouseenter(VARIANT v);

        [VtblIndex(41)]
        HRESULT get_onmouseenter(VARIANT* p);

        [VtblIndex(42)]
        HRESULT put_onmouseleave(VARIANT v);

        [VtblIndex(43)]
        HRESULT get_onmouseleave(VARIANT* p);

        [VtblIndex(44)]
        HRESULT put_onactivate(VARIANT v);

        [VtblIndex(45)]
        HRESULT get_onactivate(VARIANT* p);

        [VtblIndex(46)]
        HRESULT put_ondeactivate(VARIANT v);

        [VtblIndex(47)]
        HRESULT get_ondeactivate(VARIANT* p);

        [VtblIndex(48)]
        HRESULT dragDrop([NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(49)]
        HRESULT get_glyphMode([NativeTypeName("LONG *")] int* p);
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

        [NativeTypeName("HRESULT (IHTMLElement *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, VARIANT*, int> mergeAttributes;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isMultiLine;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_canHaveHTML;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onlayoutcomplete;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onlayoutcomplete;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpage;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpage;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_inflateBlock;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_inflateBlock;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforedeactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforedeactivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> setActive;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_contentEditable;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_contentEditable;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isContentEditable;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_hideFocus;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_hideFocus;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isDisabled;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmove;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmove;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncontrolselect;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncontrolselect;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, short*, int> fireEvent;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onresizestart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onresizestart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onresizeend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onresizeend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmovestart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmovestart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmoveend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmoveend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseenter;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseenter;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmouseleave;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmouseleave;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onactivate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondeactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondeactivate;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> dragDrop;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_glyphMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLElement3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLElement3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLElement3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLElement3(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLElement3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLElement3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLElement3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLElement3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLElement3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLElement3(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLElement3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLElement3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLElement3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLElement3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
