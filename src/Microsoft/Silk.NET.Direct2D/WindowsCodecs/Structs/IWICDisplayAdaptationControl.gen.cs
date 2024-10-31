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

namespace Silk.NET.WindowsCodecs
{
    [Guid("de9d91d2-70b4-4f41-836c-25fcd39626d3")]
    [NativeName("Name", "IWICDisplayAdaptationControl")]
    public unsafe partial struct IWICDisplayAdaptationControl : IComVtbl<IWICDisplayAdaptationControl>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("de9d91d2-70b4-4f41-836c-25fcd39626d3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICDisplayAdaptationControl val)
            => Unsafe.As<IWICDisplayAdaptationControl, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICDisplayAdaptationControl
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
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportChangingMaxLuminance(Guid* pguidDstFormat, int* pfIsSupported)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormat, pfIsSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportChangingMaxLuminance(Guid* pguidDstFormat, ref int pfIsSupported)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfIsSupportedPtr = &pfIsSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormat, pfIsSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportChangingMaxLuminance(ref Guid pguidDstFormat, int* pfIsSupported)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormatPtr, pfIsSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportChangingMaxLuminance(ref Guid pguidDstFormat, ref int pfIsSupported)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                fixed (int* pfIsSupportedPtr = &pfIsSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormatPtr, pfIsSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplayMaxLuminance(float fLuminanceInNits)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, float, int>)@this->LpVtbl[4])(@this, fLuminanceInNits);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayMaxLuminance(float* pfLuminanceInNits)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, float*, int>)@this->LpVtbl[5])(@this, pfLuminanceInNits);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayMaxLuminance(ref float pfLuminanceInNits)
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pfLuminanceInNitsPtr = &pfLuminanceInNits)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, float*, int>)@this->LpVtbl[5])(@this, pfLuminanceInNitsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDisplayAdaptationControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
