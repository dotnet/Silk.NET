// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange"]/*'/>
[Guid("305104AE-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMRange : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMRange : IHTMLDOMRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMRange));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, uint> )(lpVtbl[1]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, uint> )(lpVtbl[2]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, uint*, int> )(lpVtbl[3]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.get_startContainer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_startContainer(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int> )(lpVtbl[7]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.get_startOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_startOffset([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, int*, int> )(lpVtbl[8]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.get_endContainer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_endContainer(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int> )(lpVtbl[9]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.get_endOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_endOffset([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, int*, int> )(lpVtbl[10]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.get_collapsed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_collapsed([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, short*, int> )(lpVtbl[11]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.get_commonAncestorContainer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_commonAncestorContainer(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int> )(lpVtbl[12]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.setStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT setStart(IDispatch* refNode, [NativeTypeName("long")] int offset)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int, int> )(lpVtbl[13]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode, offset);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.setEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT setEnd(IDispatch* refNode, [NativeTypeName("long")] int offset)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int, int> )(lpVtbl[14]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode, offset);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.setStartBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT setStartBefore(IDispatch* refNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[15]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.setStartAfter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT setStartAfter(IDispatch* refNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[16]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.setEndBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT setEndBefore(IDispatch* refNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[17]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.setEndAfter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT setEndAfter(IDispatch* refNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[18]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.collapse"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT collapse([NativeTypeName("VARIANT_BOOL")] short toStart)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, short, int> )(lpVtbl[19]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), toStart);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.selectNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT selectNode(IDispatch* refNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[20]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.selectNodeContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT selectNodeContents(IDispatch* refNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[21]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.compareBoundaryPoints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT compareBoundaryPoints(short how, IDispatch* sourceRange, [NativeTypeName("long *")] int* compareResult)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, short, IDispatch*, int*, int> )(lpVtbl[22]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), how, sourceRange, compareResult);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.deleteContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT deleteContents()
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, int> )(lpVtbl[23]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.extractContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT extractContents(IDispatch** ppDocumentFragment)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch**, int> )(lpVtbl[24]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppDocumentFragment);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.cloneContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT cloneContents(IDispatch** ppDocumentFragment)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch**, int> )(lpVtbl[25]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppDocumentFragment);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.insertNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT insertNode(IDispatch* newNode)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[26]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), newNode);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.surroundContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT surroundContents(IDispatch* newParent)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int> )(lpVtbl[27]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), newParent);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.cloneRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT cloneRange(IHTMLDOMRange** ppClonedRange)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMRange**, int> )(lpVtbl[28]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppClonedRange);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** pRangeString)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, ushort**, int> )(lpVtbl[29]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), pRangeString);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.detach"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT detach()
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, int> )(lpVtbl[30]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.getClientRects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT getClientRects(IHTMLRectCollection** ppRectCol)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLRectCollection**, int> )(lpVtbl[31]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppRectCol);
    }

    /// <include file='IHTMLDOMRange.xml' path='doc/member[@name="IHTMLDOMRange.getBoundingClientRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT getBoundingClientRect(IHTMLRect** ppRect)
    {
        return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLRect**, int> )(lpVtbl[32]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppRect);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_startContainer(IHTMLDOMNode** p);
        [VtblIndex(8)]
        HRESULT get_startOffset([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT get_endContainer(IHTMLDOMNode** p);
        [VtblIndex(10)]
        HRESULT get_endOffset([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT get_collapsed([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(12)]
        HRESULT get_commonAncestorContainer(IHTMLDOMNode** p);
        [VtblIndex(13)]
        HRESULT setStart(IDispatch* refNode, [NativeTypeName("long")] int offset);
        [VtblIndex(14)]
        HRESULT setEnd(IDispatch* refNode, [NativeTypeName("long")] int offset);
        [VtblIndex(15)]
        HRESULT setStartBefore(IDispatch* refNode);
        [VtblIndex(16)]
        HRESULT setStartAfter(IDispatch* refNode);
        [VtblIndex(17)]
        HRESULT setEndBefore(IDispatch* refNode);
        [VtblIndex(18)]
        HRESULT setEndAfter(IDispatch* refNode);
        [VtblIndex(19)]
        HRESULT collapse([NativeTypeName("VARIANT_BOOL")] short toStart);
        [VtblIndex(20)]
        HRESULT selectNode(IDispatch* refNode);
        [VtblIndex(21)]
        HRESULT selectNodeContents(IDispatch* refNode);
        [VtblIndex(22)]
        HRESULT compareBoundaryPoints(short how, IDispatch* sourceRange, [NativeTypeName("long *")] int* compareResult);
        [VtblIndex(23)]
        HRESULT deleteContents();
        [VtblIndex(24)]
        HRESULT extractContents(IDispatch** ppDocumentFragment);
        [VtblIndex(25)]
        HRESULT cloneContents(IDispatch** ppDocumentFragment);
        [VtblIndex(26)]
        HRESULT insertNode(IDispatch* newNode);
        [VtblIndex(27)]
        HRESULT surroundContents(IDispatch* newParent);
        [VtblIndex(28)]
        HRESULT cloneRange(IHTMLDOMRange** ppClonedRange);
        [VtblIndex(29)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** pRangeString);
        [VtblIndex(30)]
        HRESULT detach();
        [VtblIndex(31)]
        HRESULT getClientRects(IHTMLRectCollection** ppRectCol);
        [VtblIndex(32)]
        HRESULT getBoundingClientRect(IHTMLRect** ppRect);
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
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_startContainer;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_startOffset;
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_endContainer;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_endOffset;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_collapsed;
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_commonAncestorContainer;
        [NativeTypeName("HRESULT (IDispatch *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int, int> setStart;
        [NativeTypeName("HRESULT (IDispatch *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int, int> setEnd;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> setStartBefore;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> setStartAfter;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> setEndBefore;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> setEndAfter;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> collapse;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> selectNode;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> selectNodeContents;
        [NativeTypeName("HRESULT (short, IDispatch *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IDispatch*, int*, int> compareBoundaryPoints;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteContents;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> extractContents;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> cloneContents;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> insertNode;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> surroundContents;
        [NativeTypeName("HRESULT (IHTMLDOMRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMRange**, int> cloneRange;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> detach;
        [NativeTypeName("HRESULT (IHTMLRectCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLRectCollection**, int> getClientRects;
        [NativeTypeName("HRESULT (IHTMLRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLRect**, int> getBoundingClientRect;
    }
}