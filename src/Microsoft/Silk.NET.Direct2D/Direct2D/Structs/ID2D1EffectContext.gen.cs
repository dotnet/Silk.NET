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
    public unsafe partial struct ID2D1EffectContext : IComVtbl<ID2D1EffectContext>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3d9f916b-27dc-4ad7-b4f1-64945340f563");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, float*, float*, void>)@this->LpVtbl[3])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[4])(@this, effectId, effect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumSupportedFeatureLevel([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* featureLevels, uint featureLevelsCount, Silk.NET.Core.Native.D3DFeatureLevel* maximumSupportedFeatureLevel)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Core.Native.D3DFeatureLevel*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[5])(@this, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)@this->LpVtbl[6])(@this, effect, transformNode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendTransform(uint numInputs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, ID2D1BlendTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, uint, BlendDescription*, ID2D1BlendTransform**, int>)@this->LpVtbl[7])(@this, numInputs, blendDescription, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBorderTransform(ExtendMode extendModeX, ExtendMode extendModeY, ID2D1BorderTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ExtendMode, ExtendMode, ID2D1BorderTransform**, int>)@this->LpVtbl[8])(@this, extendModeX, extendModeY, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffsetTransform(Silk.NET.Maths.Vector2D<int> offset, ID2D1OffsetTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Vector2D<int>, ID2D1OffsetTransform**, int>)@this->LpVtbl[9])(@this, offset, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBoundsAdjustmentTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Silk.NET.Maths.Box2D<int>*, ID2D1BoundsAdjustmentTransform**, int>)@this->LpVtbl[10])(@this, outputRectangle, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPixelShader(Guid* shaderId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[11])(@this, shaderId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadVertexShader(Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[12])(@this, resourceId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputeShader(Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* shaderBuffer, uint shaderBufferCount)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, byte*, uint, int>)@this->LpVtbl[13])(@this, resourceId, shaderBuffer, shaderBufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsShaderLoaded(Guid* shaderId)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this, shaderId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateResourceTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceTextureProperties* resourceTextureProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)@this->LpVtbl[15])(@this, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindResourceTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)@this->LpVtbl[16])(@this, resourceId, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferProperties* vertexBufferProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CustomVertexBufferProperties* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, ID2D1VertexBuffer**, int>)@this->LpVtbl[17])(@this, vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* resourceId, ID2D1VertexBuffer** buffer)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)@this->LpVtbl[18])(@this, resourceId, buffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[19])(@this, space, profile, profileSize, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[20])(@this, filename, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[21])(@this, wicColorContext, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature feature, void* featureSupportData, uint featureSupportDataSize)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, Feature, void*, uint, int>)@this->LpVtbl[22])(@this, feature, featureSupportData, featureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsBufferPrecisionSupported(BufferPrecision bufferPrecision)
        {
            var @this = (ID2D1EffectContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectContext*, BufferPrecision, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this, bufferPrecision);
            return ret;
        }

    }
}
