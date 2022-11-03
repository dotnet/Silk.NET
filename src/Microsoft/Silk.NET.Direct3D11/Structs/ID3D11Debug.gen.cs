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
    public unsafe partial struct ID3D11Debug : IComVtbl<ID3D11Debug>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("79cf2233-7536-4948-9d36-1e4692dc5760");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFeatureMask(uint Mask)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)@this->LpVtbl[3])(@this, Mask);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFeatureMask()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPresentPerRenderOpDelay(uint Milliseconds)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)@this->LpVtbl[5])(@this, Milliseconds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPresentPerRenderOpDelay()
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSwapChain(Silk.NET.DXGI.IDXGISwapChain* pSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)@this->LpVtbl[7])(@this, pSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSwapChain(ref Silk.NET.DXGI.IDXGISwapChain pSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain* pSwapChainPtr = &pSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)@this->LpVtbl[7])(@this, pSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateContext(ID3D11DeviceContext* pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[9])(@this, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateContext(ref ID3D11DeviceContext pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11DeviceContext* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[9])(@this, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReportLiveDeviceObjects(RldoFlags Flags)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, RldoFlags, int>)@this->LpVtbl[10])(@this, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateContextForDispatch(ID3D11DeviceContext* pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[11])(@this, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateContextForDispatch(ref ID3D11DeviceContext pContext)
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11DeviceContext* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[11])(@this, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSwapChain<TI0>(ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetSwapChain((Silk.NET.DXGI.IDXGISwapChain*) pSwapChain.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSwapChain<TI0>(ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSwapChain((Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateContext<TI0>(ComPtr<TI0> pContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateContext((ID3D11DeviceContext*) pContext.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateContextForDispatch<TI0>(ComPtr<TI0> pContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateContextForDispatch((ID3D11DeviceContext*) pContext.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11Debug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
