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
    [Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75")]
    [NativeName("Name", "IDWriteRenderingParams")]
    public unsafe partial struct IDWriteRenderingParams : IComVtbl<IDWriteRenderingParams>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2f0da53a-2add-47cd-82ee-d9ec34688e75");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteRenderingParams val)
            => Unsafe.As<IDWriteRenderingParams, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteRenderingParams
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
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetGamma()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetEnhancedContrast()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetClearTypeLevel()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PixelGeometry GetPixelGeometry()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PixelGeometry ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, PixelGeometry>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly RenderingMode GetRenderingMode()
        {
            var @this = (IDWriteRenderingParams*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            RenderingMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, RenderingMode>)@this->LpVtbl[7])(@this);
            return ret;
        }

    }
}
