// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix"]/*'/>
[Guid("305104F6-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGMatrix : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGMatrix : ISVGMatrix.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGMatrix));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGMatrix*, Guid*, void**, int> )(lpVtbl[0]))((ISVGMatrix*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGMatrix*, uint> )(lpVtbl[1]))((ISVGMatrix*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGMatrix*, uint> )(lpVtbl[2]))((ISVGMatrix*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGMatrix*, uint*, int> )(lpVtbl[3]))((ISVGMatrix*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGMatrix*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGMatrix*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGMatrix*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGMatrix*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGMatrix*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGMatrix*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.put_a"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_a(float v)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, int> )(lpVtbl[7]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.get_a"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_a(float* p)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float*, int> )(lpVtbl[8]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.put_b"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_b(float v)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, int> )(lpVtbl[9]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.get_b"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_b(float* p)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float*, int> )(lpVtbl[10]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.put_c"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_c(float v)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, int> )(lpVtbl[11]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.get_c"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_c(float* p)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float*, int> )(lpVtbl[12]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.put_d"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_d(float v)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, int> )(lpVtbl[13]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.get_d"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_d(float* p)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float*, int> )(lpVtbl[14]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.put_e"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_e(float v)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, int> )(lpVtbl[15]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.get_e"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_e(float* p)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float*, int> )(lpVtbl[16]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.put_f"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_f(float v)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, int> )(lpVtbl[17]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.get_f"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_f(float* p)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float*, int> )(lpVtbl[18]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.multiply"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT multiply(ISVGMatrix* secondMatrix, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix*, ISVGMatrix**, int> )(lpVtbl[19]))((ISVGMatrix*)Unsafe.AsPointer(ref this), secondMatrix, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.inverse"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT inverse(ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix**, int> )(lpVtbl[20]))((ISVGMatrix*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.translate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT translate(float x, float y, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, float, ISVGMatrix**, int> )(lpVtbl[21]))((ISVGMatrix*)Unsafe.AsPointer(ref this), x, y, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.scale"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT scale(float scaleFactor, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int> )(lpVtbl[22]))((ISVGMatrix*)Unsafe.AsPointer(ref this), scaleFactor, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.scaleNonUniform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT scaleNonUniform(float scaleFactorX, float scaleFactorY, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, float, ISVGMatrix**, int> )(lpVtbl[23]))((ISVGMatrix*)Unsafe.AsPointer(ref this), scaleFactorX, scaleFactorY, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.rotate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT rotate(float angle, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int> )(lpVtbl[24]))((ISVGMatrix*)Unsafe.AsPointer(ref this), angle, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.rotateFromVector"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT rotateFromVector(float x, float y, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, float, ISVGMatrix**, int> )(lpVtbl[25]))((ISVGMatrix*)Unsafe.AsPointer(ref this), x, y, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.flipX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT flipX(ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix**, int> )(lpVtbl[26]))((ISVGMatrix*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.flipY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT flipY(ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix**, int> )(lpVtbl[27]))((ISVGMatrix*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.skewX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT skewX(float angle, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int> )(lpVtbl[28]))((ISVGMatrix*)Unsafe.AsPointer(ref this), angle, ppResult);
    }

    /// <include file='ISVGMatrix.xml' path='doc/member[@name="ISVGMatrix.skewY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT skewY(float angle, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int> )(lpVtbl[29]))((ISVGMatrix*)Unsafe.AsPointer(ref this), angle, ppResult);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_a(float v);
        [VtblIndex(8)]
        HRESULT get_a(float* p);
        [VtblIndex(9)]
        HRESULT put_b(float v);
        [VtblIndex(10)]
        HRESULT get_b(float* p);
        [VtblIndex(11)]
        HRESULT put_c(float v);
        [VtblIndex(12)]
        HRESULT get_c(float* p);
        [VtblIndex(13)]
        HRESULT put_d(float v);
        [VtblIndex(14)]
        HRESULT get_d(float* p);
        [VtblIndex(15)]
        HRESULT put_e(float v);
        [VtblIndex(16)]
        HRESULT get_e(float* p);
        [VtblIndex(17)]
        HRESULT put_f(float v);
        [VtblIndex(18)]
        HRESULT get_f(float* p);
        [VtblIndex(19)]
        HRESULT multiply(ISVGMatrix* secondMatrix, ISVGMatrix** ppResult);
        [VtblIndex(20)]
        HRESULT inverse(ISVGMatrix** ppResult);
        [VtblIndex(21)]
        HRESULT translate(float x, float y, ISVGMatrix** ppResult);
        [VtblIndex(22)]
        HRESULT scale(float scaleFactor, ISVGMatrix** ppResult);
        [VtblIndex(23)]
        HRESULT scaleNonUniform(float scaleFactorX, float scaleFactorY, ISVGMatrix** ppResult);
        [VtblIndex(24)]
        HRESULT rotate(float angle, ISVGMatrix** ppResult);
        [VtblIndex(25)]
        HRESULT rotateFromVector(float x, float y, ISVGMatrix** ppResult);
        [VtblIndex(26)]
        HRESULT flipX(ISVGMatrix** ppResult);
        [VtblIndex(27)]
        HRESULT flipY(ISVGMatrix** ppResult);
        [VtblIndex(28)]
        HRESULT skewX(float angle, ISVGMatrix** ppResult);
        [VtblIndex(29)]
        HRESULT skewY(float angle, ISVGMatrix** ppResult);
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
        public delegate* unmanaged<TSelf*, float, int> put_a;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_a;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_b;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_b;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_c;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_c;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_d;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_d;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_e;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_e;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_f;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_f;
        [NativeTypeName("HRESULT (ISVGMatrix *, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix*, ISVGMatrix**, int> multiply;
        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix**, int> inverse;
        [NativeTypeName("HRESULT (float, float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, ISVGMatrix**, int> translate;
        [NativeTypeName("HRESULT (float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ISVGMatrix**, int> scale;
        [NativeTypeName("HRESULT (float, float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, ISVGMatrix**, int> scaleNonUniform;
        [NativeTypeName("HRESULT (float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ISVGMatrix**, int> rotate;
        [NativeTypeName("HRESULT (float, float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, ISVGMatrix**, int> rotateFromVector;
        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix**, int> flipX;
        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix**, int> flipY;
        [NativeTypeName("HRESULT (float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ISVGMatrix**, int> skewX;
        [NativeTypeName("HRESULT (float, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ISVGMatrix**, int> skewY;
    }
}