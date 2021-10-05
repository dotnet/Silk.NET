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
    [Guid("8c3a39f0-916e-4690-804f-4c8001355d25")]
    [NativeName("Name", "IDirectXVideoProcessor")]
    public unsafe partial struct IDirectXVideoProcessor
    {
        public static readonly Guid Guid = new("8c3a39f0-916e-4690-804f-4c8001355d25");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoProcessor val)
            => Unsafe.As<IDirectXVideoProcessor, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoProcessor
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
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorService(IDirectXVideoProcessorService** ppService)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, IDirectXVideoProcessorService**, int>)LpVtbl[3])(@this, ppService);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorService(ref IDirectXVideoProcessorService* ppService)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirectXVideoProcessorService** ppServicePtr = &ppService)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, IDirectXVideoProcessorService**, int>)LpVtbl[3])(@this, ppServicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
            {
                fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreams);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                {
                    fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreams);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                {
                    fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreams);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreamsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreams);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                    {
                        fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCaps(DXVA2VideoProcessorCaps* pCaps)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, DXVA2VideoProcessorCaps*, int>)LpVtbl[5])(@this, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCaps(ref DXVA2VideoProcessorCaps pCaps)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoProcessorCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, DXVA2VideoProcessorCaps*, int>)LpVtbl[5])(@this, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProcAmpRange(uint ProcAmpCap, DXVA2ValueRange* pRange)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)LpVtbl[6])(@this, ProcAmpCap, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProcAmpRange(uint ProcAmpCap, ref DXVA2ValueRange pRange)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ValueRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)LpVtbl[6])(@this, ProcAmpCap, pRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilterPropertyRange(uint FilterSetting, DXVA2ValueRange* pRange)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)LpVtbl[7])(@this, FilterSetting, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFilterPropertyRange(uint FilterSetting, ref DXVA2ValueRange pRange)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ValueRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)LpVtbl[7])(@this, FilterSetting, pRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamples, NumSamples, pHandleComplete);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandleCompletePtr = &pHandleComplete)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamples, NumSamples, pHandleCompletePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamplesPtr, NumSamples, pHandleComplete);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
            {
                fixed (void** pHandleCompletePtr = &pHandleComplete)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamplesPtr, NumSamples, pHandleCompletePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamples, NumSamples, pHandleComplete);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                fixed (void** pHandleCompletePtr = &pHandleComplete)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamples, NumSamples, pHandleCompletePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleComplete);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                {
                    fixed (void** pHandleCompletePtr = &pHandleComplete)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleCompletePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamples, NumSamples, pHandleComplete);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (void** pHandleCompletePtr = &pHandleComplete)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamples, NumSamples, pHandleCompletePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamplesPtr, NumSamples, pHandleComplete);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                {
                    fixed (void** pHandleCompletePtr = &pHandleComplete)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamplesPtr, NumSamples, pHandleCompletePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamples, NumSamples, pHandleComplete);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
                {
                    fixed (void** pHandleCompletePtr = &pHandleComplete)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamples, NumSamples, pHandleCompletePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
                {
                    fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleComplete);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBlt(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
                {
                    fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                    {
                        fixed (void** pHandleCompletePtr = &pHandleComplete)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleCompletePtr);
                        }
                    }
                }
            }
            return ret;
        }

    }
}
