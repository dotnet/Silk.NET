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

namespace Silk.NET.DirectComposition
{
    [Guid("9842ad7d-d9cf-4908-aed7-48b51da5e7c2")]
    [NativeName("Name", "IDCompositionRectangleClip")]
    public unsafe partial struct IDCompositionRectangleClip : IComVtbl<IDCompositionRectangleClip>, IComVtbl<IDCompositionClip>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9842ad7d-d9cf-4908-aed7-48b51da5e7c2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionClip(IDCompositionRectangleClip val)
            => Unsafe.As<IDCompositionRectangleClip, IDCompositionClip>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionRectangleClip val)
            => Unsafe.As<IDCompositionRectangleClip, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionRectangleClip
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
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLeft(float left)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[4])(@this, left);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTop(float top)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[6])(@this, top);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRight(float right)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[8])(@this, right);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBottom(float bottom)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[10])(@this, bottom);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTopLeftRadiusX(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[12])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTopLeftRadiusY(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[14])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTopRightRadiusX(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[16])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTopRightRadiusY(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[18])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBottomLeftRadiusX(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[20])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBottomLeftRadiusY(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[22])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBottomRightRadiusX(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[24])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBottomRightRadiusY(float radius)
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[26])(@this, radius);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionRectangleClip*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
