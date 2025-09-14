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
    [Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
    [NativeName("Name", "IDXGIFactory1")]
    public unsafe partial struct IDXGIFactory1 : IComVtbl<IDXGIFactory1>, IComVtbl<IDXGIFactory>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("770aae78-f26f-4dba-a829-253c83d1b387");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGIFactory(IDXGIFactory1 val)
            => Unsafe.As<IDXGIFactory1, IDXGIFactory>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIFactory1 val)
            => Unsafe.As<IDXGIFactory1, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIFactory1 val)
            => Unsafe.As<IDXGIFactory1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIFactory1
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
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MakeWindowAssociation(nint WindowHandle, uint Flags)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWindowAssociation(nint* pWindowHandle)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWindowAssociation(ref nint pWindowHandle)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pWindowHandlePtr = &pWindowHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSoftwareAdapter(nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSoftwareAdapter(nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, ref IDXGIAdapter1* ppAdapter)
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsCurrent()
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory1*, Silk.NET.Core.Bool32>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapters<TI0>(uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumAdapters(Adapter, (Silk.NET.DXGI.IDXGIAdapter**) ppAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0, TI1>(ComPtr<TI0> pDevice, SwapChainDesc* pDesc, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0>(ComPtr<TI0> pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChain<TI0, TI1>(ComPtr<TI0> pDevice, ref SwapChainDesc pDesc, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0>(ComPtr<TI0> pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pDesc, ref ppSwapChain);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain(ref pDevice, pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSwapChain<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSwapChain(ref pDevice, ref pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSoftwareAdapter<TI0>(nint Module, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSoftwareAdapter(Module, (Silk.NET.DXGI.IDXGIAdapter**) ppAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapters1<TI0>(uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<IDXGIAdapter1>, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumAdapters1(Adapter, (IDXGIAdapter1**) ppAdapter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIFactory1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
