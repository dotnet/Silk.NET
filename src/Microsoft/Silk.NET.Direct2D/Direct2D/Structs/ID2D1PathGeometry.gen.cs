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
    [Guid("2cd906a5-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1PathGeometry")]
    public unsafe partial struct ID2D1PathGeometry : IComVtbl<ID2D1PathGeometry>, IComVtbl<ID2D1Geometry>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2cd906a5-12e2-11dc-9fed-001143a055f9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Geometry(ID2D1PathGeometry val)
            => Unsafe.As<ID2D1PathGeometry, ID2D1Geometry>(ref val);

        public static implicit operator ID2D1Resource(ID2D1PathGeometry val)
            => Unsafe.As<ID2D1PathGeometry, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1PathGeometry val)
            => Unsafe.As<ID2D1PathGeometry, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1PathGeometry
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
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransform, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, contains);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* area)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransform, flatteningTolerance, area);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* length)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransform, flatteningTolerance, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVector);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(ID2D1GeometrySink** geometrySink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, ID2D1GeometrySink**, int>)@this->LpVtbl[17])(@this, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Stream(ID2D1GeometrySink* geometrySink)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, ID2D1GeometrySink*, int>)@this->LpVtbl[18])(@this, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSegmentCount(uint* count)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, uint*, int>)@this->LpVtbl[19])(@this, count);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFigureCount(uint* count)
        {
            var @this = (ID2D1PathGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry*, uint*, int>)@this->LpVtbl[20])(@this, count);
            return ret;
        }

    }
}
