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
    [Guid("b66f034f-d0e2-40ab-b436-6de39e321a94")]
    [NativeName("Name", "IWICColorTransform")]
    public unsafe partial struct IWICColorTransform : IComVtbl<IWICColorTransform>, IComVtbl<IWICBitmapSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b66f034f-d0e2-40ab-b436-6de39e321a94");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapSource(IWICColorTransform val)
            => Unsafe.As<IWICColorTransform, IWICBitmapSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICColorTransform val)
            => Unsafe.As<IWICColorTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICColorTransform
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
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, double* pDpiY)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, ref double pDpiY)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(ref double pDpiX, double* pDpiY)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResolution(ref double pDpiX, ref double pDpiY)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                fixed (double* pDpiYPtr = &pDpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDestPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDestPtr, pixelFmtDest);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
            {
                fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDestPtr, pixelFmtDestPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDest, pixelFmtDest);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDest, pixelFmtDestPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDestPtr, pixelFmtDest);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                {
                    fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDestPtr, pixelFmtDestPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDest, pixelFmtDest);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDest, pixelFmtDestPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDestPtr, pixelFmtDest);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                {
                    fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDestPtr, pixelFmtDestPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDest, pixelFmtDest);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
                {
                    fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDest, pixelFmtDestPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
                {
                    fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDestPtr, pixelFmtDest);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
                {
                    fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                    {
                        fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDestPtr, pixelFmtDestPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0, TI1, TI2>(ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ComPtr<TI2> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI2>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1, TI2>(ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ComPtr<TI2> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI2>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0, TI1>(ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1>(ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0, TI1>(ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI1> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1>(ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI1> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, ref pIContextDest, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, ref pIContextDest, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0, TI1>(ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ComPtr<TI1> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1>(ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ComPtr<TI1> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize<TI0>(ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI0> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pIBitmapSource, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI0> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref pIBitmapSource, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICColorTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
