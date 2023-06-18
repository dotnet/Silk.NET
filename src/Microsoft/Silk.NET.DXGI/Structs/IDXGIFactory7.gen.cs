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
    [Guid("a4966eed-76db-44da-84c1-ee9a7afb20a8")]
    [NativeName("Name", "IDXGIFactory7")]
    public unsafe partial struct IDXGIFactory7 : IComVtbl<IDXGIFactory7>, IComVtbl<IDXGIFactory6>, IComVtbl<IDXGIFactory5>, IComVtbl<IDXGIFactory4>, IComVtbl<IDXGIFactory3>, IComVtbl<IDXGIFactory2>, IComVtbl<IDXGIFactory1>, IComVtbl<IDXGIFactory>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a4966eed-76db-44da-84c1-ee9a7afb20a8");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGIFactory6(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory6>(ref val);

        public static implicit operator IDXGIFactory5(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory5>(ref val);

        public static implicit operator IDXGIFactory4(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory4>(ref val);

        public static implicit operator IDXGIFactory3(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory3>(ref val);

        public static implicit operator IDXGIFactory2(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory2>(ref val);

        public static implicit operator IDXGIFactory1(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory1>(ref val);

        public static implicit operator IDXGIFactory(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, IDXGIFactory>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIFactory7 val)
            => Unsafe.As<IDXGIFactory7, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIFactory7
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
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MakeWindowAssociation(nint WindowHandle, uint Flags)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWindowAssociation(nint* pWindowHandle)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSoftwareAdapter(nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsCurrent()
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Bool32>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsWindowedStereoEnabled()
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedResourceAdapterLuid(void* hResource, Luid* pLuid)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterStereoStatus(uint dwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, void>)@this->LpVtbl[20])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterOcclusionStatus(uint dwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, void>)@this->LpVtbl[23])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCreationFlags()
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterByLuid(Luid AdapterLuid, Guid* riid, void** ppvAdapter)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riid, ppvAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumWarpAdapter(Guid* riid, void** ppvAdapter)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riid, ppvAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Feature, void*, uint, int>)@this->LpVtbl[28])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterByGpuPreference(uint Adapter, GpuPreference GpuPreference, Guid* riid, void** ppvAdapter)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, GpuPreference, Guid*, void**, int>)@this->LpVtbl[29])(@this, Adapter, GpuPreference, riid, ppvAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterAdaptersChangedEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[30])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterAdaptersChangedEvent(uint dwCookie)
        {
            var @this = (IDXGIFactory7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, int>)@this->LpVtbl[31])(@this, dwCookie);
            return ret;
        }

    }
}
