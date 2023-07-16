// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement"]/*'/>
[Guid("3050F2D4-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLInputRangeElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLInputRangeElement : IHTMLInputRangeElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLInputRangeElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, uint> )(lpVtbl[1]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, uint> )(lpVtbl[2]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, uint*, int> )(lpVtbl[3]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, short, int> )(lpVtbl[7]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, short*, int> )(lpVtbl[8]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[9]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_alt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_alt([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int> )(lpVtbl[10]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_alt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[11]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int> )(lpVtbl[12]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[13]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int> )(lpVtbl[14]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[15]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_min"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_min([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int> )(lpVtbl[16]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_min"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_min([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[17]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_max"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_max([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int> )(lpVtbl[18]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_max"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_max([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[19]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_step"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_step([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int> )(lpVtbl[20]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_step"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_step([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int> )(lpVtbl[21]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.put_valueAsNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_valueAsNumber(double v)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, double, int> )(lpVtbl[22]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.get_valueAsNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_valueAsNumber(double* p)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, double*, int> )(lpVtbl[23]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.stepUp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT stepUp([NativeTypeName("long")] int n = 1)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, int, int> )(lpVtbl[24]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), n);
    }

    /// <include file='IHTMLInputRangeElement.xml' path='doc/member[@name="IHTMLInputRangeElement.stepDown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT stepDown([NativeTypeName("long")] int n = 1)
    {
        return ((delegate* unmanaged<IHTMLInputRangeElement*, int, int> )(lpVtbl[25]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), n);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(8)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(9)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT put_alt([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(11)]
        HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(13)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(14)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(15)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(16)]
        HRESULT put_min([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(17)]
        HRESULT get_min([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(18)]
        HRESULT put_max([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(19)]
        HRESULT get_max([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(20)]
        HRESULT put_step([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(21)]
        HRESULT get_step([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT put_valueAsNumber(double v);
        [VtblIndex(23)]
        HRESULT get_valueAsNumber(double* p);
        [VtblIndex(24)]
        HRESULT stepUp([NativeTypeName("long")] int n = 1);
        [VtblIndex(25)]
        HRESULT stepDown([NativeTypeName("long")] int n = 1);
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
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_alt;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_alt;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_min;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_min;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_max;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_max;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_step;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_step;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_valueAsNumber;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_valueAsNumber;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> stepUp;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> stepDown;
    }
}