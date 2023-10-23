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
    [Guid("f928b7b8-2221-40c1-b72e-7e82f1974d1a")]
    [NativeName("Name", "IWICPlanarBitmapFrameEncode")]
    public unsafe partial struct IWICPlanarBitmapFrameEncode : IComVtbl<IWICPlanarBitmapFrameEncode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f928b7b8-2221-40c1-b72e-7e82f1974d1a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICPlanarBitmapFrameEncode val)
            => Unsafe.As<IWICPlanarBitmapFrameEncode, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICPlanarBitmapFrameEncode
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
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePixels(uint lineCount, BitmapPlane* pPlanes, uint cPlanes)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint, BitmapPlane*, uint, int>)@this->LpVtbl[3])(@this, lineCount, pPlanes, cPlanes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WritePixels(uint lineCount, ref BitmapPlane pPlanes, uint cPlanes)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPlane* pPlanesPtr = &pPlanes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint, BitmapPlane*, uint, int>)@this->LpVtbl[3])(@this, lineCount, pPlanesPtr, cPlanes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, Silk.NET.Maths.Rectangle<int>* prcSource)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanes, cPlanes, prcSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, ref Silk.NET.Maths.Rectangle<int> prcSource)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanes, cPlanes, prcSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(ref IWICBitmapSource* ppPlanes, uint cPlanes, Silk.NET.Maths.Rectangle<int>* prcSource)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanesPtr, cPlanes, prcSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(ref IWICBitmapSource* ppPlanes, uint cPlanes, ref Silk.NET.Maths.Rectangle<int> prcSource)
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanesPtr, cPlanes, prcSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource<TI0>(ref ComPtr<TI0> ppPlanes, uint cPlanes, Silk.NET.Maths.Rectangle<int>* prcSource) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteSource((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, prcSource);
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteSource<TI0>(ref ComPtr<TI0> ppPlanes, uint cPlanes, ref Silk.NET.Maths.Rectangle<int> prcSource) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteSource((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, ref prcSource);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPlanarBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
