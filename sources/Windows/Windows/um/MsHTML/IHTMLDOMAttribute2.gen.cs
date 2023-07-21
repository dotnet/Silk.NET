// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2"]/*' />
[Guid("3050F810-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMAttribute2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMAttribute2 : IHTMLDOMAttribute2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMAttribute2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint>)(lpVtbl[1]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint>)(lpVtbl[2]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint*, int>)(lpVtbl[3]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, ushort**, int>)(lpVtbl[7]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.put_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, ushort*, int>)(lpVtbl[8]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, ushort**, int>)(lpVtbl[9]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_expando"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_expando([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, short*, int>)(lpVtbl[10]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_nodeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_nodeType([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, int*, int>)(lpVtbl[11]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_parentNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_parentNode(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[12]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_childNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_childNodes(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IDispatch**, int>)(lpVtbl[13]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_firstChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_firstChild(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[14]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_lastChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_lastChild(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[15]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_previousSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_previousSibling(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[16]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_nextSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_nextSibling(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[17]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_attributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_attributes(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IDispatch**, int>)(lpVtbl[18]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.get_ownerDocument"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ownerDocument(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IDispatch**, int>)(lpVtbl[19]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.insertBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int>)(lpVtbl[20]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), newChild, refChild, node);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.replaceChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[21]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), newChild, oldChild, node);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.removeChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[22]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), oldChild, node);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.appendChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[23]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), newChild, node);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.hasChildNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, short*, int>)(lpVtbl[24]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), fChildren);
    }

    /// <include file='IHTMLDOMAttribute2.xml' path='doc/member[@name="IHTMLDOMAttribute2.cloneNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMAttribute** clonedNode)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute2*, short, IHTMLDOMAttribute**, int>)(lpVtbl[25]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), fDeep, clonedNode);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(9)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_expando([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(11)]
        HRESULT get_nodeType([NativeTypeName("long *")] int* p);

        [VtblIndex(12)]
        HRESULT get_parentNode(IHTMLDOMNode** p);

        [VtblIndex(13)]
        HRESULT get_childNodes(IDispatch** p);

        [VtblIndex(14)]
        HRESULT get_firstChild(IHTMLDOMNode** p);

        [VtblIndex(15)]
        HRESULT get_lastChild(IHTMLDOMNode** p);

        [VtblIndex(16)]
        HRESULT get_previousSibling(IHTMLDOMNode** p);

        [VtblIndex(17)]
        HRESULT get_nextSibling(IHTMLDOMNode** p);

        [VtblIndex(18)]
        HRESULT get_attributes(IDispatch** p);

        [VtblIndex(19)]
        HRESULT get_ownerDocument(IDispatch** p);

        [VtblIndex(20)]
        HRESULT insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node);

        [VtblIndex(21)]
        HRESULT replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node);

        [VtblIndex(22)]
        HRESULT removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node);

        [VtblIndex(23)]
        HRESULT appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node);

        [VtblIndex(24)]
        HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren);

        [VtblIndex(25)]
        HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMAttribute** clonedNode);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_expando;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_nodeType;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_parentNode;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_childNodes;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_firstChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_lastChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_previousSibling;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_nextSibling;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_attributes;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_ownerDocument;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, VARIANT, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int> insertBefore;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int> replaceChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode**, int> removeChild;

        [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, IHTMLDOMNode**, int> appendChild;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasChildNodes;

        [NativeTypeName("HRESULT (VARIANT_BOOL, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IHTMLDOMAttribute**, int> cloneNode;
    }
}
