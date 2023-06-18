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
    [Guid("2cd906aa-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1BitmapBrush")]
    public unsafe partial struct ID2D1BitmapBrush : IComVtbl<ID2D1BitmapBrush>, IComVtbl<ID2D1Brush>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2cd906aa-12e2-11dc-9fed-001143a055f9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Brush(ID2D1BitmapBrush val)
            => Unsafe.As<ID2D1BitmapBrush, ID2D1Brush>(ref val);

        public static implicit operator ID2D1Resource(ID2D1BitmapBrush val)
            => Unsafe.As<ID2D1BitmapBrush, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1BitmapBrush val)
            => Unsafe.As<ID2D1BitmapBrush, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1BitmapBrush
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
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetOpacity(float opacity)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float, void>)@this->LpVtbl[4])(@this, opacity);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly float GetOpacity()
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetExtendModeX(ExtendMode extendModeX)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode, void>)@this->LpVtbl[8])(@this, extendModeX);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetExtendModeY(ExtendMode extendModeY)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode, void>)@this->LpVtbl[9])(@this, extendModeY);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetInterpolationMode(BitmapInterpolationMode interpolationMode)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, BitmapInterpolationMode, void>)@this->LpVtbl[10])(@this, interpolationMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetBitmap(ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap*, void>)@this->LpVtbl[11])(@this, bitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly ExtendMode GetExtendModeX()
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ExtendMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ExtendMode GetExtendModeY()
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ExtendMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly BitmapInterpolationMode GetInterpolationMode()
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            BitmapInterpolationMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, BitmapInterpolationMode>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetBitmap(ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap**, void>)@this->LpVtbl[15])(@this, bitmap);
        }

    }
}
