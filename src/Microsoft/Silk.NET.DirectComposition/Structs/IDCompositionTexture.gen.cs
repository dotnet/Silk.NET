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
    [Guid("929bb1aa-725f-433b-abd7-273075a835f2")]
    [NativeName("Name", "IDCompositionTexture")]
    public unsafe partial struct IDCompositionTexture : IComVtbl<IDCompositionTexture>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("929bb1aa-725f-433b-abd7-273075a835f2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionTexture val)
            => Unsafe.As<IDCompositionTexture, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionTexture
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
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceRect(Silk.NET.Maths.Box2D<uint>* sourceRect)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[3])(@this, sourceRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceRect(ref Silk.NET.Maths.Box2D<uint> sourceRect)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectPtr = &sourceRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[3])(@this, sourceRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColorSpace(Silk.NET.DXGI.ColorSpaceType colorSpace)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.DXGI.ColorSpaceType, int>)@this->LpVtbl[4])(@this, colorSpace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaMode(Silk.NET.DXGI.AlphaMode alphaMode)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.DXGI.AlphaMode, int>)@this->LpVtbl[5])(@this, alphaMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ulong* fenceValue, Guid* iid, void** availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iid, availableFence);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ulong* fenceValue, Guid* iid, ref void* availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** availableFencePtr = &availableFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iid, availableFencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ulong* fenceValue, ref Guid iid, void** availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iidPtr, availableFence);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ulong* fenceValue, ref Guid iid, ref void* availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** availableFencePtr = &availableFence)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iidPtr, availableFencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ref ulong fenceValue, Guid* iid, void** availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* fenceValuePtr = &fenceValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iid, availableFence);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ref ulong fenceValue, Guid* iid, ref void* availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* fenceValuePtr = &fenceValue)
            {
                fixed (void** availableFencePtr = &availableFence)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iid, availableFencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ref ulong fenceValue, ref Guid iid, void** availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* fenceValuePtr = &fenceValue)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iidPtr, availableFence);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence(ref ulong fenceValue, ref Guid iid, ref void* availableFence)
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* fenceValuePtr = &fenceValue)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** availableFencePtr = &availableFence)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iidPtr, availableFencePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableFence<TI0>(ulong* fenceValue, out ComPtr<TI0> availableFence) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            availableFence = default;
            return @this->GetAvailableFence(fenceValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) availableFence.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAvailableFence<TI0>(ref ulong fenceValue, out ComPtr<TI0> availableFence) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            availableFence = default;
            return @this->GetAvailableFence(ref fenceValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) availableFence.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetAvailableFence<TI0>(ulong* fenceValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetAvailableFence(fenceValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetAvailableFence<TI0>(ref ulong fenceValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetAvailableFence(ref fenceValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
