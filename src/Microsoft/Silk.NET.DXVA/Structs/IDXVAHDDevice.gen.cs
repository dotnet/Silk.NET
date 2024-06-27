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

namespace Silk.NET.DXVA
{
    [Guid("95f12dfd-d77e-49be-815f-57d579634d6d")]
    [NativeName("Name", "IDXVAHD_Device")]
    public unsafe partial struct IDXVAHDDevice : IComVtbl<IDXVAHDDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("95f12dfd-d77e-49be-815f-57d579634d6d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXVAHDDevice val)
            => Unsafe.As<IDXVAHDDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXVAHDDevice
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
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, void** pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, ref void* pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurfaces, void** pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacesPtr = &ppSurfaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurfaces, ref void* pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacesPtr = &ppSurfaces)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorDeviceCaps(HDVpdevcaps* pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)@this->LpVtbl[4])(@this, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorDeviceCaps(ref HDVpdevcaps pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDVpdevcaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)@this->LpVtbl[4])(@this, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorOutputFormats(uint Count, Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[5])(@this, Count, pFormats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorOutputFormats(uint Count, ref Silk.NET.Direct3D9.Format pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format* pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[5])(@this, Count, pFormatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorInputFormats(uint Count, Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[6])(@this, Count, pFormats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorInputFormats(uint Count, ref Silk.NET.Direct3D9.Format pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format* pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[6])(@this, Count, pFormatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCaps(uint Count, HDVpcaps* pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)@this->LpVtbl[7])(@this, Count, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCaps(uint Count, ref HDVpcaps pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDVpcaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)@this->LpVtbl[7])(@this, Count, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pVPGuid, uint Count, HDCustomRateData* pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuid, Count, pRates);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pVPGuid, uint Count, ref HDCustomRateData pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDCustomRateData* pRatesPtr = &pRates)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuid, Count, pRatesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pVPGuid, uint Count, HDCustomRateData* pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuidPtr, Count, pRates);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCustomRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pVPGuid, uint Count, ref HDCustomRateData pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
                fixed (HDCustomRateData* pRatesPtr = &pRates)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuidPtr, Count, pRatesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorFilterRange(HDFilter Filter, HDFilterRangeData* pRange)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)@this->LpVtbl[9])(@this, Filter, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorFilterRange(HDFilter Filter, ref HDFilterRangeData pRange)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDFilterRangeData* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)@this->LpVtbl[9])(@this, Filter, pRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuid, ppVideoProcessor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pVPGuid, ref IDXVAHDVideoProcessor* ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXVAHDVideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuid, ppVideoProcessorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pVPGuid, ref IDXVAHDVideoProcessor* ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
                fixed (IDXVAHDVideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0>(out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<IDXVAHDVideoProcessor>, IComVtbl<TI0>
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(SilkMarshal.GuidPtrOf<TI0>(), (IDXVAHDVideoProcessor**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pVPGuid, ref ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<IDXVAHDVideoProcessor>, IComVtbl<TI0>
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor(in pVPGuid, (IDXVAHDVideoProcessor**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoProcessor<TI0>() where TI0 : unmanaged, IComVtbl<IDXVAHDVideoProcessor>, IComVtbl<TI0>
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
