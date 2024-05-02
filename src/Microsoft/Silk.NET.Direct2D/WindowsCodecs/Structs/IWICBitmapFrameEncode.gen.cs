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
    [Guid("00000105-a8f2-4877-ba0a-fd2b6645fb94")]
    [NativeName("Name", "IWICBitmapFrameEncode")]
    public unsafe partial struct IWICBitmapFrameEncode : IComVtbl<IWICBitmapFrameEncode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000105-a8f2-4877-ba0a-fd2b6645fb94");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapFrameEncode val)
            => Unsafe.As<IWICBitmapFrameEncode, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapFrameEncode
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
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(Silk.NET.Core.Win32Extras.IPropertyBag2* pIEncoderOptions)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Silk.NET.Core.Win32Extras.IPropertyBag2*, int>)@this->LpVtbl[3])(@this, pIEncoderOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref Silk.NET.Core.Win32Extras.IPropertyBag2 pIEncoderOptions)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IPropertyBag2* pIEncoderOptionsPtr = &pIEncoderOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Silk.NET.Core.Win32Extras.IPropertyBag2*, int>)@this->LpVtbl[3])(@this, pIEncoderOptionsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSize(uint uiWidth, uint uiHeight)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, int>)@this->LpVtbl[4])(@this, uiWidth, uiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetResolution(double dpiX, double dpiY)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, double, double, int>)@this->LpVtbl[5])(@this, dpiX, dpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColorContexts(uint cCount, IWICColorContext** ppIColorContext)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, IWICColorContext**, int>)@this->LpVtbl[7])(@this, cCount, ppIColorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColorContexts(uint cCount, ref IWICColorContext* ppIColorContext)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextPtr = &ppIColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, IWICColorContext**, int>)@this->LpVtbl[7])(@this, cCount, ppIColorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICPalette*, int>)@this->LpVtbl[8])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICPalette*, int>)@this->LpVtbl[8])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetThumbnail(IWICBitmapSource* pIThumbnail)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIThumbnail);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetThumbnail(ref IWICBitmapSource pIThumbnail)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIThumbnailPtr = &pIThumbnail)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIThumbnailPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)@this->LpVtbl[10])(@this, lineCount, cbStride, cbBufferSize, pbPixels);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, ref byte pbPixels)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbPixelsPtr = &pbPixels)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)@this->LpVtbl[10])(@this, lineCount, cbStride, cbBufferSize, pbPixelsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbPixels)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbPixelsPtr = (byte*) SilkMarshal.StringToPtr(pbPixels, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)@this->LpVtbl[10])(@this, lineCount, cbStride, cbBufferSize, pbPixelsPtr);
            SilkMarshal.Free((nint)pbPixelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(IWICBitmapSource* pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSource, prc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(IWICBitmapSource* pIBitmapSource, ref Silk.NET.Maths.Rectangle<int> prc)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSource, prcPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource(ref IWICBitmapSource pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSourcePtr, prc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteSource(ref IWICBitmapSource pIBitmapSource, ref Silk.NET.Maths.Rectangle<int> prc)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSourcePtr, prcPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit()
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, int>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[13])(@this, ppIMetadataQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryWriter(ref IWICMetadataQueryWriter* ppIMetadataQueryWriter)
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIMetadataQueryWriterPtr = &ppIMetadataQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[13])(@this, ppIMetadataQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetColorContexts(cCount, (IWICColorContext**) ppIColorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetThumbnail<TI0>(ComPtr<TI0> pIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetThumbnail((IWICBitmapSource*) pIThumbnail.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteSource<TI0>(ComPtr<TI0> pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteSource((IWICBitmapSource*) pIBitmapSource.Handle, prc);
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteSource<TI0>(ComPtr<TI0> pIBitmapSource, ref Silk.NET.Maths.Rectangle<int> prc) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteSource((IWICBitmapSource*) pIBitmapSource.Handle, ref prc);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataQueryWriter<TI0>(ref ComPtr<TI0> ppIMetadataQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataQueryWriter((IWICMetadataQueryWriter**) ppIMetadataQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
