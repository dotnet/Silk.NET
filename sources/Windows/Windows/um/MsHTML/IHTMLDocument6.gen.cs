// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6"]/*'/>
[Guid("30510417-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument6 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument6 : IHTMLDocument6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument6));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDocument6*, uint> )(lpVtbl[1]))((IHTMLDocument6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument6*, uint> )(lpVtbl[2]))((IHTMLDocument6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, uint*, int> )(lpVtbl[3]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.get_compatible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_compatible(IHTMLDocumentCompatibleInfoCollection** p)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, IHTMLDocumentCompatibleInfoCollection**, int> )(lpVtbl[7]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.get_documentMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_documentMode(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, VARIANT*, int> )(lpVtbl[8]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.put_onstorage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_onstorage(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, VARIANT, int> )(lpVtbl[9]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.get_onstorage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_onstorage(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, VARIANT*, int> )(lpVtbl[10]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.put_onstoragecommit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_onstoragecommit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, VARIANT, int> )(lpVtbl[11]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.get_onstoragecommit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_onstoragecommit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, VARIANT*, int> )(lpVtbl[12]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.getElementById"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT getElementById([NativeTypeName("BSTR")] ushort* bstrId, IHTMLElement2** ppRetElement)
    {
        return ((delegate* unmanaged<IHTMLDocument6*, ushort*, IHTMLElement2**, int> )(lpVtbl[13]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), bstrId, ppRetElement);
    }

    /// <include file='IHTMLDocument6.xml' path='doc/member[@name="IHTMLDocument6.updateSettings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT updateSettings()
    {
        return ((delegate* unmanaged<IHTMLDocument6*, int> )(lpVtbl[14]))((IHTMLDocument6*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_compatible(IHTMLDocumentCompatibleInfoCollection** p);
        [VtblIndex(8)]
        HRESULT get_documentMode(VARIANT* p);
        [VtblIndex(9)]
        HRESULT put_onstorage(VARIANT v);
        [VtblIndex(10)]
        HRESULT get_onstorage(VARIANT* p);
        [VtblIndex(11)]
        HRESULT put_onstoragecommit(VARIANT v);
        [VtblIndex(12)]
        HRESULT get_onstoragecommit(VARIANT* p);
        [VtblIndex(13)]
        HRESULT getElementById([NativeTypeName("BSTR")] ushort* bstrId, IHTMLElement2** ppRetElement);
        [VtblIndex(14)]
        HRESULT updateSettings();
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
        [NativeTypeName("HRESULT (IHTMLDocumentCompatibleInfoCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocumentCompatibleInfoCollection**, int> get_compatible;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_documentMode;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstorage;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstorage;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstoragecommit;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstoragecommit;
        [NativeTypeName("HRESULT (BSTR, IHTMLElement2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement2**, int> getElementById;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> updateSettings;
    }
}