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
    [Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
    [NativeName("Name", "IWICBitmapDecoder")]
    public unsafe partial struct IWICBitmapDecoder : IComVtbl<IWICBitmapDecoder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9edde9e7-8dee-47ea-99df-e6faf2ed44bf");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapDecoder val)
            => Unsafe.As<IWICBitmapDecoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapDecoder
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
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryCapability(Silk.NET.Core.Win32Extras.IStream* pIStream, uint* pdwCapability)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStream, pdwCapability);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryCapability(Silk.NET.Core.Win32Extras.IStream* pIStream, ref uint pdwCapability)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCapabilityPtr = &pdwCapability)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStream, pdwCapabilityPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryCapability(ref Silk.NET.Core.Win32Extras.IStream pIStream, uint* pdwCapability)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStreamPtr, pdwCapability);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryCapability(ref Silk.NET.Core.Win32Extras.IStream pIStream, ref uint pdwCapability)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (uint* pdwCapabilityPtr = &pdwCapability)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStreamPtr, pdwCapabilityPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(Silk.NET.Core.Win32Extras.IStream* pIStream, DecodeOptions cacheOptions)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, DecodeOptions, int>)@this->LpVtbl[4])(@this, pIStream, cacheOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref Silk.NET.Core.Win32Extras.IStream pIStream, DecodeOptions cacheOptions)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, DecodeOptions, int>)@this->LpVtbl[4])(@this, pIStreamPtr, cacheOptions);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormat(Guid* pguidContainerFormat)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, int>)@this->LpVtbl[5])(@this, pguidContainerFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormat(ref Guid pguidContainerFormat)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, int>)@this->LpVtbl[5])(@this, pguidContainerFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)@this->LpVtbl[6])(@this, ppIDecoderInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderInfo(ref IWICBitmapDecoderInfo* ppIDecoderInfo)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoderInfo** ppIDecoderInfoPtr = &ppIDecoderInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)@this->LpVtbl[6])(@this, ppIDecoderInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryReader(ref IWICMetadataQueryReader* ppIMetadataQueryReader)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader** ppIMetadataQueryReaderPtr = &ppIMetadataQueryReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreview(IWICBitmapSource** ppIBitmapSource)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[9])(@this, ppIBitmapSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreview(ref IWICBitmapSource* ppIBitmapSource)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppIBitmapSourcePtr = &ppIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[9])(@this, ppIBitmapSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContexts, pcActualCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContexts, pcActualCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContextsPtr, pcActualCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                fixed (uint* pcActualCountPtr = &pcActualCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContextsPtr, pcActualCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[11])(@this, ppIThumbnail);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetThumbnail(ref IWICBitmapSource* ppIThumbnail)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppIThumbnailPtr = &ppIThumbnail)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[11])(@this, ppIThumbnailPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameCount(uint* pCount)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint*, int>)@this->LpVtbl[12])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameCount(ref uint pCount)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint*, int>)@this->LpVtbl[12])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[13])(@this, index, ppIBitmapFrame);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrame(uint index, ref IWICBitmapFrameDecode* ppIBitmapFrame)
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameDecode** ppIBitmapFramePtr = &ppIBitmapFrame)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[13])(@this, index, ppIBitmapFramePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryCapability<TI0>(ComPtr<TI0> pIStream, uint* pdwCapability) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryCapability((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pdwCapability);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryCapability<TI0>(ComPtr<TI0> pIStream, ref uint pdwCapability) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryCapability((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pdwCapability);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ComPtr<TI0> pIStream, DecodeOptions cacheOptions) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, cacheOptions);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDecoderInfo<TI0>(ref ComPtr<TI0> ppIDecoderInfo) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDecoderInfo((IWICBitmapDecoderInfo**) ppIDecoderInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataQueryReader<TI0>(ref ComPtr<TI0> ppIMetadataQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataQueryReader((IWICMetadataQueryReader**) ppIMetadataQueryReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPreview<TI0>(ref ComPtr<TI0> ppIBitmapSource) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPreview((IWICBitmapSource**) ppIBitmapSource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetThumbnail<TI0>(ref ComPtr<TI0> ppIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetThumbnail((IWICBitmapSource**) ppIThumbnail.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrame<TI0>(uint index, ref ComPtr<TI0> ppIBitmapFrame) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFrame(index, (IWICBitmapFrameDecode**) ppIBitmapFrame.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
