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
    [Guid("af671749-d241-4db8-8e41-dcc2e5c1a438")]
    [NativeName("Name", "ID2D1SvgGlyphStyle")]
    public unsafe partial struct ID2D1SvgGlyphStyle : IComVtbl<ID2D1SvgGlyphStyle>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("af671749-d241-4db8-8e41-dcc2e5c1a438");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1SvgGlyphStyle val)
            => Unsafe.As<ID2D1SvgGlyphStyle, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgGlyphStyle val)
            => Unsafe.As<ID2D1SvgGlyphStyle, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgGlyphStyle
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
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFill(ID2D1Brush* brush)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)@this->LpVtbl[4])(@this, brush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFill(ID2D1Brush** brush)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)@this->LpVtbl[5])(@this, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStroke(ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetStrokeDashesCount()
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

    }
}
