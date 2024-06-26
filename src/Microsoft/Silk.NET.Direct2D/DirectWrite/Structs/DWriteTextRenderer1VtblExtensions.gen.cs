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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteTextRenderer1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDWriteTextRenderer1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextRenderer1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, int* isDisabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, ref int isDisabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isDisabledPtr = &isDisabled)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabledPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, int* isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabled);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsPixelSnappingDisabled<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, ref int isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetCurrentTransform(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, ref Matrix transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, Matrix* transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTransform<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, ref Matrix transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float* pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, ref float pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pixelsPerDipPtr = &pixelsPerDip)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDipPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float* pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDip);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelsPerDip<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, ref float pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescriptionPtr, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, glyphRunDescription, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Underline* underlinePtr = &underline)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underlinePtr, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Strikethrough* strikethroughPtr = &strikethrough)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethroughPtr, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContextPtr, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObjectPtr, isSideways, isRightToLeft, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContextPtr, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int QueryInterface<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, Span<int> isDisabled)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsPixelSnappingDisabled(clientDrawingContext, ref isDisabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, int* isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsPixelSnappingDisabled(ref clientDrawingContext.GetPinnableReference(), isDisabled);
    }

    /// <summary>To be documented.</summary>
    public static int IsPixelSnappingDisabled<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, Span<int> isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsPixelSnappingDisabled(ref clientDrawingContext.GetPinnableReference(), ref isDisabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, Span<Matrix> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(clientDrawingContext, ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, Matrix* transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(ref clientDrawingContext.GetPinnableReference(), transform);
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTransform<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, Span<Matrix> transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(ref clientDrawingContext.GetPinnableReference(), ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, Span<float> pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelsPerDip(clientDrawingContext, ref pixelsPerDip.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float* pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelsPerDip(ref clientDrawingContext.GetPinnableReference(), pixelsPerDip);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelsPerDip<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, Span<float> pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelsPerDip(ref clientDrawingContext.GetPinnableReference(), ref pixelsPerDip.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), glyphRunDescription, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), glyphRunDescription, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, glyphRun, in glyphRunDescription.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), glyphRunDescription, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), glyphRunDescription, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGlyphRun<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, in glyphRun, in glyphRunDescription, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGlyphRun<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, underline, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Underline> underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, in underline.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, in underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Underline> underline, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(clientDrawingContext, baselineOriginX, baselineOriginY, in underline.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawUnderline(ref clientDrawingContext, baselineOriginX, baselineOriginY, underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, underline, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Underline> underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, in underline.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int DrawUnderline<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Underline underline, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawUnderline(ref clientDrawingContext, baselineOriginX, baselineOriginY, in underline, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawUnderline<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Underline> underline, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawUnderline(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, in underline.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Strikethrough> strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, in strikethrough.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, in strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Strikethrough> strikethrough, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(clientDrawingContext, baselineOriginX, baselineOriginY, in strikethrough.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawStrikethrough(ref clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, strikethrough, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Strikethrough> strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, in strikethrough.GetPinnableReference(), clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int DrawStrikethrough<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Strikethrough strikethrough, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawStrikethrough(ref clientDrawingContext, baselineOriginX, baselineOriginY, in strikethrough, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawStrikethrough<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Strikethrough> strikethrough, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawStrikethrough(ref clientDrawingContext.GetPinnableReference(), baselineOriginX, baselineOriginY, in strikethrough.GetPinnableReference(), ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<TI0, TI1>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInlineObject(clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInlineObject(clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, ref clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, Span<IDWriteInlineObject> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(clientDrawingContext, originX, originY, ref inlineObject.GetPinnableReference(), isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInlineObject(clientDrawingContext, originX, originY, ref inlineObject, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer1> thisVtbl, void* clientDrawingContext, float originX, float originY, Span<IDWriteInlineObject> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(clientDrawingContext, originX, originY, ref inlineObject.GetPinnableReference(), isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(ref clientDrawingContext.GetPinnableReference(), originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInlineObject<T0, TI0, TI1>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInlineObject(ref clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(ref clientDrawingContext.GetPinnableReference(), originX, originY, inlineObject, isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawInlineObject<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, ComPtr<TI0> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInlineObject(ref clientDrawingContext, originX, originY, (IDWriteInlineObject*) inlineObject.Handle, isSideways, isRightToLeft, ref clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float originX, float originY, Span<IDWriteInlineObject> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(ref clientDrawingContext.GetPinnableReference(), originX, originY, ref inlineObject.GetPinnableReference(), isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInlineObject<T0, TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, ref T0 clientDrawingContext, float originX, float originY, ref IDWriteInlineObject inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInlineObject(ref clientDrawingContext, originX, originY, ref inlineObject, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInlineObject<T0>(this ComPtr<IDWriteTextRenderer1> thisVtbl, Span<T0> clientDrawingContext, float originX, float originY, Span<IDWriteInlineObject> inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInlineObject(ref clientDrawingContext.GetPinnableReference(), originX, originY, ref inlineObject.GetPinnableReference(), isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteTextRenderer1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
