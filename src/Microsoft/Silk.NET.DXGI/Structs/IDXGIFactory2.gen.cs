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
    [Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0")]
    [NativeName("Name", "IDXGIFactory2")]
    public unsafe partial struct IDXGIFactory2 : IComVtbl<IDXGIFactory2>, IComVtbl<IDXGIFactory1>, IComVtbl<IDXGIFactory>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("50c83a1c-e072-4c48-87b0-3630fa36a6d0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGIFactory1(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, IDXGIFactory1>(ref val);

        public static implicit operator IDXGIFactory(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, IDXGIFactory>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIFactory2
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
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MakeWindowAssociation(nint WindowHandle, uint Flags)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWindowAssociation(nint* pWindowHandle)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWindowAssociation(ref nint pWindowHandle)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pWindowHandlePtr = &pWindowHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSoftwareAdapter(nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSoftwareAdapter(nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, ref IDXGIAdapter1* ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsCurrent()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Bool32>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsWindowedStereoEnabled()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedResourceAdapterLuid(void* hResource, Luid* pLuid)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedResourceAdapterLuid(void* hResource, ref Luid pLuid)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Luid* pLuidPtr = &pLuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedResourceAdapterLuid<T0>(ref T0 hResource, Luid* pLuid) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hResourcePtr = &hResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSharedResourceAdapterLuid<T0>(ref T0 hResource, ref Luid pLuid) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hResourcePtr = &hResource)
            {
                fixed (Luid* pLuidPtr = &pLuid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterStereoStatusWindow(nint WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusEvent<T0>(ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookie);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterStereoStatusEvent<T0>(ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterStereoStatus(uint dwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, void>)@this->LpVtbl[20])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterOcclusionStatusWindow(nint WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusEvent<T0>(ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookie);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterOcclusionStatusEvent<T0>(ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterOcclusionStatus(uint dwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, void>)@this->LpVtbl[23])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapters<TI0>(uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumAdapters(Adapter, (Silk.NET.DXGI.IDXGIAdapter**) ppAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0, TI1>(ComPtr<TI0> pDevice, SwapChainDesc* pDesc, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0>(ComPtr<TI0> pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChain<TI0, TI1>(ComPtr<TI0> pDevice, ref SwapChainDesc pDesc, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0>(ComPtr<TI0> pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pDesc, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain(ref pDevice, pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChain<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain(ref pDevice, ref pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSoftwareAdapter<TI0>(nint Module, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSoftwareAdapter(Module, (Silk.NET.DXGI.IDXGIAdapter**) ppAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapters1<TI0>(uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<IDXGIAdapter1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumAdapters1(Adapter, (IDXGIAdapter1**) ppAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1, TI2>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1, TI2>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1, TI2>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForHwnd<TI0, TI1, TI2>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForHwnd<TI0, TI1>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForHwnd<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForHwnd<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2, TI3>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI3>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI2> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1, TI2, TI3>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI3>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI2> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForCoreWindow<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0, TI1, TI2>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0, TI1>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0, TI1>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForComposition<TI0, TI1, TI2>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0, TI1>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForComposition<TI0, TI1>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0>(ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition(ref pDevice, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition(ref pDevice, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition(ref pDevice, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForComposition<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition(ref pDevice, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition(ref pDevice, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChainForComposition<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChainForComposition(ref pDevice, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
