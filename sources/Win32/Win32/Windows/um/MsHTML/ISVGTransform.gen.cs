// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305104F7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTransform : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTransform : ISVGTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTransform, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<ISVGTransform, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<ISVGTransform, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ISVGTransform,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_type(short v)
    {
        return ((delegate* unmanaged<ISVGTransform, short, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_type(short* p)
    {
        return ((delegate* unmanaged<ISVGTransform, short*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_matrix(ISVGMatrix v)
    {
        return ((delegate* unmanaged<ISVGTransform, ISVGMatrix, int>)((*lpVtbl)[9]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_matrix(ISVGMatrix* p)
    {
        return ((delegate* unmanaged<ISVGTransform, ISVGMatrix*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_angle(float v)
    {
        return ((delegate* unmanaged<ISVGTransform, float, int>)((*lpVtbl)[11]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_angle(float* p)
    {
        return ((delegate* unmanaged<ISVGTransform, float*, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT setMatrix(ISVGMatrix matrix)
    {
        return ((delegate* unmanaged<ISVGTransform, ISVGMatrix, int>)((*lpVtbl)[13]))(this, matrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT setTranslate(float tx, float ty)
    {
        return ((delegate* unmanaged<ISVGTransform, float, float, int>)((*lpVtbl)[14]))(
            this,
            tx,
            ty
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT setScale(float sx, float sy)
    {
        return ((delegate* unmanaged<ISVGTransform, float, float, int>)((*lpVtbl)[15]))(
            this,
            sx,
            sy
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT setRotate(float angle, float cx, float cy)
    {
        return ((delegate* unmanaged<ISVGTransform, float, float, float, int>)((*lpVtbl)[16]))(
            this,
            angle,
            cx,
            cy
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT setSkewX(float angle)
    {
        return ((delegate* unmanaged<ISVGTransform, float, int>)((*lpVtbl)[17]))(this, angle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT setSkewY(float angle)
    {
        return ((delegate* unmanaged<ISVGTransform, float, int>)((*lpVtbl)[18]))(this, angle);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_type(short v);

        [VtblIndex(8)]
        HRESULT get_type(short* p);

        [VtblIndex(9)]
        HRESULT putref_matrix(ISVGMatrix v);

        [VtblIndex(10)]
        HRESULT get_matrix(ISVGMatrix* p);

        [VtblIndex(11)]
        HRESULT put_angle(float v);

        [VtblIndex(12)]
        HRESULT get_angle(float* p);

        [VtblIndex(13)]
        HRESULT setMatrix(ISVGMatrix matrix);

        [VtblIndex(14)]
        HRESULT setTranslate(float tx, float ty);

        [VtblIndex(15)]
        HRESULT setScale(float sx, float sy);

        [VtblIndex(16)]
        HRESULT setRotate(float angle, float cx, float cy);

        [VtblIndex(17)]
        HRESULT setSkewX(float angle);

        [VtblIndex(18)]
        HRESULT setSkewY(float angle);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_type;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_type;

        [NativeTypeName("HRESULT (ISVGMatrix *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix, int> putref_matrix;

        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix*, int> get_matrix;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_angle;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_angle;

        [NativeTypeName("HRESULT (ISVGMatrix *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix, int> setMatrix;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> setTranslate;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> setScale;

        [NativeTypeName("HRESULT (float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, int> setRotate;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> setSkewX;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> setSkewY;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGTransform(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTransform"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGTransform value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGTransform(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
