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

namespace Silk.NET.DXGI
{
    [Guid("77db970f-6276-48ba-ba28-070143b4392c")]
    [NativeName("Name", "IDXGIDevice1")]
    public unsafe partial struct IDXGIDevice1 : IComVtbl<IDXGIDevice1>, IComVtbl<Silk.NET.DXGI.IDXGIDevice>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("77db970f-6276-48ba-ba28-070143b4392c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.DXGI.IDXGIDevice(IDXGIDevice1 val)
            => Unsafe.As<IDXGIDevice1, Silk.NET.DXGI.IDXGIDevice>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIDevice1 val)
            => Unsafe.As<IDXGIDevice1, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDevice1 val)
            => Unsafe.As<IDXGIDevice1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIDevice1
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
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(Silk.NET.DXGI.IDXGIAdapter** pAdapter)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(ref Silk.NET.DXGI.IDXGIAdapter* pAdapter)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** pAdapterPtr = &pAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedResource pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedResource pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedResource pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedResource pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
            {
                fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGPUThreadPriority(int Priority)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, int, int>)@this->LpVtbl[10])(@this, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGPUThreadPriority(int* pPriority)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, int*, int>)@this->LpVtbl[11])(@this, pPriority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGPUThreadPriority(ref int pPriority)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pPriorityPtr = &pPriority)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, int*, int>)@this->LpVtbl[11])(@this, pPriorityPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, uint, int>)@this->LpVtbl[12])(@this, MaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxLatencyPtr = &pMaxLatency)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice1*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatencyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapter<TI0>(ref ComPtr<TI0> pAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAdapter((Silk.NET.DXGI.IDXGIAdapter**) pAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(pDesc, NumSurfaces, Usage, pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedResource pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(pDesc, NumSurfaces, Usage, in pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(in pDesc, NumSurfaces, Usage, pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurface<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedResource pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(in pDesc, NumSurfaces, Usage, in pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, Residency* pResidencyStatus, uint NumResources) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryResourceResidency((Silk.NET.Core.Native.IUnknown**) ppResources.GetAddressOf(), pResidencyStatus, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryResourceResidency<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, ref Residency pResidencyStatus, uint NumResources) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryResourceResidency((Silk.NET.Core.Native.IUnknown**) ppResources.GetAddressOf(), ref pResidencyStatus, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
