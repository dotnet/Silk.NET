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
    [Guid("c3373fdf-6d39-4e5f-8e79-bf40c0b7ed77")]
    [NativeName("Name", "IWICBitmapSourceTransform2")]
    public unsafe partial struct IWICBitmapSourceTransform2 : IComVtbl<IWICBitmapSourceTransform2>, IComVtbl<IWICBitmapSourceTransform>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c3373fdf-6d39-4e5f-8e79-bf40c0b7ed77");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapSourceTransform(IWICBitmapSourceTransform2 val)
            => Unsafe.As<IWICBitmapSourceTransform2, IWICBitmapSourceTransform>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapSourceTransform2 val)
            => Unsafe.As<IWICBitmapSourceTransform2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapSourceTransform2
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
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
                {
                    fixed (byte* pbBufferPtr = &pbBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
                {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClosestSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClosestSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClosestSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClosestSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClosestPixelFormat(Guid* pguidDstFormat)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, int>)@this->LpVtbl[5])(@this, pguidDstFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClosestPixelFormat(ref Guid pguidDstFormat)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, int>)@this->LpVtbl[5])(@this, pguidDstFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(BitmapTransformOptions dstTransform, int* pfIsSupported)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, BitmapTransformOptions, int*, int>)@this->LpVtbl[6])(@this, dstTransform, pfIsSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportTransform(BitmapTransformOptions dstTransform, ref int pfIsSupported)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfIsSupportedPtr = &pfIsSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, BitmapTransformOptions, int*, int>)@this->LpVtbl[6])(@this, dstTransform, pfIsSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(Guid* pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormat, cCount, ppIColorContexts, pcActualCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(Guid* pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormat, cCount, ppIColorContexts, pcActualCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(Guid* pPixelFormat, uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormat, cCount, ppIColorContextsPtr, pcActualCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(Guid* pPixelFormat, uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                fixed (uint* pcActualCountPtr = &pcActualCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormat, cCount, ppIColorContextsPtr, pcActualCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(ref Guid pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormatPtr, cCount, ppIColorContexts, pcActualCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(ref Guid pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                fixed (uint* pcActualCountPtr = &pcActualCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormatPtr, cCount, ppIColorContexts, pcActualCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(ref Guid pPixelFormat, uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormatPtr, cCount, ppIColorContextsPtr, pcActualCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat(ref Guid pPixelFormat, uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
                {
                    fixed (uint* pcActualCountPtr = &pcActualCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[7])(@this, pPixelFormatPtr, cCount, ppIColorContextsPtr, pcActualCountPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat<TI0>(Guid* pPixelFormat, uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContextsForPixelFormat(pPixelFormat, cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat<TI0>(Guid* pPixelFormat, uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContextsForPixelFormat(pPixelFormat, cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContextsForPixelFormat<TI0>(ref Guid pPixelFormat, uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContextsForPixelFormat(ref pPixelFormat, cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorContextsForPixelFormat<TI0>(ref Guid pPixelFormat, uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContextsForPixelFormat(ref pPixelFormat, cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapSourceTransform2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
