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
    public unsafe partial struct IDXGIFactory2
    {
        public static readonly Guid Guid = new("50c83a1c-e072-4c48-87b0-3630fa36a6d0");

        public static implicit operator IDXGIFactory1(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, IDXGIFactory1>(ref val);

        public static implicit operator IDXGIFactory(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, IDXGIFactory>(ref val);

        public static implicit operator IDXGIObject(IDXGIFactory2 val)
            => Unsafe.As<IDXGIFactory2, IDXGIObject>(ref val);

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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[7])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters(uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[7])(@this, Adapter, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MakeWindowAssociation(nint WindowHandle, uint Flags)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, uint, int>)LpVtbl[8])(@this, WindowHandle, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWindowAssociation(nint* pWindowHandle)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint*, int>)LpVtbl[9])(@this, pWindowHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWindowAssociation(ref nint pWindowHandle)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pWindowHandlePtr = &pWindowHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint*, int>)LpVtbl[9])(@this, pWindowHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChain(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[11])(@this, Module, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSoftwareAdapter(nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[11])(@this, Module, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, uint, IDXGIAdapter1**, int>)LpVtbl[12])(@this, Adapter, ppAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapters1(uint Adapter, ref IDXGIAdapter1* ppAdapter)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, uint, IDXGIAdapter1**, int>)LpVtbl[12])(@this, Adapter, ppAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsCurrent()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, int>)LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsWindowedStereoEnabled()
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, int>)LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, Luid*, int>)LpVtbl[17])(@this, hResource, pLuid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedResourceAdapterLuid(void* hResource, ref Luid pLuid)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Luid* pLuidPtr = &pLuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, Luid*, int>)LpVtbl[17])(@this, hResource, pLuidPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, Luid*, int>)LpVtbl[17])(@this, hResourcePtr, pLuid);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, Luid*, int>)LpVtbl[17])(@this, hResourcePtr, pLuidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, uint, uint*, int>)LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterStereoStatusWindow(nint WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, uint, uint*, int>)LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[19])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterStereoStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[19])(@this, hEvent, pdwCookiePtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[19])(@this, hEventPtr, pdwCookie);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[19])(@this, hEventPtr, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterStereoStatus(uint dwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, uint, void>)LpVtbl[20])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, uint, uint*, int>)LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterOcclusionStatusWindow(nint WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, nint, uint, uint*, int>)LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[22])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterOcclusionStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[22])(@this, hEvent, pdwCookiePtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[22])(@this, hEventPtr, pdwCookie);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, void*, uint*, int>)LpVtbl[22])(@this, hEventPtr, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterOcclusionStatus(uint dwCookie)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, uint, void>)LpVtbl[23])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactory2*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

    }
}
