// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle"]/*'/>
[Guid("305104D3-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGAngle : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGAngle : ISVGAngle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGAngle));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGAngle*, Guid*, void**, int> )(lpVtbl[0]))((ISVGAngle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGAngle*, uint> )(lpVtbl[1]))((ISVGAngle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGAngle*, uint> )(lpVtbl[2]))((ISVGAngle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGAngle*, uint*, int> )(lpVtbl[3]))((ISVGAngle*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGAngle*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGAngle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGAngle*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGAngle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGAngle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGAngle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.put_unitType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_unitType(short v)
    {
        return ((delegate* unmanaged<ISVGAngle*, short, int> )(lpVtbl[7]))((ISVGAngle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.get_unitType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_unitType(short* p)
    {
        return ((delegate* unmanaged<ISVGAngle*, short*, int> )(lpVtbl[8]))((ISVGAngle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_value(float v)
    {
        return ((delegate* unmanaged<ISVGAngle*, float, int> )(lpVtbl[9]))((ISVGAngle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_value(float* p)
    {
        return ((delegate* unmanaged<ISVGAngle*, float*, int> )(lpVtbl[10]))((ISVGAngle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.put_valueInSpecifiedUnits"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_valueInSpecifiedUnits(float v)
    {
        return ((delegate* unmanaged<ISVGAngle*, float, int> )(lpVtbl[11]))((ISVGAngle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.get_valueInSpecifiedUnits"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_valueInSpecifiedUnits(float* p)
    {
        return ((delegate* unmanaged<ISVGAngle*, float*, int> )(lpVtbl[12]))((ISVGAngle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.put_valueAsString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_valueAsString([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ISVGAngle*, ushort*, int> )(lpVtbl[13]))((ISVGAngle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.get_valueAsString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_valueAsString([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ISVGAngle*, ushort**, int> )(lpVtbl[14]))((ISVGAngle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.newValueSpecifiedUnits"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT newValueSpecifiedUnits(short unitType, float valueInSpecifiedUnits)
    {
        return ((delegate* unmanaged<ISVGAngle*, short, float, int> )(lpVtbl[15]))((ISVGAngle*)Unsafe.AsPointer(ref this), unitType, valueInSpecifiedUnits);
    }

    /// <include file='ISVGAngle.xml' path='doc/member[@name="ISVGAngle.convertToSpecifiedUnits"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT convertToSpecifiedUnits(short unitType)
    {
        return ((delegate* unmanaged<ISVGAngle*, short, int> )(lpVtbl[16]))((ISVGAngle*)Unsafe.AsPointer(ref this), unitType);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_unitType(short v);
        [VtblIndex(8)]
        HRESULT get_unitType(short* p);
        [VtblIndex(9)]
        HRESULT put_value(float v);
        [VtblIndex(10)]
        HRESULT get_value(float* p);
        [VtblIndex(11)]
        HRESULT put_valueInSpecifiedUnits(float v);
        [VtblIndex(12)]
        HRESULT get_valueInSpecifiedUnits(float* p);
        [VtblIndex(13)]
        HRESULT put_valueAsString([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_valueAsString([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT newValueSpecifiedUnits(short unitType, float valueInSpecifiedUnits);
        [VtblIndex(16)]
        HRESULT convertToSpecifiedUnits(short unitType);
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
        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_unitType;
        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_unitType;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_value;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_value;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_valueInSpecifiedUnits;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_valueInSpecifiedUnits;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_valueAsString;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_valueAsString;
        [NativeTypeName("HRESULT (short, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, float, int> newValueSpecifiedUnits;
        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> convertToSpecifiedUnits;
    }
}