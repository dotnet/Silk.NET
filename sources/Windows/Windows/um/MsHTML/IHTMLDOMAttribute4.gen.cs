// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4"]/*'/>
[Guid("305106F9-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMAttribute4 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMAttribute4 : IHTMLDOMAttribute4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMAttribute4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint> )(lpVtbl[1]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint> )(lpVtbl[2]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint*, int> )(lpVtbl[3]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.put_nodeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_nodeValue(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, VARIANT, int> )(lpVtbl[7]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_nodeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, VARIANT*, int> )(lpVtbl[8]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_nodeName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort**, int> )(lpVtbl[9]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort**, int> )(lpVtbl[10]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort*, int> )(lpVtbl[11]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort**, int> )(lpVtbl[12]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_firstChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, IHTMLDOMNode**, int> )(lpVtbl[13]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_lastChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, IHTMLDOMNode**, int> )(lpVtbl[14]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_childNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_childNodes(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, IDispatch**, int> )(lpVtbl[15]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.hasAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, short*, int> )(lpVtbl[16]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), pfHasAttributes);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.hasChildNodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, short*, int> )(lpVtbl[17]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), fChildren);
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.normalize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT normalize()
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, int> )(lpVtbl[18]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDOMAttribute4.xml' path='doc/member[@name="IHTMLDOMAttribute4.get_specified"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDOMAttribute4*, short*, int> )(lpVtbl[19]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_nodeValue(VARIANT v);
        [VtblIndex(8)]
        HRESULT get_nodeValue(VARIANT* p);
        [VtblIndex(9)]
        HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT get_firstChild(IHTMLDOMNode** p);
        [VtblIndex(14)]
        HRESULT get_lastChild(IHTMLDOMNode** p);
        [VtblIndex(15)]
        HRESULT get_childNodes(IDispatch** p);
        [VtblIndex(16)]
        HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes);
        [VtblIndex(17)]
        HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren);
        [VtblIndex(18)]
        HRESULT normalize();
        [VtblIndex(19)]
        HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* p);
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
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeValue;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeValue;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeName;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_firstChild;
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_lastChild;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_childNodes;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasAttributes;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasChildNodes;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> normalize;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_specified;
    }
}