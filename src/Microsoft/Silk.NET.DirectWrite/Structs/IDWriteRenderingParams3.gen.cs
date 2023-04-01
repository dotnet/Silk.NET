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
    [Guid("b7924baa-391b-412a-8c5c-e44cc2d867dc")]
    [NativeName("Name", "IDWriteRenderingParams3")]
    public unsafe partial struct IDWriteRenderingParams3 : IComVtbl<IDWriteRenderingParams3>, IComVtbl<IDWriteRenderingParams2>, IComVtbl<IDWriteRenderingParams1>, IComVtbl<IDWriteRenderingParams>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b7924baa-391b-412a-8c5c-e44cc2d867dc");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteRenderingParams2(IDWriteRenderingParams3 val)
            => Unsafe.As<IDWriteRenderingParams3, IDWriteRenderingParams2>(ref val);

        public static implicit operator IDWriteRenderingParams1(IDWriteRenderingParams3 val)
            => Unsafe.As<IDWriteRenderingParams3, IDWriteRenderingParams1>(ref val);

        public static implicit operator IDWriteRenderingParams(IDWriteRenderingParams3 val)
            => Unsafe.As<IDWriteRenderingParams3, IDWriteRenderingParams>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteRenderingParams3 val)
            => Unsafe.As<IDWriteRenderingParams3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteRenderingParams3
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
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetGamma()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, float>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetEnhancedContrast()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, float>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetClearTypeLevel()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, float>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PixelGeometry GetPixelGeometry()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PixelGeometry ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, PixelGeometry>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly RenderingMode GetRenderingMode()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            RenderingMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, RenderingMode>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetGrayscaleEnhancedContrast()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, float>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly GridFitMode GetGridFitMode()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            GridFitMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, GridFitMode>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly RenderingMode1 GetRenderingMode1()
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            RenderingMode1 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams3*, RenderingMode1>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteRenderingParams3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
