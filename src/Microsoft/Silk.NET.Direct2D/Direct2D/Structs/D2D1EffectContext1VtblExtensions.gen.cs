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

public unsafe static class D2D1EffectContext1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EffectContext1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1EffectContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1EffectContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1EffectContext1> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1EffectContext1> thisVtbl, Guid* effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectId, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumSupportedFeatureLevel(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformNodeFromEffect(this ComPtr<ID2D1EffectContext1> thisVtbl, ID2D1Effect* effect, ID2D1TransformNode** transformNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effect, transformNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendTransform(this ComPtr<ID2D1EffectContext1> thisVtbl, uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, ID2D1BlendTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescription, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBorderTransform(this ComPtr<ID2D1EffectContext1> thisVtbl, ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)@this->LpVtbl[8])(@this, extendModeX, extendModeY, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffsetTransform(this ComPtr<ID2D1EffectContext1> thisVtbl, Silk.NET.Maths.Vector2D<int> offset, ID2D1OffsetTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)@this->LpVtbl[9])(@this, offset, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBoundsAdjustmentTransform(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectangle, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPixelShader(this ComPtr<ID2D1EffectContext1> thisVtbl, Guid* shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBuffer, shaderBufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadVertexShader(this ComPtr<ID2D1EffectContext1> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBuffer, shaderBufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputeShader(this ComPtr<ID2D1EffectContext1> thisVtbl, Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBuffer, shaderBufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsShaderLoaded(this ComPtr<ID2D1EffectContext1> thisVtbl, Guid* shaderId)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this, shaderId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateResourceTexture(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindResourceTexture(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceId, resourceTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindVertexBuffer(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ID2D1VertexBuffer** buffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceId, buffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1EffectContext1> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profile, profileSize, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1EffectContext1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filename, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext(this ComPtr<ID2D1EffectContext1> thisVtbl, IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContext, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID2D1EffectContext1> thisVtbl, Feature feature, void* featureSupportData, uint featureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Feature, void*, uint, int>)@this->LpVtbl[22])(@this, feature, featureSupportData, featureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsBufferPrecisionSupported(this ComPtr<ID2D1EffectContext1> thisVtbl, BufferPrecision bufferPrecision)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this, bufferPrecision);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLookupTable3D(this ComPtr<ID2D1EffectContext1> thisVtbl, BufferPrecision precision, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* extents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, ID2D1LookupTable3D** lookupTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, data, dataCount, strides, lookupTable);
        return ret;
    }

}
