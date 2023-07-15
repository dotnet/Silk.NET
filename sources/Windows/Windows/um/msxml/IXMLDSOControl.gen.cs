// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXMLDSOControl.xml' path='doc/member[@name="IXMLDSOControl"]/*'/>
[Guid("310AFA62-0575-11D2-9CA9-0060B0EC3D39")]
[NativeTypeName("struct IXMLDSOControl : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLDSOControl : IXMLDSOControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDSOControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, Guid*, void**, int> )(lpVtbl[0]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDSOControl*, uint> )(lpVtbl[1]))((IXMLDSOControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDSOControl*, uint> )(lpVtbl[2]))((IXMLDSOControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, uint*, int> )(lpVtbl[3]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLDSOControl.xml' path='doc/member[@name="IXMLDSOControl.get_XMLDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XMLDocument(IXMLDOMDocument** ppDoc)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, IXMLDOMDocument**, int> )(lpVtbl[7]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
    }

    /// <include file='IXMLDSOControl.xml' path='doc/member[@name="IXMLDSOControl.put_XMLDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_XMLDocument(IXMLDOMDocument* ppDoc)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, IXMLDOMDocument*, int> )(lpVtbl[8]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
    }

    /// <include file='IXMLDSOControl.xml' path='doc/member[@name="IXMLDSOControl.get_JavaDSOCompatible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_JavaDSOCompatible(BOOL* fJavaDSOCompatible)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, BOOL*, int> )(lpVtbl[9]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
    }

    /// <include file='IXMLDSOControl.xml' path='doc/member[@name="IXMLDSOControl.put_JavaDSOCompatible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_JavaDSOCompatible(BOOL fJavaDSOCompatible)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, BOOL, int> )(lpVtbl[10]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
    }

    /// <include file='IXMLDSOControl.xml' path='doc/member[@name="IXMLDSOControl.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* state)
    {
        return ((delegate* unmanaged<IXMLDSOControl*, int*, int> )(lpVtbl[11]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), state);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_XMLDocument(IXMLDOMDocument** ppDoc);
        [VtblIndex(8)]
        HRESULT put_XMLDocument(IXMLDOMDocument* ppDoc);
        [VtblIndex(9)]
        HRESULT get_JavaDSOCompatible(BOOL* fJavaDSOCompatible);
        [VtblIndex(10)]
        HRESULT put_JavaDSOCompatible(BOOL fJavaDSOCompatible);
        [VtblIndex(11)]
        HRESULT get_readyState([NativeTypeName("long *")] int* state);
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
        [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocument**, int> get_XMLDocument;
        [NativeTypeName("HRESULT (IXMLDOMDocument *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocument*, int> put_XMLDocument;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_JavaDSOCompatible;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_JavaDSOCompatible;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;
    }
}