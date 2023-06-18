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
    [Guid("fc51a552-d5e7-11d9-af55-00054e43ff02")]
    [NativeName("Name", "IDirectXVideoProcessorService")]
    public unsafe partial struct IDirectXVideoProcessorService : IComVtbl<IDirectXVideoProcessorService>, IComVtbl<IDirectXVideoAccelerationService>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fc51a552-d5e7-11d9-af55-00054e43ff02");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDirectXVideoAccelerationService(IDirectXVideoProcessorService val)
            => Unsafe.As<IDirectXVideoProcessorService, IDirectXVideoAccelerationService>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoProcessorService val)
            => Unsafe.As<IDirectXVideoProcessorService, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoProcessorService
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
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterVideoProcessorSoftwareDevice(void* pCallbacks)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, void*, int>)@this->LpVtbl[4])(@this, pCallbacks);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorDeviceGuids([Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, uint* pCount, Guid** pGuids)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDesc, pCount, pGuids);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorRenderTargets(Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDesc, pCount, pFormats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorSubStreamFormats(Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCount, pFormats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCaps(Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, DXVA2VideoProcessorCaps* pCaps)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProcAmpRange(Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, DXVA2ValueRange* pRange)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, ProcAmpCap, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilterPropertyRange(Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, DXVA2ValueRange* pRange)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, FilterSetting, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, IDirectXVideoProcessor** ppVidProcess)
        {
            var @this = (IDirectXVideoProcessorService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, MaxNumSubStreams, ppVidProcess);
            return ret;
        }

    }
}
