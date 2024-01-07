// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Guid("2cd9069e-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1SimplifiedGeometrySink")]
    public unsafe partial struct ID2D1SimplifiedGeometrySink : IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2cd9069e-12e2-11dc-9fed-001143a055f9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SimplifiedGeometrySink val)
            => Unsafe.As<ID2D1SimplifiedGeometrySink, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SimplifiedGeometrySink
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetFillMode(FillMode fillMode)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, FillMode, void>)@this->LpVtbl[3])(@this, fillMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetSegmentFlags(PathSegment vertexFlags)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, PathSegment, void>)@this->LpVtbl[4])(@this, vertexFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginFigure(Silk.NET.Maths.Vector2D<float> startPoint, FigureBegin figureBegin)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Silk.NET.Maths.Vector2D<float>, FigureBegin, void>)@this->LpVtbl[5])(@this, startPoint, figureBegin);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddLines([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Silk.NET.Maths.Vector2D<float>*, uint, void>)@this->LpVtbl[6])(@this, points, pointsCount);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddLines([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> points, uint pointsCount)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<float>* pointsPtr = &points)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, Silk.NET.Maths.Vector2D<float>*, uint, void>)@this->LpVtbl[6])(@this, pointsPtr, pointsCount);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AddBeziers([Flow(Silk.NET.Core.Native.FlowDirection.In)] BezierSegment* beziers, uint beziersCount)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, BezierSegment*, uint, void>)@this->LpVtbl[7])(@this, beziers, beziersCount);
        }

        /// <summary>To be documented.</summary>
        public readonly void AddBeziers([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BezierSegment beziers, uint beziersCount)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BezierSegment* beziersPtr = &beziers)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, BezierSegment*, uint, void>)@this->LpVtbl[7])(@this, beziersPtr, beziersCount);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndFigure(FigureEnd figureEnd)
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, FigureEnd, void>)@this->LpVtbl[8])(@this, figureEnd);
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SimplifiedGeometrySink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
