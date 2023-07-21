// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument"]/*' />
[Guid("F52E2B61-18A1-11D1-B105-00805F49916B")]
[NativeTypeName("struct IXMLDocument : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLDocument : IXMLDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDocument));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDocument*, uint>)(lpVtbl[1]))((IXMLDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDocument*, uint>)(lpVtbl[2]))((IXMLDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDocument*, uint*, int>)(lpVtbl[3]))((IXMLDocument*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDocument*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDocument*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_root"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_root(IXMLElement** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, IXMLElement**, int>)(lpVtbl[7]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_fileSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[8]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_fileModifiedDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[9]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_fileUpdatedDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[10]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_URL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[11]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.put_URL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_URL([NativeTypeName("BSTR")] ushort* p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort*, int>)(lpVtbl[12]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_mimeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[13]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_readyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IXMLDocument*, int*, int>)(lpVtbl[14]))((IXMLDocument*)Unsafe.AsPointer(ref this), pl);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_charset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[15]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.put_charset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_charset([NativeTypeName("BSTR")] ushort* p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort*, int>)(lpVtbl[16]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_version([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[17]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_doctype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_doctype([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[18]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.get_dtdURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[19]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLDocument.xml' path='doc/member[@name="IXMLDocument.createElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT createElement(VARIANT vType, VARIANT var1, IXMLElement** ppElem)
    {
        return ((delegate* unmanaged<IXMLDocument*, VARIANT, VARIANT, IXMLElement**, int>)(lpVtbl[20]))((IXMLDocument*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_root(IXMLElement** p);

        [VtblIndex(8)]
        HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(12)]
        HRESULT put_URL([NativeTypeName("BSTR")] ushort* p);

        [VtblIndex(13)]
        HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(14)]
        HRESULT get_readyState([NativeTypeName("long *")] int* pl);

        [VtblIndex(15)]
        HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(16)]
        HRESULT put_charset([NativeTypeName("BSTR")] ushort* p);

        [VtblIndex(17)]
        HRESULT get_version([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT get_doctype([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT get_dtdURL([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(20)]
        HRESULT createElement(VARIANT vType, VARIANT var1, IXMLElement** ppElem);
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

        [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement**, int> get_root;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileSize;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileModifiedDate;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileUpdatedDate;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_URL;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_URL;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_mimeType;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_charset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_charset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_version;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_doctype;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dtdURL;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, IXMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, IXMLElement**, int> createElement;
    }
}
