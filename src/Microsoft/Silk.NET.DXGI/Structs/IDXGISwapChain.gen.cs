// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGISwapChain")]
    public unsafe partial struct IDXGISwapChain
    {
        public IDXGISwapChain
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (void** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppDevicePtr = &ppDevice)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present(uint SyncInterval, uint Flags)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, uint, uint, int>)LpVtbl[8])(@this, SyncInterval, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, Guid* riid, ref void* ppSurface)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (void** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, ref Guid riid, void** ppSurface)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, ref Guid riid, ref void* ppSurface)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetFullscreenState(int Fullscreen, IDXGIOutput* pTarget)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetFullscreenState(int Fullscreen, ref IDXGIOutput pTarget)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pTargetPtr = &pTarget)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(int* pFullscreen, IDXGIOutput** ppTarget)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(int* pFullscreen, ref IDXGIOutput* ppTarget)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(ref int pFullscreen, IDXGIOutput** ppTarget)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (int* pFullscreenPtr = &pFullscreen)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(ref int pFullscreen, ref IDXGIOutput* ppTarget)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (int* pFullscreenPtr = &pFullscreen)
                {
                    fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(SwapChainDesc* pDesc)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref SwapChainDesc pDesc)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeBuffers(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeTarget(ModeDesc* pNewTargetParameters)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeTarget(ref ModeDesc pNewTargetParameters)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContainingOutput(ref IDXGIOutput* ppOutput)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, FrameStatistics*, int>)LpVtbl[16])(@this, pStats);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameStatistics(ref FrameStatistics pStats)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (FrameStatistics* pStatsPtr = &pStats)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, FrameStatistics*, int>)LpVtbl[16])(@this, pStatsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain*, uint*, int>)LpVtbl[17])(@this, pLastPresentCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetLastPresentCount(ref uint pLastPresentCount)
        {
            fixed (IDXGISwapChain* @this = &this)
            {
                int ret = default;
                fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain*, uint*, int>)LpVtbl[17])(@this, pLastPresentCountPtr);
                }
                return ret;
            }
        }

    }
}
