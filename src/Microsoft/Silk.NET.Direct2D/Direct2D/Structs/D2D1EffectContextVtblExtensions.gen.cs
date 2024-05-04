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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1EffectContextVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1EffectContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1EffectContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiXPtr, dpiYPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectId, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* effectId, ref ID2D1Effect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect** effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectId, effectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectIdPtr, effect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid effectId, ref ID2D1Effect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            fixed (ID2D1Effect** effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectIdPtr, effectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, ref Silk.NET.Core.Native.D3DFeatureLevel maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevelPtr = &maximumSupportedFeatureLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.D3DFeatureLevel* featureLevelsPtr = &featureLevels)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevelsPtr, featureLevelsCount, maximumSupportedFeatureLevel);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel featureLevels, uint featureLevelsCount, ref Silk.NET.Core.Native.D3DFeatureLevel maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.D3DFeatureLevel* featureLevelsPtr = &featureLevels)
        {
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevelPtr = &maximumSupportedFeatureLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevelsPtr, featureLevelsCount, maximumSupportedFeatureLevelPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext> thisVtbl, ID2D1Effect* effect, ID2D1TransformNode** transformNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effect, transformNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext> thisVtbl, ID2D1Effect* effect, ref ID2D1TransformNode* transformNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformNode** transformNodePtr = &transformNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effect, transformNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext> thisVtbl, ref ID2D1Effect effect, ID2D1TransformNode** transformNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effectPtr, transformNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext> thisVtbl, ref ID2D1Effect effect, ref ID2D1TransformNode* transformNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            fixed (ID2D1TransformNode** transformNodePtr = &transformNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effectPtr, transformNodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, ID2D1BlendTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescription, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, ref ID2D1BlendTransform* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BlendTransform** transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescription, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, ID2D1BlendTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescriptionPtr, transform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, ref ID2D1BlendTransform* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
        {
            fixed (ID2D1BlendTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescriptionPtr, transformPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBorderTransform(this ComPtr<ID2D1EffectContext> thisVtbl, ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)@this->LpVtbl[8])(@this, extendModeX, extendModeY, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBorderTransform(this ComPtr<ID2D1EffectContext> thisVtbl, ExtendMode extendModeX, ExtendMode extendModeY, ref ID2D1BorderTransform* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BorderTransform** transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)@this->LpVtbl[8])(@this, extendModeX, extendModeY, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffsetTransform(this ComPtr<ID2D1EffectContext> thisVtbl, Silk.NET.Maths.Vector2D<int> offset, ID2D1OffsetTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)@this->LpVtbl[9])(@this, offset, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffsetTransform(this ComPtr<ID2D1EffectContext> thisVtbl, Silk.NET.Maths.Vector2D<int> offset, ref ID2D1OffsetTransform* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1OffsetTransform** transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)@this->LpVtbl[9])(@this, offset, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectangle, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BoundsAdjustmentTransform** transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectangle, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectanglePtr = &outputRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectanglePtr, transform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectanglePtr = &outputRectangle)
        {
            fixed (ID2D1BoundsAdjustmentTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectanglePtr, transformPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBuffer, shaderBufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* shaderBufferPtr = &shaderBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBufferPtr, shaderBufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBufferPtr, shaderBufferCount);
        SilkMarshal.Free((nint)shaderBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* shaderIdPtr = &shaderId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderIdPtr, shaderBuffer, shaderBufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* shaderIdPtr = &shaderId)
        {
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderIdPtr, shaderBufferPtr, shaderBufferCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* shaderIdPtr = &shaderId)
        {
        var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderIdPtr, shaderBufferPtr, shaderBufferCount);
        SilkMarshal.Free((nint)shaderBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBuffer, shaderBufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* shaderBufferPtr = &shaderBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
        SilkMarshal.Free((nint)shaderBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceIdPtr, shaderBuffer, shaderBufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
        var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
        SilkMarshal.Free((nint)shaderBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBuffer, shaderBufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* shaderBufferPtr = &shaderBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
        SilkMarshal.Free((nint)shaderBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceIdPtr, shaderBuffer, shaderBufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
        var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
        SilkMarshal.Free((nint)shaderBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsShaderLoaded(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* shaderId)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this, shaderId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsShaderLoaded(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid shaderId)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (Guid* shaderIdPtr = &shaderId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this, shaderIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* stridesPtr = &strides)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* stridesPtr = &strides)
        {
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
        }
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        fixed (uint* stridesPtr = &strides)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
        }
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        fixed (uint* stridesPtr = &strides)
        {
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
            }
        }
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexture);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (byte* dataPtr = &data)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
            }
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
            }
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, strides, dataSize, resourceTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, strides, dataSize, resourceTexturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexture);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (byte* dataPtr = &data)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
            }
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
            }
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexture);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexture);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                }
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceId, resourceTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceId, resourceTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceIdPtr, resourceTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceIdPtr, resourceTexturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, bufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferPropertiesPtr, buffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
        {
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferPropertiesPtr, bufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferProperties, buffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferProperties, bufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferPropertiesPtr, buffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferPropertiesPtr, bufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferProperties, buffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferProperties, bufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferPropertiesPtr, buffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferPropertiesPtr, bufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferProperties, buffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferProperties, bufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferPropertiesPtr, buffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
        {
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferPropertiesPtr, bufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceId, buffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceId, bufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceIdPtr, buffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* resourceIdPtr = &resourceId)
        {
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceIdPtr, bufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profile, profileSize, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profile, profileSize, colorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* profilePtr = &profile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* profilePtr = &profile)
        {
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContext);
        SilkMarshal.Free((nint)profilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContextPtr);
        }
        SilkMarshal.Free((nint)profilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filename, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filename, colorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filenamePtr = &filename)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filenamePtr = &filename)
        {
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, byte*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContext);
        SilkMarshal.Free((nint)filenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, byte*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContextPtr);
        }
        SilkMarshal.Free((nint)filenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContext, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, IWICColorContext* wicColorContext, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContext, colorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID2D1EffectContext> thisVtbl, Feature feature, void* featureSupportData, uint featureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Feature, void*, uint, int>)@this->LpVtbl[22])(@this, feature, featureSupportData, featureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID2D1EffectContext> thisVtbl, Feature feature, ref T0 featureSupportData, uint featureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* featureSupportDataPtr = &featureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Feature, void*, uint, int>)@this->LpVtbl[22])(@this, feature, featureSupportDataPtr, featureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsBufferPrecisionSupported(this ComPtr<ID2D1EffectContext> thisVtbl, BufferPrecision bufferPrecision)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, BufferPrecision, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this, bufferPrecision);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1EffectContext> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateEffect<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, out ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        effect = default;
        return @this->CreateEffect(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1Effect**) effect.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEffect(ref effectId.GetPinnableReference(), effect);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEffect<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ref Guid effectId, ref ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEffect(ref effectId, (ID2D1Effect**) effect.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> effectId, ref ID2D1Effect* effect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEffect(ref effectId.GetPinnableReference(), ref effect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, Span<Silk.NET.Core.Native.D3DFeatureLevel> maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMaximumSupportedFeatureLevel(featureLevels, featureLevelsCount, ref maximumSupportedFeatureLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMaximumSupportedFeatureLevel(in featureLevels.GetPinnableReference(), featureLevelsCount, maximumSupportedFeatureLevel);
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> featureLevels, uint featureLevelsCount, Span<Silk.NET.Core.Native.D3DFeatureLevel> maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMaximumSupportedFeatureLevel(in featureLevels.GetPinnableReference(), featureLevelsCount, ref maximumSupportedFeatureLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformNodeFromEffect<TI0, TI1>(this ComPtr<ID2D1EffectContext> thisVtbl, ComPtr<TI0> effect, ref ComPtr<TI1> transformNode) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformNodeFromEffect((ID2D1Effect*) effect.Handle, (ID2D1TransformNode**) transformNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ComPtr<TI0> effect, ref ID2D1TransformNode* transformNode) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformNodeFromEffect((ID2D1Effect*) effect.Handle, ref transformNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext> thisVtbl, Span<ID2D1Effect> effect, ID2D1TransformNode** transformNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformNodeFromEffect(ref effect.GetPinnableReference(), transformNode);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformNodeFromEffect<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ref ID2D1Effect effect, ref ComPtr<TI0> transformNode) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformNodeFromEffect(ref effect, (ID2D1TransformNode**) transformNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext> thisVtbl, Span<ID2D1Effect> effect, ref ID2D1TransformNode* transformNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformNodeFromEffect(ref effect.GetPinnableReference(), ref transformNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BlendTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlendTransform(numInputs, blendDescription, (ID2D1BlendTransform**) transform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, ID2D1BlendTransform** transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlendTransform(numInputs, in blendDescription.GetPinnableReference(), transform);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlendTransform<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BlendTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlendTransform(numInputs, in blendDescription, (ID2D1BlendTransform**) transform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, ref ID2D1BlendTransform* transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlendTransform(numInputs, in blendDescription.GetPinnableReference(), ref transform);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBorderTransform<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ExtendMode extendModeX, ExtendMode extendModeY, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BorderTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBorderTransform(extendModeX, extendModeY, (ID2D1BorderTransform**) transform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateOffsetTransform<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, Silk.NET.Maths.Vector2D<int> offset, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1OffsetTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateOffsetTransform(offset, (ID2D1OffsetTransform**) transform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRectangle, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BoundsAdjustmentTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBoundsAdjustmentTransform(outputRectangle, (ID2D1BoundsAdjustmentTransform**) transform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBoundsAdjustmentTransform(in outputRectangle.GetPinnableReference(), transform);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBoundsAdjustmentTransform<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRectangle, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BoundsAdjustmentTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBoundsAdjustmentTransform(in outputRectangle, (ID2D1BoundsAdjustmentTransform**) transform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBoundsAdjustmentTransform(in outputRectangle.GetPinnableReference(), ref transform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadPixelShader(shaderId, in shaderBuffer.GetPinnableReference(), shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadPixelShader(ref shaderId.GetPinnableReference(), shaderBuffer, shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadPixelShader(ref shaderId.GetPinnableReference(), in shaderBuffer.GetPinnableReference(), shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int LoadPixelShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadPixelShader(ref shaderId.GetPinnableReference(), shaderBuffer, shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadVertexShader(resourceId, in shaderBuffer.GetPinnableReference(), shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadVertexShader(ref resourceId.GetPinnableReference(), shaderBuffer, shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadVertexShader(ref resourceId.GetPinnableReference(), in shaderBuffer.GetPinnableReference(), shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int LoadVertexShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadVertexShader(ref resourceId.GetPinnableReference(), shaderBuffer, shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputeShader(resourceId, in shaderBuffer.GetPinnableReference(), shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputeShader(ref resourceId.GetPinnableReference(), shaderBuffer, shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputeShader(ref resourceId.GetPinnableReference(), in shaderBuffer.GetPinnableReference(), shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int LoadComputeShader(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputeShader(ref resourceId.GetPinnableReference(), shaderBuffer, shaderBufferCount);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsShaderLoaded(this ComPtr<ID2D1EffectContext> thisVtbl, Span<Guid> shaderId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsShaderLoaded(ref shaderId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, in data.GetPinnableReference(), strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, in data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, in data.GetPinnableReference(), strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, in data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties, in data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties, in data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(resourceId, in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, in data.GetPinnableReference(), strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, resourceTextureProperties, in data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, in data.GetPinnableReference(), strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, resourceTextureProperties, in data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), resourceTextureProperties, data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, in resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, in resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, in resourceTextureProperties, in data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, in resourceTextureProperties, in data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), in data.GetPinnableReference(), in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, in resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, strides, dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static int CreateResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceTextureProperties resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateResourceTexture(in resourceId, in resourceTextureProperties, data, in strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceTextureProperties> resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateResourceTexture(in resourceId.GetPinnableReference(), in resourceTextureProperties.GetPinnableReference(), data, in strides.GetPinnableReference(), dataSize, ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static int FindResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, out ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        resourceTexture = default;
        return @this->FindResourceTexture(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindResourceTexture(in resourceId.GetPinnableReference(), resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static int FindResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindResourceTexture(in resourceId, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, ref ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindResourceTexture(in resourceId.GetPinnableReference(), ref resourceTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, resourceId, in customVertexBufferProperties.GetPinnableReference(), buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, resourceId, in customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, resourceId, in customVertexBufferProperties.GetPinnableReference(), ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, in resourceId.GetPinnableReference(), customVertexBufferProperties, buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, in resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, in resourceId.GetPinnableReference(), customVertexBufferProperties, ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, in resourceId.GetPinnableReference(), in customVertexBufferProperties.GetPinnableReference(), buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, in resourceId, in customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(vertexBufferProperties, in resourceId.GetPinnableReference(), in customVertexBufferProperties.GetPinnableReference(), ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), resourceId, customVertexBufferProperties, buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties, resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), resourceId, customVertexBufferProperties, ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), resourceId, in customVertexBufferProperties.GetPinnableReference(), buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties, resourceId, in customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), resourceId, in customVertexBufferProperties.GetPinnableReference(), ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), in resourceId.GetPinnableReference(), customVertexBufferProperties, buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties, in resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), in resourceId.GetPinnableReference(), customVertexBufferProperties, ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), in resourceId.GetPinnableReference(), in customVertexBufferProperties.GetPinnableReference(), buffer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexBufferProperties vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties, in resourceId, in customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexBufferProperties> vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CustomVertexBufferProperties> customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexBuffer(in vertexBufferProperties.GetPinnableReference(), in resourceId.GetPinnableReference(), in customVertexBufferProperties.GetPinnableReference(), ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static int FindVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, out ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        buffer = default;
        return @this->FindVertexBuffer(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindVertexBuffer(in resourceId.GetPinnableReference(), buffer);
    }

    /// <summary>To be documented.</summary>
    public static int FindVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid resourceId, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindVertexBuffer(in resourceId, (ID2D1VertexBuffer**) buffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> resourceId, ref ID2D1VertexBuffer* buffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindVertexBuffer(in resourceId.GetPinnableReference(), ref buffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext(space, profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContext(space, in profile.GetPinnableReference(), profileSize, colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContext<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext(space, in profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContext(space, in profile.GetPinnableReference(), profileSize, ref colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContext<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext(space, profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromFilename(filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContextFromFilename(in filename.GetPinnableReference(), colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContextFromFilename<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromFilename(in filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContextFromFilename(in filename.GetPinnableReference(), ref colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContextFromFilename<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromFilename(filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl, IWICColorContext* wicColorContext, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromWicColorContext(wicColorContext, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID2D1EffectContext> thisVtbl, Feature feature, Span<T0> featureSupportData, uint featureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckFeatureSupport(feature, ref featureSupportData.GetPinnableReference(), featureSupportDataSize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateEffect<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateEffect(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> FindResourceTexture<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->FindResourceTexture(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> FindVertexBuffer<TI0>(this ComPtr<ID2D1EffectContext> thisVtbl) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->FindVertexBuffer(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
