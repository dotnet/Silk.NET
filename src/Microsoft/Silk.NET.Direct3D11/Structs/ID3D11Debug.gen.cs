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

namespace Silk.NET.Direct3D11
{
    [Guid("79cf2233-7536-4948-9d36-1e4692dc5760")]
    [NativeName("Name", "ID3D11Debug")]
    public unsafe partial struct ID3D11Debug
    {
        public static readonly Guid Guid = new("79cf2233-7536-4948-9d36-1e4692dc5760");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Debug val)
            => Unsafe.As<ID3D11Debug, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Debug
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
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFeatureMask(uint Mask)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, uint, int>)LpVtbl[3])(@this, Mask);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)LpVtbl[3])(@this, Mask);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, uint, int>)LpVtbl[3])(@this, Mask);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFeatureMask()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPresentPerRenderOpDelay(uint Milliseconds)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, uint, int>)LpVtbl[5])(@this, Milliseconds);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)LpVtbl[5])(@this, Milliseconds);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, uint, int>)LpVtbl[5])(@this, Milliseconds);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPresentPerRenderOpDelay()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSwapChain(Silk.NET.DXGI.IDXGISwapChain* pSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSwapChain(ref Silk.NET.DXGI.IDXGISwapChain pSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain* pSwapChainPtr = &pSwapChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)LpVtbl[7])(@this, pSwapChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)LpVtbl[8])(@this, ppSwapChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateContext(ID3D11DeviceContext* pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContext);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContext);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContext);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateContext(ref ID3D11DeviceContext pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11DeviceContext* pContextPtr = &pContext)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContextPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContextPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[9])(@this, pContextPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReportLiveDeviceObjects(RldoFlags Flags)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, RldoFlags, int>)LpVtbl[10])(@this, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, RldoFlags, int>)LpVtbl[10])(@this, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, RldoFlags, int>)LpVtbl[10])(@this, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateContextForDispatch(ID3D11DeviceContext* pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContext);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContext);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContext);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateContextForDispatch(ref ID3D11DeviceContext pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11DeviceContext* pContextPtr = &pContext)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContextPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContextPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Debug*, ID3D11DeviceContext*, int>)LpVtbl[11])(@this, pContextPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
