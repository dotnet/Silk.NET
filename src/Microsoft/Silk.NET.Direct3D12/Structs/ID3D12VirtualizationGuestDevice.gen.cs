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

namespace Silk.NET.Direct3D12
{
    [Guid("bc66d368-7373-4943-8757-fc87dc79e476")]
    [NativeName("Name", "ID3D12VirtualizationGuestDevice")]
    public unsafe partial struct ID3D12VirtualizationGuestDevice : IComVtbl<ID3D12VirtualizationGuestDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bc66d368-7373-4943-8757-fc87dc79e476");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VirtualizationGuestDevice val)
            => Unsafe.As<ID3D12VirtualizationGuestDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VirtualizationGuestDevice
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
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost(ID3D12DeviceChild* pObject, void** pHandle)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObject, pHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost(ID3D12DeviceChild* pObject, ref void* pHandle)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObject, pHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost(ref ID3D12DeviceChild pObject, void** pHandle)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObjectPtr, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost(ref ID3D12DeviceChild pObject, ref void* pHandle)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObjectPtr, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFenceFd(ID3D12Fence* pFence, ulong FenceValue, int* pFenceFd)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFence, FenceValue, pFenceFd);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFenceFd(ID3D12Fence* pFence, ulong FenceValue, ref int pFenceFd)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pFenceFdPtr = &pFenceFd)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFence, FenceValue, pFenceFdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFenceFd(ref ID3D12Fence pFence, ulong FenceValue, int* pFenceFd)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence* pFencePtr = &pFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue, pFenceFd);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFenceFd(ref ID3D12Fence pFence, ulong FenceValue, ref int pFenceFd)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence* pFencePtr = &pFence)
            {
                fixed (int* pFenceFdPtr = &pFenceFd)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue, pFenceFdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost<TI0>(ComPtr<TI0> pObject, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ShareWithHost((ID3D12DeviceChild*) pObject.Handle, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost<TI0>(ComPtr<TI0> pObject, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ShareWithHost((ID3D12DeviceChild*) pObject.Handle, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFenceFd<TI0>(ComPtr<TI0> pFence, ulong FenceValue, int* pFenceFd) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFenceFd((ID3D12Fence*) pFence.Handle, FenceValue, pFenceFd);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFenceFd<TI0>(ComPtr<TI0> pFence, ulong FenceValue, ref int pFenceFd) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFenceFd((ID3D12Fence*) pFence.Handle, FenceValue, ref pFenceFd);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
