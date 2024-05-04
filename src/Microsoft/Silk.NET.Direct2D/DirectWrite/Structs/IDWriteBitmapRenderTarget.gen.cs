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

namespace Silk.NET.DirectWrite
{
    [Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267")]
    [NativeName("Name", "IDWriteBitmapRenderTarget")]
    public unsafe partial struct IDWriteBitmapRenderTarget : IComVtbl<IDWriteBitmapRenderTarget>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5e5a32a3-8dff-4773-9ff6-0696eab77267");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteBitmapRenderTarget val)
            => Unsafe.As<IDWriteBitmapRenderTarget, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteBitmapRenderTarget
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
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParamsPtr, textColor, blackBoxRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParamsPtr, textColor, blackBoxRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParams, textColor, blackBoxRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParams, textColor, blackBoxRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParamsPtr, textColor, blackBoxRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParamsPtr, textColor, blackBoxRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nint GetMemoryDC()
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, nint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetPixelsPerDip()
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelsPerDip(float pixelsPerDip)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, int>)@this->LpVtbl[6])(@this, pixelsPerDip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(Matrix* transform)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[7])(@this, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentTransform(ref Matrix transform)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[7])(@this, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCurrentTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[8])(@this, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[8])(@this, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(Silk.NET.Maths.Vector2D<int>* size)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[9])(@this, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref Silk.NET.Maths.Vector2D<int> size)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<int>* sizePtr = &size)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[9])(@this, sizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Resize(uint width, uint height)
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint, uint, int>)@this->LpVtbl[10])(@this, width, height);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ComPtr<TI0> renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, blackBoxRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ComPtr<TI0> renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, ref blackBoxRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, ComPtr<TI0> renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, blackBoxRect);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, ComPtr<TI0> renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, ref blackBoxRect);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteBitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
