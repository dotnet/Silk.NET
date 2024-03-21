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

public unsafe static class DWriteGlyphRunAnalysisVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaTextureBounds(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, Silk.NET.Maths.Box2D<int>* textureBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, textureType, textureBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAlphaTextureBounds(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, ref Silk.NET.Maths.Box2D<int> textureBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* textureBoundsPtr = &textureBounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, textureType, textureBoundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, byte* alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValues, bufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, ref byte alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* alphaValuesPtr = &alphaValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValuesPtr, bufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var alphaValuesPtr = (byte*) SilkMarshal.StringToPtr(alphaValues, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValuesPtr, bufferSize);
        SilkMarshal.Free((nint)alphaValuesPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> textureBounds, byte* alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* textureBoundsPtr = &textureBounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBoundsPtr, alphaValues, bufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> textureBounds, ref byte alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* textureBoundsPtr = &textureBounds)
        {
            fixed (byte* alphaValuesPtr = &alphaValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBoundsPtr, alphaValuesPtr, bufferSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> textureBounds, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* textureBoundsPtr = &textureBounds)
        {
        var alphaValuesPtr = (byte*) SilkMarshal.StringToPtr(alphaValues, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBoundsPtr, alphaValuesPtr, bufferSize);
        SilkMarshal.Free((nint)alphaValuesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrastPtr, blendClearTypeLevel);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
        {
            fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrastPtr, blendClearTypeLevelPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, ref float blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendGammaPtr = &blendGamma)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGammaPtr, blendEnhancedContrast, blendClearTypeLevel);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, ref float blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendGammaPtr = &blendGamma)
        {
            fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGammaPtr, blendEnhancedContrast, blendClearTypeLevelPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, ref float blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendGammaPtr = &blendGamma)
        {
            fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGammaPtr, blendEnhancedContrastPtr, blendClearTypeLevel);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, ref float blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* blendGammaPtr = &blendGamma)
        {
            fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
            {
                fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGammaPtr, blendEnhancedContrastPtr, blendClearTypeLevelPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, float* blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGamma, blendEnhancedContrast, blendClearTypeLevelPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, float* blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGamma, blendEnhancedContrastPtr, blendClearTypeLevel);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, float* blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
            {
                fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGamma, blendEnhancedContrastPtr, blendClearTypeLevelPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, ref float blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendGammaPtr = &blendGamma)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGammaPtr, blendEnhancedContrast, blendClearTypeLevel);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, ref float blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendGammaPtr = &blendGamma)
            {
                fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGammaPtr, blendEnhancedContrast, blendClearTypeLevelPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, ref float blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendGammaPtr = &blendGamma)
            {
                fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGammaPtr, blendEnhancedContrastPtr, blendClearTypeLevel);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ref IDWriteRenderingParams renderingParams, ref float blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (float* blendGammaPtr = &blendGamma)
            {
                fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
                {
                    fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGammaPtr, blendEnhancedContrastPtr, blendClearTypeLevelPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAlphaTextureBounds(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, Span<Silk.NET.Maths.Box2D<int>> textureBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaTextureBounds(textureType, ref textureBounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, Span<byte> alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateAlphaTexture(textureType, textureBounds, ref alphaValues.GetPinnableReference(), bufferSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> textureBounds, byte* alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateAlphaTexture(textureType, in textureBounds.GetPinnableReference(), alphaValues, bufferSize);
    }

    /// <summary>To be documented.</summary>
    public static int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> textureBounds, Span<byte> alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateAlphaTexture(textureType, in textureBounds.GetPinnableReference(), ref alphaValues.GetPinnableReference(), bufferSize);
    }

    /// <summary>To be documented.</summary>
    public static int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> textureBounds, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateAlphaTexture(textureType, in textureBounds.GetPinnableReference(), alphaValues, bufferSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, blendGamma, blendEnhancedContrast, ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, float* blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, blendEnhancedContrast, ref blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, Span<float> blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, blendGamma, ref blendEnhancedContrast.GetPinnableReference(), blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, float* blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, ref blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, Span<float> blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, blendGamma, ref blendEnhancedContrast.GetPinnableReference(), ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, float* blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, ref blendEnhancedContrast, ref blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, Span<float> blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, ref blendGamma.GetPinnableReference(), blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, ref float blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, Span<float> blendGamma, float* blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, ref blendGamma.GetPinnableReference(), blendEnhancedContrast, ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, ref float blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, blendEnhancedContrast, ref blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, Span<float> blendGamma, Span<float> blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, ref blendGamma.GetPinnableReference(), ref blendEnhancedContrast.GetPinnableReference(), blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, ref float blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, ref blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, Span<float> blendGamma, Span<float> blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(renderingParams, ref blendGamma.GetPinnableReference(), ref blendEnhancedContrast.GetPinnableReference(), ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAlphaBlendParams<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, ComPtr<TI0> renderingParams, ref float blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, ref blendEnhancedContrast, ref blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), blendGamma, blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, float* blendGamma, float* blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), blendGamma, blendEnhancedContrast, ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, float* blendGamma, Span<float> blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), blendGamma, ref blendEnhancedContrast.GetPinnableReference(), blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, float* blendGamma, Span<float> blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), blendGamma, ref blendEnhancedContrast.GetPinnableReference(), ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, Span<float> blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), ref blendGamma.GetPinnableReference(), blendEnhancedContrast, blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, Span<float> blendGamma, float* blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), ref blendGamma.GetPinnableReference(), blendEnhancedContrast, ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, Span<float> blendGamma, Span<float> blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), ref blendGamma.GetPinnableReference(), ref blendEnhancedContrast.GetPinnableReference(), blendClearTypeLevel);
    }

    /// <summary>To be documented.</summary>
    public static int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Span<IDWriteRenderingParams> renderingParams, Span<float> blendGamma, Span<float> blendEnhancedContrast, Span<float> blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAlphaBlendParams(ref renderingParams.GetPinnableReference(), ref blendGamma.GetPinnableReference(), ref blendEnhancedContrast.GetPinnableReference(), ref blendClearTypeLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
