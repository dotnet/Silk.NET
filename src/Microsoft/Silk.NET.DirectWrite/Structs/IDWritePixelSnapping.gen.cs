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
    [Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b")]
    [NativeName("Name", "IDWritePixelSnapping")]
    public unsafe partial struct IDWritePixelSnapping : IComVtbl<IDWritePixelSnapping>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("eaf3a2da-ecf4-4d24-b644-b34f6842024b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWritePixelSnapping val)
            => Unsafe.As<IDWritePixelSnapping, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWritePixelSnapping
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
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled(void* clientDrawingContext, int* isDisabled)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled(void* clientDrawingContext, ref int isDisabled)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isDisabledPtr = &isDisabled)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabledPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled<T0>(ref T0 clientDrawingContext, int* isDisabled) where T0 : unmanaged
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabled);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsPixelSnappingDisabled<T0>(ref T0 clientDrawingContext, ref int isDisabled) where T0 : unmanaged
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (int* isDisabledPtr = &isDisabled)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabledPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(void* clientDrawingContext, Matrix* transform)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(void* clientDrawingContext, ref Matrix transform)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform<T0>(ref T0 clientDrawingContext, Matrix* transform) where T0 : unmanaged
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transform);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentTransform<T0>(ref T0 clientDrawingContext, ref Matrix transform) where T0 : unmanaged
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transformPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip(void* clientDrawingContext, ref float pixelsPerDip)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pixelsPerDipPtr = &pixelsPerDip)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDipPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip<T0>(ref T0 clientDrawingContext, float* pixelsPerDip) where T0 : unmanaged
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDip);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelsPerDip<T0>(ref T0 clientDrawingContext, ref float pixelsPerDip) where T0 : unmanaged
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (float* pixelsPerDipPtr = &pixelsPerDip)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDipPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
