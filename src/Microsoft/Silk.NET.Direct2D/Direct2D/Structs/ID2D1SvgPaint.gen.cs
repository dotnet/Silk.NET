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
    [Guid("d59bab0a-68a2-455b-a5dc-9eb2854e2490")]
    [NativeName("Name", "ID2D1SvgPaint")]
    public unsafe partial struct ID2D1SvgPaint : IComVtbl<ID2D1SvgPaint>, IComVtbl<ID2D1SvgAttribute>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d59bab0a-68a2-455b-a5dc-9eb2854e2490");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1SvgAttribute(ID2D1SvgPaint val)
            => Unsafe.As<ID2D1SvgPaint, ID2D1SvgAttribute>(ref val);

        public static implicit operator ID2D1Resource(ID2D1SvgPaint val)
            => Unsafe.As<ID2D1SvgPaint, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgPaint val)
            => Unsafe.As<ID2D1SvgPaint, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgPaint
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
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPaintType(SvgPaintType paintType)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType, int>)@this->LpVtbl[6])(@this, paintType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SvgPaintType GetPaintType()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SvgPaintType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[8])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetColor(Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[9])(@this, color);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetId([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)@this->LpVtbl[10])(@this, id);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetId(char* id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)@this->LpVtbl[11])(@this, id, idCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetIdLength()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[12])(@this);
            return ret;
        }

    }
}
