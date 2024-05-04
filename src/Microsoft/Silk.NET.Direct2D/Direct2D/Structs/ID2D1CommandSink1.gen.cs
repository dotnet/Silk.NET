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
    [Guid("9eb767fd-4269-4467-b8c2-eb30cb305743")]
    [NativeName("Name", "ID2D1CommandSink1")]
    public unsafe partial struct ID2D1CommandSink1 : IComVtbl<ID2D1CommandSink1>, IComVtbl<ID2D1CommandSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9eb767fd-4269-4467-b8c2-eb30cb305743");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1CommandSink(ID2D1CommandSink1 val)
            => Unsafe.As<ID2D1CommandSink1, ID2D1CommandSink>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1CommandSink1 val)
            => Unsafe.As<ID2D1CommandSink1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1CommandSink1
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
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginDraw()
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndDraw()
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAntialiasMode(AntialiasMode antialiasMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, AntialiasMode, int>)@this->LpVtbl[5])(@this, antialiasMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTags(ulong tag1, ulong tag2)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ulong, ulong, int>)@this->LpVtbl[6])(@this, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, TextAntialiasMode, int>)@this->LpVtbl[7])(@this, textAntialiasMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, IDWriteRenderingParams*, int>)@this->LpVtbl[8])(@this, textRenderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[9])(@this, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[9])(@this, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrimitiveBlend(PrimitiveBlend primitiveBlend)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, PrimitiveBlend, int>)@this->LpVtbl[10])(@this, primitiveBlend);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetUnitMode(UnitMode unitMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, UnitMode, int>)@this->LpVtbl[11])(@this, unitMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clear([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[12])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Clear([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[12])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteGlyphRunDescription*, ID2D1Brush*, DwriteMeasuringMode, int>)@this->LpVtbl[13])(@this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteGlyphRunDescription*, ID2D1Brush*, DwriteMeasuringMode, int>)@this->LpVtbl[13])(@this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrushPtr, measuringMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brush, strokeWidth, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brush, strokeWidth, strokeStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brushPtr, strokeWidth, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brush, strokeWidth, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brush, strokeWidth, strokeStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brushPtr, strokeWidth, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brush, strokeWidth, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawBitmap(ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffset, imageRectangle, interpolationMode, compositeMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawImage(ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafile, targetOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafile, targetOffsetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGdiMetafile(ref ID2D1GdiMetafile gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafilePtr, targetOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGdiMetafile(ref ID2D1GdiMetafile gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafilePtr, targetOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, mesh, brush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillMesh(ID2D1Mesh* mesh, ref ID2D1Brush brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, mesh, brushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillMesh(ref ID2D1Mesh mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Mesh* meshPtr = &mesh)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, meshPtr, brush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FillMesh(ref ID2D1Mesh mesh, ref ID2D1Brush brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Mesh* meshPtr = &mesh)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, meshPtr, brushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectangle, sourceRectangle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectangle, sourceRectanglePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectanglePtr, sourceRectangle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectangle, sourceRectangle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectangle, sourceRectanglePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectanglePtr, sourceRectangle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectangle, sourceRectangle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectangle, sourceRectanglePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectanglePtr, sourceRectangle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectangle, sourceRectangle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectangle, sourceRectanglePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectanglePtr, sourceRectangle);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                    {
                        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectanglePtr, sourceRectanglePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brush, opacityBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brush, opacityBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brushPtr, opacityBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brushPtr, opacityBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brush, opacityBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brush, opacityBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, opacityBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, opacityBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rect, brush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rect, brushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rectPtr, brush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FillRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rectPtr, brushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushAxisAlignedClip([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, int>)@this->LpVtbl[24])(@this, clipRect, antialiasMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushAxisAlignedClip([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* clipRectPtr = &clipRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, int>)@this->LpVtbl[24])(@this, clipRectPtr, antialiasMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ID2D1Layer* layer)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1, layer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ref ID2D1Layer layer)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Layer* layerPtr = &layer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1, layerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LayerParameters1 layerParameters1, ID2D1Layer* layer)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LayerParameters1* layerParameters1Ptr = &layerParameters1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1Ptr, layer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LayerParameters1 layerParameters1, ref ID2D1Layer layer)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LayerParameters1* layerParameters1Ptr = &layerParameters1)
            {
                fixed (ID2D1Layer* layerPtr = &layer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1Ptr, layerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PopAxisAlignedClip()
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PopLayer()
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)@this->LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrimitiveBlend1(PrimitiveBlend primitiveBlend)
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, PrimitiveBlend, int>)@this->LpVtbl[28])(@this, primitiveBlend);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ComPtr<TI0> foregroundBrush, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(baselineOrigin, glyphRun, glyphRunDescription, (ID2D1Brush*) foregroundBrush.Handle, measuringMode);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawLine<TI0, TI1>(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawLine<TI0>(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawLine<TI0>(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawLine(point0, point1, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0, TI1, TI2>(ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ComPtr<TI2> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI2>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0, TI1>(ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0, TI1>(ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0>(ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, ref strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0, TI1>(ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0>(ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGeometry<TI0>(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGeometry(ref geometry, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawRectangle(rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawRectangle<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawRectangle(in rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawRectangle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawRectangle(in rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawRectangle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawRectangle(in rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, sourceRectangle, in perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, in sourceRectangle, perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, in sourceRectangle, in perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, sourceRectangle, in perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, in sourceRectangle, perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawBitmap<TI0>(ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, in sourceRectangle, in perspectiveTransform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage<TI0>(ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawImage((ID2D1Image*) image.Handle, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage<TI0>(ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawImage((ID2D1Image*) image.Handle, targetOffset, in imageRectangle, interpolationMode, compositeMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage<TI0>(ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawImage((ID2D1Image*) image.Handle, in targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawImage<TI0>(ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawImage((ID2D1Image*) image.Handle, in targetOffset, in imageRectangle, interpolationMode, compositeMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGdiMetafile<TI0>(ComPtr<TI0> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGdiMetafile((ID2D1GdiMetafile*) gdiMetafile.Handle, targetOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGdiMetafile<TI0>(ComPtr<TI0> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGdiMetafile((ID2D1GdiMetafile*) gdiMetafile.Handle, in targetOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillMesh<TI0, TI1>(ComPtr<TI0> mesh, ComPtr<TI1> brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillMesh((ID2D1Mesh*) mesh.Handle, (ID2D1Brush*) brush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillMesh<TI0>(ComPtr<TI0> mesh, ref ID2D1Brush brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillMesh((ID2D1Mesh*) mesh.Handle, ref brush);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillMesh<TI0>(ref ID2D1Mesh mesh, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillMesh(ref mesh, (ID2D1Brush*) brush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0, TI1>(ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0, TI1>(ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, destinationRectangle, in sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0, TI1>(ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, in destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillOpacityMask<TI0, TI1>(ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, in destinationRectangle, in sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0>(ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0>(ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, destinationRectangle, in sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0>(ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, in destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillOpacityMask<TI0>(ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, in destinationRectangle, in sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0>(ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0>(ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, destinationRectangle, in sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask<TI0>(ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, in destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillOpacityMask<TI0>(ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, in destinationRectangle, in sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0, TI1, TI2>(ComPtr<TI0> geometry, ComPtr<TI1> brush, ComPtr<TI2> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI2>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0, TI1>(ComPtr<TI0> geometry, ComPtr<TI1> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, ref opacityBrush);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0, TI1>(ComPtr<TI0> geometry, ref ID2D1Brush brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, (ID2D1Brush*) opacityBrush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0>(ComPtr<TI0> geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, ref opacityBrush);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0, TI1>(ref ID2D1Geometry geometry, ComPtr<TI0> brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0>(ref ID2D1Geometry geometry, ComPtr<TI0> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, ref opacityBrush);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillGeometry<TI0>(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ComPtr<TI0> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillGeometry(ref geometry, ref brush, (ID2D1Brush*) opacityBrush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillRectangle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillRectangle(rect, (ID2D1Brush*) brush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FillRectangle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FillRectangle(in rect, (ID2D1Brush*) brush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushLayer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->PushLayer(layerParameters1, (ID2D1Layer*) layer.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushLayer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LayerParameters1 layerParameters1, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->PushLayer(in layerParameters1, (ID2D1Layer*) layer.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1CommandSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
