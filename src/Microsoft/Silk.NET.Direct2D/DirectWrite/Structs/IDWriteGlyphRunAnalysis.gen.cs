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
        public readonly unsafe int CreateAlphaTexture(TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, byte* alphaValues, uint bufferSize)
        {
            var @this = (IDWriteGlyphRunAnalysis*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValues, bufferSize);
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

    }
}
