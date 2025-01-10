// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051049C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMConstructorCollection : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMConstructorCollection
    : IHTMLDOMConstructorCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMConstructorCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMConstructorCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMConstructorCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructorCollection, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, uint, uint, ITypeInfo*, int>)(
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
                IHTMLDOMConstructorCollection,
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
                IHTMLDOMConstructorCollection,
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
    public HRESULT get_Attr(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[7])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BehaviorUrnsCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[8])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BookmarkCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[9])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CompatibleInfo(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[10])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CompatibleInfoCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[11])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ControlRangeCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[12])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CSSCurrentStyleDeclaration(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[13])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CSSRuleList(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[14])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CSSRuleStyleDeclaration(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[15])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CSSStyleDeclaration(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[16])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CSSStyleRule(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[17])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CSSStyleSheet(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[18])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DataTransfer(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[19])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DOMImplementation(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[20])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Element(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[21])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Event(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[22])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_History(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[23])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_HTCElementBehaviorDefaults(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[24])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_HTMLAnchorElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[25])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_HTMLAreaElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[26])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_HTMLAreasCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[27])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_HTMLBaseElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[28])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_HTMLBaseFontElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[29])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_HTMLBGSoundElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[30])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_HTMLBlockElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[31])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_HTMLBodyElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[32])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_HTMLBRElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[33])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_HTMLButtonElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[34])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_HTMLCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[35])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_HTMLCommentElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[36])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_HTMLDDElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[37])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_HTMLDivElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[38])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_HTMLDocument(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[39])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_HTMLDListElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[40])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_HTMLDTElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[41])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_HTMLEmbedElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[42])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_HTMLFieldSetElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[43])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_HTMLFontElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[44])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_HTMLFormElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[45])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_HTMLFrameElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[46])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_HTMLFrameSetElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[47])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_HTMLGenericElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[48])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_HTMLHeadElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[49])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_HTMLHeadingElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[50])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_HTMLHRElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[51])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_HTMLHtmlElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[52])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_HTMLIFrameElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[53])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_HTMLImageElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[54])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_HTMLInputElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[55])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_HTMLIsIndexElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[56])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_HTMLLabelElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[57])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_HTMLLegendElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[58])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_HTMLLIElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[59])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_HTMLLinkElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[60])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_HTMLMapElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[61])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_HTMLMarqueeElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[62])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_HTMLMetaElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[63])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_HTMLModelessDialog(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[64])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_HTMLNamespaceInfo(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[65])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_HTMLNamespaceInfoCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[66])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_HTMLNextIdElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[67])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_HTMLNoShowElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[68])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_HTMLObjectElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[69])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_HTMLOListElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[70])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_HTMLOptionElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[71])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_HTMLParagraphElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[72])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_HTMLParamElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[73])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_HTMLPhraseElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[74])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_HTMLPluginsCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[75])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_HTMLPopup(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[76])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_HTMLScriptElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[77])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_HTMLSelectElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[78])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_HTMLSpanElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[79])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_HTMLStyleElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[80])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_HTMLTableCaptionElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[81])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_HTMLTableCellElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[82])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_HTMLTableColElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[83])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_HTMLTableElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[84])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_HTMLTableRowElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[85])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_HTMLTableSectionElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[86])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_HTMLTextAreaElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[87])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_HTMLTextElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[88])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_HTMLTitleElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[89])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_HTMLUListElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[90])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_HTMLUnknownElement(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[91])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_Image(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[92])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_Location(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[93])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_NamedNodeMap(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[94])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_Navigator(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[95])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_NodeList(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[96])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_Option(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[97])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_Screen(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[98])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_Selection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[99])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_StaticNodeList(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[100])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_Storage(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[101])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_StyleSheetList(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[102])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_StyleSheetPage(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[103])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_StyleSheetPageList(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[104])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_Text(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[105])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_TextRange(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[106])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_TextRangeCollection(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[107])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_TextRectangle(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[108])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_TextRectangleList(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[109])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_Window(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[110])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_XDomainRequest(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[111])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_XMLHttpRequest(IDispatch* p)
    {
        return (
            (delegate* unmanaged<IHTMLDOMConstructorCollection, IDispatch*, int>)((*lpVtbl)[112])
        )(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Attr(IDispatch* p);

        [VtblIndex(8)]
        HRESULT get_BehaviorUrnsCollection(IDispatch* p);

        [VtblIndex(9)]
        HRESULT get_BookmarkCollection(IDispatch* p);

        [VtblIndex(10)]
        HRESULT get_CompatibleInfo(IDispatch* p);

        [VtblIndex(11)]
        HRESULT get_CompatibleInfoCollection(IDispatch* p);

        [VtblIndex(12)]
        HRESULT get_ControlRangeCollection(IDispatch* p);

        [VtblIndex(13)]
        HRESULT get_CSSCurrentStyleDeclaration(IDispatch* p);

        [VtblIndex(14)]
        HRESULT get_CSSRuleList(IDispatch* p);

        [VtblIndex(15)]
        HRESULT get_CSSRuleStyleDeclaration(IDispatch* p);

        [VtblIndex(16)]
        HRESULT get_CSSStyleDeclaration(IDispatch* p);

        [VtblIndex(17)]
        HRESULT get_CSSStyleRule(IDispatch* p);

        [VtblIndex(18)]
        HRESULT get_CSSStyleSheet(IDispatch* p);

        [VtblIndex(19)]
        HRESULT get_DataTransfer(IDispatch* p);

        [VtblIndex(20)]
        HRESULT get_DOMImplementation(IDispatch* p);

        [VtblIndex(21)]
        HRESULT get_Element(IDispatch* p);

        [VtblIndex(22)]
        HRESULT get_Event(IDispatch* p);

        [VtblIndex(23)]
        HRESULT get_History(IDispatch* p);

        [VtblIndex(24)]
        HRESULT get_HTCElementBehaviorDefaults(IDispatch* p);

        [VtblIndex(25)]
        HRESULT get_HTMLAnchorElement(IDispatch* p);

        [VtblIndex(26)]
        HRESULT get_HTMLAreaElement(IDispatch* p);

        [VtblIndex(27)]
        HRESULT get_HTMLAreasCollection(IDispatch* p);

        [VtblIndex(28)]
        HRESULT get_HTMLBaseElement(IDispatch* p);

        [VtblIndex(29)]
        HRESULT get_HTMLBaseFontElement(IDispatch* p);

        [VtblIndex(30)]
        HRESULT get_HTMLBGSoundElement(IDispatch* p);

        [VtblIndex(31)]
        HRESULT get_HTMLBlockElement(IDispatch* p);

        [VtblIndex(32)]
        HRESULT get_HTMLBodyElement(IDispatch* p);

        [VtblIndex(33)]
        HRESULT get_HTMLBRElement(IDispatch* p);

        [VtblIndex(34)]
        HRESULT get_HTMLButtonElement(IDispatch* p);

        [VtblIndex(35)]
        HRESULT get_HTMLCollection(IDispatch* p);

        [VtblIndex(36)]
        HRESULT get_HTMLCommentElement(IDispatch* p);

        [VtblIndex(37)]
        HRESULT get_HTMLDDElement(IDispatch* p);

        [VtblIndex(38)]
        HRESULT get_HTMLDivElement(IDispatch* p);

        [VtblIndex(39)]
        HRESULT get_HTMLDocument(IDispatch* p);

        [VtblIndex(40)]
        HRESULT get_HTMLDListElement(IDispatch* p);

        [VtblIndex(41)]
        HRESULT get_HTMLDTElement(IDispatch* p);

        [VtblIndex(42)]
        HRESULT get_HTMLEmbedElement(IDispatch* p);

        [VtblIndex(43)]
        HRESULT get_HTMLFieldSetElement(IDispatch* p);

        [VtblIndex(44)]
        HRESULT get_HTMLFontElement(IDispatch* p);

        [VtblIndex(45)]
        HRESULT get_HTMLFormElement(IDispatch* p);

        [VtblIndex(46)]
        HRESULT get_HTMLFrameElement(IDispatch* p);

        [VtblIndex(47)]
        HRESULT get_HTMLFrameSetElement(IDispatch* p);

        [VtblIndex(48)]
        HRESULT get_HTMLGenericElement(IDispatch* p);

        [VtblIndex(49)]
        HRESULT get_HTMLHeadElement(IDispatch* p);

        [VtblIndex(50)]
        HRESULT get_HTMLHeadingElement(IDispatch* p);

        [VtblIndex(51)]
        HRESULT get_HTMLHRElement(IDispatch* p);

        [VtblIndex(52)]
        HRESULT get_HTMLHtmlElement(IDispatch* p);

        [VtblIndex(53)]
        HRESULT get_HTMLIFrameElement(IDispatch* p);

        [VtblIndex(54)]
        HRESULT get_HTMLImageElement(IDispatch* p);

        [VtblIndex(55)]
        HRESULT get_HTMLInputElement(IDispatch* p);

        [VtblIndex(56)]
        HRESULT get_HTMLIsIndexElement(IDispatch* p);

        [VtblIndex(57)]
        HRESULT get_HTMLLabelElement(IDispatch* p);

        [VtblIndex(58)]
        HRESULT get_HTMLLegendElement(IDispatch* p);

        [VtblIndex(59)]
        HRESULT get_HTMLLIElement(IDispatch* p);

        [VtblIndex(60)]
        HRESULT get_HTMLLinkElement(IDispatch* p);

        [VtblIndex(61)]
        HRESULT get_HTMLMapElement(IDispatch* p);

        [VtblIndex(62)]
        HRESULT get_HTMLMarqueeElement(IDispatch* p);

        [VtblIndex(63)]
        HRESULT get_HTMLMetaElement(IDispatch* p);

        [VtblIndex(64)]
        HRESULT get_HTMLModelessDialog(IDispatch* p);

        [VtblIndex(65)]
        HRESULT get_HTMLNamespaceInfo(IDispatch* p);

        [VtblIndex(66)]
        HRESULT get_HTMLNamespaceInfoCollection(IDispatch* p);

        [VtblIndex(67)]
        HRESULT get_HTMLNextIdElement(IDispatch* p);

        [VtblIndex(68)]
        HRESULT get_HTMLNoShowElement(IDispatch* p);

        [VtblIndex(69)]
        HRESULT get_HTMLObjectElement(IDispatch* p);

        [VtblIndex(70)]
        HRESULT get_HTMLOListElement(IDispatch* p);

        [VtblIndex(71)]
        HRESULT get_HTMLOptionElement(IDispatch* p);

        [VtblIndex(72)]
        HRESULT get_HTMLParagraphElement(IDispatch* p);

        [VtblIndex(73)]
        HRESULT get_HTMLParamElement(IDispatch* p);

        [VtblIndex(74)]
        HRESULT get_HTMLPhraseElement(IDispatch* p);

        [VtblIndex(75)]
        HRESULT get_HTMLPluginsCollection(IDispatch* p);

        [VtblIndex(76)]
        HRESULT get_HTMLPopup(IDispatch* p);

        [VtblIndex(77)]
        HRESULT get_HTMLScriptElement(IDispatch* p);

        [VtblIndex(78)]
        HRESULT get_HTMLSelectElement(IDispatch* p);

        [VtblIndex(79)]
        HRESULT get_HTMLSpanElement(IDispatch* p);

        [VtblIndex(80)]
        HRESULT get_HTMLStyleElement(IDispatch* p);

        [VtblIndex(81)]
        HRESULT get_HTMLTableCaptionElement(IDispatch* p);

        [VtblIndex(82)]
        HRESULT get_HTMLTableCellElement(IDispatch* p);

        [VtblIndex(83)]
        HRESULT get_HTMLTableColElement(IDispatch* p);

        [VtblIndex(84)]
        HRESULT get_HTMLTableElement(IDispatch* p);

        [VtblIndex(85)]
        HRESULT get_HTMLTableRowElement(IDispatch* p);

        [VtblIndex(86)]
        HRESULT get_HTMLTableSectionElement(IDispatch* p);

        [VtblIndex(87)]
        HRESULT get_HTMLTextAreaElement(IDispatch* p);

        [VtblIndex(88)]
        HRESULT get_HTMLTextElement(IDispatch* p);

        [VtblIndex(89)]
        HRESULT get_HTMLTitleElement(IDispatch* p);

        [VtblIndex(90)]
        HRESULT get_HTMLUListElement(IDispatch* p);

        [VtblIndex(91)]
        HRESULT get_HTMLUnknownElement(IDispatch* p);

        [VtblIndex(92)]
        HRESULT get_Image(IDispatch* p);

        [VtblIndex(93)]
        HRESULT get_Location(IDispatch* p);

        [VtblIndex(94)]
        HRESULT get_NamedNodeMap(IDispatch* p);

        [VtblIndex(95)]
        HRESULT get_Navigator(IDispatch* p);

        [VtblIndex(96)]
        HRESULT get_NodeList(IDispatch* p);

        [VtblIndex(97)]
        HRESULT get_Option(IDispatch* p);

        [VtblIndex(98)]
        HRESULT get_Screen(IDispatch* p);

        [VtblIndex(99)]
        HRESULT get_Selection(IDispatch* p);

        [VtblIndex(100)]
        HRESULT get_StaticNodeList(IDispatch* p);

        [VtblIndex(101)]
        HRESULT get_Storage(IDispatch* p);

        [VtblIndex(102)]
        HRESULT get_StyleSheetList(IDispatch* p);

        [VtblIndex(103)]
        HRESULT get_StyleSheetPage(IDispatch* p);

        [VtblIndex(104)]
        HRESULT get_StyleSheetPageList(IDispatch* p);

        [VtblIndex(105)]
        HRESULT get_Text(IDispatch* p);

        [VtblIndex(106)]
        HRESULT get_TextRange(IDispatch* p);

        [VtblIndex(107)]
        HRESULT get_TextRangeCollection(IDispatch* p);

        [VtblIndex(108)]
        HRESULT get_TextRectangle(IDispatch* p);

        [VtblIndex(109)]
        HRESULT get_TextRectangleList(IDispatch* p);

        [VtblIndex(110)]
        HRESULT get_Window(IDispatch* p);

        [VtblIndex(111)]
        HRESULT get_XDomainRequest(IDispatch* p);

        [VtblIndex(112)]
        HRESULT get_XMLHttpRequest(IDispatch* p);
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
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Attr;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_BehaviorUrnsCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_BookmarkCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CompatibleInfo;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CompatibleInfoCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_ControlRangeCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CSSCurrentStyleDeclaration;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CSSRuleList;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CSSRuleStyleDeclaration;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CSSStyleDeclaration;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CSSStyleRule;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_CSSStyleSheet;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_DataTransfer;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_DOMImplementation;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Element;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Event;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_History;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTCElementBehaviorDefaults;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLAnchorElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLAreaElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLAreasCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLBaseElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLBaseFontElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLBGSoundElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLBlockElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLBodyElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLBRElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLButtonElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLCommentElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLDDElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLDivElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLDocument;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLDListElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLDTElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLEmbedElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLFieldSetElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLFontElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLFormElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLFrameElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLFrameSetElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLGenericElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLHeadElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLHeadingElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLHRElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLHtmlElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLIFrameElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLImageElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLInputElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLIsIndexElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLLabelElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLLegendElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLLIElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLLinkElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLMapElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLMarqueeElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLMetaElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLModelessDialog;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLNamespaceInfo;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLNamespaceInfoCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLNextIdElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLNoShowElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLObjectElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLOListElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLOptionElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLParagraphElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLParamElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLPhraseElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLPluginsCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLPopup;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLScriptElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLSelectElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLSpanElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLStyleElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTableCaptionElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTableCellElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTableColElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTableElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTableRowElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTableSectionElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTextAreaElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTextElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLTitleElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLUListElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_HTMLUnknownElement;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Image;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Location;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_NamedNodeMap;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Navigator;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_NodeList;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Option;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Screen;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Selection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_StaticNodeList;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Storage;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_StyleSheetList;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_StyleSheetPage;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_StyleSheetPageList;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Text;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_TextRange;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_TextRangeCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_TextRectangle;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_TextRectangleList;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Window;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_XDomainRequest;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_XMLHttpRequest;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLDOMConstructorCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLDOMConstructorCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLDOMConstructorCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLDOMConstructorCollection(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLDOMConstructorCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDOMConstructorCollection"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDOMConstructorCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLDOMConstructorCollection value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLDOMConstructorCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLDOMConstructorCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLDOMConstructorCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDOMConstructorCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDOMConstructorCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLDOMConstructorCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
