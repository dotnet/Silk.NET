// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305107AA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElement7 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElement7 : IHTMLElement7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElement7));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElement7, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLElement7, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElement7, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElement7, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElement7, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLElement7, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLElement7,
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
    public HRESULT put_onmspointerdown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_onmspointerdown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_onmspointermove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[9]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_onmspointermove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_onmspointerup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[11]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_onmspointerup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onmspointerover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onmspointerover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_onmspointerout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[15]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_onmspointerout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onmspointercancel(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[17]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onmspointercancel(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_onmspointerhover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_onmspointerhover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_onmslostpointercapture(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[21]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_onmslostpointercapture(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onmsgotpointercapture(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[23]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onmsgotpointercapture(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onmsgesturestart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[25]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onmsgesturestart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[26]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_onmsgesturechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[27]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_onmsgesturechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[28]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_onmsgestureend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[29]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_onmsgestureend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[30]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onmsgesturehold(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[31]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onmsgesturehold(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[32]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onmsgesturetap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[33]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onmsgesturetap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[34]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_onmsgesturedoubletap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[35]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_onmsgesturedoubletap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[36]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_onmsinertiastart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[37]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_onmsinertiastart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[38]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT msSetPointerCapture([NativeTypeName("long")] int pointerId)
    {
        return ((delegate* unmanaged<IHTMLElement7, int, int>)((*lpVtbl)[39]))(this, pointerId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT msReleasePointerCapture([NativeTypeName("long")] int pointerId)
    {
        return ((delegate* unmanaged<IHTMLElement7, int, int>)((*lpVtbl)[40]))(this, pointerId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_onmstransitionstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[41]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_onmstransitionstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[42]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_onmstransitionend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[43]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_onmstransitionend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[44]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_onmsanimationstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[45]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_onmsanimationstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[46]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_onmsanimationend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[47]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_onmsanimationend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[48]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_onmsanimationiteration(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[49]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_onmsanimationiteration(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[50]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_oninvalid(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[51]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_oninvalid(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[52]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_xmsAcceleratorKey([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElement7, ushort*, int>)((*lpVtbl)[53]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_xmsAcceleratorKey([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement7, ushort**, int>)((*lpVtbl)[54]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_spellcheck(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[55]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_spellcheck(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[56]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_onmsmanipulationstatechanged(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[57]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_onmsmanipulationstatechanged(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[58]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_oncuechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT, int>)((*lpVtbl)[59]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_oncuechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement7, VARIANT*, int>)((*lpVtbl)[60]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_onmspointerdown(VARIANT v);

        [VtblIndex(8)]
        HRESULT get_onmspointerdown(VARIANT* p);

        [VtblIndex(9)]
        HRESULT put_onmspointermove(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_onmspointermove(VARIANT* p);

        [VtblIndex(11)]
        HRESULT put_onmspointerup(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_onmspointerup(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_onmspointerover(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_onmspointerover(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_onmspointerout(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_onmspointerout(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_onmspointercancel(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_onmspointercancel(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_onmspointerhover(VARIANT v);

        [VtblIndex(20)]
        HRESULT get_onmspointerhover(VARIANT* p);

        [VtblIndex(21)]
        HRESULT put_onmslostpointercapture(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_onmslostpointercapture(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_onmsgotpointercapture(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_onmsgotpointercapture(VARIANT* p);

        [VtblIndex(25)]
        HRESULT put_onmsgesturestart(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_onmsgesturestart(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_onmsgesturechange(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_onmsgesturechange(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_onmsgestureend(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_onmsgestureend(VARIANT* p);

        [VtblIndex(31)]
        HRESULT put_onmsgesturehold(VARIANT v);

        [VtblIndex(32)]
        HRESULT get_onmsgesturehold(VARIANT* p);

        [VtblIndex(33)]
        HRESULT put_onmsgesturetap(VARIANT v);

        [VtblIndex(34)]
        HRESULT get_onmsgesturetap(VARIANT* p);

        [VtblIndex(35)]
        HRESULT put_onmsgesturedoubletap(VARIANT v);

        [VtblIndex(36)]
        HRESULT get_onmsgesturedoubletap(VARIANT* p);

        [VtblIndex(37)]
        HRESULT put_onmsinertiastart(VARIANT v);

        [VtblIndex(38)]
        HRESULT get_onmsinertiastart(VARIANT* p);

        [VtblIndex(39)]
        HRESULT msSetPointerCapture([NativeTypeName("long")] int pointerId);

        [VtblIndex(40)]
        HRESULT msReleasePointerCapture([NativeTypeName("long")] int pointerId);

        [VtblIndex(41)]
        HRESULT put_onmstransitionstart(VARIANT v);

        [VtblIndex(42)]
        HRESULT get_onmstransitionstart(VARIANT* p);

        [VtblIndex(43)]
        HRESULT put_onmstransitionend(VARIANT v);

        [VtblIndex(44)]
        HRESULT get_onmstransitionend(VARIANT* p);

        [VtblIndex(45)]
        HRESULT put_onmsanimationstart(VARIANT v);

        [VtblIndex(46)]
        HRESULT get_onmsanimationstart(VARIANT* p);

        [VtblIndex(47)]
        HRESULT put_onmsanimationend(VARIANT v);

        [VtblIndex(48)]
        HRESULT get_onmsanimationend(VARIANT* p);

        [VtblIndex(49)]
        HRESULT put_onmsanimationiteration(VARIANT v);

        [VtblIndex(50)]
        HRESULT get_onmsanimationiteration(VARIANT* p);

        [VtblIndex(51)]
        HRESULT put_oninvalid(VARIANT v);

        [VtblIndex(52)]
        HRESULT get_oninvalid(VARIANT* p);

        [VtblIndex(53)]
        HRESULT put_xmsAcceleratorKey([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(54)]
        HRESULT get_xmsAcceleratorKey([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(55)]
        HRESULT put_spellcheck(VARIANT v);

        [VtblIndex(56)]
        HRESULT get_spellcheck(VARIANT* p);

        [VtblIndex(57)]
        HRESULT put_onmsmanipulationstatechanged(VARIANT v);

        [VtblIndex(58)]
        HRESULT get_onmsmanipulationstatechanged(VARIANT* p);

        [VtblIndex(59)]
        HRESULT put_oncuechange(VARIANT v);

        [VtblIndex(60)]
        HRESULT get_oncuechange(VARIANT* p);
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

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerdown;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerdown;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointermove;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointermove;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerup;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerup;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerover;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerover;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerout;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerout;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointercancel;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointercancel;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerhover;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerhover;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmslostpointercapture;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmslostpointercapture;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgotpointercapture;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgotpointercapture;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturestart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturestart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturechange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgestureend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgestureend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturehold;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturehold;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturetap;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturetap;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturedoubletap;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturedoubletap;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsinertiastart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsinertiastart;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> msSetPointerCapture;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> msReleasePointerCapture;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmstransitionstart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmstransitionstart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmstransitionend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmstransitionend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsanimationstart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsanimationstart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsanimationend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsanimationend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsanimationiteration;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsanimationiteration;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oninvalid;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oninvalid;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_xmsAcceleratorKey;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_xmsAcceleratorKey;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_spellcheck;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_spellcheck;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsmanipulationstatechanged;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsmanipulationstatechanged;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncuechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncuechange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLElement7"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLElement7(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLElement7"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLElement7(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLElement7(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLElement7"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLElement7"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLElement7 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLElement7"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLElement7(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLElement7(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLElement7"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLElement7"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLElement7 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
