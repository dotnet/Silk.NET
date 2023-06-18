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
    [Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c")]
    [NativeName("Name", "ID2D1ImageBrush")]
    public unsafe partial struct ID2D1ImageBrush : IComVtbl<ID2D1ImageBrush>, IComVtbl<ID2D1Brush>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fe9e984d-3f95-407c-b5db-cb94d4e8f87c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Brush(ID2D1ImageBrush val)
            => Unsafe.As<ID2D1ImageBrush, ID2D1Brush>(ref val);

        public static implicit operator ID2D1Resource(ID2D1ImageBrush val)
            => Unsafe.As<ID2D1ImageBrush, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1ImageBrush val)
            => Unsafe.As<ID2D1ImageBrush, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1ImageBrush
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
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetOpacity(float opacity)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float, void>)@this->LpVtbl[4])(@this, opacity);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly float GetOpacity()
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetImage(ID2D1Image* image)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image*, void>)@this->LpVtbl[8])(@this, image);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetExtendModeX(ExtendMode extendModeX)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)@this->LpVtbl[9])(@this, extendModeX);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetExtendModeY(ExtendMode extendModeY)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)@this->LpVtbl[10])(@this, extendModeY);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetInterpolationMode(InterpolationMode interpolationMode)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode, void>)@this->LpVtbl[11])(@this, interpolationMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetSourceRectangle([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[12])(@this, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetImage(ID2D1Image** image)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image**, void>)@this->LpVtbl[13])(@this, image);
        }

        /// <summary>To be documented.</summary>
        public readonly ExtendMode GetExtendModeX()
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ExtendMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ExtendMode GetExtendModeY()
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ExtendMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly InterpolationMode GetInterpolationMode()
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            InterpolationMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetSourceRectangle(Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1ImageBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[17])(@this, sourceRectangle);
        }

    }
}
