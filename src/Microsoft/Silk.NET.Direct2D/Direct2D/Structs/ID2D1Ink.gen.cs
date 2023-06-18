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
        public readonly unsafe void SetStartPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkPoint* startPoint)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, void>)@this->LpVtbl[4])(@this, startPoint);
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
        public readonly unsafe int SetSegmentAtEnd([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segment)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, int>)@this->LpVtbl[9])(@this, segment);
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
        public readonly unsafe int StreamAsGeometry(ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Ink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransform, flatteningTolerance, geometrySink);
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

    }
}
