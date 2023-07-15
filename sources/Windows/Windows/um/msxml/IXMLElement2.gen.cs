// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2"]/*'/>
[Guid("2B8DE2FF-8D2D-11D1-B2FC-00C04FD915A9")]
[NativeTypeName("struct IXMLElement2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLElement2 : IXMLElement2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLElement2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLElement2*, Guid*, void**, int> )(lpVtbl[0]))((IXMLElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLElement2*, uint> )(lpVtbl[1]))((IXMLElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLElement2*, uint> )(lpVtbl[2]))((IXMLElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLElement2*, uint*, int> )(lpVtbl[3]))((IXMLElement2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLElement2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IXMLElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLElement2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IXMLElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IXMLElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.get_tagName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort**, int> )(lpVtbl[7]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.put_tagName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_tagName([NativeTypeName("BSTR")] ushort* p)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort*, int> )(lpVtbl[8]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.get_parent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_parent(IXMLElement2** ppParent)
    {
        return ((delegate* unmanaged<IXMLElement2*, IXMLElement2**, int> )(lpVtbl[9]))((IXMLElement2*)Unsafe.AsPointer(ref this), ppParent);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.setAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort*, VARIANT, int> )(lpVtbl[10]))((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.getAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT* PropertyValue)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort*, VARIANT*, int> )(lpVtbl[11]))((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.removeAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort*, int> )(lpVtbl[12]))((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.get_children"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_children(IXMLElementCollection** pp)
    {
        return ((delegate* unmanaged<IXMLElement2*, IXMLElementCollection**, int> )(lpVtbl[13]))((IXMLElement2*)Unsafe.AsPointer(ref this), pp);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_type([NativeTypeName("long *")] int* plType)
    {
        return ((delegate* unmanaged<IXMLElement2*, int*, int> )(lpVtbl[14]))((IXMLElement2*)Unsafe.AsPointer(ref this), plType);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.get_text"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort**, int> )(lpVtbl[15]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.put_text"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* p)
    {
        return ((delegate* unmanaged<IXMLElement2*, ushort*, int> )(lpVtbl[16]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.addChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT addChild(IXMLElement2* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
    {
        return ((delegate* unmanaged<IXMLElement2*, IXMLElement2*, int, int, int> )(lpVtbl[17]))((IXMLElement2*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.removeChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT removeChild(IXMLElement2* pChildElem)
    {
        return ((delegate* unmanaged<IXMLElement2*, IXMLElement2*, int> )(lpVtbl[18]))((IXMLElement2*)Unsafe.AsPointer(ref this), pChildElem);
    }

    /// <include file='IXMLElement2.xml' path='doc/member[@name="IXMLElement2.get_attributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_attributes(IXMLElementCollection** pp)
    {
        return ((delegate* unmanaged<IXMLElement2*, IXMLElementCollection**, int> )(lpVtbl[19]))((IXMLElement2*)Unsafe.AsPointer(ref this), pp);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(8)]
        HRESULT put_tagName([NativeTypeName("BSTR")] ushort* p);
        [VtblIndex(9)]
        HRESULT get_parent(IXMLElement2** ppParent);
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
        HRESULT addChild(IXMLElement2* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved);
        [VtblIndex(18)]
        HRESULT removeChild(IXMLElement2* pChildElem);
        [VtblIndex(19)]
        HRESULT get_attributes(IXMLElementCollection** pp);
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
        [NativeTypeName("HRESULT (IXMLElement2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement2**, int> get_parent;
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
        [NativeTypeName("HRESULT (IXMLElement2 *, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement2*, int, int, int> addChild;
        [NativeTypeName("HRESULT (IXMLElement2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElement2*, int> removeChild;
        [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLElementCollection**, int> get_attributes;
    }
}