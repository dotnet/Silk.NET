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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11Debug")]
    public unsafe partial struct ID3D11Debug
    {
        public ID3D11Debug
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
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11Debug* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11Debug* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetFeatureMask(uint Mask)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, uint, int>)LpVtbl[3])(@this, Mask);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetFeatureMask()
        {
            fixed (ID3D11Debug* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, uint>)LpVtbl[4])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPresentPerRenderOpDelay(uint Milliseconds)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, uint, int>)LpVtbl[5])(@this, Milliseconds);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetPresentPerRenderOpDelay()
        {
            fixed (ID3D11Debug* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, uint>)LpVtbl[6])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetSwapChain(Silk.NET.DXGI.IDXGISwapChain* pSwapChain)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetSwapChain(ref Silk.NET.DXGI.IDXGISwapChain pSwapChain)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.IDXGISwapChain* pSwapChainPtr = &pSwapChain)
                {
                    ret = ((delegate* cdecl<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChain(Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChain(ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* cdecl<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ValidateContext(ID3D11DeviceContext* pContext)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContext);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ValidateContext(ref ID3D11DeviceContext pContext)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (ID3D11DeviceContext* pContextPtr = &pContext)
                {
                    ret = ((delegate* cdecl<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContextPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReportLiveDeviceObjects(RldoFlags Flags)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, RldoFlags, int>)LpVtbl[10])(@this, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ValidateContextForDispatch(ID3D11DeviceContext* pContext)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContext);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ValidateContextForDispatch(ref ID3D11DeviceContext pContext)
        {
            fixed (ID3D11Debug* @this = &this)
            {
                int ret = default;
                fixed (ID3D11DeviceContext* pContextPtr = &pContext)
                {
                    ret = ((delegate* cdecl<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContextPtr);
                }
                return ret;
            }
        }

    }
}
