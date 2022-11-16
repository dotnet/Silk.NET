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
    [Guid("84ab595a-fc81-4546-bacd-e8ef4d8abe7a")]
    [NativeName("Name", "ID2D1EffectContext1")]
    public unsafe partial struct ID2D1EffectContext1 : IComVtbl<ID2D1EffectContext1>, IComVtbl<ID2D1EffectContext>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("84ab595a-fc81-4546-bacd-e8ef4d8abe7a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1EffectContext(ID2D1EffectContext1 val)
            => Unsafe.As<ID2D1EffectContext1, ID2D1EffectContext>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1EffectContext1 val)
            => Unsafe.As<ID2D1EffectContext1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1EffectContext1
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
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectId, effect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ref ID2D1Effect* effect)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect** effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectId, effectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(ref Guid effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectIdPtr, effect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(ref Guid effectId, ref ID2D1Effect* effect)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                fixed (ID2D1Effect** effectPtr = &effect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectIdPtr, effectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, ref Silk.NET.Core.Native.D3DFeatureLevel maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevelPtr = &maximumSupportedFeatureLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel(ref Silk.NET.Core.Native.D3DFeatureLevel featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* featureLevelsPtr = &featureLevels)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevelsPtr, featureLevelsCount, maximumSupportedFeatureLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumSupportedFeatureLevel(ref Silk.NET.Core.Native.D3DFeatureLevel featureLevels, uint featureLevelsCount, ref Silk.NET.Core.Native.D3DFeatureLevel maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* featureLevelsPtr = &featureLevels)
            {
                fixed (Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevelPtr = &maximumSupportedFeatureLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevelsPtr, featureLevelsCount, maximumSupportedFeatureLevelPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effect, transformNode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ID2D1Effect* effect, ref ID2D1TransformNode* transformNode)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode** transformNodePtr = &transformNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effect, transformNodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ref ID2D1Effect effect, ID2D1TransformNode** transformNode)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effectPtr, transformNode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ref ID2D1Effect effect, ref ID2D1TransformNode* transformNode)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                fixed (ID2D1TransformNode** transformNodePtr = &transformNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effectPtr, transformNodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ID2D1BlendTransform** transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescription, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, BlendDescription* blendDescription, ref ID2D1BlendTransform* transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BlendTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescription, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, ref BlendDescription blendDescription, ID2D1BlendTransform** transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescriptionPtr, transform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, ref BlendDescription blendDescription, ref ID2D1BlendTransform* transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (ID2D1BlendTransform** transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescriptionPtr, transformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)@this->LpVtbl[8])(@this, extendModeX, extendModeY, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ref ID2D1BorderTransform* transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BorderTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)@this->LpVtbl[8])(@this, extendModeX, extendModeY, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffsetTransform(Silk.NET.Maths.Vector2D<int> offset, ID2D1OffsetTransform** transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)@this->LpVtbl[9])(@this, offset, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffsetTransform(Silk.NET.Maths.Vector2D<int> offset, ref ID2D1OffsetTransform* transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1OffsetTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)@this->LpVtbl[9])(@this, offset, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(Silk.NET.Maths.Box2D<int>* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectangle, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(Silk.NET.Maths.Box2D<int>* outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BoundsAdjustmentTransform** transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectangle, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(ref Silk.NET.Maths.Box2D<int> outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectanglePtr = &outputRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectanglePtr, transform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform(ref Silk.NET.Maths.Box2D<int> outputRectangle, ref ID2D1BoundsAdjustmentTransform* transform)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectanglePtr = &outputRectangle)
            {
                fixed (ID2D1BoundsAdjustmentTransform** transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectanglePtr, transformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBufferPtr, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(ref Guid shaderId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderIdPtr, shaderBuffer, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadPixelShader(ref Guid shaderId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                fixed (byte* shaderBufferPtr = &shaderBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderIdPtr, shaderBufferPtr, shaderBufferCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadPixelShader(ref Guid shaderId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderIdPtr, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(ref Guid resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceIdPtr, shaderBuffer, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadVertexShader(ref Guid resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* shaderBufferPtr = &shaderBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadVertexShader(ref Guid resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* shaderBufferPtr = &shaderBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(ref Guid resourceId, byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceIdPtr, shaderBuffer, shaderBufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadComputeShader(ref Guid resourceId, ref byte shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* shaderBufferPtr = &shaderBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadComputeShader(ref Guid resourceId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var shaderBufferPtr = (byte*) SilkMarshal.StringToPtr(shaderBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceIdPtr, shaderBufferPtr, shaderBufferCount);
            SilkMarshal.Free((nint)shaderBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsShaderLoaded(Guid* shaderId)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, int>)@this->LpVtbl[14])(@this, shaderId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsShaderLoaded(ref Guid shaderId)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, int>)@this->LpVtbl[14])(@this, shaderIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                }
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, strides, dataSize, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, strides, dataSize, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, data, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, strides, dataSize, resourceTexturePtr);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexture);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTextureProperties, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
                    }
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexture);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, strides, dataSize, resourceTexturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, data, stridesPtr, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        fixed (uint* stridesPtr = &strides)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
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
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexture);
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, strides, dataSize, resourceTexturePtr);
                    }
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ResourceTextureProperties* resourceTexturePropertiesPtr = &resourceTextureProperties)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexture);
                    }
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceIdPtr, resourceTexturePropertiesPtr, dataPtr, stridesPtr, dataSize, resourceTexturePtr);
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
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceId, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(Guid* resourceId, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceId, resourceTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(ref Guid resourceId, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceIdPtr, resourceTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture(ref Guid resourceId, ref ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1ResourceTexture** resourceTexturePtr = &resourceTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceIdPtr, resourceTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, bufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferPropertiesPtr, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferPropertiesPtr, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferProperties, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferProperties, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferPropertiesPtr, buffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceIdPtr, customVertexBufferPropertiesPtr, bufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferProperties, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferProperties, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferPropertiesPtr, buffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceId, customVertexBufferPropertiesPtr, bufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferProperties, buffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferProperties, bufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferPropertiesPtr, buffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexBufferProperties* vertexBufferPropertiesPtr = &vertexBufferProperties)
            {
                fixed (Guid* resourceIdPtr = &resourceId)
                {
                    fixed (CustomVertexBufferProperties* customVertexBufferPropertiesPtr = &customVertexBufferProperties)
                    {
                        fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferPropertiesPtr, resourceIdPtr, customVertexBufferPropertiesPtr, bufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(Guid* resourceId, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceId, buffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(Guid* resourceId, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceId, bufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(ref Guid resourceId, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceIdPtr, buffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer(ref Guid resourceId, ref ID2D1VertexBuffer* buffer)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* resourceIdPtr = &resourceId)
            {
                fixed (ID2D1VertexBuffer** bufferPtr = &buffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceIdPtr, bufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profile, profileSize, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profile, profileSize, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, ref byte profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, ref byte profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContext);
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profilePtr, profileSize, colorContextPtr);
            }
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(char* filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filename, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(char* filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filename, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(ref char filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filenamePtr = &filename)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(ref char filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filenamePtr = &filename)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, byte*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContext);
            SilkMarshal.Free((nint)filenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, byte*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filenamePtr, colorContextPtr);
            }
            SilkMarshal.Free((nint)filenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContext, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContext, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(ref IWICColorContext wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* wicColorContextPtr = &wicColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContextPtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(ref IWICColorContext wicColorContext, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* wicColorContextPtr = &wicColorContext)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContextPtr, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature feature, void* featureSupportData, uint featureSupportDataSize)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Feature, void*, uint, int>)@this->LpVtbl[22])(@this, feature, featureSupportData, featureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(Feature feature, ref T0 featureSupportData, uint featureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* featureSupportDataPtr = &featureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, Feature, void*, uint, int>)@this->LpVtbl[22])(@this, feature, featureSupportDataPtr, featureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsBufferPrecisionSupported(BufferPrecision bufferPrecision)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, int>)@this->LpVtbl[23])(@this, bufferPrecision);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, data, dataCount, strides, lookupTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, data, dataCount, strides, lookupTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, data, dataCount, stridesPtr, lookupTable);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, data, dataCount, stridesPtr, lookupTablePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, strides, lookupTable);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, strides, lookupTablePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTable);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, strides, lookupTable);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, strides, lookupTablePtr);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTable);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                }
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, data, dataCount, strides, lookupTable);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, data, dataCount, strides, lookupTablePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, data, dataCount, stridesPtr, lookupTable);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, data, dataCount, stridesPtr, lookupTablePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTable);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTablePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTable);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTable);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTablePtr);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTable);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext1*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[24])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                    }
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEffect<TI0>(out ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            effect = default;
            return @this->CreateEffect(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1Effect**) effect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEffect<TI0>(ref Guid effectId, ref ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEffect(ref effectId, (ID2D1Effect**) effect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformNodeFromEffect<TI0, TI1>(ComPtr<TI0> effect, ref ComPtr<TI1> transformNode) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI1>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformNodeFromEffect((ID2D1Effect*) effect.Handle, (ID2D1TransformNode**) transformNode.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect<TI0>(ComPtr<TI0> effect, ref ID2D1TransformNode* transformNode) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformNodeFromEffect((ID2D1Effect*) effect.Handle, ref transformNode);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformNodeFromEffect<TI0>(ref ID2D1Effect effect, ref ComPtr<TI0> transformNode) where TI0 : unmanaged, IComVtbl<ID2D1TransformNode>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformNodeFromEffect(ref effect, (ID2D1TransformNode**) transformNode.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform<TI0>(uint numInputs, BlendDescription* blendDescription, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BlendTransform>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBlendTransform(numInputs, blendDescription, (ID2D1BlendTransform**) transform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBlendTransform<TI0>(uint numInputs, ref BlendDescription blendDescription, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BlendTransform>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBlendTransform(numInputs, ref blendDescription, (ID2D1BlendTransform**) transform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBorderTransform<TI0>(ExtendMode extendModeX, ExtendMode extendModeY, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BorderTransform>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBorderTransform(extendModeX, extendModeY, (ID2D1BorderTransform**) transform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateOffsetTransform<TI0>(Silk.NET.Maths.Vector2D<int> offset, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1OffsetTransform>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateOffsetTransform(offset, (ID2D1OffsetTransform**) transform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform<TI0>(Silk.NET.Maths.Box2D<int>* outputRectangle, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BoundsAdjustmentTransform>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBoundsAdjustmentTransform(outputRectangle, (ID2D1BoundsAdjustmentTransform**) transform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBoundsAdjustmentTransform<TI0>(ref Silk.NET.Maths.Box2D<int> outputRectangle, ref ComPtr<TI0> transform) where TI0 : unmanaged, IComVtbl<ID2D1BoundsAdjustmentTransform>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBoundsAdjustmentTransform(ref outputRectangle, (ID2D1BoundsAdjustmentTransform**) transform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, resourceTextureProperties, ref data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, resourceTextureProperties, ref data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, ref resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, ref resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, ref resourceTextureProperties, ref data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, ref resourceTextureProperties, ref data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, ref resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(Guid* resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(resourceId, ref resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, resourceTextureProperties, ref data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, resourceTextureProperties, ref data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ResourceTextureProperties* resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, ref resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, byte* data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, ref resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, ref resourceTextureProperties, ref data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateResourceTexture<TI0>(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, ref byte data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, ref resourceTextureProperties, ref data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture<TI0>(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint* strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, ref resourceTextureProperties, data, strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateResourceTexture<TI0>(ref Guid resourceId, ref ResourceTextureProperties resourceTextureProperties, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ref uint strides, uint dataSize, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateResourceTexture(ref resourceId, ref resourceTextureProperties, data, ref strides, dataSize, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FindResourceTexture<TI0>(out ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            resourceTexture = default;
            return @this->FindResourceTexture(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FindResourceTexture<TI0>(ref Guid resourceId, ref ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindResourceTexture(ref resourceId, (ID2D1ResourceTexture**) resourceTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(vertexBufferProperties, resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(VertexBufferProperties* vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(vertexBufferProperties, resourceId, ref customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(vertexBufferProperties, ref resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(VertexBufferProperties* vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(vertexBufferProperties, ref resourceId, ref customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(ref vertexBufferProperties, resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(ref VertexBufferProperties vertexBufferProperties, Guid* resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(ref vertexBufferProperties, resourceId, ref customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, CustomVertexBufferProperties* customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(ref vertexBufferProperties, ref resourceId, customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVertexBuffer<TI0>(ref VertexBufferProperties vertexBufferProperties, ref Guid resourceId, ref CustomVertexBufferProperties customVertexBufferProperties, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(ref vertexBufferProperties, ref resourceId, ref customVertexBufferProperties, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FindVertexBuffer<TI0>(out ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            buffer = default;
            return @this->FindVertexBuffer(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FindVertexBuffer<TI0>(ref Guid resourceId, ref ComPtr<TI0> buffer) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindVertexBuffer(ref resourceId, (ID2D1VertexBuffer**) buffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext<TI0>(ColorSpace space, byte* profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContext(space, profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContext<TI0>(ColorSpace space, ref byte profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContext(space, ref profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContext<TI0>(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContext(space, profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename<TI0>(char* filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContextFromFilename(filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContextFromFilename<TI0>(ref char filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContextFromFilename(ref filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContextFromFilename<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContextFromFilename(filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext<TI0>(IWICColorContext* wicColorContext, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContextFromWicColorContext(wicColorContext, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContextFromWicColorContext<TI0>(ref IWICColorContext wicColorContext, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContextFromWicColorContext(ref wicColorContext, (ID2D1ColorContext**) colorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, extents, data, dataCount, strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, uint* extents, byte* data, uint dataCount, ref uint strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, extents, data, dataCount, ref strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, uint* strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, extents, ref data, dataCount, strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, ref uint strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, extents, ref data, dataCount, ref strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, extents, data, dataCount, strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, extents, data, dataCount, ref strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, uint* strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, ref extents, data, dataCount, strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, ref uint strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, ref extents, data, dataCount, ref strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, uint* strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, ref extents, ref data, dataCount, strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateLookupTable3D<TI0>(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, ref uint strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, ref extents, ref data, dataCount, ref strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D<TI0>(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, ref extents, data, dataCount, strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateLookupTable3D<TI0>(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ref ComPtr<TI0> lookupTable) where TI0 : unmanaged, IComVtbl<ID2D1LookupTable3D>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLookupTable3D(precision, ref extents, data, dataCount, ref strides, (ID2D1LookupTable3D**) lookupTable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateEffect<TI0>() where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateEffect(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> FindResourceTexture<TI0>() where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->FindResourceTexture(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> FindVertexBuffer<TI0>() where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->FindVertexBuffer(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
