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
    [NativeName("Name", "IDXGISwapChain2")]
    public unsafe partial struct IDXGISwapChain2
    {
        public IDXGISwapChain2
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
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (void** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppDevicePtr = &ppDevice)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present(uint SyncInterval, uint Flags)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint, uint, int>)LpVtbl[8])(@this, SyncInterval, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, Guid* riid, ref void* ppSurface)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (void** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, ref Guid riid, void** ppSurface)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, ref Guid riid, ref void* ppSurface)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetFullscreenState(int Fullscreen, IDXGIOutput* pTarget)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetFullscreenState(int Fullscreen, ref IDXGIOutput pTarget)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pTargetPtr = &pTarget)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(int* pFullscreen, IDXGIOutput** ppTarget)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(int* pFullscreen, ref IDXGIOutput* ppTarget)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(ref int pFullscreen, IDXGIOutput** ppTarget)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (int* pFullscreenPtr = &pFullscreen)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(ref int pFullscreen, ref IDXGIOutput* ppTarget)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (int* pFullscreenPtr = &pFullscreen)
                {
                    fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(SwapChainDesc* pDesc)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref SwapChainDesc pDesc)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeBuffers(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeTarget(ModeDesc* pNewTargetParameters)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeTarget(ref ModeDesc pNewTargetParameters)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContainingOutput(ref IDXGIOutput* ppOutput)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStats);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameStatistics(ref FrameStatistics pStats)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (FrameStatistics* pStatsPtr = &pStats)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStatsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetLastPresentCount(ref uint pLastPresentCount)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc1(SwapChainDesc1* pDesc)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc1(ref SwapChainDesc1 pDesc)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenDesc(SwapChainFullscreenDesc* pDesc)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFullscreenDesc(ref SwapChainFullscreenDesc pDesc)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetHwnd(IntPtr* pHwnd)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, IntPtr*, int>)LpVtbl[20])(@this, pHwnd);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetHwnd(ref IntPtr pHwnd)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (IntPtr* pHwndPtr = &pHwnd)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, IntPtr*, int>)LpVtbl[20])(@this, pHwndPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(Guid* refiid, void** ppUnk)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnk);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(Guid* refiid, ref void* ppUnk)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (void** ppUnkPtr = &ppUnk)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnkPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(ref Guid refiid, void** ppUnk)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* refiidPtr = &refiid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnk);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(ref Guid refiid, ref void* ppUnk)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Guid* refiidPtr = &refiid)
                {
                    fixed (void** ppUnkPtr = &ppUnk)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present1(uint SyncInterval, uint PresentFlags, ref PresentParameters pPresentParameters)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsTemporaryMonoSupported()
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, int>)LpVtbl[23])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRestrictToOutput(ref IDXGIOutput* ppRestrictToOutput)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetBackgroundColor(D3Dcolorvalue* pColor)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (D3Dcolorvalue* pColorPtr = &pColor)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBackgroundColor(D3Dcolorvalue* pColor)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (D3Dcolorvalue* pColorPtr = &pColor)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetRotation(ModeRotation Rotation)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, ModeRotation, int>)LpVtbl[27])(@this, Rotation);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRotation(ModeRotation* pRotation)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotation);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRotation(ref ModeRotation pRotation)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (ModeRotation* pRotationPtr = &pRotation)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotationPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetSourceSize(uint Width, uint Height)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint, uint, int>)LpVtbl[29])(@this, Width, Height);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceSize(uint* pWidth, uint* pHeight)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeight);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceSize(uint* pWidth, ref uint pHeight)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pHeightPtr = &pHeight)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeightPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceSize(ref uint pWidth, uint* pHeight)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pWidthPtr = &pWidth)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeight);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetSourceSize(ref uint pWidth, ref uint pHeight)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pWidthPtr = &pWidth)
                {
                    fixed (uint* pHeightPtr = &pHeight)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMaximumFrameLatency(uint MaxLatency)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint, int>)LpVtbl[31])(@this, MaxLatency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (uint* pMaxLatencyPtr = &pMaxLatency)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatencyPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetFrameLatencyWaitableObject()
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                void* ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, void*>)LpVtbl[33])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetMatrixTransform(Matrix3X2F* pMatrix)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrix);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrixPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMatrixTransform(Matrix3X2F* pMatrix)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrix);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            fixed (IDXGISwapChain2* @this = &this)
            {
                int ret = default;
                fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrixPtr);
                }
                return ret;
            }
        }

    }
}
