// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2933BF84-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMCharacterData : IXMLDOMNode")]
[NativeInheritance("IXMLDOMNode")]
public unsafe partial struct IXMLDOMCharacterData : IXMLDOMCharacterData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMCharacterData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXMLDOMCharacterData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<IXMLDOMCharacterData, Guid*, ushort**, uint, uint, int*, int>)(
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
                IXMLDOMCharacterData,
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
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[7]))(
            this,
            name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* value)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, VARIANT*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_nodeValue(VARIANT value)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, VARIANT, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_nodeType(DOMNodeType* type)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, DOMNodeType*, int>)((*lpVtbl)[10]))(
            this,
            type
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_parentNode(IXMLDOMNode* parent)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode*, int>)((*lpVtbl)[11]))(
            this,
            parent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_childNodes(IXMLDOMNodeList* childList)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNodeList*, int>)((*lpVtbl)[12]))(
            this,
            childList
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IXMLDOMNode* firstChild)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode*, int>)((*lpVtbl)[13]))(
            this,
            firstChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IXMLDOMNode* lastChild)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode*, int>)((*lpVtbl)[14]))(
            this,
            lastChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_previousSibling(IXMLDOMNode* previousSibling)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode*, int>)((*lpVtbl)[15]))(
            this,
            previousSibling
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_nextSibling(IXMLDOMNode* nextSibling)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode*, int>)((*lpVtbl)[16]))(
            this,
            nextSibling
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_attributes(IXMLDOMNamedNodeMap* attributeMap)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNamedNodeMap*, int>)((*lpVtbl)[17])
        )(this, attributeMap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT insertBefore(IXMLDOMNode newChild, VARIANT refChild, IXMLDOMNode* outNewChild)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode, VARIANT, IXMLDOMNode*, int>)(
                (*lpVtbl)[18]
            )
        )(this, newChild, refChild, outNewChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT replaceChild(
        IXMLDOMNode newChild,
        IXMLDOMNode oldChild,
        IXMLDOMNode* outOldChild
    )
    {
        return (
            (delegate* unmanaged<
                IXMLDOMCharacterData,
                IXMLDOMNode,
                IXMLDOMNode,
                IXMLDOMNode*,
                int>)((*lpVtbl)[19])
        )(this, newChild, oldChild, outOldChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeChild(IXMLDOMNode childNode, IXMLDOMNode* oldChild)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode, IXMLDOMNode*, int>)(
                (*lpVtbl)[20]
            )
        )(this, childNode, oldChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT appendChild(IXMLDOMNode newChild, IXMLDOMNode* outNewChild)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode, IXMLDOMNode*, int>)(
                (*lpVtbl)[21]
            )
        )(this, newChild, outNewChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, short*, int>)((*lpVtbl)[22]))(
            this,
            hasChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ownerDocument(IXMLDOMDocument* XMLDOMDocument)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMDocument*, int>)((*lpVtbl)[23]))(
            this,
            XMLDOMDocument
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode* cloneRoot)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, short, IXMLDOMNode*, int>)((*lpVtbl)[24])
        )(this, deep, cloneRoot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[25]))(
            this,
            nodeType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[26]))(
            this,
            text
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort*, int>)((*lpVtbl)[27]))(
            this,
            text
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, short*, int>)((*lpVtbl)[28]))(
            this,
            isSpecified
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_definition(IXMLDOMNode* definitionNode)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode*, int>)((*lpVtbl)[29]))(
            this,
            definitionNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_nodeTypedValue(VARIANT* typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, VARIANT*, int>)((*lpVtbl)[30]))(
            this,
            typedValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, VARIANT, int>)((*lpVtbl)[31]))(
            this,
            typedValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_dataType(VARIANT* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, VARIANT*, int>)((*lpVtbl)[32]))(
            this,
            dataTypeName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort*, int>)((*lpVtbl)[33]))(
            this,
            dataTypeName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[34]))(
            this,
            xmlString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT transformNode(
        IXMLDOMNode stylesheet,
        [NativeTypeName("BSTR *")] ushort** xmlString
    )
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode, ushort**, int>)((*lpVtbl)[35])
        )(this, stylesheet, xmlString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT selectNodes(
        [NativeTypeName("BSTR")] ushort* queryString,
        IXMLDOMNodeList* resultList
    )
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, ushort*, IXMLDOMNodeList*, int>)(
                (*lpVtbl)[36]
            )
        )(this, queryString, resultList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT selectSingleNode(
        [NativeTypeName("BSTR")] ushort* queryString,
        IXMLDOMNode* resultNode
    )
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, ushort*, IXMLDOMNode*, int>)((*lpVtbl)[37])
        )(this, queryString, resultNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, short*, int>)((*lpVtbl)[38]))(
            this,
            isParsed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[39]))(
            this,
            namespaceURI
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[40]))(
            this,
            prefixString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[41]))(
            this,
            nameString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT transformNodeToObject(IXMLDOMNode stylesheet, VARIANT outputObject)
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, IXMLDOMNode, VARIANT, int>)((*lpVtbl)[42])
        )(this, stylesheet, outputObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_data([NativeTypeName("BSTR *")] ushort** data)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort**, int>)((*lpVtbl)[43]))(
            this,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_data([NativeTypeName("BSTR")] ushort* data)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort*, int>)((*lpVtbl)[44]))(
            this,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_length([NativeTypeName("long *")] int* dataLength)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, int*, int>)((*lpVtbl)[45]))(
            this,
            dataLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT substringData(
        [NativeTypeName("long")] int offset,
        [NativeTypeName("long")] int count,
        [NativeTypeName("BSTR *")] ushort** data
    )
    {
        return (
            (delegate* unmanaged<IXMLDOMCharacterData, int, int, ushort**, int>)((*lpVtbl)[46])
        )(this, offset, count, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT appendData([NativeTypeName("BSTR")] ushort* data)
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, ushort*, int>)((*lpVtbl)[47]))(
            this,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT insertData(
        [NativeTypeName("long")] int offset,
        [NativeTypeName("BSTR")] ushort* data
    )
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, int, ushort*, int>)((*lpVtbl)[48]))(
            this,
            offset,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT deleteData(
        [NativeTypeName("long")] int offset,
        [NativeTypeName("long")] int count
    )
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, int, int, int>)((*lpVtbl)[49]))(
            this,
            offset,
            count
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT replaceData(
        [NativeTypeName("long")] int offset,
        [NativeTypeName("long")] int count,
        [NativeTypeName("BSTR")] ushort* data
    )
    {
        return ((delegate* unmanaged<IXMLDOMCharacterData, int, int, ushort*, int>)((*lpVtbl)[50]))(
            this,
            offset,
            count,
            data
        );
    }

    public interface Interface : IXMLDOMNode.Interface
    {
        [VtblIndex(43)]
        HRESULT get_data([NativeTypeName("BSTR *")] ushort** data);

        [VtblIndex(44)]
        HRESULT put_data([NativeTypeName("BSTR")] ushort* data);

        [VtblIndex(45)]
        HRESULT get_length([NativeTypeName("long *")] int* dataLength);

        [VtblIndex(46)]
        HRESULT substringData(
            [NativeTypeName("long")] int offset,
            [NativeTypeName("long")] int count,
            [NativeTypeName("BSTR *")] ushort** data
        );

        [VtblIndex(47)]
        HRESULT appendData([NativeTypeName("BSTR")] ushort* data);

        [VtblIndex(48)]
        HRESULT insertData(
            [NativeTypeName("long")] int offset,
            [NativeTypeName("BSTR")] ushort* data
        );

        [VtblIndex(49)]
        HRESULT deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count);

        [VtblIndex(50)]
        HRESULT replaceData(
            [NativeTypeName("long")] int offset,
            [NativeTypeName("long")] int count,
            [NativeTypeName("BSTR")] ushort* data
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeName;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeValue;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeValue;

        [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DOMNodeType*, int> get_nodeType;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> get_parentNode;

        [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNodeList*, int> get_childNodes;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> get_firstChild;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> get_lastChild;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> get_previousSibling;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> get_nextSibling;

        [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNamedNodeMap*, int> get_attributes;

        [NativeTypeName(
            "HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXMLDOMNode, VARIANT, IXMLDOMNode*, int> insertBefore;

        [NativeTypeName(
            "HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IXMLDOMNode,
            IXMLDOMNode,
            IXMLDOMNode*,
            int> replaceChild;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode, IXMLDOMNode*, int> removeChild;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode, IXMLDOMNode*, int> appendChild;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasChildNodes;

        [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocument*, int> get_ownerDocument;

        [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IXMLDOMNode*, int> cloneNode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeTypeString;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_specified;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> get_definition;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeTypedValue;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeTypedValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dataType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dataType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_xml;

        [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode, ushort**, int> transformNode;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNodeList*, int> selectNodes;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNode*, int> selectSingleNode;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_parsed;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_namespaceURI;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_prefix;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_baseName;

        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode, VARIANT, int> transformNodeToObject;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_data;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_data;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort**, int> substringData;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> appendData;

        [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort*, int> insertData;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> deleteData;

        [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort*, int> replaceData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXMLDOMCharacterData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXMLDOMCharacterData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IXMLDOMNode"/> to <see cref = "IXMLDOMCharacterData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IXMLDOMNode"/> instance to be converted </param>
    public static explicit operator IXMLDOMCharacterData(Silk.NET.Windows.IXMLDOMNode value)
    {
        return new IXMLDOMCharacterData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLDOMCharacterData"/> to <see cref = "Silk.NET.Windows.IXMLDOMNode"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLDOMCharacterData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IXMLDOMNode(IXMLDOMCharacterData value)
    {
        return new Silk.NET.Windows.IXMLDOMNode(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IXMLDOMCharacterData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IXMLDOMCharacterData(Silk.NET.Windows.IDispatch value)
    {
        return new IXMLDOMCharacterData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLDOMCharacterData"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLDOMCharacterData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IXMLDOMCharacterData value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXMLDOMCharacterData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXMLDOMCharacterData(Silk.NET.Windows.IUnknown value)
    {
        return new IXMLDOMCharacterData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLDOMCharacterData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLDOMCharacterData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXMLDOMCharacterData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
