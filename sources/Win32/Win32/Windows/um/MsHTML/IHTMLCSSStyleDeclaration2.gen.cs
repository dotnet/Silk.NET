// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305107D1-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCSSStyleDeclaration2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCSSStyleDeclaration2
    : IHTMLCSSStyleDeclaration2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCSSStyleDeclaration2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration2, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
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
            (delegate* unmanaged<
                IHTMLCSSStyleDeclaration2,
                Guid*,
                ushort**,
                uint,
                uint,
                int*,
                int>)((*lpVtbl)[5])
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
                IHTMLCSSStyleDeclaration2,
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
    public HRESULT put_msScrollChaining([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[7]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_msScrollChaining([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[8]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_msContentZooming([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[9]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_msContentZooming([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[10]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_msContentZoomSnapType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[11]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_msContentZoomSnapType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[12]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_msScrollRails([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[13]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_msScrollRails([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[14]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_msContentZoomChaining([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[15]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_msContentZoomChaining([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[16]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_msScrollSnapType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[17]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_msScrollSnapType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[18]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_msContentZoomLimit([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[19]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_msContentZoomLimit([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[20]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_msContentZoomSnap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[21]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_msContentZoomSnap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[22]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_msContentZoomSnapPoints([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[23]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_msContentZoomSnapPoints([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[24]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_msContentZoomLimitMin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[25]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_msContentZoomLimitMin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[26]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_msContentZoomLimitMax(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[27]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_msContentZoomLimitMax(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[28]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_msScrollSnapX([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[29]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_msScrollSnapX([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[30]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_msScrollSnapY([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[31]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_msScrollSnapY([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[32]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_msScrollSnapPointsX([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[33]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_msScrollSnapPointsX([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[34]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_msScrollSnapPointsY([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[35]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_msScrollSnapPointsY([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[36]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_msGridColumn(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[37]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_msGridColumn(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[38]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_msGridColumnAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[39]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_msGridColumnAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[40]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_msGridColumns([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[41]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_msGridColumns([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[42]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_msGridColumnSpan(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[43]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_msGridColumnSpan(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[44]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_msGridRow(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[45]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_msGridRow(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[46]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_msGridRowAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[47]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_msGridRowAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[48]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_msGridRows([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[49]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_msGridRows([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[50]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_msGridRowSpan(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[51]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_msGridRowSpan(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[52]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_msWrapThrough([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[53]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_msWrapThrough([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[54]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_msWrapMargin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[55]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_msWrapMargin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[56]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_msWrapFlow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[57]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_msWrapFlow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[58]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_msAnimationName([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[59]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_msAnimationName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[60]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_msAnimationDuration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[61]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_msAnimationDuration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[62]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_msAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[63]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_msAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[64]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT put_msAnimationDelay([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[65]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_msAnimationDelay([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[66]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT put_msAnimationDirection([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[67]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_msAnimationDirection([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[68]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT put_msAnimationPlayState([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[69]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_msAnimationPlayState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[70]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_msAnimationIterationCount([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[71]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_msAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[72]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_msAnimation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[73]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_msAnimation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[74]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_msAnimationFillMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[75]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_msAnimationFillMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[76]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_colorInterpolationFilters([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[77]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_colorInterpolationFilters([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[78]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_columnCount(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[79]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_columnCount(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[80]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT put_columnWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[81]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_columnWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[82]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT put_columnGap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[83]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_columnGap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[84]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT put_columnFill([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[85]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_columnFill([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[86]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT put_columnSpan([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[87]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_columnSpan([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[88]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_columns([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[89]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_columns([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[90]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT put_columnRule([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[91]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_columnRule([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[92]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT put_columnRuleColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[93]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_columnRuleColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[94]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT put_columnRuleStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[95]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_columnRuleStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[96]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT put_columnRuleWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[97]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_columnRuleWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[98]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT put_breakBefore([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[99]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_breakBefore([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[100]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT put_breakAfter([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[101]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_breakAfter([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[102]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT put_breakInside([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[103]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_breakInside([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[104]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT put_floodColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[105]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_floodColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[106]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT put_floodOpacity(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[107]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_floodOpacity(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[108]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT put_lightingColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[109]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_lightingColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[110]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT put_msScrollLimitXMin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[111]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_msScrollLimitXMin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[112]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT put_msScrollLimitYMin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[113]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT get_msScrollLimitYMin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[114]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT put_msScrollLimitXMax(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[115]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT get_msScrollLimitXMax(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[116]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT put_msScrollLimitYMax(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[117]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT get_msScrollLimitYMax(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[118]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT put_msScrollLimit([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[119]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT get_msScrollLimit([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[120]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT put_textShadow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[121]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT get_textShadow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[122]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT put_msFlowFrom([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[123]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT get_msFlowFrom([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[124]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT put_msFlowInto([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[125]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT get_msFlowInto([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[126]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT put_msHyphens([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[127]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT get_msHyphens([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[128]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT put_msHyphenateLimitZone(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[129]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT get_msHyphenateLimitZone(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[130]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT put_msHyphenateLimitChars([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[131]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT get_msHyphenateLimitChars([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[132]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT put_msHyphenateLimitLines(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[133]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT get_msHyphenateLimitLines(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[134]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT put_msHighContrastAdjust([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[135]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT get_msHighContrastAdjust([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[136]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT put_enableBackground([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[137]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT get_enableBackground([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[138]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT put_msFontFeatureSettings([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[139]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT get_msFontFeatureSettings([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[140]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT put_msUserSelect([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[141]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT get_msUserSelect([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[142]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT put_msOverflowStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[143]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT get_msOverflowStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[144]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT put_msTransformStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[145]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT get_msTransformStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[146]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(147)]
    public HRESULT put_msBackfaceVisibility([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[147]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(148)]
    public HRESULT get_msBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[148]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(149)]
    public HRESULT put_msPerspective(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[149]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(150)]
    public HRESULT get_msPerspective(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[150]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(151)]
    public HRESULT put_msPerspectiveOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[151]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(152)]
    public HRESULT get_msPerspectiveOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[152]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(153)]
    public HRESULT put_msTransitionProperty([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[153]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(154)]
    public HRESULT get_msTransitionProperty([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[154]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(155)]
    public HRESULT put_msTransitionDuration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[155]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(156)]
    public HRESULT get_msTransitionDuration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[156]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(157)]
    public HRESULT put_msTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[157]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(158)]
    public HRESULT get_msTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[158]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(159)]
    public HRESULT put_msTransitionDelay([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[159]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(160)]
    public HRESULT get_msTransitionDelay([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[160]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(161)]
    public HRESULT put_msTransition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[161]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(162)]
    public HRESULT get_msTransition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[162]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(163)]
    public HRESULT put_msTouchAction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[163]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(164)]
    public HRESULT get_msTouchAction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[164]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(165)]
    public HRESULT put_msScrollTranslation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[165]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(166)]
    public HRESULT get_msScrollTranslation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[166]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(167)]
    public HRESULT put_msFlex([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[167]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(168)]
    public HRESULT get_msFlex([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[168]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(169)]
    public HRESULT put_msFlexPositive(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[169]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(170)]
    public HRESULT get_msFlexPositive(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[170]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(171)]
    public HRESULT put_msFlexNegative(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[171]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(172)]
    public HRESULT get_msFlexNegative(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[172]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(173)]
    public HRESULT put_msFlexPreferredSize(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[173]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(174)]
    public HRESULT get_msFlexPreferredSize(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[174]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(175)]
    public HRESULT put_msFlexFlow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[175]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(176)]
    public HRESULT get_msFlexFlow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[176]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(177)]
    public HRESULT put_msFlexDirection([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[177]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(178)]
    public HRESULT get_msFlexDirection([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[178]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(179)]
    public HRESULT put_msFlexWrap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[179]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(180)]
    public HRESULT get_msFlexWrap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[180]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(181)]
    public HRESULT put_msFlexAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[181]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(182)]
    public HRESULT get_msFlexAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[182]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(183)]
    public HRESULT put_msFlexItemAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[183]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(184)]
    public HRESULT get_msFlexItemAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[184]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(185)]
    public HRESULT put_msFlexPack([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[185]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(186)]
    public HRESULT get_msFlexPack([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[186]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(187)]
    public HRESULT put_msFlexLinePack([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[187]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(188)]
    public HRESULT get_msFlexLinePack([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[188]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(189)]
    public HRESULT put_msFlexOrder(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[189]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(190)]
    public HRESULT get_msFlexOrder(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[190]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(191)]
    public HRESULT put_msTouchSelect([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[191]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(192)]
    public HRESULT get_msTouchSelect([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[192]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(193)]
    public HRESULT put_transform([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[193]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(194)]
    public HRESULT get_transform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[194]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(195)]
    public HRESULT put_transformOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[195]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(196)]
    public HRESULT get_transformOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[196]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(197)]
    public HRESULT put_transformStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[197]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(198)]
    public HRESULT get_transformStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[198]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(199)]
    public HRESULT put_backfaceVisibility([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[199]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(200)]
    public HRESULT get_backfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[200]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(201)]
    public HRESULT put_perspective(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT, int>)((*lpVtbl)[201]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(202)]
    public HRESULT get_perspective(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, VARIANT*, int>)((*lpVtbl)[202]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(203)]
    public HRESULT put_perspectiveOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[203]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(204)]
    public HRESULT get_perspectiveOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[204]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(205)]
    public HRESULT put_transitionProperty([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[205]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(206)]
    public HRESULT get_transitionProperty([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[206]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(207)]
    public HRESULT put_transitionDuration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[207]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(208)]
    public HRESULT get_transitionDuration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[208]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(209)]
    public HRESULT put_transitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[209]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(210)]
    public HRESULT get_transitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[210]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(211)]
    public HRESULT put_transitionDelay([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[211]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(212)]
    public HRESULT get_transitionDelay([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[212]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(213)]
    public HRESULT put_transition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[213]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(214)]
    public HRESULT get_transition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[214]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(215)]
    public HRESULT put_fontFeatureSettings([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[215]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(216)]
    public HRESULT get_fontFeatureSettings([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[216]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(217)]
    public HRESULT put_animationName([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[217]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(218)]
    public HRESULT get_animationName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[218]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(219)]
    public HRESULT put_animationDuration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[219]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(220)]
    public HRESULT get_animationDuration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[220]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(221)]
    public HRESULT put_animationTimingFunction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[221]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(222)]
    public HRESULT get_animationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[222]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(223)]
    public HRESULT put_animationDelay([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[223]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(224)]
    public HRESULT get_animationDelay([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[224]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(225)]
    public HRESULT put_animationDirection([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[225]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(226)]
    public HRESULT get_animationDirection([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[226]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(227)]
    public HRESULT put_animationPlayState([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[227]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(228)]
    public HRESULT get_animationPlayState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[228]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(229)]
    public HRESULT put_animationIterationCount([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[229]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(230)]
    public HRESULT get_animationIterationCount([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[230]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(231)]
    public HRESULT put_animation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[231]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(232)]
    public HRESULT get_animation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[232]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(233)]
    public HRESULT put_animationFillMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort*, int>)((*lpVtbl)[233]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(234)]
    public HRESULT get_animationFillMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2, ushort**, int>)((*lpVtbl)[234]))(
            this,
            p
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_msScrollChaining([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_msScrollChaining([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_msContentZooming([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_msContentZooming([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_msContentZoomSnapType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_msContentZoomSnapType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_msScrollRails([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_msScrollRails([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_msContentZoomChaining([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_msContentZoomChaining([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_msScrollSnapType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(18)]
        HRESULT get_msScrollSnapType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT put_msContentZoomLimit([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_msContentZoomLimit([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_msContentZoomSnap([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(22)]
        HRESULT get_msContentZoomSnap([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(23)]
        HRESULT put_msContentZoomSnapPoints([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(24)]
        HRESULT get_msContentZoomSnapPoints([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(25)]
        HRESULT put_msContentZoomLimitMin(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_msContentZoomLimitMin(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_msContentZoomLimitMax(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_msContentZoomLimitMax(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_msScrollSnapX([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(30)]
        HRESULT get_msScrollSnapX([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(31)]
        HRESULT put_msScrollSnapY([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(32)]
        HRESULT get_msScrollSnapY([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(33)]
        HRESULT put_msScrollSnapPointsX([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(34)]
        HRESULT get_msScrollSnapPointsX([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(35)]
        HRESULT put_msScrollSnapPointsY([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(36)]
        HRESULT get_msScrollSnapPointsY([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(37)]
        HRESULT put_msGridColumn(VARIANT v);

        [VtblIndex(38)]
        HRESULT get_msGridColumn(VARIANT* p);

        [VtblIndex(39)]
        HRESULT put_msGridColumnAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(40)]
        HRESULT get_msGridColumnAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(41)]
        HRESULT put_msGridColumns([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(42)]
        HRESULT get_msGridColumns([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(43)]
        HRESULT put_msGridColumnSpan(VARIANT v);

        [VtblIndex(44)]
        HRESULT get_msGridColumnSpan(VARIANT* p);

        [VtblIndex(45)]
        HRESULT put_msGridRow(VARIANT v);

        [VtblIndex(46)]
        HRESULT get_msGridRow(VARIANT* p);

        [VtblIndex(47)]
        HRESULT put_msGridRowAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(48)]
        HRESULT get_msGridRowAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(49)]
        HRESULT put_msGridRows([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(50)]
        HRESULT get_msGridRows([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(51)]
        HRESULT put_msGridRowSpan(VARIANT v);

        [VtblIndex(52)]
        HRESULT get_msGridRowSpan(VARIANT* p);

        [VtblIndex(53)]
        HRESULT put_msWrapThrough([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(54)]
        HRESULT get_msWrapThrough([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(55)]
        HRESULT put_msWrapMargin(VARIANT v);

        [VtblIndex(56)]
        HRESULT get_msWrapMargin(VARIANT* p);

        [VtblIndex(57)]
        HRESULT put_msWrapFlow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(58)]
        HRESULT get_msWrapFlow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(59)]
        HRESULT put_msAnimationName([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(60)]
        HRESULT get_msAnimationName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(61)]
        HRESULT put_msAnimationDuration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(62)]
        HRESULT get_msAnimationDuration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(63)]
        HRESULT put_msAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(64)]
        HRESULT get_msAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(65)]
        HRESULT put_msAnimationDelay([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(66)]
        HRESULT get_msAnimationDelay([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(67)]
        HRESULT put_msAnimationDirection([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(68)]
        HRESULT get_msAnimationDirection([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(69)]
        HRESULT put_msAnimationPlayState([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(70)]
        HRESULT get_msAnimationPlayState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(71)]
        HRESULT put_msAnimationIterationCount([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(72)]
        HRESULT get_msAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(73)]
        HRESULT put_msAnimation([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(74)]
        HRESULT get_msAnimation([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(75)]
        HRESULT put_msAnimationFillMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(76)]
        HRESULT get_msAnimationFillMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(77)]
        HRESULT put_colorInterpolationFilters([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(78)]
        HRESULT get_colorInterpolationFilters([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(79)]
        HRESULT put_columnCount(VARIANT v);

        [VtblIndex(80)]
        HRESULT get_columnCount(VARIANT* p);

        [VtblIndex(81)]
        HRESULT put_columnWidth(VARIANT v);

        [VtblIndex(82)]
        HRESULT get_columnWidth(VARIANT* p);

        [VtblIndex(83)]
        HRESULT put_columnGap(VARIANT v);

        [VtblIndex(84)]
        HRESULT get_columnGap(VARIANT* p);

        [VtblIndex(85)]
        HRESULT put_columnFill([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(86)]
        HRESULT get_columnFill([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(87)]
        HRESULT put_columnSpan([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(88)]
        HRESULT get_columnSpan([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(89)]
        HRESULT put_columns([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(90)]
        HRESULT get_columns([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(91)]
        HRESULT put_columnRule([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(92)]
        HRESULT get_columnRule([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(93)]
        HRESULT put_columnRuleColor(VARIANT v);

        [VtblIndex(94)]
        HRESULT get_columnRuleColor(VARIANT* p);

        [VtblIndex(95)]
        HRESULT put_columnRuleStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(96)]
        HRESULT get_columnRuleStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(97)]
        HRESULT put_columnRuleWidth(VARIANT v);

        [VtblIndex(98)]
        HRESULT get_columnRuleWidth(VARIANT* p);

        [VtblIndex(99)]
        HRESULT put_breakBefore([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(100)]
        HRESULT get_breakBefore([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(101)]
        HRESULT put_breakAfter([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(102)]
        HRESULT get_breakAfter([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(103)]
        HRESULT put_breakInside([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(104)]
        HRESULT get_breakInside([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(105)]
        HRESULT put_floodColor(VARIANT v);

        [VtblIndex(106)]
        HRESULT get_floodColor(VARIANT* p);

        [VtblIndex(107)]
        HRESULT put_floodOpacity(VARIANT v);

        [VtblIndex(108)]
        HRESULT get_floodOpacity(VARIANT* p);

        [VtblIndex(109)]
        HRESULT put_lightingColor(VARIANT v);

        [VtblIndex(110)]
        HRESULT get_lightingColor(VARIANT* p);

        [VtblIndex(111)]
        HRESULT put_msScrollLimitXMin(VARIANT v);

        [VtblIndex(112)]
        HRESULT get_msScrollLimitXMin(VARIANT* p);

        [VtblIndex(113)]
        HRESULT put_msScrollLimitYMin(VARIANT v);

        [VtblIndex(114)]
        HRESULT get_msScrollLimitYMin(VARIANT* p);

        [VtblIndex(115)]
        HRESULT put_msScrollLimitXMax(VARIANT v);

        [VtblIndex(116)]
        HRESULT get_msScrollLimitXMax(VARIANT* p);

        [VtblIndex(117)]
        HRESULT put_msScrollLimitYMax(VARIANT v);

        [VtblIndex(118)]
        HRESULT get_msScrollLimitYMax(VARIANT* p);

        [VtblIndex(119)]
        HRESULT put_msScrollLimit([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(120)]
        HRESULT get_msScrollLimit([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(121)]
        HRESULT put_textShadow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(122)]
        HRESULT get_textShadow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(123)]
        HRESULT put_msFlowFrom([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(124)]
        HRESULT get_msFlowFrom([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(125)]
        HRESULT put_msFlowInto([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(126)]
        HRESULT get_msFlowInto([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(127)]
        HRESULT put_msHyphens([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(128)]
        HRESULT get_msHyphens([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(129)]
        HRESULT put_msHyphenateLimitZone(VARIANT v);

        [VtblIndex(130)]
        HRESULT get_msHyphenateLimitZone(VARIANT* p);

        [VtblIndex(131)]
        HRESULT put_msHyphenateLimitChars([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(132)]
        HRESULT get_msHyphenateLimitChars([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(133)]
        HRESULT put_msHyphenateLimitLines(VARIANT v);

        [VtblIndex(134)]
        HRESULT get_msHyphenateLimitLines(VARIANT* p);

        [VtblIndex(135)]
        HRESULT put_msHighContrastAdjust([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(136)]
        HRESULT get_msHighContrastAdjust([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(137)]
        HRESULT put_enableBackground([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(138)]
        HRESULT get_enableBackground([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(139)]
        HRESULT put_msFontFeatureSettings([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(140)]
        HRESULT get_msFontFeatureSettings([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(141)]
        HRESULT put_msUserSelect([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(142)]
        HRESULT get_msUserSelect([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(143)]
        HRESULT put_msOverflowStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(144)]
        HRESULT get_msOverflowStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(145)]
        HRESULT put_msTransformStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(146)]
        HRESULT get_msTransformStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(147)]
        HRESULT put_msBackfaceVisibility([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(148)]
        HRESULT get_msBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(149)]
        HRESULT put_msPerspective(VARIANT v);

        [VtblIndex(150)]
        HRESULT get_msPerspective(VARIANT* p);

        [VtblIndex(151)]
        HRESULT put_msPerspectiveOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(152)]
        HRESULT get_msPerspectiveOrigin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(153)]
        HRESULT put_msTransitionProperty([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(154)]
        HRESULT get_msTransitionProperty([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(155)]
        HRESULT put_msTransitionDuration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(156)]
        HRESULT get_msTransitionDuration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(157)]
        HRESULT put_msTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(158)]
        HRESULT get_msTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(159)]
        HRESULT put_msTransitionDelay([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(160)]
        HRESULT get_msTransitionDelay([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(161)]
        HRESULT put_msTransition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(162)]
        HRESULT get_msTransition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(163)]
        HRESULT put_msTouchAction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(164)]
        HRESULT get_msTouchAction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(165)]
        HRESULT put_msScrollTranslation([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(166)]
        HRESULT get_msScrollTranslation([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(167)]
        HRESULT put_msFlex([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(168)]
        HRESULT get_msFlex([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(169)]
        HRESULT put_msFlexPositive(VARIANT v);

        [VtblIndex(170)]
        HRESULT get_msFlexPositive(VARIANT* p);

        [VtblIndex(171)]
        HRESULT put_msFlexNegative(VARIANT v);

        [VtblIndex(172)]
        HRESULT get_msFlexNegative(VARIANT* p);

        [VtblIndex(173)]
        HRESULT put_msFlexPreferredSize(VARIANT v);

        [VtblIndex(174)]
        HRESULT get_msFlexPreferredSize(VARIANT* p);

        [VtblIndex(175)]
        HRESULT put_msFlexFlow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(176)]
        HRESULT get_msFlexFlow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(177)]
        HRESULT put_msFlexDirection([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(178)]
        HRESULT get_msFlexDirection([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(179)]
        HRESULT put_msFlexWrap([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(180)]
        HRESULT get_msFlexWrap([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(181)]
        HRESULT put_msFlexAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(182)]
        HRESULT get_msFlexAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(183)]
        HRESULT put_msFlexItemAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(184)]
        HRESULT get_msFlexItemAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(185)]
        HRESULT put_msFlexPack([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(186)]
        HRESULT get_msFlexPack([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(187)]
        HRESULT put_msFlexLinePack([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(188)]
        HRESULT get_msFlexLinePack([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(189)]
        HRESULT put_msFlexOrder(VARIANT v);

        [VtblIndex(190)]
        HRESULT get_msFlexOrder(VARIANT* p);

        [VtblIndex(191)]
        HRESULT put_msTouchSelect([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(192)]
        HRESULT get_msTouchSelect([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(193)]
        HRESULT put_transform([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(194)]
        HRESULT get_transform([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(195)]
        HRESULT put_transformOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(196)]
        HRESULT get_transformOrigin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(197)]
        HRESULT put_transformStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(198)]
        HRESULT get_transformStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(199)]
        HRESULT put_backfaceVisibility([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(200)]
        HRESULT get_backfaceVisibility([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(201)]
        HRESULT put_perspective(VARIANT v);

        [VtblIndex(202)]
        HRESULT get_perspective(VARIANT* p);

        [VtblIndex(203)]
        HRESULT put_perspectiveOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(204)]
        HRESULT get_perspectiveOrigin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(205)]
        HRESULT put_transitionProperty([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(206)]
        HRESULT get_transitionProperty([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(207)]
        HRESULT put_transitionDuration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(208)]
        HRESULT get_transitionDuration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(209)]
        HRESULT put_transitionTimingFunction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(210)]
        HRESULT get_transitionTimingFunction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(211)]
        HRESULT put_transitionDelay([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(212)]
        HRESULT get_transitionDelay([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(213)]
        HRESULT put_transition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(214)]
        HRESULT get_transition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(215)]
        HRESULT put_fontFeatureSettings([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(216)]
        HRESULT get_fontFeatureSettings([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(217)]
        HRESULT put_animationName([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(218)]
        HRESULT get_animationName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(219)]
        HRESULT put_animationDuration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(220)]
        HRESULT get_animationDuration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(221)]
        HRESULT put_animationTimingFunction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(222)]
        HRESULT get_animationTimingFunction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(223)]
        HRESULT put_animationDelay([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(224)]
        HRESULT get_animationDelay([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(225)]
        HRESULT put_animationDirection([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(226)]
        HRESULT get_animationDirection([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(227)]
        HRESULT put_animationPlayState([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(228)]
        HRESULT get_animationPlayState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(229)]
        HRESULT put_animationIterationCount([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(230)]
        HRESULT get_animationIterationCount([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(231)]
        HRESULT put_animation([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(232)]
        HRESULT get_animation([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(233)]
        HRESULT put_animationFillMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(234)]
        HRESULT get_animationFillMode([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollChaining;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollChaining;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msContentZooming;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msContentZooming;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msContentZoomSnapType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msContentZoomSnapType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollRails;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollRails;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msContentZoomChaining;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msContentZoomChaining;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollSnapType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollSnapType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msContentZoomLimit;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msContentZoomLimit;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msContentZoomSnap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msContentZoomSnap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msContentZoomSnapPoints;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msContentZoomSnapPoints;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msContentZoomLimitMin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msContentZoomLimitMin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msContentZoomLimitMax;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msContentZoomLimitMax;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollSnapX;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollSnapX;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollSnapY;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollSnapY;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollSnapPointsX;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollSnapPointsX;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollSnapPointsY;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollSnapPointsY;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msGridColumn;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msGridColumn;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msGridColumnAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msGridColumnAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msGridColumns;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msGridColumns;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msGridColumnSpan;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msGridColumnSpan;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msGridRow;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msGridRow;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msGridRowAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msGridRowAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msGridRows;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msGridRows;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msGridRowSpan;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msGridRowSpan;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msWrapThrough;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msWrapThrough;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msWrapMargin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msWrapMargin;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msWrapFlow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msWrapFlow;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationName;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationDuration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationDuration;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationTimingFunction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationTimingFunction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationDelay;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationDelay;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationDirection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationDirection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationPlayState;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationPlayState;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationIterationCount;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationIterationCount;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimation;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimation;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msAnimationFillMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msAnimationFillMode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_colorInterpolationFilters;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_colorInterpolationFilters;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_columnCount;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_columnCount;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_columnWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_columnWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_columnGap;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_columnGap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_columnFill;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_columnFill;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_columnSpan;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_columnSpan;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_columns;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_columns;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_columnRule;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_columnRule;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_columnRuleColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_columnRuleColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_columnRuleStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_columnRuleStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_columnRuleWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_columnRuleWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_breakBefore;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_breakBefore;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_breakAfter;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_breakAfter;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_breakInside;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_breakInside;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_floodColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_floodColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_floodOpacity;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_floodOpacity;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_lightingColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_lightingColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msScrollLimitXMin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msScrollLimitXMin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msScrollLimitYMin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msScrollLimitYMin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msScrollLimitXMax;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msScrollLimitXMax;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msScrollLimitYMax;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msScrollLimitYMax;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollLimit;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollLimit;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textShadow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textShadow;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlowFrom;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlowFrom;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlowInto;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlowInto;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msHyphens;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msHyphens;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msHyphenateLimitZone;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msHyphenateLimitZone;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msHyphenateLimitChars;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msHyphenateLimitChars;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msHyphenateLimitLines;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msHyphenateLimitLines;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msHighContrastAdjust;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msHighContrastAdjust;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_enableBackground;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_enableBackground;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFontFeatureSettings;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFontFeatureSettings;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msUserSelect;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msUserSelect;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msOverflowStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msOverflowStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransformStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransformStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msBackfaceVisibility;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msBackfaceVisibility;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msPerspective;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msPerspective;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msPerspectiveOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msPerspectiveOrigin;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransitionProperty;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransitionProperty;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransitionDuration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransitionDuration;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransitionTimingFunction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransitionTimingFunction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransitionDelay;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransitionDelay;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTouchAction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTouchAction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msScrollTranslation;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msScrollTranslation;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlex;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlex;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msFlexPositive;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msFlexPositive;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msFlexNegative;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msFlexNegative;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msFlexPreferredSize;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msFlexPreferredSize;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexFlow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexFlow;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexDirection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexDirection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexWrap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexWrap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexItemAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexItemAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexPack;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexPack;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msFlexLinePack;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msFlexLinePack;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msFlexOrder;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msFlexOrder;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTouchSelect;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTouchSelect;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transform;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transform;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transformOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transformOrigin;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transformStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transformStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backfaceVisibility;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backfaceVisibility;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_perspective;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_perspective;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_perspectiveOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_perspectiveOrigin;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transitionProperty;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transitionProperty;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transitionDuration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transitionDuration;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transitionTimingFunction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transitionTimingFunction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transitionDelay;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transitionDelay;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_transition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_transition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontFeatureSettings;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontFeatureSettings;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationName;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationDuration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationDuration;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationTimingFunction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationTimingFunction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationDelay;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationDelay;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationDirection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationDirection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationPlayState;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationPlayState;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationIterationCount;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationIterationCount;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animation;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animation;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_animationFillMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_animationFillMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLCSSStyleDeclaration2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLCSSStyleDeclaration2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLCSSStyleDeclaration2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLCSSStyleDeclaration2(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLCSSStyleDeclaration2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLCSSStyleDeclaration2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLCSSStyleDeclaration2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLCSSStyleDeclaration2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLCSSStyleDeclaration2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLCSSStyleDeclaration2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLCSSStyleDeclaration2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLCSSStyleDeclaration2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLCSSStyleDeclaration2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLCSSStyleDeclaration2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
