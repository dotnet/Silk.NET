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
    [NativeName("Name", "IDXGIDevice3")]
    public unsafe partial struct IDXGIDevice3
    {
        public IDXGIDevice3
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
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAdapter(IDXGIAdapter** pAdapter)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, IDXGIAdapter**, int>)LpVtbl[7])(@this, pAdapter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAdapter(ref IDXGIAdapter* pAdapter)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIAdapter** pAdapterPtr = &pAdapter)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, IDXGIAdapter**, int>)LpVtbl[7])(@this, pAdapterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (SurfaceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (SurfaceDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (SurfaceDesc* pDescPtr = &pDesc)
                {
                    fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (SurfaceDesc* pDescPtr = &pDesc)
                {
                    fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                    {
                        fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                        {
                            ret = ((delegate* cdecl<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryResourceResidency(Silk.NET.Core.Runtime.Windows.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, Silk.NET.Core.Runtime.Windows.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryResourceResidency(Silk.NET.Core.Runtime.Windows.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Silk.NET.Core.Runtime.Windows.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryResourceResidency(ref Silk.NET.Core.Runtime.Windows.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown** ppResourcesPtr = &ppResources)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, Silk.NET.Core.Runtime.Windows.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryResourceResidency(ref Silk.NET.Core.Runtime.Windows.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown** ppResourcesPtr = &ppResources)
                {
                    fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, Silk.NET.Core.Runtime.Windows.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetGPUThreadPriority(int Priority)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, int, int>)LpVtbl[10])(@this, Priority);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetGPUThreadPriority(int* pPriority)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, int*, int>)LpVtbl[11])(@this, pPriority);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetGPUThreadPriority(ref int pPriority)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (int* pPriorityPtr = &pPriority)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, int*, int>)LpVtbl[11])(@this, pPriorityPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMaximumFrameLatency(uint MaxLatency)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, uint, int>)LpVtbl[12])(@this, MaxLatency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, uint*, int>)LpVtbl[13])(@this, pMaxLatency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (uint* pMaxLatencyPtr = &pMaxLatency)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, uint*, int>)LpVtbl[13])(@this, pMaxLatencyPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, uint, IDXGIResource**, OfferResourcePriority, int>)LpVtbl[14])(@this, NumResources, ppResources, Priority);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int OfferResources(uint NumResources, ref IDXGIResource* ppResources, OfferResourcePriority Priority)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIResource** ppResourcesPtr = &ppResources)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, uint, IDXGIResource**, OfferResourcePriority, int>)LpVtbl[14])(@this, NumResources, ppResourcesPtr, Priority);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReclaimResources(uint NumResources, IDXGIResource** ppResources, int* pDiscarded)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResources, pDiscarded);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReclaimResources(uint NumResources, IDXGIResource** ppResources, ref int pDiscarded)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (int* pDiscardedPtr = &pDiscarded)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResources, pDiscardedPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReclaimResources(uint NumResources, ref IDXGIResource* ppResources, int* pDiscarded)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIResource** ppResourcesPtr = &ppResources)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscarded);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReclaimResources(uint NumResources, ref IDXGIResource* ppResources, ref int pDiscarded)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIResource** ppResourcesPtr = &ppResources)
                {
                    fixed (int* pDiscardedPtr = &pDiscarded)
                    {
                        ret = ((delegate* cdecl<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscardedPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnqueueSetEvent(void* hEvent)
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDevice3*, void*, int>)LpVtbl[16])(@this, hEvent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int EnqueueSetEvent<T0>(ref T0 hEvent) where T0 : unmanaged
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    ret = ((delegate* cdecl<IDXGIDevice3*, T0*, int>)LpVtbl[16])(@this, hEventPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void Trim()
        {
            fixed (IDXGIDevice3* @this = &this)
            {
                ((delegate* cdecl<IDXGIDevice3*, void>)LpVtbl[17])(@this);
            }
        }

    }
}
