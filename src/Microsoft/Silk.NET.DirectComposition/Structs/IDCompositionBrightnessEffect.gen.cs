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
    [Guid("6027496e-cb3a-49ab-934f-d798da4f7da6")]
    [NativeName("Name", "IDCompositionBrightnessEffect")]
    public unsafe partial struct IDCompositionBrightnessEffect : IComVtbl<IDCompositionBrightnessEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("6027496e-cb3a-49ab-934f-d798da4f7da6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionBrightnessEffect val)
            => Unsafe.As<IDCompositionBrightnessEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionBrightnessEffect val)
            => Unsafe.As<IDCompositionBrightnessEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionBrightnessEffect val)
            => Unsafe.As<IDCompositionBrightnessEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionBrightnessEffect
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
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetWhitePoint(Silk.NET.Maths.Vector2D<float>* whitePoint)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[4])(@this, whitePoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlackPoint(Silk.NET.Maths.Vector2D<float>* blackPoint)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[5])(@this, blackPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWhitePointX(float whitePointX)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[7])(@this, whitePointX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWhitePointY(float whitePointY)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[9])(@this, whitePointY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlackPointX(float blackPointX)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[11])(@this, blackPointX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlackPointY(float blackPointY)
        {
            var @this = (IDCompositionBrightnessEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[13])(@this, blackPointY);
            return ret;
        }

    }
}
