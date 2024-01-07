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
    [Guid("9d5e227a-4430-4161-88b3-3eca6bb16e19")]
    [NativeName("Name", "ID3D12Resource1")]
    public unsafe partial struct ID3D12Resource1 : IComVtbl<ID3D12Resource1>, IComVtbl<ID3D12Resource>, IComVtbl<ID3D12Pageable>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9d5e227a-4430-4161-88b3-3eca6bb16e19");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12Resource(ID3D12Resource1 val)
            => Unsafe.As<ID3D12Resource1, ID3D12Resource>(ref val);

        public static implicit operator ID3D12Pageable(ID3D12Resource1 val)
            => Unsafe.As<ID3D12Resource1, ID3D12Pageable>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12Resource1 val)
            => Unsafe.As<ID3D12Resource1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12Resource1 val)
            => Unsafe.As<ID3D12Resource1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Resource1 val)
            => Unsafe.As<ID3D12Resource1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Resource1
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
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pReadRange, void** ppData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pReadRange, ref void* ppData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Range pReadRange, void** ppData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Range* pReadRangePtr = &pReadRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRangePtr, ppData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Range pReadRange, ref void* ppData)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Range* pReadRangePtr = &pReadRange)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRangePtr, ppDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Unmap(uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pWrittenRange)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRange);
        }

        /// <summary>To be documented.</summary>
        public readonly void Unmap(uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Range pWrittenRange)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Range* pWrittenRangePtr = &pWrittenRange)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRangePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly ResourceDesc GetDesc()
        {
            ResourceDesc silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceDesc* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, ResourceDesc*, ResourceDesc*>)@this->LpVtbl[10])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetGPUVirtualAddress()
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, ulong>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteToSubresource(uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteToSubresource<T0>(uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteToSubresource(uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteToSubresource<T0>(uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFromSubresource<T0>(ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDstDataPtr = &pDstData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReadFromSubresource<T0>(ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox) where T0 : unmanaged
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDstDataPtr = &pDstData)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHeapProperties(HeapProperties* pHeapProperties, HeapFlags* pHeapFlags)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHeapProperties(HeapProperties* pHeapProperties, ref HeapFlags pHeapFlags)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHeapProperties(ref HeapProperties pHeapProperties, HeapFlags* pHeapFlags)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHeapProperties(ref HeapProperties pHeapProperties, ref HeapFlags pHeapFlags)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlagsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtectedResourceSession(Guid* riid, void** ppProtectedSession)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riid, ppProtectedSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtectedResourceSession(Guid* riid, ref void* ppProtectedSession)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riid, ppProtectedSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtectedResourceSession(ref Guid riid, void** ppProtectedSession)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riidPtr, ppProtectedSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtectedResourceSession(ref Guid riid, ref void* ppProtectedSession)
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riidPtr, ppProtectedSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProtectedResourceSession<TI0>(out ComPtr<TI0> ppProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppProtectedSession = default;
            return @this->GetProtectedResourceSession(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppProtectedSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetProtectedResourceSession<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Resource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetProtectedResourceSession(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
