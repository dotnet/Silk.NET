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
    [Guid("7d97dbf7-e085-42d4-81e3-6a883bded118")]
    [NativeName("Name", "IDWriteGlyphRunAnalysis")]
    public unsafe partial struct IDWriteGlyphRunAnalysis : IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7d97dbf7-e085-42d4-81e3-6a883bded118");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteGlyphRunAnalysis val)
            => Unsafe.As<IDWriteGlyphRunAnalysis, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteGlyphRunAnalysis
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
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaTextureBounds(TextureType textureType, Silk.NET.Maths.Box2D<int>* textureBounds)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, textureType, textureBounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAlphaTextureBounds(TextureType textureType, ref Silk.NET.Maths.Box2D<int> textureBounds)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* textureBoundsPtr = &textureBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, textureType, textureBoundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, byte* alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValues, bufferSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, ref byte alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* alphaValuesPtr = &alphaValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValuesPtr, bufferSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var alphaValuesPtr = (byte*) SilkMarshal.StringToPtr(alphaValues, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValuesPtr, bufferSize);
            SilkMarshal.Free((nint)alphaValuesPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> textureBounds, byte* alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* textureBoundsPtr = &textureBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBoundsPtr, alphaValues, bufferSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> textureBounds, ref byte alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> textureBounds, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* blendClearTypeLevelPtr = &blendClearTypeLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* blendEnhancedContrastPtr = &blendEnhancedContrast)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrastPtr, blendClearTypeLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, ref float blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* blendGammaPtr = &blendGamma)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGammaPtr, blendEnhancedContrast, blendClearTypeLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, ref float blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, ref float blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, ref float blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParamsPtr, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, float* blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, float* blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, float* blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, ref float blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, ref float blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, ref float blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetAlphaBlendParams(ref IDWriteRenderingParams renderingParams, ref float blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, float* blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, blendEnhancedContrast, ref blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, float* blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, ref blendEnhancedContrast, blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, float* blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, blendGamma, ref blendEnhancedContrast, ref blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, ref float blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, ref float blendGamma, float* blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, blendEnhancedContrast, ref blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, ref float blendGamma, ref float blendEnhancedContrast, float* blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, ref blendEnhancedContrast, blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAlphaBlendParams<TI0>(ComPtr<TI0> renderingParams, ref float blendGamma, ref float blendEnhancedContrast, ref float blendClearTypeLevel) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAlphaBlendParams((IDWriteRenderingParams*) renderingParams.Handle, ref blendGamma, ref blendEnhancedContrast, ref blendClearTypeLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
