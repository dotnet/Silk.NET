// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker"]/*' />
[Guid("30510748-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMTreeWalker : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMTreeWalker : IDOMTreeWalker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMTreeWalker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, Guid*, void**, int>)(lpVtbl[0]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, uint>)(lpVtbl[1]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, uint>)(lpVtbl[2]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, uint*, int>)(lpVtbl[3]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.get_root"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_root(IDispatch** p)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[7]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.get_whatToShow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_whatToShow([NativeTypeName("ULONG *")] uint* p)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, uint*, int>)(lpVtbl[8]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.get_filter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_filter(IDispatch** p)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[9]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.get_expandEntityReferences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_expandEntityReferences([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, short*, int>)(lpVtbl[10]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.putref_currentNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_currentNode(IDispatch* v)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch*, int>)(lpVtbl[11]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.get_currentNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_currentNode(IDispatch** p)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[12]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.parentNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT parentNode(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[13]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.firstChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT firstChild(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[14]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.lastChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT lastChild(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[15]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.previousSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT previousSibling(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[16]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.nextSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT nextSibling(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[17]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.previousNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT previousNode(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[18]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    /// <include file='IDOMTreeWalker.xml' path='doc/member[@name="IDOMTreeWalker.nextNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT nextNode(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[19]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_root(IDispatch** p);

        [VtblIndex(8)]
        HRESULT get_whatToShow([NativeTypeName("ULONG *")] uint* p);

        [VtblIndex(9)]
        HRESULT get_filter(IDispatch** p);

        [VtblIndex(10)]
        HRESULT get_expandEntityReferences([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(11)]
        HRESULT putref_currentNode(IDispatch* v);

        [VtblIndex(12)]
        HRESULT get_currentNode(IDispatch** p);

        [VtblIndex(13)]
        HRESULT parentNode(IDispatch** ppRetNode);

        [VtblIndex(14)]
        HRESULT firstChild(IDispatch** ppRetNode);

        [VtblIndex(15)]
        HRESULT lastChild(IDispatch** ppRetNode);

        [VtblIndex(16)]
        HRESULT previousSibling(IDispatch** ppRetNode);

        [VtblIndex(17)]
        HRESULT nextSibling(IDispatch** ppRetNode);

        [VtblIndex(18)]
        HRESULT previousNode(IDispatch** ppRetNode);

        [VtblIndex(19)]
        HRESULT nextNode(IDispatch** ppRetNode);
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_root;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_whatToShow;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_filter;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_expandEntityReferences;

        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> putref_currentNode;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_currentNode;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> parentNode;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> firstChild;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> lastChild;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> previousSibling;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> nextSibling;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> previousNode;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> nextNode;
    }
}
