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
    [Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
    [NativeName("Name", "IWICFormatConverter")]
    public unsafe partial struct IWICFormatConverter : IComVtbl<IWICFormatConverter>, IComVtbl<IWICBitmapSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000301-a8f2-4877-ba0a-fd2b6645fb94");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapSource(IWICFormatConverter val)
            => Unsafe.As<IWICFormatConverter, IWICBitmapSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICFormatConverter val)
            => Unsafe.As<IWICFormatConverter, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICFormatConverter
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
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, double* pDpiY)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, ref double pDpiY)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(ref double pDpiX, double* pDpiY)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResolution(ref double pDpiX, ref double pDpiY)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                fixed (double* pDpiYPtr = &pDpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pISource, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pISource, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormat, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pISource, ref Guid dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstFormatPtr = &dstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormatPtr, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pISource, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstFormatPtr = &dstFormat)
            {
                fixed (IWICPalette* pIPalettePtr = &pIPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormatPtr, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pISource, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISourcePtr = &pISource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pISource, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISourcePtr = &pISource)
            {
                fixed (IWICPalette* pIPalettePtr = &pIPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormat, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pISource, ref Guid dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISourcePtr = &pISource)
            {
                fixed (Guid* dstFormatPtr = &dstFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormatPtr, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref IWICBitmapSource pISource, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISourcePtr = &pISource)
            {
                fixed (Guid* dstFormatPtr = &dstFormat)
                {
                    fixed (IWICPalette* pIPalettePtr = &pIPalette)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormatPtr, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(Guid* srcPixelFormat, Guid* dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormat, pfCanConvert);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(Guid* srcPixelFormat, Guid* dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfCanConvertPtr = &pfCanConvert)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormat, pfCanConvertPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(Guid* srcPixelFormat, ref Guid dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormatPtr, pfCanConvert);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(Guid* srcPixelFormat, ref Guid dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
            {
                fixed (int* pfCanConvertPtr = &pfCanConvert)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormatPtr, pfCanConvertPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(ref Guid srcPixelFormat, Guid* dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormat, pfCanConvert);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(ref Guid srcPixelFormat, Guid* dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
            {
                fixed (int* pfCanConvertPtr = &pfCanConvert)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormat, pfCanConvertPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert(ref Guid srcPixelFormat, ref Guid dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
            {
                fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormatPtr, pfCanConvert);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanConvert(ref Guid srcPixelFormat, ref Guid dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
            {
                fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
                {
                    fixed (int* pfCanConvertPtr = &pfCanConvert)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormatPtr, pfCanConvertPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0, TI1>(ComPtr<TI0> pISource, Guid* dstFormat, BitmapDitherType dither, ComPtr<TI1> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI1>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pISource.Handle, dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ComPtr<TI0> pISource, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pISource.Handle, dstFormat, dither, ref pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1>(ComPtr<TI0> pISource, ref Guid dstFormat, BitmapDitherType dither, ComPtr<TI1> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI1>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pISource.Handle, ref dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ComPtr<TI0> pISource, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pISource.Handle, ref dstFormat, dither, ref pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ref IWICBitmapSource pISource, Guid* dstFormat, BitmapDitherType dither, ComPtr<TI0> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pISource, dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ref IWICBitmapSource pISource, ref Guid dstFormat, BitmapDitherType dither, ComPtr<TI0> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pISource, ref dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
