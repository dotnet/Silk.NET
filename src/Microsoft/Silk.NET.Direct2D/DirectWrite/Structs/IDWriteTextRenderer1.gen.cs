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
    [Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1")]
    [NativeName("Name", "IDWriteTextRenderer1")]
    public unsafe partial struct IDWriteTextRenderer1 : IComVtbl<IDWriteTextRenderer1>, IComVtbl<IDWriteTextRenderer>, IComVtbl<IDWritePixelSnapping>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d3e0e934-22a0-427e-aae4-7d9574b59db1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextRenderer(IDWriteTextRenderer1 val)
            => Unsafe.As<IDWriteTextRenderer1, IDWriteTextRenderer>(ref val);

        public static implicit operator IDWritePixelSnapping(IDWriteTextRenderer1 val)
            => Unsafe.As<IDWriteTextRenderer1, IDWritePixelSnapping>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextRenderer1 val)
            => Unsafe.As<IDWriteTextRenderer1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextRenderer1
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
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled(void* clientDrawingContext, int* isDisabled)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled(void* clientDrawingContext, ref int isDisabled)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isDisabledPtr = &isDisabled)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabledPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled<T0>(ref T0 clientDrawingContext, int* isDisabled) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabled);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsPixelSnappingDisabled<T0>(ref T0 clientDrawingContext, ref int isDisabled) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (int* isDisabledPtr = &isDisabled)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabledPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(void* clientDrawingContext, Matrix* transform)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(void* clientDrawingContext, ref Matrix transform)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform<T0>(ref T0 clientDrawingContext, Matrix* transform) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentTransform<T0>(ref T0 clientDrawingContext, ref Matrix transform) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip(void* clientDrawingContext, ref float pixelsPerDip)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pixelsPerDipPtr = &pixelsPerDip)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDipPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip<T0>(ref T0 clientDrawingContext, float* pixelsPerDip) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDip);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelsPerDip<T0>(ref T0 clientDrawingContext, ref float pixelsPerDip) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (float* pixelsPerDipPtr = &pixelsPerDip)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDipPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescriptionPtr, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescriptionPtr, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescription, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescription, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescriptionPtr, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescriptionPtr, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescriptionPtr, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescriptionPtr, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (GlyphRun* glyphRunPtr = &glyphRun)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescription, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (GlyphRun* glyphRunPtr = &glyphRun)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescription, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (GlyphRun* glyphRunPtr = &glyphRun)
                {
                    fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescriptionPtr, clientDrawingEffect);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGlyphRun<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (GlyphRun* glyphRunPtr = &glyphRun)
                {
                    fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescriptionPtr, clientDrawingEffectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Underline* underlinePtr = &underline)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underlinePtr, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Underline* underlinePtr = &underline)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underlinePtr, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, underline, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Underline* underlinePtr = &underline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, underlinePtr, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawUnderline<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Underline* underlinePtr = &underline)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, underlinePtr, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Strikethrough* strikethroughPtr = &strikethrough)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethroughPtr, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Strikethrough* strikethroughPtr = &strikethrough)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethroughPtr, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Strikethrough* strikethroughPtr = &strikethrough)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, strikethroughPtr, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawStrikethrough<T0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Strikethrough* strikethroughPtr = &strikethrough)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, strikethroughPtr, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject(void* clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObjectPtr, isSideways, isRightToLeft, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject(void* clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObjectPtr, isSideways, isRightToLeft, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject<T0>(ref T0 clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContextPtr, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject<T0>(ref T0 clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContextPtr, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject<T0>(ref T0 clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContextPtr, originX, originY, inlineObjectPtr, isSideways, isRightToLeft, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawInlineObject<T0>(ref T0 clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContextPtr, originX, originY, inlineObjectPtr, isSideways, isRightToLeft, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawGlyphRun<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, in underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawUnderline(ref clientDrawingContext, baselineOriginX, baselineOriginY, underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawUnderline<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawUnderline(ref clientDrawingContext, baselineOriginX, baselineOriginY, in underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough<TI0>(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, in strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawStrikethrough(ref clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawStrikethrough<T0, TI0>(ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawStrikethrough(ref clientDrawingContext, baselineOriginX, baselineOriginY, in strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject<TI0, TI1>(void* clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawInlineObject(clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject<TI0>(void* clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawInlineObject(clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, ref clientDrawingEffect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject<TI0>(void* clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawInlineObject(clientDrawingContext, originX, originY, ref inlineObject, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawInlineObject<T0, TI0, TI1>(ref T0 clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawInlineObject(ref clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawInlineObject<T0, TI0>(ref T0 clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawInlineObject(ref clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, ref clientDrawingEffect);
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawInlineObject<T0, TI0>(ref T0 clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DrawInlineObject(ref clientDrawingContext, originX, originY, ref inlineObject, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
