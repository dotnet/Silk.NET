// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXMLDOMEntity.xml' path='doc/member[@name="IXMLDOMEntity"]/*'/>
[Guid("2933BF8D-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMEntity : IXMLDOMNode")]
[NativeInheritance("IXMLDOMNode")]
public unsafe partial struct IXMLDOMEntity : IXMLDOMEntity.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMEntity));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, Guid*, void**, int> )(lpVtbl[0]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, uint> )(lpVtbl[1]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, uint> )(lpVtbl[2]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, uint*, int> )(lpVtbl[3]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[7]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* value)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT*, int> )(lpVtbl[8]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_nodeValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_nodeValue(VARIANT value)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT, int> )(lpVtbl[9]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_nodeType(DOMNodeType* type)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, DOMNodeType*, int> )(lpVtbl[10]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), type);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_parentNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_parentNode(IXMLDOMNode** parent)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode**, int> )(lpVtbl[11]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), parent);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_childNodes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_childNodes(IXMLDOMNodeList** childList)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNodeList**, int> )(lpVtbl[12]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), childList);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_firstChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IXMLDOMNode** firstChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode**, int> )(lpVtbl[13]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), firstChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_lastChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IXMLDOMNode** lastChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode**, int> )(lpVtbl[14]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), lastChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_previousSibling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode**, int> )(lpVtbl[15]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), previousSibling);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nextSibling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode**, int> )(lpVtbl[16]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), nextSibling);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_attributes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNamedNodeMap**, int> )(lpVtbl[17]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), attributeMap);
    }

    /// <inheritdoc cref = "IXMLDOMNode.insertBefore"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> )(lpVtbl[18]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.replaceChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[19]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.removeChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[20]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), childNode, oldChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.appendChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[21]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), newChild, outNewChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.hasChildNodes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, short*, int> )(lpVtbl[22]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), hasChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_ownerDocument"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMDocument**, int> )(lpVtbl[23]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), XMLDOMDocument);
    }

    /// <inheritdoc cref = "IXMLDOMNode.cloneNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, short, IXMLDOMNode**, int> )(lpVtbl[24]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), deep, cloneRoot);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeTypeString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[25]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), nodeType);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_text"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[26]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), text);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_text"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort*, int> )(lpVtbl[27]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), text);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_specified"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, short*, int> )(lpVtbl[28]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), isSpecified);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_definition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_definition(IXMLDOMNode** definitionNode)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode**, int> )(lpVtbl[29]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), definitionNode);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeTypedValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_nodeTypedValue(VARIANT* typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT*, int> )(lpVtbl[30]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_nodeTypedValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT, int> )(lpVtbl[31]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_dataType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_dataType(VARIANT* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT*, int> )(lpVtbl[32]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_dataType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort*, int> )(lpVtbl[33]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_xml"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[34]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), xmlString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.transformNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode*, ushort**, int> )(lpVtbl[35]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.selectNodes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort*, IXMLDOMNodeList**, int> )(lpVtbl[36]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), queryString, resultList);
    }

    /// <inheritdoc cref = "IXMLDOMNode.selectSingleNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort*, IXMLDOMNode**, int> )(lpVtbl[37]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), queryString, resultNode);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_parsed"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, short*, int> )(lpVtbl[38]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), isParsed);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_namespaceURI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[39]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), namespaceURI);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_prefix"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[40]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), prefixString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_baseName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[41]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), nameString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.transformNodeToObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, IXMLDOMNode*, VARIANT, int> )(lpVtbl[42]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
    }

    /// <include file='IXMLDOMEntity.xml' path='doc/member[@name="IXMLDOMEntity.get_publicId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_publicId(VARIANT* publicID)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT*, int> )(lpVtbl[43]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), publicID);
    }

    /// <include file='IXMLDOMEntity.xml' path='doc/member[@name="IXMLDOMEntity.get_systemId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_systemId(VARIANT* systemID)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, VARIANT*, int> )(lpVtbl[44]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), systemID);
    }

    /// <include file='IXMLDOMEntity.xml' path='doc/member[@name="IXMLDOMEntity.get_notationName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_notationName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMEntity*, ushort**, int> )(lpVtbl[45]))((IXMLDOMEntity*)Unsafe.AsPointer(ref this), name);
    }

    public interface Interface : IXMLDOMNode.Interface
    {
        [VtblIndex(43)]
        HRESULT get_publicId(VARIANT* publicID);
        [VtblIndex(44)]
        HRESULT get_systemId(VARIANT* systemID);
        [VtblIndex(45)]
        HRESULT get_notationName([NativeTypeName("BSTR *")] ushort** name);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeName;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeValue;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeValue;
        [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DOMNodeType*, int> get_nodeType;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_parentNode;
        [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNodeList**, int> get_childNodes;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_firstChild;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_lastChild;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_previousSibling;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_nextSibling;
        [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;
        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;
        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;
        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;
        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasChildNodes;
        [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;
        [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IXMLDOMNode**, int> cloneNode;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeTypeString;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_specified;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_definition;
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
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, ushort**, int> transformNode;
        [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNodeList**, int> selectNodes;
        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNode**, int> selectSingleNode;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_parsed;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_namespaceURI;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_prefix;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_baseName;
        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_publicId;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_systemId;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_notationName;
    }
}