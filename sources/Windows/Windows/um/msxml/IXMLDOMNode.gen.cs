// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode"]/*'/>
[Guid("2933BF80-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMNode : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLDOMNode : IXMLDOMNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNode));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, Guid*, void**, int> )(lpVtbl[0]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMNode*, uint> )(lpVtbl[1]))((IXMLDOMNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMNode*, uint> )(lpVtbl[2]))((IXMLDOMNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, uint*, int> )(lpVtbl[3]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_nodeName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[7]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_nodeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* value)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, VARIANT*, int> )(lpVtbl[8]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.put_nodeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_nodeValue(VARIANT value)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, VARIANT, int> )(lpVtbl[9]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_nodeType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_nodeType(DOMNodeType* type)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, DOMNodeType*, int> )(lpVtbl[10]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), type);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_parentNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_parentNode(IXMLDOMNode** parent)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[11]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), parent);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_childNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_childNodes(IXMLDOMNodeList** childList)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNodeList**, int> )(lpVtbl[12]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), childList);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_firstChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IXMLDOMNode** firstChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[13]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), firstChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_lastChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IXMLDOMNode** lastChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[14]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), lastChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_previousSibling"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[15]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), previousSibling);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_nextSibling"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[16]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), nextSibling);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_attributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNamedNodeMap**, int> )(lpVtbl[17]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), attributeMap);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.insertBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> )(lpVtbl[18]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.replaceChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[19]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.removeChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[20]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), childNode, oldChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.appendChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[21]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, outNewChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.hasChildNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, short*, int> )(lpVtbl[22]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), hasChild);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_ownerDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMDocument**, int> )(lpVtbl[23]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), XMLDOMDocument);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.cloneNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, short, IXMLDOMNode**, int> )(lpVtbl[24]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), deep, cloneRoot);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_nodeTypeString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[25]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), nodeType);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_text"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[26]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.put_text"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort*, int> )(lpVtbl[27]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_specified"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, short*, int> )(lpVtbl[28]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), isSpecified);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_definition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_definition(IXMLDOMNode** definitionNode)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[29]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), definitionNode);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_nodeTypedValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_nodeTypedValue(VARIANT* typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, VARIANT*, int> )(lpVtbl[30]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.put_nodeTypedValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, VARIANT, int> )(lpVtbl[31]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_dataType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_dataType(VARIANT* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, VARIANT*, int> )(lpVtbl[32]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.put_dataType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort*, int> )(lpVtbl[33]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_xml"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[34]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), xmlString);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.transformNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, ushort**, int> )(lpVtbl[35]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.selectNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort*, IXMLDOMNodeList**, int> )(lpVtbl[36]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultList);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.selectSingleNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort*, IXMLDOMNode**, int> )(lpVtbl[37]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultNode);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_parsed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, short*, int> )(lpVtbl[38]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), isParsed);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_namespaceURI"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[39]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), namespaceURI);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_prefix"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[40]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), prefixString);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.get_baseName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int> )(lpVtbl[41]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), nameString);
    }

    /// <include file='IXMLDOMNode.xml' path='doc/member[@name="IXMLDOMNode.transformNodeToObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
    {
        return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, VARIANT, int> )(lpVtbl[42]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name);
        [VtblIndex(8)]
        HRESULT get_nodeValue(VARIANT* value);
        [VtblIndex(9)]
        HRESULT put_nodeValue(VARIANT value);
        [VtblIndex(10)]
        HRESULT get_nodeType(DOMNodeType* type);
        [VtblIndex(11)]
        HRESULT get_parentNode(IXMLDOMNode** parent);
        [VtblIndex(12)]
        HRESULT get_childNodes(IXMLDOMNodeList** childList);
        [VtblIndex(13)]
        HRESULT get_firstChild(IXMLDOMNode** firstChild);
        [VtblIndex(14)]
        HRESULT get_lastChild(IXMLDOMNode** lastChild);
        [VtblIndex(15)]
        HRESULT get_previousSibling(IXMLDOMNode** previousSibling);
        [VtblIndex(16)]
        HRESULT get_nextSibling(IXMLDOMNode** nextSibling);
        [VtblIndex(17)]
        HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap);
        [VtblIndex(18)]
        HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild);
        [VtblIndex(19)]
        HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild);
        [VtblIndex(20)]
        HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild);
        [VtblIndex(21)]
        HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild);
        [VtblIndex(22)]
        HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild);
        [VtblIndex(23)]
        HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument);
        [VtblIndex(24)]
        HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot);
        [VtblIndex(25)]
        HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType);
        [VtblIndex(26)]
        HRESULT get_text([NativeTypeName("BSTR *")] ushort** text);
        [VtblIndex(27)]
        HRESULT put_text([NativeTypeName("BSTR")] ushort* text);
        [VtblIndex(28)]
        HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified);
        [VtblIndex(29)]
        HRESULT get_definition(IXMLDOMNode** definitionNode);
        [VtblIndex(30)]
        HRESULT get_nodeTypedValue(VARIANT* typedValue);
        [VtblIndex(31)]
        HRESULT put_nodeTypedValue(VARIANT typedValue);
        [VtblIndex(32)]
        HRESULT get_dataType(VARIANT* dataTypeName);
        [VtblIndex(33)]
        HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName);
        [VtblIndex(34)]
        HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString);
        [VtblIndex(35)]
        HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString);
        [VtblIndex(36)]
        HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList);
        [VtblIndex(37)]
        HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode);
        [VtblIndex(38)]
        HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed);
        [VtblIndex(39)]
        HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI);
        [VtblIndex(40)]
        HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString);
        [VtblIndex(41)]
        HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString);
        [VtblIndex(42)]
        HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject);
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
    }
}