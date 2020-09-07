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
    [NativeName("Name", "IDXGISwapChainMedia")]
    public unsafe partial struct IDXGISwapChainMedia
    {
        public IDXGISwapChainMedia
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
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChainMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGISwapChainMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChainMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChainMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameStatisticsMedia(FrameStatisticsMedia* pStats)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChainMedia*, FrameStatisticsMedia*, int>)LpVtbl[3])(@this, pStats);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameStatisticsMedia(ref FrameStatisticsMedia pStats)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (FrameStatisticsMedia* pStatsPtr = &pStats)
                {
                    ret = ((delegate* cdecl<IDXGISwapChainMedia*, FrameStatisticsMedia*, int>)LpVtbl[3])(@this, pStatsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPresentDuration(uint Duration)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint, int>)LpVtbl[4])(@this, Duration);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint, uint*, uint*, int>)LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, ref uint pClosestLargerPresentDuration)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (uint* pClosestLargerPresentDurationPtr = &pClosestLargerPresentDuration)
                {
                    ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint, uint*, uint*, int>)LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDurationPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckPresentDurationSupport(uint DesiredPresentDuration, ref uint pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (uint* pClosestSmallerPresentDurationPtr = &pClosestSmallerPresentDuration)
                {
                    ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint, uint*, uint*, int>)LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDurationPtr, pClosestLargerPresentDuration);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckPresentDurationSupport(uint DesiredPresentDuration, ref uint pClosestSmallerPresentDuration, ref uint pClosestLargerPresentDuration)
        {
            fixed (IDXGISwapChainMedia* @this = &this)
            {
                int ret = default;
                fixed (uint* pClosestSmallerPresentDurationPtr = &pClosestSmallerPresentDuration)
                {
                    fixed (uint* pClosestLargerPresentDurationPtr = &pClosestLargerPresentDuration)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChainMedia*, uint, uint*, uint*, int>)LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDurationPtr, pClosestLargerPresentDurationPtr);
                    }
                }
                return ret;
            }
        }

    }
}
