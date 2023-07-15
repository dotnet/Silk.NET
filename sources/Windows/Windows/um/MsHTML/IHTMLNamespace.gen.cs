// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace"]/*'/>
[Guid("3050F6BB-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLNamespace : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLNamespace : IHTMLNamespace.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLNamespace));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLNamespace*, uint> )(lpVtbl[1]))((IHTMLNamespace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLNamespace*, uint> )(lpVtbl[2]))((IHTMLNamespace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, uint*, int> )(lpVtbl[3]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, ushort**, int> )(lpVtbl[7]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.get_urn"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_urn([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, ushort**, int> )(lpVtbl[8]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.get_tagNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_tagNames(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, IDispatch**, int> )(lpVtbl[9]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_readyState(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, VARIANT*, int> )(lpVtbl[10]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, VARIANT, int> )(lpVtbl[11]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, VARIANT*, int> )(lpVtbl[12]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.doImport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT doImport([NativeTypeName("BSTR")] ushort* bstrImplementationUrl)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, ushort*, int> )(lpVtbl[13]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), bstrImplementationUrl);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.attachEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, ushort*, IDispatch*, short*, int> )(lpVtbl[14]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), @event, pDisp, pfResult);
    }

    /// <include file='IHTMLNamespace.xml' path='doc/member[@name="IHTMLNamespace.detachEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp)
    {
        return ((delegate* unmanaged<IHTMLNamespace*, ushort*, IDispatch*, int> )(lpVtbl[15]))((IHTMLNamespace*)Unsafe.AsPointer(ref this), @event, pDisp);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(8)]
        HRESULT get_urn([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_tagNames(IDispatch** p);
        [VtblIndex(10)]
        HRESULT get_readyState(VARIANT* p);
        [VtblIndex(11)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(12)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(13)]
        HRESULT doImport([NativeTypeName("BSTR")] ushort* bstrImplementationUrl);
        [VtblIndex(14)]
        HRESULT attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult);
        [VtblIndex(15)]
        HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_urn;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_tagNames;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_readyState;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> doImport;
        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch*, short*, int> attachEvent;
        [NativeTypeName("HRESULT (BSTR, IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch*, int> detachEvent;
    }
}