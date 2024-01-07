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
    [Guid("51218251-1e33-4617-9ccb-4d3a4367e7bb")]
    [NativeName("Name", "ID3D11Texture2D1")]
    public unsafe partial struct ID3D11Texture2D1 : IComVtbl<ID3D11Texture2D1>, IComVtbl<ID3D11Texture2D>, IComVtbl<ID3D11Resource>, IComVtbl<ID3D11DeviceChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("51218251-1e33-4617-9ccb-4d3a4367e7bb");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11Texture2D(ID3D11Texture2D1 val)
            => Unsafe.As<ID3D11Texture2D1, ID3D11Texture2D>(ref val);

        public static implicit operator ID3D11Resource(ID3D11Texture2D1 val)
            => Unsafe.As<ID3D11Texture2D1, ID3D11Resource>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11Texture2D1 val)
            => Unsafe.As<ID3D11Texture2D1, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Texture2D1 val)
            => Unsafe.As<ID3D11Texture2D1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Texture2D1
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
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetType(ResourceDimension* pResourceDimension)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, ResourceDimension*, void>)@this->LpVtbl[7])(@this, pResourceDimension);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetType(ref ResourceDimension pResourceDimension)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDimension* pResourceDimensionPtr = &pResourceDimension)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, ResourceDimension*, void>)@this->LpVtbl[7])(@this, pResourceDimensionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetEvictionPriority(uint EvictionPriority)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint, void>)@this->LpVtbl[8])(@this, EvictionPriority);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetEvictionPriority()
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesc(Texture2DDesc* pDesc)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Texture2DDesc*, void>)@this->LpVtbl[10])(@this, pDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesc(ref Texture2DDesc pDesc)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Texture2DDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Texture2DDesc*, void>)@this->LpVtbl[10])(@this, pDescPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesc1(Texture2DDesc1* pDesc)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Texture2DDesc1*, void>)@this->LpVtbl[11])(@this, pDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesc1(ref Texture2DDesc1 pDesc)
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Texture2DDesc1* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Texture2DDesc1*, void>)@this->LpVtbl[11])(@this, pDescPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
