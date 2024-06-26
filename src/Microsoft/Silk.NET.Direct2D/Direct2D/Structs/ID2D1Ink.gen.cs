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
    [Guid("b499923b-7029-478f-a8b3-432c7c5f5312")]
    [NativeName("Name", "ID2D1Ink")]
    public unsafe partial struct ID2D1Ink : IComVtbl<ID2D1Ink>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b499923b-7029-478f-a8b3-432c7c5f5312");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1Ink val)
            => Unsafe.As<ID2D1Ink, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Ink val)
            => Unsafe.As<ID2D1Ink, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Ink
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
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetStartPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkPoint* startPoint)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, void>)@this->LpVtbl[4])(@this, startPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetStartPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkPoint startPoint)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (InkPoint* startPointPtr = &startPoint)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, void>)@this->LpVtbl[4])(@this, startPointPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly InkPoint GetStartPoint()
        {
            InkPoint silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            InkPoint* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, InkPoint*>)@this->LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSegments([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segments, uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, uint, int>)@this->LpVtbl[6])(@this, segments, segmentsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddSegments([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkBezierSegment segments, uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkBezierSegment* segmentsPtr = &segments)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, uint, int>)@this->LpVtbl[6])(@this, segmentsPtr, segmentsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveSegmentsAtEnd(uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, int>)@this->LpVtbl[7])(@this, segmentsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSegments(uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segments, uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[8])(@this, startSegment, segments, segmentsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSegments(uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkBezierSegment segments, uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkBezierSegment* segmentsPtr = &segments)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[8])(@this, startSegment, segmentsPtr, segmentsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSegmentAtEnd([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segment)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, int>)@this->LpVtbl[9])(@this, segment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSegmentAtEnd([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkBezierSegment segment)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkBezierSegment* segmentPtr = &segment)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, int>)@this->LpVtbl[9])(@this, segmentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSegmentCount()
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSegments(uint startSegment, InkBezierSegment* segments, uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[11])(@this, startSegment, segments, segmentsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSegments(uint startSegment, ref InkBezierSegment segments, uint segmentsCount)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkBezierSegment* segmentsPtr = &segments)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[11])(@this, startSegment, segmentsPtr, segmentsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransform, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransform, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransformPtr, flatteningTolerance, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StreamAsGeometry(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransform, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransform, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransformPtr, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransformPtr, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransform, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransform, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransformPtr, bounds);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBounds(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransformPtr, boundsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry<TI0, TI1>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry<TI0>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, worldTransform, flatteningTolerance, ref geometrySink);
        }

        /// <summary>To be documented.</summary>
        public readonly int StreamAsGeometry<TI0, TI1>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int StreamAsGeometry<TI0>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, flatteningTolerance, ref geometrySink);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StreamAsGeometry<TI0>(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StreamAsGeometry(ref inkStyle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int StreamAsGeometry<TI0>(ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StreamAsGeometry(ref inkStyle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds<TI0>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, worldTransform, bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds<TI0>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, worldTransform, ref bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds<TI0>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBounds<TI0>(ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, ref bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
