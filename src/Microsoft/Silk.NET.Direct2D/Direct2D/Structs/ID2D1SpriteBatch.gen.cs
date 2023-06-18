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
    [Guid("4dc583bf-3a10-438a-8722-e9765224f1f1")]
    [NativeName("Name", "ID2D1SpriteBatch")]
    public unsafe partial struct ID2D1SpriteBatch : IComVtbl<ID2D1SpriteBatch>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4dc583bf-3a10-438a-8722-e9765224f1f1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1SpriteBatch val)
            => Unsafe.As<ID2D1SpriteBatch, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SpriteBatch val)
            => Unsafe.As<ID2D1SpriteBatch, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SpriteBatch
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
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSprites(uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSprites(uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSprites(uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSpriteCount()
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Clear()
        {
            var @this = (ID2D1SpriteBatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, void>)@this->LpVtbl[8])(@this);
        }

    }
}
