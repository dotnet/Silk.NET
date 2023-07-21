// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext"]/*' />
[Guid("3D9F916B-27DC-4AD7-B4F1-64945340F563")]
[NativeTypeName("struct ID2D1EffectContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1EffectContext : ID2D1EffectContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1EffectContext));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, uint>)(lpVtbl[1]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, uint>)(lpVtbl[2]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.GetDpi"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1EffectContext*, float*, float*, void>)(lpVtbl[3]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateEffect([NativeTypeName("const IID &")] Guid* effectId, ID2D1Effect** effect)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)(lpVtbl[4]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), effectId, effect);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.GetMaximumSupportedFeatureLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaximumSupportedFeatureLevel([NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, D3D_FEATURE_LEVEL*, uint, D3D_FEATURE_LEVEL*, int>)(lpVtbl[5]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateTransformNodeFromEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)(lpVtbl[6]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), effect, transformNode);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateBlendTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBlendTransform([NativeTypeName("UINT32")] uint numInputs, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, uint, D2D1_BLEND_DESCRIPTION*, ID2D1BlendTransform**, int>)(lpVtbl[7]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), numInputs, blendDescription, transform);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateBorderTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_EXTEND_MODE, D2D1_EXTEND_MODE, ID2D1BorderTransform**, int>)(lpVtbl[8]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), extendModeX, extendModeY, transform);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateOffsetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateOffsetTransform([NativeTypeName("D2D1_POINT_2L")] POINT offset, ID2D1OffsetTransform** transform)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, POINT, ID2D1OffsetTransform**, int>)(lpVtbl[9]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), offset, transform);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateBoundsAdjustmentTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBoundsAdjustmentTransform([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, RECT*, ID2D1BoundsAdjustmentTransform**, int>)(lpVtbl[10]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), outputRectangle, transform);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.LoadPixelShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LoadPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[11]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), shaderId, shaderBuffer, shaderBufferCount);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.LoadVertexShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT LoadVertexShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[12]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.LoadComputeShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT LoadComputeShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[13]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.IsShaderLoaded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public BOOL IsShaderLoaded([NativeTypeName("const GUID &")] Guid* shaderId)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, int>)(lpVtbl[14]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), shaderId);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateResourceTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_RESOURCE_TEXTURE_PROPERTIES *")] D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, ID2D1ResourceTexture** resourceTexture)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, D2D1_RESOURCE_TEXTURE_PROPERTIES*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)(lpVtbl[15]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.FindResourceTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FindResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)(lpVtbl[16]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, resourceTexture);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateVertexBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateVertexBuffer([NativeTypeName("const D2D1_VERTEX_BUFFER_PROPERTIES *")] D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *")] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_VERTEX_BUFFER_PROPERTIES*, Guid*, D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES*, ID2D1VertexBuffer**, int>)(lpVtbl[17]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.FindVertexBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FindVertexBuffer([NativeTypeName("const GUID *")] Guid* resourceId, ID2D1VertexBuffer** buffer)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)(lpVtbl[18]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, buffer);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateColorContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_COLOR_SPACE, byte*, uint, ID2D1ColorContext**, int>)(lpVtbl[19]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateColorContextFromFilename"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, ID2D1ColorContext** colorContext)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, ushort*, ID2D1ColorContext**, int>)(lpVtbl[20]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), filename, colorContext);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CreateColorContextFromWicColorContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)(lpVtbl[21]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.CheckFeatureSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CheckFeatureSupport(D2D1_FEATURE feature, void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_FEATURE, void*, uint, int>)(lpVtbl[22]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), feature, featureSupportData, featureSupportDataSize);
    }

    /// <include file='ID2D1EffectContext.xml' path='doc/member[@name="ID2D1EffectContext.IsBufferPrecisionSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public BOOL IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
    {
        return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_BUFFER_PRECISION, int>)(lpVtbl[23]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), bufferPrecision);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void GetDpi(float* dpiX, float* dpiY);

        [VtblIndex(4)]
        HRESULT CreateEffect([NativeTypeName("const IID &")] Guid* effectId, ID2D1Effect** effect);

        [VtblIndex(5)]
        HRESULT GetMaximumSupportedFeatureLevel([NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel);

        [VtblIndex(6)]
        HRESULT CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode);

        [VtblIndex(7)]
        HRESULT CreateBlendTransform([NativeTypeName("UINT32")] uint numInputs, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform);

        [VtblIndex(8)]
        HRESULT CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform);

        [VtblIndex(9)]
        HRESULT CreateOffsetTransform([NativeTypeName("D2D1_POINT_2L")] POINT offset, ID2D1OffsetTransform** transform);

        [VtblIndex(10)]
        HRESULT CreateBoundsAdjustmentTransform([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRectangle, ID2D1BoundsAdjustmentTransform** transform);

        [VtblIndex(11)]
        HRESULT LoadPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [VtblIndex(12)]
        HRESULT LoadVertexShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [VtblIndex(13)]
        HRESULT LoadComputeShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [VtblIndex(14)]
        BOOL IsShaderLoaded([NativeTypeName("const GUID &")] Guid* shaderId);

        [VtblIndex(15)]
        HRESULT CreateResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_RESOURCE_TEXTURE_PROPERTIES *")] D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, ID2D1ResourceTexture** resourceTexture);

        [VtblIndex(16)]
        HRESULT FindResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, ID2D1ResourceTexture** resourceTexture);

        [VtblIndex(17)]
        HRESULT CreateVertexBuffer([NativeTypeName("const D2D1_VERTEX_BUFFER_PROPERTIES *")] D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *")] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer);

        [VtblIndex(18)]
        HRESULT FindVertexBuffer([NativeTypeName("const GUID *")] Guid* resourceId, ID2D1VertexBuffer** buffer);

        [VtblIndex(19)]
        HRESULT CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext);

        [VtblIndex(20)]
        HRESULT CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, ID2D1ColorContext** colorContext);

        [VtblIndex(21)]
        HRESULT CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext);

        [VtblIndex(22)]
        HRESULT CheckFeatureSupport(D2D1_FEATURE feature, void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize);

        [VtblIndex(23)]
        BOOL IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, float*, void> GetDpi;

        [NativeTypeName("HRESULT (const IID &, ID2D1Effect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ID2D1Effect**, int> CreateEffect;

        [NativeTypeName("HRESULT (const D3D_FEATURE_LEVEL *, UINT32, D3D_FEATURE_LEVEL *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_FEATURE_LEVEL*, uint, D3D_FEATURE_LEVEL*, int> GetMaximumSupportedFeatureLevel;

        [NativeTypeName("HRESULT (ID2D1Effect *, ID2D1TransformNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Effect*, ID2D1TransformNode**, int> CreateTransformNodeFromEffect;

        [NativeTypeName("HRESULT (UINT32, const D2D1_BLEND_DESCRIPTION *, ID2D1BlendTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D2D1_BLEND_DESCRIPTION*, ID2D1BlendTransform**, int> CreateBlendTransform;

        [NativeTypeName("HRESULT (D2D1_EXTEND_MODE, D2D1_EXTEND_MODE, ID2D1BorderTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, D2D1_EXTEND_MODE, ID2D1BorderTransform**, int> CreateBorderTransform;

        [NativeTypeName("HRESULT (D2D1_POINT_2L, ID2D1OffsetTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, ID2D1OffsetTransform**, int> CreateOffsetTransform;

        [NativeTypeName("HRESULT (const D2D1_RECT_L *, ID2D1BoundsAdjustmentTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, ID2D1BoundsAdjustmentTransform**, int> CreateBoundsAdjustmentTransform;

        [NativeTypeName("HRESULT (const GUID &, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, int> LoadPixelShader;

        [NativeTypeName("HRESULT (const GUID &, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, int> LoadVertexShader;

        [NativeTypeName("HRESULT (const GUID &, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, int> LoadComputeShader;

        [NativeTypeName("BOOL (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsShaderLoaded;

        [NativeTypeName("HRESULT (const GUID *, const D2D1_RESOURCE_TEXTURE_PROPERTIES *, const BYTE *, const UINT32 *, UINT32, ID2D1ResourceTexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, D2D1_RESOURCE_TEXTURE_PROPERTIES*, byte*, uint*, uint, ID2D1ResourceTexture**, int> CreateResourceTexture;

        [NativeTypeName("HRESULT (const GUID *, ID2D1ResourceTexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ID2D1ResourceTexture**, int> FindResourceTexture;

        [NativeTypeName("HRESULT (const D2D1_VERTEX_BUFFER_PROPERTIES *, const GUID *, const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *, ID2D1VertexBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_VERTEX_BUFFER_PROPERTIES*, Guid*, D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES*, ID2D1VertexBuffer**, int> CreateVertexBuffer;

        [NativeTypeName("HRESULT (const GUID *, ID2D1VertexBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ID2D1VertexBuffer**, int> FindVertexBuffer;

        [NativeTypeName("HRESULT (D2D1_COLOR_SPACE, const BYTE *, UINT32, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_SPACE, byte*, uint, ID2D1ColorContext**, int> CreateColorContext;

        [NativeTypeName("HRESULT (PCWSTR, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ID2D1ColorContext**, int> CreateColorContextFromFilename;

        [NativeTypeName("HRESULT (IWICColorContext *, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorContext*, ID2D1ColorContext**, int> CreateColorContextFromWicColorContext;

        [NativeTypeName("HRESULT (D2D1_FEATURE, void *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_FEATURE, void*, uint, int> CheckFeatureSupport;

        [NativeTypeName("BOOL (D2D1_BUFFER_PRECISION) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BUFFER_PRECISION, int> IsBufferPrecisionSupported;
    }
}
