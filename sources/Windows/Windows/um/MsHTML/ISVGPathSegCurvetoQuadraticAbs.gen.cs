// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs"]/*'/>
[Guid("30510504-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGPathSegCurvetoQuadraticAbs : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGPathSegCurvetoQuadraticAbs : ISVGPathSegCurvetoQuadraticAbs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGPathSegCurvetoQuadraticAbs));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, Guid*, void**, int> )(lpVtbl[0]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, uint> )(lpVtbl[1]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, uint> )(lpVtbl[2]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, uint*, int> )(lpVtbl[3]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.put_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_x(float v)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float, int> )(lpVtbl[7]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.get_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x(float* p)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float*, int> )(lpVtbl[8]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.put_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_y(float v)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float, int> )(lpVtbl[9]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.get_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y(float* p)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float*, int> )(lpVtbl[10]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.put_x1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_x1(float v)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float, int> )(lpVtbl[11]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.get_x1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_x1(float* p)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float*, int> )(lpVtbl[12]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.put_y1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_y1(float v)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float, int> )(lpVtbl[13]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPathSegCurvetoQuadraticAbs.xml' path='doc/member[@name="ISVGPathSegCurvetoQuadraticAbs.get_y1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_y1(float* p)
    {
        return ((delegate* unmanaged<ISVGPathSegCurvetoQuadraticAbs*, float*, int> )(lpVtbl[14]))((ISVGPathSegCurvetoQuadraticAbs*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_x(float v);
        [VtblIndex(8)]
        HRESULT get_x(float* p);
        [VtblIndex(9)]
        HRESULT put_y(float v);
        [VtblIndex(10)]
        HRESULT get_y(float* p);
        [VtblIndex(11)]
        HRESULT put_x1(float v);
        [VtblIndex(12)]
        HRESULT get_x1(float* p);
        [VtblIndex(13)]
        HRESULT put_y1(float v);
        [VtblIndex(14)]
        HRESULT get_y1(float* p);
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
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_x;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_x;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_y;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_y;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_x1;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_x1;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_y1;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_y1;
    }
}