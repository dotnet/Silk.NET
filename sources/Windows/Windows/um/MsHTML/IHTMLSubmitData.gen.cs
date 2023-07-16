// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLSubmitData.xml' path='doc/member[@name="IHTMLSubmitData"]/*'/>
[Guid("3050F645-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLSubmitData : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLSubmitData : IHTMLSubmitData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLSubmitData));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, uint> )(lpVtbl[1]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, uint> )(lpVtbl[2]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, uint*, int> )(lpVtbl[3]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLSubmitData.xml' path='doc/member[@name="IHTMLSubmitData.appendNameValuePair"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT appendNameValuePair([NativeTypeName("BSTR")] ushort* name = null, [NativeTypeName("BSTR")] ushort* value = null)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, ushort*, ushort*, int> )(lpVtbl[7]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IHTMLSubmitData.xml' path='doc/member[@name="IHTMLSubmitData.appendNameFilePair"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT appendNameFilePair([NativeTypeName("BSTR")] ushort* name = null, [NativeTypeName("BSTR")] ushort* filename = null)
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, ushort*, ushort*, int> )(lpVtbl[8]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this), name, filename);
    }

    /// <include file='IHTMLSubmitData.xml' path='doc/member[@name="IHTMLSubmitData.appendItemSeparator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT appendItemSeparator()
    {
        return ((delegate* unmanaged<IHTMLSubmitData*, int> )(lpVtbl[9]))((IHTMLSubmitData*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT appendNameValuePair([NativeTypeName("BSTR")] ushort* name = null, [NativeTypeName("BSTR")] ushort* value = null);
        [VtblIndex(8)]
        HRESULT appendNameFilePair([NativeTypeName("BSTR")] ushort* name = null, [NativeTypeName("BSTR")] ushort* filename = null);
        [VtblIndex(9)]
        HRESULT appendItemSeparator();
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
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> appendNameValuePair;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> appendNameFilePair;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> appendItemSeparator;
    }
}