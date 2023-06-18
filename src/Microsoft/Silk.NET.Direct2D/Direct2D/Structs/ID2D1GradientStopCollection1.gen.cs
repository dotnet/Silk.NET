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
    [Guid("ae1572f4-5dd0-4777-998b-9279472ae63b")]
    [NativeName("Name", "ID2D1GradientStopCollection1")]
    public unsafe partial struct ID2D1GradientStopCollection1 : IComVtbl<ID2D1GradientStopCollection1>, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ae1572f4-5dd0-4777-998b-9279472ae63b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1GradientStopCollection(ID2D1GradientStopCollection1 val)
            => Unsafe.As<ID2D1GradientStopCollection1, ID2D1GradientStopCollection>(ref val);

        public static implicit operator ID2D1Resource(ID2D1GradientStopCollection1 val)
            => Unsafe.As<ID2D1GradientStopCollection1, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1GradientStopCollection1 val)
            => Unsafe.As<ID2D1GradientStopCollection1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1GradientStopCollection1
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
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetGradientStopCount()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetGradientStops(GradientStop* gradientStops, uint gradientStopsCount)
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, GradientStop*, uint, void>)@this->LpVtbl[5])(@this, gradientStops, gradientStopsCount);
        }

        /// <summary>To be documented.</summary>
        public readonly Gamma GetColorInterpolationGamma()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Gamma ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, Gamma>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ExtendMode GetExtendMode()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ExtendMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ExtendMode>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetGradientStops1(GradientStop* gradientStops, uint gradientStopsCount)
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, GradientStop*, uint, void>)@this->LpVtbl[8])(@this, gradientStops, gradientStopsCount);
        }

        /// <summary>To be documented.</summary>
        public readonly ColorSpace GetPreInterpolationSpace()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ColorSpace ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorSpace>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ColorSpace GetPostInterpolationSpace()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ColorSpace ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorSpace>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly BufferPrecision GetBufferPrecision()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            BufferPrecision ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, BufferPrecision>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ColorInterpolationMode GetColorInterpolationMode()
        {
            var @this = (ID2D1GradientStopCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ColorInterpolationMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorInterpolationMode>)@this->LpVtbl[12])(@this);
            return ret;
        }

    }
}
