// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLAttributeCollection2.xml' path='doc/member[@name="IHTMLAttributeCollection2"]/*'/>
[Guid("3050F80A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAttributeCollection2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAttributeCollection2 : IHTMLAttributeCollection2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAttributeCollection2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint> )(lpVtbl[1]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint> )(lpVtbl[2]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint*, int> )(lpVtbl[3]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLAttributeCollection2.xml' path='doc/member[@name="IHTMLAttributeCollection2.getNamedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** newretNode)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, ushort*, IHTMLDOMAttribute**, int> )(lpVtbl[7]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), bstrName, newretNode);
    }

    /// <include file='IHTMLAttributeCollection2.xml' path='doc/member[@name="IHTMLAttributeCollection2.setNamedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setNamedItem(IHTMLDOMAttribute* ppNode, IHTMLDOMAttribute** newretNode)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int> )(lpVtbl[8]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), ppNode, newretNode);
    }

    /// <include file='IHTMLAttributeCollection2.xml' path='doc/member[@name="IHTMLAttributeCollection2.removeNamedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** newretNode)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection2*, ushort*, IHTMLDOMAttribute**, int> )(lpVtbl[9]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), bstrName, newretNode);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** newretNode);
        [VtblIndex(8)]
        HRESULT setNamedItem(IHTMLDOMAttribute* ppNode, IHTMLDOMAttribute** newretNode);
        [VtblIndex(9)]
        HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** newretNode);
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
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute**, int> getNamedItem;
        [NativeTypeName("HRESULT (IHTMLDOMAttribute *, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int> setNamedItem;
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute**, int> removeNamedItem;
    }
}