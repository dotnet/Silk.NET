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
    [Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
    [NativeName("Name", "IWICBitmapFrameDecode")]
    public unsafe partial struct IWICBitmapFrameDecode : IComVtbl<IWICBitmapFrameDecode>, IComVtbl<IWICBitmapSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3b16811b-6a43-4ec9-a813-3d930c13b940");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapSource(IWICBitmapFrameDecode val)
            => Unsafe.As<IWICBitmapFrameDecode, IWICBitmapSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapFrameDecode val)
            => Unsafe.As<IWICBitmapFrameDecode, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapFrameDecode
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
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, double* pDpiY)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, ref double pDpiY)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(ref double pDpiX, double* pDpiY)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResolution(ref double pDpiX, ref double pDpiY)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                fixed (double* pDpiYPtr = &pDpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryReader(ref IWICMetadataQueryReader* ppIMetadataQueryReader)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader** ppIMetadataQueryReaderPtr = &ppIMetadataQueryReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                fixed (uint* pcActualCountPtr = &pcActualCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnail);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetThumbnail(ref IWICBitmapSource* ppIThumbnail)
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppIThumbnailPtr = &ppIThumbnail)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnailPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataQueryReader<TI0>(ref ComPtr<TI0> ppIMetadataQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataQueryReader((IWICMetadataQueryReader**) ppIMetadataQueryReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetThumbnail<TI0>(ref ComPtr<TI0> ppIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetThumbnail((IWICBitmapSource**) ppIThumbnail.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
