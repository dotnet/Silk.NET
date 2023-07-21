// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3"]/*' />
[Guid("30510433-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLIFrameElement3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLIFrameElement3 : IHTMLIFrameElement3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLIFrameElement3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, uint>)(lpVtbl[1]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, uint>)(lpVtbl[2]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, uint*, int>)(lpVtbl[3]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.get_contentDocument"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_contentDocument(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, IDispatch**, int>)(lpVtbl[7]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.put_src"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, ushort*, int>)(lpVtbl[8]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.get_src"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, ushort**, int>)(lpVtbl[9]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.put_longDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_longDesc([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, ushort*, int>)(lpVtbl[10]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.get_longDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_longDesc([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, ushort**, int>)(lpVtbl[11]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.put_frameBorder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_frameBorder([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, ushort*, int>)(lpVtbl[12]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLIFrameElement3.xml' path='doc/member[@name="IHTMLIFrameElement3.get_frameBorder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_frameBorder([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement3*, ushort**, int>)(lpVtbl[13]))((IHTMLIFrameElement3*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_contentDocument(IDispatch** p);

        [VtblIndex(8)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(9)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT put_longDesc([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(11)]
        HRESULT get_longDesc([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(12)]
        HRESULT put_frameBorder([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(13)]
        HRESULT get_frameBorder([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_contentDocument;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_src;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_src;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_longDesc;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_longDesc;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_frameBorder;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_frameBorder;
    }
}
