// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode"]/*' />
[Guid("3050F5DA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMNode : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMNode : IHTMLDOMNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMNode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, uint>)(lpVtbl[1]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, uint>)(lpVtbl[2]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, uint*, int>)(lpVtbl[3]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_nodeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nodeType([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, int*, int>)(lpVtbl[7]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_parentNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_parentNode(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[8]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.hasChildNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, short*, int>)(lpVtbl[9]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), fChildren);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_childNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_childNodes(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IDispatch**, int>)(lpVtbl[10]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_attributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_attributes(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IDispatch**, int>)(lpVtbl[11]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.insertBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int>)(lpVtbl[12]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), newChild, refChild, node);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.removeChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[13]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), oldChild, node);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.replaceChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[14]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), newChild, oldChild, node);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.cloneNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode** clonedNode)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, short, IHTMLDOMNode**, int>)(lpVtbl[15]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), fDeep, clonedNode);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.removeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT removeNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode** removed)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, short, IHTMLDOMNode**, int>)(lpVtbl[16]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), fDeep, removed);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.swapNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT swapNode(IHTMLDOMNode* otherNode, IHTMLDOMNode** swappedNode)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[17]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), otherNode, swappedNode);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.replaceNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT replaceNode(IHTMLDOMNode* replacement, IHTMLDOMNode** replaced)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[18]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), replacement, replaced);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.appendChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[19]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), newChild, node);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_nodeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, ushort**, int>)(lpVtbl[20]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.put_nodeValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_nodeValue(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, VARIANT, int>)(lpVtbl[21]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_nodeValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_nodeValue(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, VARIANT*, int>)(lpVtbl[22]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_firstChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_firstChild(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[23]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_lastChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_lastChild(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[24]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_previousSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_previousSibling(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[25]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMNode.xml' path='doc/member[@name="IHTMLDOMNode.get_nextSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_nextSibling(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[26]))((IHTMLDOMNode*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_nodeType([NativeTypeName("long *")] int* p);

        [VtblIndex(8)]
        HRESULT get_parentNode(IHTMLDOMNode** p);

        [VtblIndex(9)]
        HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren);

        [VtblIndex(10)]
        HRESULT get_childNodes(IDispatch** p);

        [VtblIndex(11)]
        HRESULT get_attributes(IDispatch** p);

        [VtblIndex(12)]
        HRESULT insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node);

        [VtblIndex(13)]
        HRESULT removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node);

        [VtblIndex(14)]
        HRESULT replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node);

        [VtblIndex(15)]
        HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode** clonedNode);

        [VtblIndex(16)]
        HRESULT removeNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode** removed);

        [VtblIndex(17)]
        HRESULT swapNode(IHTMLDOMNode* otherNode, IHTMLDOMNode** swappedNode);

        [VtblIndex(18)]
        HRESULT replaceNode(IHTMLDOMNode* replacement, IHTMLDOMNode** replaced);

        [VtblIndex(19)]
        HRESULT appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node);

        [VtblIndex(20)]
        HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_nodeValue(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_nodeValue(VARIANT* p);

        [VtblIndex(23)]
        HRESULT get_firstChild(IHTMLDOMNode** p);

        [VtblIndex(24)]
        HRESULT get_lastChild(IHTMLDOMNode** p);

        [VtblIndex(25)]
        HRESULT get_previousSibling(IHTMLDOMNode** p);

        [VtblIndex(26)]
        HRESULT get_nextSibling(IHTMLDOMNode** p);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_nodeType;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_parentNode;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasChildNodes;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_childNodes;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_attributes;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, VARIANT, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int> insertBefore;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode**, int> removeChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int> replaceChild;

        [NativeTypeName("HRESULT (VARIANT_BOOL, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IHTMLDOMNode**, int> cloneNode;

        [NativeTypeName("HRESULT (VARIANT_BOOL, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IHTMLDOMNode**, int> removeNode;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode**, int> swapNode;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode**, int> replaceNode;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode**, int> appendChild;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeName;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeValue;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_firstChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_lastChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_previousSibling;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_nextSibling;
    }
}
