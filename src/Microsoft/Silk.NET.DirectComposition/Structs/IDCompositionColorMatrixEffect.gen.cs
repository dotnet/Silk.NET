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
    [Guid("c1170a22-3ce2-4966-90d4-55408bfc84c4")]
    [NativeName("Name", "IDCompositionColorMatrixEffect")]
    public unsafe partial struct IDCompositionColorMatrixEffect : IComVtbl<IDCompositionColorMatrixEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c1170a22-3ce2-4966-90d4-55408bfc84c4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionColorMatrixEffect val)
            => Unsafe.As<IDCompositionColorMatrixEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionColorMatrixEffect val)
            => Unsafe.As<IDCompositionColorMatrixEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionColorMatrixEffect val)
            => Unsafe.As<IDCompositionColorMatrixEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionColorMatrixEffect
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
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMatrix(Silk.NET.Maths.Matrix5X4<float>* matrix)
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Maths.Matrix5X4<float>*, int>)@this->LpVtbl[4])(@this, matrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMatrixElement(int row, int column, float value)
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, int, int, float, int>)@this->LpVtbl[6])(@this, row, column, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaMode(Silk.NET.Direct2D.ColormatrixAlphaMode mode)
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Direct2D.ColormatrixAlphaMode, int>)@this->LpVtbl[7])(@this, mode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClampOutput(Silk.NET.Core.Bool32 clamp)
        {
            var @this = (IDCompositionColorMatrixEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, clamp);
            return ret;
        }

    }
}
