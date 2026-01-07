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
    [Guid("f343d1a0-afe3-439f-b13d-cd87a43b70ca")]
    [NativeName("Name", "ID3D12DSRDeviceFactory")]
    public unsafe partial struct ID3D12DSRDeviceFactory : IComVtbl<ID3D12DSRDeviceFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f343d1a0-afe3-439f-b13d-cd87a43b70ca");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DSRDeviceFactory val)
            => Unsafe.As<ID3D12DSRDeviceFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DSRDeviceFactory
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
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ID3D12Device* pD3D12Device, uint NodeMask, Guid* riid, void** ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riid, ppvDSRDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ID3D12Device* pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riid, ppvDSRDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ID3D12Device* pD3D12Device, uint NodeMask, ref Guid riid, void** ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riidPtr, ppvDSRDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ID3D12Device* pD3D12Device, uint NodeMask, ref Guid riid, ref void* ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riidPtr, ppvDSRDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ref ID3D12Device pD3D12Device, uint NodeMask, Guid* riid, void** ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riid, ppvDSRDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ref ID3D12Device pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
            {
                fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riid, ppvDSRDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ref ID3D12Device pD3D12Device, uint NodeMask, ref Guid riid, void** ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riidPtr, ppvDSRDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice(ref ID3D12Device pD3D12Device, uint NodeMask, ref Guid riid, ref void* ppvDSRDevice)
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riidPtr, ppvDSRDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDSRDevice<TI0, TI1>(ComPtr<TI0> pD3D12Device, uint NodeMask, out ComPtr<TI1> ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDSRDevice = default;
            return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvDSRDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice<TI0>(ComPtr<TI0> pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, riid, ref ppvDSRDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice<TI0>(ComPtr<TI0> pD3D12Device, uint NodeMask, ref Guid riid, void** ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, ref riid, ppvDSRDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDSRDevice<TI0>(ComPtr<TI0> pD3D12Device, uint NodeMask, ref Guid riid, ref void* ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, ref riid, ref ppvDSRDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDSRDevice<TI0>(ref ID3D12Device pD3D12Device, uint NodeMask, out ComPtr<TI0> ppvDSRDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDSRDevice = default;
            return @this->CreateDSRDevice(ref pD3D12Device, NodeMask, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDSRDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateDSRDevice<TI0, TI1>(ComPtr<TI0> pD3D12Device, uint NodeMask) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDSRDevice(pD3D12Device, NodeMask, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDSRDevice<TI0>(ref ID3D12Device pD3D12Device, uint NodeMask) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DSRDeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDSRDevice(ref pD3D12Device, NodeMask, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
