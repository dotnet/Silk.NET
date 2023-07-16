// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IXMLDOMComment.xml' path='doc/member[@name="IXMLDOMComment"]/*'/>
[Guid("2933BF88-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMComment : IXMLDOMCharacterData")]
[NativeInheritance("IXMLDOMCharacterData")]
public unsafe partial struct IXMLDOMComment : IXMLDOMComment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMComment));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, Guid*, void**, int> )(lpVtbl[0]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMComment*, uint> )(lpVtbl[1]))((IXMLDOMComment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMComment*, uint> )(lpVtbl[2]))((IXMLDOMComment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, uint*, int> )(lpVtbl[3]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[7]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* value)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, VARIANT*, int> )(lpVtbl[8]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_nodeValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_nodeValue(VARIANT value)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, VARIANT, int> )(lpVtbl[9]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_nodeType(DOMNodeType* type)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, DOMNodeType*, int> )(lpVtbl[10]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), type);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_parentNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_parentNode(IXMLDOMNode** parent)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int> )(lpVtbl[11]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), parent);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_childNodes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_childNodes(IXMLDOMNodeList** childList)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNodeList**, int> )(lpVtbl[12]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), childList);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_firstChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IXMLDOMNode** firstChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int> )(lpVtbl[13]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), firstChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_lastChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IXMLDOMNode** lastChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int> )(lpVtbl[14]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), lastChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_previousSibling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int> )(lpVtbl[15]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), previousSibling);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nextSibling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int> )(lpVtbl[16]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), nextSibling);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_attributes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNamedNodeMap**, int> )(lpVtbl[17]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), attributeMap);
    }

    /// <inheritdoc cref = "IXMLDOMNode.insertBefore"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> )(lpVtbl[18]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.replaceChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[19]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.removeChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[20]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), childNode, oldChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.appendChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, IXMLDOMNode**, int> )(lpVtbl[21]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, outNewChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.hasChildNodes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, short*, int> )(lpVtbl[22]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), hasChild);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_ownerDocument"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMDocument**, int> )(lpVtbl[23]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), XMLDOMDocument);
    }

    /// <inheritdoc cref = "IXMLDOMNode.cloneNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, short, IXMLDOMNode**, int> )(lpVtbl[24]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), deep, cloneRoot);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeTypeString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[25]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), nodeType);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_text"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[26]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), text);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_text"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int> )(lpVtbl[27]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), text);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_specified"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, short*, int> )(lpVtbl[28]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), isSpecified);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_definition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_definition(IXMLDOMNode** definitionNode)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int> )(lpVtbl[29]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), definitionNode);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_nodeTypedValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_nodeTypedValue(VARIANT* typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, VARIANT*, int> )(lpVtbl[30]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_nodeTypedValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, VARIANT, int> )(lpVtbl[31]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_dataType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_dataType(VARIANT* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, VARIANT*, int> )(lpVtbl[32]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <inheritdoc cref = "IXMLDOMNode.put_dataType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int> )(lpVtbl[33]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_xml"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[34]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), xmlString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.transformNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, ushort**, int> )(lpVtbl[35]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.selectNodes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort*, IXMLDOMNodeList**, int> )(lpVtbl[36]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), queryString, resultList);
    }

    /// <inheritdoc cref = "IXMLDOMNode.selectSingleNode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort*, IXMLDOMNode**, int> )(lpVtbl[37]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), queryString, resultNode);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_parsed"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, short*, int> )(lpVtbl[38]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), isParsed);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_namespaceURI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[39]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), namespaceURI);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_prefix"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[40]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), prefixString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.get_baseName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[41]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), nameString);
    }

    /// <inheritdoc cref = "IXMLDOMNode.transformNodeToObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, VARIANT, int> )(lpVtbl[42]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.get_data"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_data([NativeTypeName("BSTR *")] ushort** data)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int> )(lpVtbl[43]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.put_data"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_data([NativeTypeName("BSTR")] ushort* data)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int> )(lpVtbl[44]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.get_length"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_length([NativeTypeName("long *")] int* dataLength)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, int*, int> )(lpVtbl[45]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataLength);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.substringData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] ushort** data)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, int, int, ushort**, int> )(lpVtbl[46]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count, data);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.appendData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT appendData([NativeTypeName("BSTR")] ushort* data)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int> )(lpVtbl[47]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.insertData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* data)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, int, ushort*, int> )(lpVtbl[48]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, data);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.deleteData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, int, int, int> )(lpVtbl[49]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count);
    }

    /// <inheritdoc cref = "IXMLDOMCharacterData.replaceData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] ushort* data)
    {
        return ((delegate* unmanaged<IXMLDOMComment*, int, int, ushort*, int> )(lpVtbl[50]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count, data);
    }

    public interface Interface : IXMLDOMCharacterData.Interface
    {
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
}