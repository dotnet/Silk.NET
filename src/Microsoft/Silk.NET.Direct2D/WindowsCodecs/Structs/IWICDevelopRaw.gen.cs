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
    [Guid("fbec5e44-f7be-4b65-b7f8-c0c81fef026d")]
    [NativeName("Name", "IWICDevelopRaw")]
    public unsafe partial struct IWICDevelopRaw : IComVtbl<IWICDevelopRaw>, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<IWICBitmapSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fbec5e44-f7be-4b65-b7f8-c0c81fef026d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapFrameDecode(IWICDevelopRaw val)
            => Unsafe.As<IWICDevelopRaw, IWICBitmapFrameDecode>(ref val);

        public static implicit operator IWICBitmapSource(IWICDevelopRaw val)
            => Unsafe.As<IWICDevelopRaw, IWICBitmapSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICDevelopRaw val)
            => Unsafe.As<IWICDevelopRaw, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICDevelopRaw
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
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, double* pDpiY)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(double* pDpiX, ref double pDpiY)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolution(ref double pDpiX, double* pDpiY)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResolution(ref double pDpiX, ref double pDpiY)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pDpiXPtr = &pDpiX)
            {
                fixed (double* pDpiYPtr = &pDpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataQueryReader(ref IWICMetadataQueryReader* ppIMetadataQueryReader)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader** ppIMetadataQueryReaderPtr = &ppIMetadataQueryReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts(uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
            {
                fixed (uint* pcActualCountPtr = &pcActualCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnail);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetThumbnail(ref IWICBitmapSource* ppIThumbnail)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource** ppIThumbnailPtr = &ppIThumbnail)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnailPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryRawCapabilitiesInfo(RawCapabilitiesInfo* pInfo)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawCapabilitiesInfo*, int>)@this->LpVtbl[11])(@this, pInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryRawCapabilitiesInfo(ref RawCapabilitiesInfo pInfo)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RawCapabilitiesInfo* pInfoPtr = &pInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawCapabilitiesInfo*, int>)@this->LpVtbl[11])(@this, pInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadParameterSet(RawParameterSet ParameterSet)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawParameterSet, int>)@this->LpVtbl[12])(@this, ParameterSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentParameterSet(Silk.NET.Core.Win32Extras.IPropertyBag2** ppCurrentParameterSet)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[13])(@this, ppCurrentParameterSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentParameterSet(ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppCurrentParameterSet)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IPropertyBag2** ppCurrentParameterSetPtr = &ppCurrentParameterSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[13])(@this, ppCurrentParameterSetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetExposureCompensation(double ev)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[14])(@this, ev);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExposureCompensation(double* pEV)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[15])(@this, pEV);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetExposureCompensation(ref double pEV)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pEVPtr = &pEV)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[15])(@this, pEVPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWhitePointRGB(uint Red, uint Green, uint Blue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, uint, uint, int>)@this->LpVtbl[16])(@this, Red, Green, Blue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(uint* pRed, uint* pGreen, uint* pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreen, pBlue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(uint* pRed, uint* pGreen, ref uint pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBluePtr = &pBlue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreen, pBluePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(uint* pRed, ref uint pGreen, uint* pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pGreenPtr = &pGreen)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreenPtr, pBlue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(uint* pRed, ref uint pGreen, ref uint pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pGreenPtr = &pGreen)
            {
                fixed (uint* pBluePtr = &pBlue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreenPtr, pBluePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(ref uint pRed, uint* pGreen, uint* pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRedPtr = &pRed)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreen, pBlue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(ref uint pRed, uint* pGreen, ref uint pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRedPtr = &pRed)
            {
                fixed (uint* pBluePtr = &pBlue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreen, pBluePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointRGB(ref uint pRed, ref uint pGreen, uint* pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRedPtr = &pRed)
            {
                fixed (uint* pGreenPtr = &pGreen)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreenPtr, pBlue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWhitePointRGB(ref uint pRed, ref uint pGreen, ref uint pBlue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRedPtr = &pRed)
            {
                fixed (uint* pGreenPtr = &pGreen)
                {
                    fixed (uint* pBluePtr = &pBlue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreenPtr, pBluePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNamedWhitePoint(NamedWhitePoint WhitePoint)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, NamedWhitePoint, int>)@this->LpVtbl[18])(@this, WhitePoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNamedWhitePoint(NamedWhitePoint* pWhitePoint)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, NamedWhitePoint*, int>)@this->LpVtbl[19])(@this, pWhitePoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNamedWhitePoint(ref NamedWhitePoint pWhitePoint)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (NamedWhitePoint* pWhitePointPtr = &pWhitePoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, NamedWhitePoint*, int>)@this->LpVtbl[19])(@this, pWhitePointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWhitePointKelvin(uint WhitePointKelvin)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, int>)@this->LpVtbl[20])(@this, WhitePointKelvin);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWhitePointKelvin(uint* pWhitePointKelvin)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, int>)@this->LpVtbl[21])(@this, pWhitePointKelvin);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWhitePointKelvin(ref uint pWhitePointKelvin)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWhitePointKelvinPtr = &pWhitePointKelvin)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, int>)@this->LpVtbl[21])(@this, pWhitePointKelvinPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(uint* pMinKelvinTemp, uint* pMaxKelvinTemp, ref uint pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(uint* pMinKelvinTemp, ref uint pMaxKelvinTemp, uint* pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTempPtr, pKelvinTempStepValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(uint* pMinKelvinTemp, ref uint pMaxKelvinTemp, ref uint pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
            {
                fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTempPtr, pKelvinTempStepValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(ref uint pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTemp, pKelvinTempStepValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(ref uint pMinKelvinTemp, uint* pMaxKelvinTemp, ref uint pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
            {
                fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTemp, pKelvinTempStepValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKelvinRangeInfo(ref uint pMinKelvinTemp, ref uint pMaxKelvinTemp, uint* pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
            {
                fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTempPtr, pKelvinTempStepValue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKelvinRangeInfo(ref uint pMinKelvinTemp, ref uint pMaxKelvinTemp, ref uint pKelvinTempStepValue)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
            {
                fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
                {
                    fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTempPtr, pKelvinTempStepValuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetContrast(double Contrast)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[23])(@this, Contrast);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContrast(double* pContrast)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[24])(@this, pContrast);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContrast(ref double pContrast)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pContrastPtr = &pContrast)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[24])(@this, pContrastPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGamma(double Gamma)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[25])(@this, Gamma);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGamma(double* pGamma)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[26])(@this, pGamma);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGamma(ref double pGamma)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pGammaPtr = &pGamma)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[26])(@this, pGammaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSharpness(double Sharpness)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[27])(@this, Sharpness);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharpness(double* pSharpness)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[28])(@this, pSharpness);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSharpness(ref double pSharpness)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pSharpnessPtr = &pSharpness)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[28])(@this, pSharpnessPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSaturation(double Saturation)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[29])(@this, Saturation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSaturation(double* pSaturation)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[30])(@this, pSaturation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSaturation(ref double pSaturation)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pSaturationPtr = &pSaturation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[30])(@this, pSaturationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTint(double Tint)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[31])(@this, Tint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTint(double* pTint)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[32])(@this, pTint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTint(ref double pTint)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pTintPtr = &pTint)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[32])(@this, pTintPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNoiseReduction(double NoiseReduction)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[33])(@this, NoiseReduction);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNoiseReduction(double* pNoiseReduction)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[34])(@this, pNoiseReduction);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNoiseReduction(ref double pNoiseReduction)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pNoiseReductionPtr = &pNoiseReduction)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[34])(@this, pNoiseReductionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDestinationColorContext(IWICColorContext* pColorContext)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICColorContext*, int>)@this->LpVtbl[35])(@this, pColorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDestinationColorContext(ref IWICColorContext pColorContext)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* pColorContextPtr = &pColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICColorContext*, int>)@this->LpVtbl[35])(@this, pColorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetToneCurve(uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurve* pToneCurve)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, int>)@this->LpVtbl[36])(@this, cbToneCurveSize, pToneCurve);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetToneCurve(uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurve pToneCurve)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RawToneCurve* pToneCurvePtr = &pToneCurve)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, int>)@this->LpVtbl[36])(@this, cbToneCurveSize, pToneCurvePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetToneCurve(uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetToneCurve(uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, ref uint pcbActualToneCurveBufferSize)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbActualToneCurveBufferSizePtr = &pcbActualToneCurveBufferSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetToneCurve(uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, uint* pcbActualToneCurveBufferSize)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RawToneCurve* pToneCurvePtr = &pToneCurve)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurvePtr, pcbActualToneCurveBufferSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetToneCurve(uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, ref uint pcbActualToneCurveBufferSize)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RawToneCurve* pToneCurvePtr = &pToneCurve)
            {
                fixed (uint* pcbActualToneCurveBufferSizePtr = &pcbActualToneCurveBufferSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurvePtr, pcbActualToneCurveBufferSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRotation(double Rotation)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[38])(@this, Rotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRotation(double* pRotation)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[39])(@this, pRotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRotation(ref double pRotation)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pRotationPtr = &pRotation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[39])(@this, pRotationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderMode(RawRenderMode RenderMode)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawRenderMode, int>)@this->LpVtbl[40])(@this, RenderMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderMode(RawRenderMode* pRenderMode)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawRenderMode*, int>)@this->LpVtbl[41])(@this, pRenderMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderMode(ref RawRenderMode pRenderMode)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RawRenderMode* pRenderModePtr = &pRenderMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawRenderMode*, int>)@this->LpVtbl[41])(@this, pRenderModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetNotificationCallback(IWICDevelopRawNotificationCallback* pCallback)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)@this->LpVtbl[42])(@this, pCallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNotificationCallback(ref IWICDevelopRawNotificationCallback pCallback)
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICDevelopRawNotificationCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)@this->LpVtbl[42])(@this, pCallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataQueryReader<TI0>(ref ComPtr<TI0> ppIMetadataQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataQueryReader((IWICMetadataQueryReader**) ppIMetadataQueryReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorContexts<TI0>(uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetThumbnail<TI0>(ref ComPtr<TI0> ppIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetThumbnail((IWICBitmapSource**) ppIThumbnail.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDestinationColorContext<TI0>(ComPtr<TI0> pColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetDestinationColorContext((IWICColorContext*) pColorContext.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNotificationCallback<TI0>(ComPtr<TI0> pCallback) where TI0 : unmanaged, IComVtbl<IWICDevelopRawNotificationCallback>, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetNotificationCallback((IWICDevelopRawNotificationCallback*) pCallback.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDevelopRaw*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
