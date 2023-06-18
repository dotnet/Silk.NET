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
    [Guid("fc51a551-d5e7-11d9-af55-00054e43ff02")]
    [NativeName("Name", "IDirectXVideoDecoderService")]
    public unsafe partial struct IDirectXVideoDecoderService : IComVtbl<IDirectXVideoDecoderService>, IComVtbl<IDirectXVideoAccelerationService>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fc51a551-d5e7-11d9-af55-00054e43ff02");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDirectXVideoAccelerationService(IDirectXVideoDecoderService val)
            => Unsafe.As<IDirectXVideoDecoderService, IDirectXVideoAccelerationService>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoDecoderService val)
            => Unsafe.As<IDirectXVideoDecoderService, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoDecoderService
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
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderDeviceGuids(uint* pCount, Guid** pGuids)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCount, pGuids);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(Guid* Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCount, pFormats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            return ret;
        }

    }
}
