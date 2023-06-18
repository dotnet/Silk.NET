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

namespace Silk.NET.DirectWrite
{
    [Guid("f9d711c3-9777-40ae-87e8-3e5af9bf0948")]
    [NativeName("Name", "IDWriteRenderingParams2")]
    public unsafe partial struct IDWriteRenderingParams2 : IComVtbl<IDWriteRenderingParams2>, IComVtbl<IDWriteRenderingParams1>, IComVtbl<IDWriteRenderingParams>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f9d711c3-9777-40ae-87e8-3e5af9bf0948");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteRenderingParams1(IDWriteRenderingParams2 val)
            => Unsafe.As<IDWriteRenderingParams2, IDWriteRenderingParams1>(ref val);

        public static implicit operator IDWriteRenderingParams(IDWriteRenderingParams2 val)
            => Unsafe.As<IDWriteRenderingParams2, IDWriteRenderingParams>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteRenderingParams2 val)
            => Unsafe.As<IDWriteRenderingParams2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteRenderingParams2
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
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetGamma()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetEnhancedContrast()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetClearTypeLevel()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PixelGeometry GetPixelGeometry()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PixelGeometry ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, PixelGeometry>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly RenderingMode GetRenderingMode()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            RenderingMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, RenderingMode>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetGrayscaleEnhancedContrast()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, float>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly GridFitMode GetGridFitMode()
        {
            var @this = (IDWriteRenderingParams2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            GridFitMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams2*, GridFitMode>)@this->LpVtbl[9])(@this);
            return ret;
        }

    }
}
