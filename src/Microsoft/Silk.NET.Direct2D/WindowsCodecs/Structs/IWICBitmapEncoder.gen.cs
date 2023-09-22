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
    [Guid("00000103-a8f2-4877-ba0a-fd2b6645fb94")]
    [NativeName("Name", "IWICBitmapEncoder")]
    public unsafe partial struct IWICBitmapEncoder : IComVtbl<IWICBitmapEncoder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000103-a8f2-4877-ba0a-fd2b6645fb94");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapEncoder val)
            => Unsafe.As<IWICBitmapEncoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapEncoder
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
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(Silk.NET.Core.Win32Extras.IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Silk.NET.Core.Win32Extras.IStream*, WICBitmapEncoderCacheOption, int>)@this->LpVtbl[3])(@this, pIStream, cacheOption);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref Silk.NET.Core.Win32Extras.IStream pIStream, WICBitmapEncoderCacheOption cacheOption)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Silk.NET.Core.Win32Extras.IStream*, WICBitmapEncoderCacheOption, int>)@this->LpVtbl[3])(@this, pIStreamPtr, cacheOption);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormat(Guid* pguidContainerFormat)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, int>)@this->LpVtbl[4])(@this, pguidContainerFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormat(ref Guid pguidContainerFormat)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, int>)@this->LpVtbl[4])(@this, pguidContainerFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoderInfo(IWICBitmapEncoderInfo** ppIEncoderInfo)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int>)@this->LpVtbl[5])(@this, ppIEncoderInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoderInfo(ref IWICBitmapEncoderInfo* ppIEncoderInfo)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapEncoderInfo** ppIEncoderInfoPtr = &ppIEncoderInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int>)@this->LpVtbl[5])(@this, ppIEncoderInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColorContexts(uint cCount, IWICColorContext** ppIColorContext)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint, IWICColorContext**, int>)@this->LpVtbl[6])(@this, cCount, ppIColorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColorContexts(uint cCount, ref IWICColorContext* ppIColorContext)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextPtr = &ppIColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint, IWICColorContext**, int>)@this->LpVtbl[6])(@this, cCount, ppIColorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetThumbnail(IWICBitmapSource* pIThumbnail)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[8])(@this, pIThumbnail);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetThumbnail(ref IWICBitmapSource pIThumbnail)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIThumbnailPtr = &pIThumbnail)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[8])(@this, pIThumbnailPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPreview(IWICBitmapSource* pIPreview)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIPreview);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPreview(ref IWICBitmapSource pIPreview)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIPreviewPtr = &pIPreview)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIPreviewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, Silk.NET.Core.Native.IUnknown** ppIEncoderOptions)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, ppIFrameEncode, ppIEncoderOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, ref Silk.NET.Core.Native.IUnknown* ppIEncoderOptions)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppIEncoderOptionsPtr = &ppIEncoderOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, ppIFrameEncode, ppIEncoderOptionsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, Silk.NET.Core.Native.IUnknown** ppIEncoderOptions)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, ppIFrameEncodePtr, ppIEncoderOptions);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, ref Silk.NET.Core.Native.IUnknown* ppIEncoderOptions)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIEncoderOptionsPtr = &ppIEncoderOptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, ppIFrameEncodePtr, ppIEncoderOptionsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit()
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, int>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[12])(@this, ppIMetadataQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryWriter(ref IWICMetadataQueryWriter* ppIMetadataQueryWriter)
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIMetadataQueryWriterPtr = &ppIMetadataQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[12])(@this, ppIMetadataQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ComPtr<TI0> pIStream, WICBitmapEncoderCacheOption cacheOption) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, cacheOption);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncoderInfo<TI0>(ref ComPtr<TI0> ppIEncoderInfo) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoderInfo>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEncoderInfo((IWICBitmapEncoderInfo**) ppIEncoderInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetColorContexts(cCount, (IWICColorContext**) ppIColorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetThumbnail<TI0>(ComPtr<TI0> pIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetThumbnail((IWICBitmapSource*) pIThumbnail.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPreview<TI0>(ComPtr<TI0> pIPreview) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPreview((IWICBitmapSource*) pIPreview.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateNewFrame<TI0, TI1>(ref ComPtr<TI0> ppIFrameEncode, ref ComPtr<TI1> ppIEncoderOptions) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), (Silk.NET.Core.Native.IUnknown**) ppIEncoderOptions.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, ref Silk.NET.Core.Native.IUnknown* ppIEncoderOptions) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref ppIEncoderOptions);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref IWICBitmapFrameEncode* ppIFrameEncode, ref ComPtr<TI0> ppIEncoderOptions) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame(ref ppIFrameEncode, (Silk.NET.Core.Native.IUnknown**) ppIEncoderOptions.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataQueryWriter<TI0>(ref ComPtr<TI0> ppIMetadataQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataQueryWriter((IWICMetadataQueryWriter**) ppIMetadataQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
