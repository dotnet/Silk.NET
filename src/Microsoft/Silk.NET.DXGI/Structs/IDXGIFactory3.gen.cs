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
    [NativeName("Name", "IDXGIFactory3")]
    public unsafe partial struct IDXGIFactory3
    {
        public IDXGIFactory3
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
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, uint, IDXGIAdapter**, int>)LpVtbl[7])(@this, Adapter, ppAdapter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumAdapters(uint Adapter, ref IDXGIAdapter* ppAdapter)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIAdapter** ppAdapterPtr = &ppAdapter)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, uint, IDXGIAdapter**, int>)LpVtbl[7])(@this, Adapter, ppAdapterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int MakeWindowAssociation(IntPtr WindowHandle, uint Flags)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, uint, int>)LpVtbl[8])(@this, WindowHandle, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetWindowAssociation(IntPtr* pWindowHandle)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr*, int>)LpVtbl[9])(@this, pWindowHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetWindowAssociation(ref IntPtr pWindowHandle)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IntPtr* pWindowHandlePtr = &pWindowHandle)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr*, int>)LpVtbl[9])(@this, pWindowHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, SwapChainDesc* pDesc, IDXGISwapChain** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, SwapChainDesc* pDesc, ref IDXGISwapChain* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref SwapChainDesc pDesc, IDXGISwapChain** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref SwapChainDesc pDesc, ref IDXGISwapChain* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, SwapChainDesc* pDesc, IDXGISwapChain** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, SwapChainDesc* pDesc, ref IDXGISwapChain* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref SwapChainDesc pDesc, IDXGISwapChain** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChain(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref SwapChainDesc pDesc, ref IDXGISwapChain* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc*, IDXGISwapChain**, int>)LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSoftwareAdapter(IntPtr Module, IDXGIAdapter** ppAdapter)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, IDXGIAdapter**, int>)LpVtbl[11])(@this, Module, ppAdapter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSoftwareAdapter(IntPtr Module, ref IDXGIAdapter* ppAdapter)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIAdapter** ppAdapterPtr = &ppAdapter)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, IDXGIAdapter**, int>)LpVtbl[11])(@this, Module, ppAdapterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, uint, IDXGIAdapter1**, int>)LpVtbl[12])(@this, Adapter, ppAdapter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumAdapters1(uint Adapter, ref IDXGIAdapter1* ppAdapter)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, uint, IDXGIAdapter1**, int>)LpVtbl[12])(@this, Adapter, ppAdapterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsCurrent()
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, int>)LpVtbl[13])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsWindowedStereoEnabled()
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, int>)LpVtbl[14])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForHwnd(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, IntPtr hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                                {
                                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, Silk.NET.Core.Runtime.Windows.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (SwapChainDesc1* pDescPtr = &pDesc)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (SwapChainDesc1* pDescPtr = &pDesc)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (SwapChainDesc1* pDescPtr = &pDesc)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForCoreWindow(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref Silk.NET.Core.Runtime.Windows.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pWindowPtr = &pWindow)
                    {
                        fixed (SwapChainDesc1* pDescPtr = &pDesc)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                                {
                                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSharedResourceAdapterLuid(void* hResource, ValueTuple<ulong, long>* pLuid)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, void*, ValueTuple<ulong, long>*, int>)LpVtbl[17])(@this, hResource, pLuid);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSharedResourceAdapterLuid(void* hResource, ref ValueTuple<ulong, long> pLuid)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (ValueTuple<ulong, long>* pLuidPtr = &pLuid)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, void*, ValueTuple<ulong, long>*, int>)LpVtbl[17])(@this, hResource, pLuidPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSharedResourceAdapterLuid<T0>(ref T0 hResource, ValueTuple<ulong, long>* pLuid) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* hResourcePtr = &hResource)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, T0*, ValueTuple<ulong, long>*, int>)LpVtbl[17])(@this, hResourcePtr, pLuid);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetSharedResourceAdapterLuid<T0>(ref T0 hResource, ref ValueTuple<ulong, long> pLuid) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* hResourcePtr = &hResource)
                {
                    fixed (ValueTuple<ulong, long>* pLuidPtr = &pLuid)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, T0*, ValueTuple<ulong, long>*, int>)LpVtbl[17])(@this, hResourcePtr, pLuidPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterStereoStatusWindow(IntPtr WindowHandle, uint wMsg, uint* pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, uint, uint*, int>)LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterStereoStatusWindow(IntPtr WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, uint, uint*, int>)LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookiePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterStereoStatusEvent(void* hEvent, uint* pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, void*, uint*, int>)LpVtbl[19])(@this, hEvent, pdwCookie);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterStereoStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, void*, uint*, int>)LpVtbl[19])(@this, hEvent, pdwCookiePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterStereoStatusEvent<T0>(ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, T0*, uint*, int>)LpVtbl[19])(@this, hEventPtr, pdwCookie);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterStereoStatusEvent<T0>(ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    fixed (uint* pdwCookiePtr = &pdwCookie)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, T0*, uint*, int>)LpVtbl[19])(@this, hEventPtr, pdwCookiePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void UnregisterStereoStatus(uint dwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                ((delegate* cdecl<IDXGIFactory3*, uint, void>)LpVtbl[20])(@this, dwCookie);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterOcclusionStatusWindow(IntPtr WindowHandle, uint wMsg, uint* pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, uint, uint*, int>)LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterOcclusionStatusWindow(IntPtr WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, IntPtr, uint, uint*, int>)LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookiePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterOcclusionStatusEvent(void* hEvent, uint* pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, void*, uint*, int>)LpVtbl[22])(@this, hEvent, pdwCookie);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterOcclusionStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, void*, uint*, int>)LpVtbl[22])(@this, hEvent, pdwCookiePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterOcclusionStatusEvent<T0>(ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, T0*, uint*, int>)LpVtbl[22])(@this, hEventPtr, pdwCookie);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterOcclusionStatusEvent<T0>(ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    fixed (uint* pdwCookiePtr = &pdwCookie)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, T0*, uint*, int>)LpVtbl[22])(@this, hEventPtr, pdwCookiePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void UnregisterOcclusionStatus(uint dwCookie)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                ((delegate* cdecl<IDXGIFactory3*, uint, void>)LpVtbl[23])(@this, dwCookie);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(Silk.NET.Core.Runtime.Windows.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSwapChainForComposition(ref Silk.NET.Core.Runtime.Windows.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* cdecl<IDXGIFactory3*, Silk.NET.Core.Runtime.Windows.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetCreationFlags()
        {
            fixed (IDXGIFactory3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIFactory3*, uint>)LpVtbl[25])(@this);
                return ret;
            }
        }

    }
}
