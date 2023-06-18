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
    [Guid("a6a55bda-c09c-49f3-9193-a41922c89715")]
    [NativeName("Name", "IDCompositionTurbulenceEffect")]
    public unsafe partial struct IDCompositionTurbulenceEffect : IComVtbl<IDCompositionTurbulenceEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a6a55bda-c09c-49f3-9193-a41922c89715");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionTurbulenceEffect val)
            => Unsafe.As<IDCompositionTurbulenceEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionTurbulenceEffect val)
            => Unsafe.As<IDCompositionTurbulenceEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionTurbulenceEffect val)
            => Unsafe.As<IDCompositionTurbulenceEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionTurbulenceEffect
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
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOffset(Silk.NET.Maths.Vector2D<float>* offset)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[4])(@this, offset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBaseFrequency(Silk.NET.Maths.Vector2D<float>* frequency)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[5])(@this, frequency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSize(Silk.NET.Maths.Vector2D<float>* size)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[6])(@this, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNumOctaves(uint numOctaves)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, int>)@this->LpVtbl[7])(@this, numOctaves);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSeed(uint seed)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, int>)@this->LpVtbl[8])(@this, seed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNoise(Silk.NET.Direct2D.TurbulenceNoise noise)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Direct2D.TurbulenceNoise, int>)@this->LpVtbl[9])(@this, noise);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStitchable(Silk.NET.Core.Bool32 stitchable)
        {
            var @this = (IDCompositionTurbulenceEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, stitchable);
            return ret;
        }

    }
}
