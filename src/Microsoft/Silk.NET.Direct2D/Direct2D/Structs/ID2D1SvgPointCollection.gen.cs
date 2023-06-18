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
    [Guid("9dbe4c0d-3572-4dd9-9825-5530813bb712")]
    [NativeName("Name", "ID2D1SvgPointCollection")]
    public unsafe partial struct ID2D1SvgPointCollection : IComVtbl<ID2D1SvgPointCollection>, IComVtbl<ID2D1SvgAttribute>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9dbe4c0d-3572-4dd9-9825-5530813bb712");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1SvgAttribute(ID2D1SvgPointCollection val)
            => Unsafe.As<ID2D1SvgPointCollection, ID2D1SvgAttribute>(ref val);

        public static implicit operator ID2D1Resource(ID2D1SvgPointCollection val)
            => Unsafe.As<ID2D1SvgPointCollection, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgPointCollection val)
            => Unsafe.As<ID2D1SvgPointCollection, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgPointCollection
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
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemovePointsAtEnd(uint pointsCount)
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint, int>)@this->LpVtbl[6])(@this, pointsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdatePoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Silk.NET.Maths.Vector2D<float>*, uint, uint, int>)@this->LpVtbl[7])(@this, points, pointsCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPoints(Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Silk.NET.Maths.Vector2D<float>*, uint, uint, int>)@this->LpVtbl[8])(@this, points, pointsCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPointsCount()
        {
            var @this = (ID2D1SvgPointCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)@this->LpVtbl[9])(@this);
            return ret;
        }

    }
}
