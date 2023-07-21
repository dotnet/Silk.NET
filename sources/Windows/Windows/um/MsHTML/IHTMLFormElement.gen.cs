// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement"]/*' />
[Guid("3050F1F7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLFormElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLFormElement : IHTMLFormElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLFormElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLFormElement*, uint>)(lpVtbl[1]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLFormElement*, uint>)(lpVtbl[2]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, uint*, int>)(lpVtbl[3]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_action([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[7]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_action([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[8]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_dir"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_dir([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[9]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_dir"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[10]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_encoding([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[11]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_encoding([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[12]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_method([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[13]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_method([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[14]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_elements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_elements(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, IDispatch**, int>)(lpVtbl[15]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_target"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_target([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[16]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_target"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_target([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[17]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[18]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[19]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_onsubmit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_onsubmit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, int>)(lpVtbl[20]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_onsubmit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_onsubmit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, VARIANT*, int>)(lpVtbl[21]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_onreset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_onreset(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, int>)(lpVtbl[22]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_onreset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_onreset(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, VARIANT*, int>)(lpVtbl[23]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.submit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT submit()
    {
        return ((delegate* unmanaged<IHTMLFormElement*, int>)(lpVtbl[24]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT reset()
    {
        return ((delegate* unmanaged<IHTMLFormElement*, int>)(lpVtbl[25]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.put_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_length([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, int, int>)(lpVtbl[26]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, int*, int>)(lpVtbl[27]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.get__newEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get__newEnum(IUnknown** p)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, IUnknown**, int>)(lpVtbl[28]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[29]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), name, index, pdisp);
    }

    /// <include file='IHTMLFormElement.xml' path='doc/member[@name="IHTMLFormElement.tags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT tags(VARIANT tagName, IDispatch** pdisp)
    {
        return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, IDispatch**, int>)(lpVtbl[30]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), tagName, pdisp);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_action([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_action([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_dir([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_dir([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_encoding([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_encoding([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_method([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_method([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT get_elements(IDispatch** p);

        [VtblIndex(16)]
        HRESULT put_target([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(17)]
        HRESULT get_target([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(19)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(20)]
        HRESULT put_onsubmit(VARIANT v);

        [VtblIndex(21)]
        HRESULT get_onsubmit(VARIANT* p);

        [VtblIndex(22)]
        HRESULT put_onreset(VARIANT v);

        [VtblIndex(23)]
        HRESULT get_onreset(VARIANT* p);

        [VtblIndex(24)]
        HRESULT submit();

        [VtblIndex(25)]
        HRESULT reset();

        [VtblIndex(26)]
        HRESULT put_length([NativeTypeName("long")] int v);

        [VtblIndex(27)]
        HRESULT get_length([NativeTypeName("long *")] int* p);

        [VtblIndex(28)]
        HRESULT get__newEnum(IUnknown** p);

        [VtblIndex(29)]
        HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp);

        [VtblIndex(30)]
        HRESULT tags(VARIANT tagName, IDispatch** pdisp);
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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_action;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_action;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dir;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dir;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_encoding;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_encoding;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_method;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_method;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_elements;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_target;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_target;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onsubmit;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onsubmit;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreset;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreset;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> submit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> reset;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_length;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__newEnum;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, IDispatch**, int> item;

        [NativeTypeName("HRESULT (VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IDispatch**, int> tags;
    }
}
