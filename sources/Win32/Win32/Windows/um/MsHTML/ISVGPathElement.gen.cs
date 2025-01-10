// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510512-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGPathElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGPathElement : ISVGPathElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGPathElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGPathElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISVGPathElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGPathElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGPathElement, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<ISVGPathElement, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISVGPathElement, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISVGPathElement,
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
    public HRESULT putref_pathLength(ISVGAnimatedNumber v)
    {
        return ((delegate* unmanaged<ISVGPathElement, ISVGAnimatedNumber, int>)((*lpVtbl)[7]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_pathLength(ISVGAnimatedNumber* p)
    {
        return ((delegate* unmanaged<ISVGPathElement, ISVGAnimatedNumber*, int>)((*lpVtbl)[8]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT getTotalLength(float* pfltResult)
    {
        return ((delegate* unmanaged<ISVGPathElement, float*, int>)((*lpVtbl)[9]))(
            this,
            pfltResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getPointAtLength(float fltdistance, ISVGPoint* ppPointResult)
    {
        return ((delegate* unmanaged<ISVGPathElement, float, ISVGPoint*, int>)((*lpVtbl)[10]))(
            this,
            fltdistance,
            ppPointResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getPathSegAtLength(float fltdistance, [NativeTypeName("long *")] int* plResult)
    {
        return ((delegate* unmanaged<ISVGPathElement, float, int*, int>)((*lpVtbl)[11]))(
            this,
            fltdistance,
            plResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT createSVGPathSegClosePath(ISVGPathSegClosePath* ppResult)
    {
        return ((delegate* unmanaged<ISVGPathElement, ISVGPathSegClosePath*, int>)((*lpVtbl)[12]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT createSVGPathSegMovetoAbs(float x, float y, ISVGPathSegMovetoAbs* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, float, ISVGPathSegMovetoAbs*, int>)(
                (*lpVtbl)[13]
            )
        )(this, x, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT createSVGPathSegMovetoRel(float x, float y, ISVGPathSegMovetoRel* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, float, ISVGPathSegMovetoRel*, int>)(
                (*lpVtbl)[14]
            )
        )(this, x, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT createSVGPathSegLinetoAbs(float x, float y, ISVGPathSegLinetoAbs* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, float, ISVGPathSegLinetoAbs*, int>)(
                (*lpVtbl)[15]
            )
        )(this, x, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT createSVGPathSegLinetoRel(float x, float y, ISVGPathSegLinetoRel* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, float, ISVGPathSegLinetoRel*, int>)(
                (*lpVtbl)[16]
            )
        )(this, x, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT createSVGPathSegCurvetoCubicAbs(
        float x,
        float y,
        float x1,
        float y1,
        float x2,
        float y2,
        ISVGPathSegCurvetoCubicAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                float,
                float,
                ISVGPathSegCurvetoCubicAbs*,
                int>)((*lpVtbl)[17])
        )(this, x, y, x1, y1, x2, y2, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT createSVGPathSegCurvetoCubicRel(
        float x,
        float y,
        float x1,
        float y1,
        float x2,
        float y2,
        ISVGPathSegCurvetoCubicRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                float,
                float,
                ISVGPathSegCurvetoCubicRel*,
                int>)((*lpVtbl)[18])
        )(this, x, y, x1, y1, x2, y2, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT createSVGPathSegCurvetoQuadraticAbs(
        float x,
        float y,
        float x1,
        float y1,
        ISVGPathSegCurvetoQuadraticAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                ISVGPathSegCurvetoQuadraticAbs*,
                int>)((*lpVtbl)[19])
        )(this, x, y, x1, y1, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT createSVGPathSegCurvetoQuadraticRel(
        float x,
        float y,
        float x1,
        float y1,
        ISVGPathSegCurvetoQuadraticRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                ISVGPathSegCurvetoQuadraticRel*,
                int>)((*lpVtbl)[20])
        )(this, x, y, x1, y1, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT createSVGPathSegArcAbs(
        float x,
        float y,
        float r1,
        float r2,
        float angle,
        [NativeTypeName("VARIANT_BOOL")] short largeArcFlag,
        [NativeTypeName("VARIANT_BOOL")] short sweepFlag,
        ISVGPathSegArcAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                float,
                short,
                short,
                ISVGPathSegArcAbs*,
                int>)((*lpVtbl)[21])
        )(this, x, y, r1, r2, angle, largeArcFlag, sweepFlag, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT createSVGPathSegArcRel(
        float x,
        float y,
        float r1,
        float r2,
        float angle,
        [NativeTypeName("VARIANT_BOOL")] short largeArcFlag,
        [NativeTypeName("VARIANT_BOOL")] short sweepFlag,
        ISVGPathSegArcRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                float,
                short,
                short,
                ISVGPathSegArcRel*,
                int>)((*lpVtbl)[22])
        )(this, x, y, r1, r2, angle, largeArcFlag, sweepFlag, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT createSVGPathSegLinetoHorizontalAbs(
        float x,
        ISVGPathSegLinetoHorizontalAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, ISVGPathSegLinetoHorizontalAbs*, int>)(
                (*lpVtbl)[23]
            )
        )(this, x, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT createSVGPathSegLinetoHorizontalRel(
        float x,
        ISVGPathSegLinetoHorizontalRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, ISVGPathSegLinetoHorizontalRel*, int>)(
                (*lpVtbl)[24]
            )
        )(this, x, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT createSVGPathSegLinetoVerticalAbs(
        float y,
        ISVGPathSegLinetoVerticalAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, ISVGPathSegLinetoVerticalAbs*, int>)(
                (*lpVtbl)[25]
            )
        )(this, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT createSVGPathSegLinetoVerticalRel(
        float y,
        ISVGPathSegLinetoVerticalRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISVGPathElement, float, ISVGPathSegLinetoVerticalRel*, int>)(
                (*lpVtbl)[26]
            )
        )(this, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT createSVGPathSegCurvetoCubicSmoothAbs(
        float x,
        float y,
        float x2,
        float y2,
        ISVGPathSegCurvetoCubicSmoothAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                ISVGPathSegCurvetoCubicSmoothAbs*,
                int>)((*lpVtbl)[27])
        )(this, x, y, x2, y2, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT createSVGPathSegCurvetoCubicSmoothRel(
        float x,
        float y,
        float x2,
        float y2,
        ISVGPathSegCurvetoCubicSmoothRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                float,
                float,
                ISVGPathSegCurvetoCubicSmoothRel*,
                int>)((*lpVtbl)[28])
        )(this, x, y, x2, y2, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT createSVGPathSegCurvetoQuadraticSmoothAbs(
        float x,
        float y,
        ISVGPathSegCurvetoQuadraticSmoothAbs* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                ISVGPathSegCurvetoQuadraticSmoothAbs*,
                int>)((*lpVtbl)[29])
        )(this, x, y, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT createSVGPathSegCurvetoQuadraticSmoothRel(
        float x,
        float y,
        ISVGPathSegCurvetoQuadraticSmoothRel* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                ISVGPathElement,
                float,
                float,
                ISVGPathSegCurvetoQuadraticSmoothRel*,
                int>)((*lpVtbl)[30])
        )(this, x, y, ppResult);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_pathLength(ISVGAnimatedNumber v);

        [VtblIndex(8)]
        HRESULT get_pathLength(ISVGAnimatedNumber* p);

        [VtblIndex(9)]
        HRESULT getTotalLength(float* pfltResult);

        [VtblIndex(10)]
        HRESULT getPointAtLength(float fltdistance, ISVGPoint* ppPointResult);

        [VtblIndex(11)]
        HRESULT getPathSegAtLength(float fltdistance, [NativeTypeName("long *")] int* plResult);

        [VtblIndex(12)]
        HRESULT createSVGPathSegClosePath(ISVGPathSegClosePath* ppResult);

        [VtblIndex(13)]
        HRESULT createSVGPathSegMovetoAbs(float x, float y, ISVGPathSegMovetoAbs* ppResult);

        [VtblIndex(14)]
        HRESULT createSVGPathSegMovetoRel(float x, float y, ISVGPathSegMovetoRel* ppResult);

        [VtblIndex(15)]
        HRESULT createSVGPathSegLinetoAbs(float x, float y, ISVGPathSegLinetoAbs* ppResult);

        [VtblIndex(16)]
        HRESULT createSVGPathSegLinetoRel(float x, float y, ISVGPathSegLinetoRel* ppResult);

        [VtblIndex(17)]
        HRESULT createSVGPathSegCurvetoCubicAbs(
            float x,
            float y,
            float x1,
            float y1,
            float x2,
            float y2,
            ISVGPathSegCurvetoCubicAbs* ppResult
        );

        [VtblIndex(18)]
        HRESULT createSVGPathSegCurvetoCubicRel(
            float x,
            float y,
            float x1,
            float y1,
            float x2,
            float y2,
            ISVGPathSegCurvetoCubicRel* ppResult
        );

        [VtblIndex(19)]
        HRESULT createSVGPathSegCurvetoQuadraticAbs(
            float x,
            float y,
            float x1,
            float y1,
            ISVGPathSegCurvetoQuadraticAbs* ppResult
        );

        [VtblIndex(20)]
        HRESULT createSVGPathSegCurvetoQuadraticRel(
            float x,
            float y,
            float x1,
            float y1,
            ISVGPathSegCurvetoQuadraticRel* ppResult
        );

        [VtblIndex(21)]
        HRESULT createSVGPathSegArcAbs(
            float x,
            float y,
            float r1,
            float r2,
            float angle,
            [NativeTypeName("VARIANT_BOOL")] short largeArcFlag,
            [NativeTypeName("VARIANT_BOOL")] short sweepFlag,
            ISVGPathSegArcAbs* ppResult
        );

        [VtblIndex(22)]
        HRESULT createSVGPathSegArcRel(
            float x,
            float y,
            float r1,
            float r2,
            float angle,
            [NativeTypeName("VARIANT_BOOL")] short largeArcFlag,
            [NativeTypeName("VARIANT_BOOL")] short sweepFlag,
            ISVGPathSegArcRel* ppResult
        );

        [VtblIndex(23)]
        HRESULT createSVGPathSegLinetoHorizontalAbs(
            float x,
            ISVGPathSegLinetoHorizontalAbs* ppResult
        );

        [VtblIndex(24)]
        HRESULT createSVGPathSegLinetoHorizontalRel(
            float x,
            ISVGPathSegLinetoHorizontalRel* ppResult
        );

        [VtblIndex(25)]
        HRESULT createSVGPathSegLinetoVerticalAbs(float y, ISVGPathSegLinetoVerticalAbs* ppResult);

        [VtblIndex(26)]
        HRESULT createSVGPathSegLinetoVerticalRel(float y, ISVGPathSegLinetoVerticalRel* ppResult);

        [VtblIndex(27)]
        HRESULT createSVGPathSegCurvetoCubicSmoothAbs(
            float x,
            float y,
            float x2,
            float y2,
            ISVGPathSegCurvetoCubicSmoothAbs* ppResult
        );

        [VtblIndex(28)]
        HRESULT createSVGPathSegCurvetoCubicSmoothRel(
            float x,
            float y,
            float x2,
            float y2,
            ISVGPathSegCurvetoCubicSmoothRel* ppResult
        );

        [VtblIndex(29)]
        HRESULT createSVGPathSegCurvetoQuadraticSmoothAbs(
            float x,
            float y,
            ISVGPathSegCurvetoQuadraticSmoothAbs* ppResult
        );

        [VtblIndex(30)]
        HRESULT createSVGPathSegCurvetoQuadraticSmoothRel(
            float x,
            float y,
            ISVGPathSegCurvetoQuadraticSmoothRel* ppResult
        );
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

        [NativeTypeName("HRESULT (ISVGAnimatedNumber *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedNumber, int> putref_pathLength;

        [NativeTypeName("HRESULT (ISVGAnimatedNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedNumber*, int> get_pathLength;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> getTotalLength;

        [NativeTypeName("HRESULT (float, ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ISVGPoint*, int> getPointAtLength;

        [NativeTypeName("HRESULT (float, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int*, int> getPathSegAtLength;

        [NativeTypeName("HRESULT (ISVGPathSegClosePath **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPathSegClosePath*, int> createSVGPathSegClosePath;

        [NativeTypeName("HRESULT (float, float, ISVGPathSegMovetoAbs **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            ISVGPathSegMovetoAbs*,
            int> createSVGPathSegMovetoAbs;

        [NativeTypeName("HRESULT (float, float, ISVGPathSegMovetoRel **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            ISVGPathSegMovetoRel*,
            int> createSVGPathSegMovetoRel;

        [NativeTypeName("HRESULT (float, float, ISVGPathSegLinetoAbs **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            ISVGPathSegLinetoAbs*,
            int> createSVGPathSegLinetoAbs;

        [NativeTypeName("HRESULT (float, float, ISVGPathSegLinetoRel **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            ISVGPathSegLinetoRel*,
            int> createSVGPathSegLinetoRel;

        [NativeTypeName(
            "HRESULT (float, float, float, float, float, float, ISVGPathSegCurvetoCubicAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            float,
            ISVGPathSegCurvetoCubicAbs*,
            int> createSVGPathSegCurvetoCubicAbs;

        [NativeTypeName(
            "HRESULT (float, float, float, float, float, float, ISVGPathSegCurvetoCubicRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            float,
            ISVGPathSegCurvetoCubicRel*,
            int> createSVGPathSegCurvetoCubicRel;

        [NativeTypeName(
            "HRESULT (float, float, float, float, ISVGPathSegCurvetoQuadraticAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            ISVGPathSegCurvetoQuadraticAbs*,
            int> createSVGPathSegCurvetoQuadraticAbs;

        [NativeTypeName(
            "HRESULT (float, float, float, float, ISVGPathSegCurvetoQuadraticRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            ISVGPathSegCurvetoQuadraticRel*,
            int> createSVGPathSegCurvetoQuadraticRel;

        [NativeTypeName(
            "HRESULT (float, float, float, float, float, VARIANT_BOOL, VARIANT_BOOL, ISVGPathSegArcAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            short,
            short,
            ISVGPathSegArcAbs*,
            int> createSVGPathSegArcAbs;

        [NativeTypeName(
            "HRESULT (float, float, float, float, float, VARIANT_BOOL, VARIANT_BOOL, ISVGPathSegArcRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            short,
            short,
            ISVGPathSegArcRel*,
            int> createSVGPathSegArcRel;

        [NativeTypeName(
            "HRESULT (float, ISVGPathSegLinetoHorizontalAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ISVGPathSegLinetoHorizontalAbs*,
            int> createSVGPathSegLinetoHorizontalAbs;

        [NativeTypeName(
            "HRESULT (float, ISVGPathSegLinetoHorizontalRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ISVGPathSegLinetoHorizontalRel*,
            int> createSVGPathSegLinetoHorizontalRel;

        [NativeTypeName(
            "HRESULT (float, ISVGPathSegLinetoVerticalAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ISVGPathSegLinetoVerticalAbs*,
            int> createSVGPathSegLinetoVerticalAbs;

        [NativeTypeName(
            "HRESULT (float, ISVGPathSegLinetoVerticalRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ISVGPathSegLinetoVerticalRel*,
            int> createSVGPathSegLinetoVerticalRel;

        [NativeTypeName(
            "HRESULT (float, float, float, float, ISVGPathSegCurvetoCubicSmoothAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            ISVGPathSegCurvetoCubicSmoothAbs*,
            int> createSVGPathSegCurvetoCubicSmoothAbs;

        [NativeTypeName(
            "HRESULT (float, float, float, float, ISVGPathSegCurvetoCubicSmoothRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            ISVGPathSegCurvetoCubicSmoothRel*,
            int> createSVGPathSegCurvetoCubicSmoothRel;

        [NativeTypeName(
            "HRESULT (float, float, ISVGPathSegCurvetoQuadraticSmoothAbs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            ISVGPathSegCurvetoQuadraticSmoothAbs*,
            int> createSVGPathSegCurvetoQuadraticSmoothAbs;

        [NativeTypeName(
            "HRESULT (float, float, ISVGPathSegCurvetoQuadraticSmoothRel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            ISVGPathSegCurvetoQuadraticSmoothRel*,
            int> createSVGPathSegCurvetoQuadraticSmoothRel;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGPathElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGPathElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGPathElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGPathElement(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGPathElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGPathElement"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGPathElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGPathElement value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGPathElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGPathElement(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGPathElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGPathElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGPathElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGPathElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
