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
    [Guid("3d9f916b-27dc-4ad7-b4f1-64945340f563")]
    [NativeName("Name", "ID2D1EffectContext")]
    public unsafe partial struct ID2D1EffectContext
    {
        public static readonly Guid Guid = new("3d9f916b-27dc-4ad7-b4f1-64945340f563");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1EffectContext val)
            => Unsafe.As<ID2D1EffectContext, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1EffectContext
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
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)LpVtbl[3])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)LpVtbl[3])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)LpVtbl[3])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)LpVtbl[3])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)LpVtbl[4])(@this, effectId, effect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ref ID2D1Effect* effect)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect** effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)LpVtbl[4])(@this, effectId, effectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(ref Guid effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)LpVtbl[4])(@this, effectIdPtr, effect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(ref Guid effectId, ref ID2D1Effect* effect)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                fixed (ID2D1Effect** effectPtr = &effect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)LpVtbl[4])(@this, effectIdPtr, effectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, ref Silk.NET.Core.Native.D3DFeatureLevel maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevelPtr = &maximumSupportedFeatureLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel(ref Silk.NET.Core.Native.D3DFeatureLevel featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* featureLevelsPtr = &featureLevels)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[5])(@this, featureLevelsPtr, featureLevelsCount, maximumSupportedFeatureLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumSupportedFeatureLevel(ref Silk.NET.Core.Native.D3DFeatureLevel featureLevels, uint featureLevelsCount, ref Silk.NET.Core.Native.D3DFeatureLevel maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* featureLevelsPtr = &featureLevels)
            {
                fixed (Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevelPtr = &maximumSupportedFeatureLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[5])(@this, featureLevelsPtr, featureLevelsCount, maximumSupportedFeatureLevelPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)LpVtbl[6])(@this, effect, transformNode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ID2D1Effect* effect, ref ID2D1TransformNode* transformNode)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode** transformNodePtr = &transformNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)LpVtbl[6])(@this, effect, transformNodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ref ID2D1Effect effect, ID2D1TransformNode** transformNode)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)LpVtbl[6])(@this, effectPtr, transformNode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ref ID2D1Effect effect, ref ID2D1TransformNode* transformNode)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                fixed (ID2D1TransformNode** transformNodePtr = &transformNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)LpVtbl[6])(@this, effectPtr, transformNodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ID2D1BlendTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)LpVtbl[7])(@this, numInputs, blendDescription, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ref ID2D1BlendTransform* transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BlendTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)LpVtbl[7])(@this, numInputs, blendDescription, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, ref BlendDescription blendDescription, ID2D1BlendTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)LpVtbl[7])(@this, numInputs, blendDescriptionPtr, transform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, ref BlendDescription blendDescription, ref ID2D1BlendTransform* transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (ID2D1BlendTransform** transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)LpVtbl[7])(@this, numInputs, blendDescriptionPtr, transformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)LpVtbl[8])(@this, extendModeX, extendModeY, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ref ID2D1BorderTransform* transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BorderTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)LpVtbl[8])(@this, extendModeX, extendModeY, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffsetTransform(Silk.NET.Maths.Vector2D<int> offset, ID2D1OffsetTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)LpVtbl[9])(@this, offset, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffsetTransform(Silk.NET.Maths.Vector2D<int> offset, ref ID2D1OffsetTransform* transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1OffsetTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)LpVtbl[9])(@this, offset, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(Silk.NET.Maths.Rectangle<int>* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Rectangle<int>*, ID2D1BoundsAdjustmentTransform**, int>)LpVtbl[10])(@this, outputRectangle, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(Silk.NET.Maths.Rectangle<int>* outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BoundsAdjustmentTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Rectangle<int>*, ID2D1BoundsAdjustmentTransform**, int>)LpVtbl[10])(@this, outputRectangle, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(ref Silk.NET.Maths.Rectangle<int> outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputRectanglePtr = &outputRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Rectangle<int>*, ID2D1BoundsAdjustmentTransform**, int>)LpVtbl[10])(@this, outputRectanglePtr, transform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(ref Silk.NET.Maths.Rectangle<int> outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputRectanglePtr = &outputRectangle)
            {
                fixed (ID2D1BoundsAdjustmentTransform** transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Rectangle<int>*, ID2D1BoundsAdjustmentTransform**, int>)LpVtbl[10])(@this, outputRectanglePtr, transformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[11])(@this, shaderId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[11])(@this, shaderId, shaderBufferPtr, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[11])(@this, shaderId, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(ref Guid shaderId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[11])(@this, shaderIdPtr, shaderBuffer, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadPixelShader(ref Guid shaderId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                fixed (byte* shaderBufferPtr = &shaderBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[11])(@this, shaderIdPtr, shaderBufferPtr, shaderBufferCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadPixelShader(ref Guid shaderId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[11])(@this, shaderIdPtr, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[12])(@this, resourceId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[12])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[12])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(ref Guid resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[12])(@this, resourceIdPtr, shaderBuffer, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadVertexShader(ref Guid resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* shaderBufferPtr = &shaderBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[12])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadVertexShader(ref Guid resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[12])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[13])(@this, resourceId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[13])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[13])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(ref Guid resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[13])(@this, resourceIdPtr, shaderBuffer, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadComputeShader(ref Guid resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* shaderBufferPtr = &shaderBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[13])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadComputeShader(ref Guid resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)LpVtbl[13])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsShaderLoaded(Guid* shaderId)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, int>)LpVtbl[14])(@this, shaderId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsShaderLoaded(ref Guid shaderId)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, int>)LpVtbl[14])(@this, shaderIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, strides, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, strides, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        fixed (uint* stridesPtr = &strides)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)LpVtbl[16])(@this, resourceId, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(Guid* resourceId, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)LpVtbl[16])(@this, resourceId, resourceTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(ref Guid resourceId, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)LpVtbl[16])(@this, resourceIdPtr, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(ref Guid resourceId, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)LpVtbl[16])(@this, resourceIdPtr, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, bufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferPropertiesPtr, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferPropertiesPtr, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferProperties, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferProperties, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferPropertiesPtr, buffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferPropertiesPtr, bufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferProperties, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferProperties, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferPropertiesPtr, buffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferPropertiesPtr, bufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferProperties, buffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferProperties, bufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferPropertiesPtr, buffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                    {
                        fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferPropertiesPtr, bufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(Guid* resourceId, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)LpVtbl[18])(@this, resourceId, buffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(Guid* resourceId, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)LpVtbl[18])(@this, resourceId, bufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(ref Guid resourceId, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)LpVtbl[18])(@this, resourceIdPtr, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(ref Guid resourceId, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)LpVtbl[18])(@this, resourceIdPtr, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[19])(@this, space, profile, profileSize, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[19])(@this, space, profile, profileSize, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, ref byte profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[19])(@this, space, profilePtr, profileSize, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, ref byte profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[19])(@this, space, profilePtr, profileSize, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[19])(@this, space, profilePtr, profileSize, colorContext);
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[19])(@this, space, profilePtr, profileSize, colorContextPtr);
            }
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(char* filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)LpVtbl[20])(@this, filename, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(char* filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)LpVtbl[20])(@this, filename, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(ref char filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filenamePtr = &filename)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)LpVtbl[20])(@this, filenamePtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(ref char filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filenamePtr = &filename)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)LpVtbl[20])(@this, filenamePtr, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, byte*, ID2D1ColorContext**, int>)LpVtbl[20])(@this, filenamePtr, colorContext);
            SilkMarshal.Free((nint)filenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, byte*, ID2D1ColorContext**, int>)LpVtbl[20])(@this, filenamePtr, colorContextPtr);
            }
            SilkMarshal.Free((nint)filenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[21])(@this, wicColorContext, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[21])(@this, wicColorContext, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(ref IWICColorContext wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* wicColorContextPtr = &wicColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[21])(@this, wicColorContextPtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(ref IWICColorContext wicColorContext, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* wicColorContextPtr = &wicColorContext)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[21])(@this, wicColorContextPtr, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature feature, void* featureSupportData, uint featureSupportDataSize)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Feature, void*, uint, int>)LpVtbl[22])(@this, feature, featureSupportData, featureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(Feature feature, ref T0 featureSupportData, uint featureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* featureSupportDataPtr = &featureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Feature, void*, uint, int>)LpVtbl[22])(@this, feature, featureSupportDataPtr, featureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsBufferPrecisionSupported(BufferPrecision bufferPrecision)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, BufferPrecision, int>)LpVtbl[23])(@this, bufferPrecision);
            return ret;
        }

    }
}
