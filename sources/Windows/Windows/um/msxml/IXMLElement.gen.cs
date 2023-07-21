// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement"]/*' />
[Guid("3F7F31AC-E15F-11D0-9C25-00C04FC99C8E")]
[NativeTypeName("struct IXMLElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLElement : IXMLElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLElement*, Guid*, void**, int>)(lpVtbl[0]))((IXMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLElement*, uint>)(lpVtbl[1]))((IXMLElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLElement*, uint>)(lpVtbl[2]))((IXMLElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLElement*, uint*, int>)(lpVtbl[3]))((IXMLElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.get_tagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort**, int>)(lpVtbl[7]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.put_tagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_tagName([NativeTypeName("BSTR")] ushort* p)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort*, int>)(lpVtbl[8]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.get_parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_parent(IXMLElement** ppParent)
    {
        return ((delegate* unmanaged<IXMLElement*, IXMLElement**, int>)(lpVtbl[9]))((IXMLElement*)Unsafe.AsPointer(ref this), ppParent);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.setAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort*, VARIANT, int>)(lpVtbl[10]))((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.getAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT* PropertyValue)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort*, VARIANT*, int>)(lpVtbl[11]))((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.removeAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort*, int>)(lpVtbl[12]))((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.get_children"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_children(IXMLElementCollection** pp)
    {
        return ((delegate* unmanaged<IXMLElement*, IXMLElementCollection**, int>)(lpVtbl[13]))((IXMLElement*)Unsafe.AsPointer(ref this), pp);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_type([NativeTypeName("long *")] int* plType)
    {
        return ((delegate* unmanaged<IXMLElement*, int*, int>)(lpVtbl[14]))((IXMLElement*)Unsafe.AsPointer(ref this), plType);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.get_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort**, int>)(lpVtbl[15]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.put_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* p)
    {
        return ((delegate* unmanaged<IXMLElement*, ushort*, int>)(lpVtbl[16]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.addChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT addChild(IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
    {
        return ((delegate* unmanaged<IXMLElement*, IXMLElement*, int, int, int>)(lpVtbl[17]))((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
    }

    /// <include file='IXMLElement.xml' path='doc/member[@name="IXMLElement.removeChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT removeChild(IXMLElement* pChildElem)
    {
        return ((delegate* unmanaged<IXMLElement*, IXMLElement*, int>)(lpVtbl[18]))((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT put_tagName([NativeTypeName("BSTR")] ushort* p);

        [VtblIndex(9)]
        HRESULT get_parent(IXMLElement** ppParent);

        [VtblIndex(10)]
        HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue);

        [VtblIndex(11)]
        HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT* PropertyValue);

        [VtblIndex(12)]
        HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName);

        [VtblIndex(13)]
        HRESULT get_children(IXMLElementCollection** pp);

        [VtblIndex(14)]
        HRESULT get_type([NativeTypeName("long *")] int* plType);

        [VtblIndex(15)]
        HRESULT get_text([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(16)]
        HRESULT put_text([NativeTypeName("BSTR")] ushort* p);

        [VtblIndex(17)]
        HRESULT addChild(IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved);

        [VtblIndex(18)]
        HRESULT removeChild(IXMLElement* pChildElem);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_tagName;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_tagName;

        [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement**, int> get_parent;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> setAttribute;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getAttribute;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> removeAttribute;

        [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElementCollection**, int> get_children;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;

        [NativeTypeName("HRESULT (IXMLElement *, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement*, int, int, int> addChild;

        [NativeTypeName("HRESULT (IXMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement*, int> removeChild;
    }
}
