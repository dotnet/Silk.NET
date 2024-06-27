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
    [Guid("bebee9cb-83b0-4dcc-8132-b0aaa55eac96")]
    [NativeName("Name", "IWICPlanarFormatConverter")]
    public unsafe partial struct IWICPlanarFormatConverter : IComVtbl<IWICPlanarFormatConverter>, IComVtbl<IWICBitmapSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bebee9cb-83b0-4dcc-8132-b0aaa55eac96");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapSource(IWICPlanarFormatConverter val)
            => Unsafe.As<IWICPlanarFormatConverter, IWICBitmapSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICPlanarFormatConverter val)
            => Unsafe.As<IWICPlanarFormatConverter, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICPlanarFormatConverter
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
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, double* pDpiY)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, ref double pDpiY)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(ref double pDpiX, double* pDpiY)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResolution(ref double pDpiX, ref double pDpiY)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                fixed (double* pDpiYPtr = &pDpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanes, cPlanes, dstFormat, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstFormatPtr = &dstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanes, cPlanes, dstFormatPtr, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstFormatPtr = &dstFormat)
            {
                fixed (IWICPalette* pIPalettePtr = &pIPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanes, cPlanes, dstFormatPtr, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource* ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanesPtr, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource* ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
            {
                fixed (IWICPalette* pIPalettePtr = &pIPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanesPtr, cPlanes, dstFormat, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource* ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
            {
                fixed (Guid* dstFormatPtr = &dstFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanesPtr, cPlanes, dstFormatPtr, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource* ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
            {
                fixed (Guid* dstFormatPtr = &dstFormat)
                {
                    fixed (IWICPalette* pIPalettePtr = &pIPalette)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, ppPlanesPtr, cPlanes, dstFormatPtr, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pSrcPixelFormats, uint cSrcPlanes, Guid* dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pSrcPixelFormats, uint cSrcPlanes, Guid* dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfCanConvertPtr = &pfCanConvert)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvertPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pSrcPixelFormats, uint cSrcPlanes, ref Guid dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormats, cSrcPlanes, dstPixelFormatPtr, pfCanConvert);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pSrcPixelFormats, uint cSrcPlanes, ref Guid dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
            {
                fixed (int* pfCanConvertPtr = &pfCanConvert)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormats, cSrcPlanes, dstPixelFormatPtr, pfCanConvertPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pSrcPixelFormats, uint cSrcPlanes, Guid* dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pSrcPixelFormatsPtr = &pSrcPixelFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormatsPtr, cSrcPlanes, dstPixelFormat, pfCanConvert);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pSrcPixelFormats, uint cSrcPlanes, Guid* dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pSrcPixelFormatsPtr = &pSrcPixelFormats)
            {
                fixed (int* pfCanConvertPtr = &pfCanConvert)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormatsPtr, cSrcPlanes, dstPixelFormat, pfCanConvertPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pSrcPixelFormats, uint cSrcPlanes, ref Guid dstPixelFormat, int* pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pSrcPixelFormatsPtr = &pSrcPixelFormats)
            {
                fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormatsPtr, cSrcPlanes, dstPixelFormatPtr, pfCanConvert);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanConvert([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pSrcPixelFormats, uint cSrcPlanes, ref Guid dstPixelFormat, ref int pfCanConvert)
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pSrcPixelFormatsPtr = &pSrcPixelFormats)
            {
                fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
                {
                    fixed (int* pfCanConvertPtr = &pfCanConvert)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)@this->LpVtbl[9])(@this, pSrcPixelFormatsPtr, cSrcPlanes, dstPixelFormatPtr, pfCanConvertPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0, TI1>(ref ComPtr<TI0> ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, ComPtr<TI1> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI1>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ref ComPtr<TI0> ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, dstFormat, dither, ref pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1>(ref ComPtr<TI0> ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, ComPtr<TI1> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI1>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, ref dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ref ComPtr<TI0> ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, ref dstFormat, dither, ref pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ref IWICBitmapSource* ppPlanes, uint cPlanes, Guid* dstFormat, BitmapDitherType dither, ComPtr<TI0> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref ppPlanes, cPlanes, dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ref IWICBitmapSource* ppPlanes, uint cPlanes, ref Guid dstFormat, BitmapDitherType dither, ComPtr<TI0> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref ppPlanes, cPlanes, ref dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPlanarFormatConverter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
