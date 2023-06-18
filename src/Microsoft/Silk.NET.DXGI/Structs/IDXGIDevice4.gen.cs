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
    [Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10")]
    [NativeName("Name", "IDXGIDevice4")]
    public unsafe partial struct IDXGIDevice4 : IComVtbl<IDXGIDevice4>, IComVtbl<IDXGIDevice3>, IComVtbl<IDXGIDevice2>, IComVtbl<IDXGIDevice1>, IComVtbl<Silk.NET.DXGI.IDXGIDevice>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGIDevice3(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice3>(ref val);

        public static implicit operator IDXGIDevice2(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice2>(ref val);

        public static implicit operator IDXGIDevice1(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice1>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIDevice(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, Silk.NET.DXGI.IDXGIDevice>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIDevice4
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
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(Silk.NET.DXGI.IDXGIAdapter** pAdapter)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGPUThreadPriority(int Priority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, int, int>)@this->LpVtbl[10])(@this, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGPUThreadPriority(int* pPriority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, int*, int>)@this->LpVtbl[11])(@this, pPriority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, int>)@this->LpVtbl[12])(@this, MaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources(uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, OfferResourcePriority Priority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, int>)@this->LpVtbl[14])(@this, NumResources, ppResources, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, int* pDiscarded)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResources, pDiscarded);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueSetEvent(void* hEvent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, void*, int>)@this->LpVtbl[16])(@this, hEvent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Trim()
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, void>)@this->LpVtbl[17])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources1(uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, OfferResourcePriority Priority, uint Flags)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, uint, int>)@this->LpVtbl[18])(@this, NumResources, ppResources, Priority, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources1(uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, ReclaimResourceResults* pResults)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)@this->LpVtbl[19])(@this, NumResources, ppResources, pResults);
            return ret;
        }

    }
}
