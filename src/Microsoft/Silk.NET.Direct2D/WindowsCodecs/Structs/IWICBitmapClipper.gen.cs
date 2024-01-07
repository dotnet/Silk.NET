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
    [Guid("e4fbcf03-223d-4e81-9333-d635556dd1b5")]
    [NativeName("Name", "IWICBitmapClipper")]
    public unsafe partial struct IWICBitmapClipper : IComVtbl<IWICBitmapClipper>, IComVtbl<IWICBitmapSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e4fbcf03-223d-4e81-9333-d635556dd1b5");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapSource(IWICBitmapClipper val)
            => Unsafe.As<IWICBitmapClipper, IWICBitmapSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapClipper val)
            => Unsafe.As<IWICBitmapClipper, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapClipper
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
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, double* pDpiY)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, ref double pDpiY)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(ref double pDpiX, double* pDpiY)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResolution(ref double pDpiX, ref double pDpiY)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                fixed (double* pDpiYPtr = &pDpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pISource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[8])(@this, pISource, prc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pISource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[8])(@this, pISource, prcPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pISource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISourcePtr = &pISource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[8])(@this, pISourcePtr, prc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref IWICBitmapSource pISource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc)
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISourcePtr = &pISource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapClipper*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[8])(@this, pISourcePtr, prcPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ComPtr<TI0> pISource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pISource.Handle, prc);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ComPtr<TI0> pISource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pISource.Handle, in prc);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapClipper*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
