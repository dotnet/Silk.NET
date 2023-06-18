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
    [Guid("c78a6519-40d6-4218-b2de-beeeb744bb3e")]
    [NativeName("Name", "ID2D1CommandSink4")]
    public unsafe partial struct ID2D1CommandSink4 : IComVtbl<ID2D1CommandSink4>, IComVtbl<ID2D1CommandSink3>, IComVtbl<ID2D1CommandSink2>, IComVtbl<ID2D1CommandSink1>, IComVtbl<ID2D1CommandSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c78a6519-40d6-4218-b2de-beeeb744bb3e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1CommandSink3(ID2D1CommandSink4 val)
            => Unsafe.As<ID2D1CommandSink4, ID2D1CommandSink3>(ref val);

        public static implicit operator ID2D1CommandSink2(ID2D1CommandSink4 val)
            => Unsafe.As<ID2D1CommandSink4, ID2D1CommandSink2>(ref val);

        public static implicit operator ID2D1CommandSink1(ID2D1CommandSink4 val)
            => Unsafe.As<ID2D1CommandSink4, ID2D1CommandSink1>(ref val);

        public static implicit operator ID2D1CommandSink(ID2D1CommandSink4 val)
            => Unsafe.As<ID2D1CommandSink4, ID2D1CommandSink>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1CommandSink4 val)
            => Unsafe.As<ID2D1CommandSink4, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1CommandSink4
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
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginDraw()
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndDraw()
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAntialiasMode(AntialiasMode antialiasMode)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, AntialiasMode, int>)@this->LpVtbl[5])(@this, antialiasMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTags(ulong tag1, ulong tag2)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ulong, ulong, int>)@this->LpVtbl[6])(@this, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, TextAntialiasMode, int>)@this->LpVtbl[7])(@this, textAntialiasMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, IDWriteRenderingParams*, int>)@this->LpVtbl[8])(@this, textRenderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[9])(@this, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrimitiveBlend(PrimitiveBlend primitiveBlend)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, PrimitiveBlend, int>)@this->LpVtbl[10])(@this, primitiveBlend);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetUnitMode(UnitMode unitMode)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, UnitMode, int>)@this->LpVtbl[11])(@this, unitMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clear([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[12])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteGlyphRunDescription*, ID2D1Brush*, DwriteMeasuringMode, int>)@this->LpVtbl[13])(@this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brush, strokeWidth, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brush, strokeWidth, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawBitmap(ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawImage(ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafile, targetOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, mesh, brush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectangle, sourceRectangle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brush, opacityBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rect, brush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushAxisAlignedClip([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, int>)@this->LpVtbl[24])(@this, clipRect, antialiasMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ID2D1Layer* layer)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1, layer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PopAxisAlignedClip()
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PopLayer()
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrimitiveBlend1(PrimitiveBlend primitiveBlend)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, PrimitiveBlend, int>)@this->LpVtbl[28])(@this, primitiveBlend);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInk(ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, ink, brush, inkStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGradientMesh(ID2D1GradientMesh* gradientMesh)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GradientMesh*, int>)@this->LpVtbl[30])(@this, gradientMesh);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawSpriteBatch(ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, int>)@this->LpVtbl[32])(@this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrimitiveBlend2(PrimitiveBlend primitiveBlend)
        {
            var @this = (ID2D1CommandSink4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, PrimitiveBlend, int>)@this->LpVtbl[33])(@this, primitiveBlend);
            return ret;
        }

    }
}
