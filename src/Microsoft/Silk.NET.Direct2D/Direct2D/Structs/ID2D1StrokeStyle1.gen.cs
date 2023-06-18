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
    [Guid("10a72a66-e91c-43f4-993f-ddf4b82b0b4a")]
    [NativeName("Name", "ID2D1StrokeStyle1")]
    public unsafe partial struct ID2D1StrokeStyle1 : IComVtbl<ID2D1StrokeStyle1>, IComVtbl<ID2D1StrokeStyle>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("10a72a66-e91c-43f4-993f-ddf4b82b0b4a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1StrokeStyle(ID2D1StrokeStyle1 val)
            => Unsafe.As<ID2D1StrokeStyle1, ID2D1StrokeStyle>(ref val);

        public static implicit operator ID2D1Resource(ID2D1StrokeStyle1 val)
            => Unsafe.As<ID2D1StrokeStyle1, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1StrokeStyle1 val)
            => Unsafe.As<ID2D1StrokeStyle1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1StrokeStyle1
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
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly CapStyle GetStartCap()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CapStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, CapStyle>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CapStyle GetEndCap()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CapStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, CapStyle>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CapStyle GetDashCap()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CapStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, CapStyle>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetMiterLimit()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, float>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly LineJoin GetLineJoin()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            LineJoin ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, LineJoin>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetDashOffset()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, float>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly DashStyle GetDashStyle()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DashStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, DashStyle>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetDashesCount()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, uint>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDashes(float* dashes, uint dashesCount)
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, float*, uint, void>)@this->LpVtbl[12])(@this, dashes, dashesCount);
        }

        /// <summary>To be documented.</summary>
        public readonly StrokeTransformType GetStrokeTransformType()
        {
            var @this = (ID2D1StrokeStyle1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            StrokeTransformType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, StrokeTransformType>)@this->LpVtbl[13])(@this);
            return ret;
        }

    }
}
