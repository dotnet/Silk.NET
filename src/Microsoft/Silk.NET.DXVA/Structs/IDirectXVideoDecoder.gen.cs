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
    [Guid("f2b0810a-fd00-43c9-918c-df94e2d8ef7d")]
    [NativeName("Name", "IDirectXVideoDecoder")]
    public unsafe partial struct IDirectXVideoDecoder : IComVtbl<IDirectXVideoDecoder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f2b0810a-fd00-43c9-918c-df94e2d8ef7d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoDecoder val)
            => Unsafe.As<IDirectXVideoDecoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoDecoder
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
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderService(IDirectXVideoDecoderService** ppService)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)@this->LpVtbl[3])(@this, ppService);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, void** ppBuffer, uint* pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)@this->LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseBuffer(uint BufferType)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, int>)@this->LpVtbl[6])(@this, BufferType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, void* pvPVPData)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)@this->LpVtbl[7])(@this, pRenderTarget, pvPVPData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndFrame(void** pHandleComplete)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, void**, int>)@this->LpVtbl[8])(@this, pHandleComplete);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Execute([Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2DecodeExecuteParams* pExecuteParams)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)@this->LpVtbl[9])(@this, pExecuteParams);
            return ret;
        }

    }
}
