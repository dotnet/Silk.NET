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

namespace Silk.NET.DirectComposition
{
    [Guid("0b74b9e8-cdd6-492f-bbbc-5ed32157026d")]
    [NativeName("Name", "IDCompositionAffineTransform2DEffect")]
    public unsafe partial struct IDCompositionAffineTransform2DEffect : IComVtbl<IDCompositionAffineTransform2DEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0b74b9e8-cdd6-492f-bbbc-5ed32157026d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionAffineTransform2DEffect val)
            => Unsafe.As<IDCompositionAffineTransform2DEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionAffineTransform2DEffect val)
            => Unsafe.As<IDCompositionAffineTransform2DEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionAffineTransform2DEffect val)
            => Unsafe.As<IDCompositionAffineTransform2DEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionAffineTransform2DEffect
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
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInterpolationMode(Silk.NET.Direct2D.D2D12DaffinetransformInterpolationMode interpolationMode)
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Silk.NET.Direct2D.D2D12DaffinetransformInterpolationMode, int>)@this->LpVtbl[4])(@this, interpolationMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBorderMode(Silk.NET.Direct2D.BorderMode borderMode)
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Silk.NET.Direct2D.BorderMode, int>)@this->LpVtbl[5])(@this, borderMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransformMatrix(Silk.NET.Maths.Matrix3X2<float>* transformMatrix)
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, transformMatrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransformMatrixElement(int row, int column, float value)
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, int, int, float, int>)@this->LpVtbl[8])(@this, row, column, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSharpness(float sharpness)
        {
            var @this = (IDCompositionAffineTransform2DEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, float, int>)@this->LpVtbl[10])(@this, sharpness);
            return ret;
        }

    }
}
