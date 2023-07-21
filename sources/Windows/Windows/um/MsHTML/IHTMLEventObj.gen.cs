// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj"]/*' />
[Guid("3050F32D-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEventObj : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLEventObj : IHTMLEventObj.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEventObj));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLEventObj*, uint>)(lpVtbl[1]))((IHTMLEventObj*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEventObj*, uint>)(lpVtbl[2]))((IHTMLEventObj*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, uint*, int>)(lpVtbl[3]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_srcElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_srcElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, IHTMLElement**, int>)(lpVtbl[7]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_altKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[8]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_ctrlKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[9]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_shiftKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[10]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.put_returnValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_returnValue(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, VARIANT, int>)(lpVtbl[11]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_returnValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_returnValue(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, VARIANT*, int>)(lpVtbl[12]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.put_cancelBubble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, short, int>)(lpVtbl[13]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_cancelBubble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[14]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_fromElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_fromElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, IHTMLElement**, int>)(lpVtbl[15]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_toElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_toElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, IHTMLElement**, int>)(lpVtbl[16]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.put_keyCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_keyCode([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int, int>)(lpVtbl[17]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_keyCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_keyCode([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[18]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_button"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_button([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[19]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, ushort**, int>)(lpVtbl[20]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_qualifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, ushort**, int>)(lpVtbl[21]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_reason([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[22]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_x([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[23]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_y([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[24]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_clientX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_clientX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[25]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_clientY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_clientY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[26]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_offsetX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_offsetX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[27]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_offsetY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_offsetY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[28]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_screenX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_screenX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[29]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_screenY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_screenY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[30]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEventObj.xml' path='doc/member[@name="IHTMLEventObj.get_srcFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_srcFilter(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj*, IDispatch**, int>)(lpVtbl[31]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_srcElement(IHTMLElement** p);

        [VtblIndex(8)]
        HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(9)]
        HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(10)]
        HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(11)]
        HRESULT put_returnValue(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_returnValue(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(14)]
        HRESULT get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(15)]
        HRESULT get_fromElement(IHTMLElement** p);

        [VtblIndex(16)]
        HRESULT get_toElement(IHTMLElement** p);

        [VtblIndex(17)]
        HRESULT put_keyCode([NativeTypeName("long")] int v);

        [VtblIndex(18)]
        HRESULT get_keyCode([NativeTypeName("long *")] int* p);

        [VtblIndex(19)]
        HRESULT get_button([NativeTypeName("long *")] int* p);

        [VtblIndex(20)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(22)]
        HRESULT get_reason([NativeTypeName("long *")] int* p);

        [VtblIndex(23)]
        HRESULT get_x([NativeTypeName("long *")] int* p);

        [VtblIndex(24)]
        HRESULT get_y([NativeTypeName("long *")] int* p);

        [VtblIndex(25)]
        HRESULT get_clientX([NativeTypeName("long *")] int* p);

        [VtblIndex(26)]
        HRESULT get_clientY([NativeTypeName("long *")] int* p);

        [VtblIndex(27)]
        HRESULT get_offsetX([NativeTypeName("long *")] int* p);

        [VtblIndex(28)]
        HRESULT get_offsetY([NativeTypeName("long *")] int* p);

        [VtblIndex(29)]
        HRESULT get_screenX([NativeTypeName("long *")] int* p);

        [VtblIndex(30)]
        HRESULT get_screenY([NativeTypeName("long *")] int* p);

        [VtblIndex(31)]
        HRESULT get_srcFilter(IDispatch** p);
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

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_srcElement;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_altKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ctrlKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_shiftKey;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_returnValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_returnValue;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_cancelBubble;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_cancelBubble;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_fromElement;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_toElement;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_keyCode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_keyCode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_button;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_qualifier;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_reason;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_x;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_y;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenY;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_srcFilter;
    }
}
