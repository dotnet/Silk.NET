// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.DXGI
{
    [Guid("05008617-fbfd-4051-a790-144884b4f6a9")]
    [NativeName("Name", "IDXGIDevice2")]
    public unsafe partial struct IDXGIDevice2
    {
        public static readonly Guid Guid = new("05008617-fbfd-4051-a790-144884b4f6a9");

        public static implicit operator IDXGIDevice1(IDXGIDevice2 val)
            => Unsafe.As<IDXGIDevice2, IDXGIDevice1>(ref val);

        public static implicit operator IDXGIDevice(IDXGIDevice2 val)
            => Unsafe.As<IDXGIDevice2, IDXGIDevice>(ref val);

        public static implicit operator IDXGIObject(IDXGIDevice2 val)
            => Unsafe.As<IDXGIDevice2, IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDevice2 val)
            => Unsafe.As<IDXGIDevice2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIDevice2
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
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(Silk.NET.DXGI.IDXGIAdapter** pAdapter)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[7])(@this, pAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(ref Silk.NET.DXGI.IDXGIAdapter* pAdapter)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** pAdapterPtr = &pAdapter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[7])(@this, pAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(Silk.NET.Core.Native.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(ref Silk.NET.Core.Native.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(ref Silk.NET.Core.Native.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
            {
                fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGPUThreadPriority(int Priority)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, int, int>)LpVtbl[10])(@this, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGPUThreadPriority(int* pPriority)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, int*, int>)LpVtbl[11])(@this, pPriority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGPUThreadPriority(ref int pPriority)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pPriorityPtr = &pPriority)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, int*, int>)LpVtbl[11])(@this, pPriorityPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, int>)LpVtbl[12])(@this, MaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint*, int>)LpVtbl[13])(@this, pMaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxLatencyPtr = &pMaxLatency)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint*, int>)LpVtbl[13])(@this, pMaxLatencyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, IDXGIResource**, OfferResourcePriority, int>)LpVtbl[14])(@this, NumResources, ppResources, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources(uint NumResources, ref IDXGIResource* ppResources, OfferResourcePriority Priority)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, IDXGIResource**, OfferResourcePriority, int>)LpVtbl[14])(@this, NumResources, ppResourcesPtr, Priority);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, IDXGIResource** ppResources, int* pDiscarded)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResources, pDiscarded);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, IDXGIResource** ppResources, ref int pDiscarded)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pDiscardedPtr = &pDiscarded)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResources, pDiscardedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, ref IDXGIResource* ppResources, int* pDiscarded)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscarded);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, ref IDXGIResource* ppResources, ref int pDiscarded)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                fixed (int* pDiscardedPtr = &pDiscarded)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscardedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueSetEvent(void* hEvent)
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, void*, int>)LpVtbl[16])(@this, hEvent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueSetEvent<T0>(ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (IDXGIDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice2*, T0*, int>)LpVtbl[16])(@this, hEventPtr);
            }
            return ret;
        }

    }
}
