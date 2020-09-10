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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12Resource1")]
    public unsafe partial struct ID3D12Resource1
    {
        public ID3D12Resource1
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
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12Resource1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(uint Subresource, Range* pReadRange, void** ppData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, uint, Range*, void**, int>)LpVtbl[8])(@this, Subresource, pReadRange, ppData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(uint Subresource, Range* pReadRange, ref void* ppData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, uint, Range*, void**, int>)LpVtbl[8])(@this, Subresource, pReadRange, ppDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(uint Subresource, ref Range pReadRange, void** ppData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Range* pReadRangePtr = &pReadRange)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, uint, Range*, void**, int>)LpVtbl[8])(@this, Subresource, pReadRangePtr, ppData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(uint Subresource, ref Range pReadRange, ref void* ppData)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Range* pReadRangePtr = &pReadRange)
                {
                    fixed (void** ppDataPtr = &ppData)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, uint, Range*, void**, int>)LpVtbl[8])(@this, Subresource, pReadRangePtr, ppDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void Unmap(uint Subresource, Range* pWrittenRange)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                ((delegate* cdecl<ID3D12Resource1*, uint, Range*, void>)LpVtbl[9])(@this, Subresource, pWrittenRange);
            }
        }

        /// <summary>To be added.</summary>
        public void Unmap(uint Subresource, ref Range pWrittenRange)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                fixed (Range* pWrittenRangePtr = &pWrittenRange)
                {
                    ((delegate* cdecl<ID3D12Resource1*, uint, Range*, void>)LpVtbl[9])(@this, Subresource, pWrittenRangePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public ResourceDesc GetDesc()
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                ResourceDesc ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, ResourceDesc>)LpVtbl[10])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetGPUVirtualAddress()
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, ulong>)LpVtbl[11])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int WriteToSubresource(uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int WriteToSubresource<T0>(uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pSrcDataPtr = &pSrcData)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, uint, Box*, T0*, uint, uint, int>)LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int WriteToSubresource(uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int WriteToSubresource<T0>(uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (T0* pSrcDataPtr = &pSrcData)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, uint, Box*, T0*, uint, uint, int>)LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, ref Box pSrcBox)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReadFromSubresource<T0>(ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDstDataPtr = &pDstData)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, T0*, uint, uint, uint, Box*, int>)LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReadFromSubresource<T0>(ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, ref Box pSrcBox) where T0 : unmanaged
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDstDataPtr = &pDstData)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, T0*, uint, uint, uint, Box*, int>)LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetHeapProperties(HeapProperties* pHeapProperties, HeapFlags* pHeapFlags)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)LpVtbl[14])(@this, pHeapProperties, pHeapFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetHeapProperties(HeapProperties* pHeapProperties, ref HeapFlags pHeapFlags)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)LpVtbl[14])(@this, pHeapProperties, pHeapFlagsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetHeapProperties(ref HeapProperties pHeapProperties, HeapFlags* pHeapFlags)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetHeapProperties(ref HeapProperties pHeapProperties, ref HeapFlags pHeapFlags)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
                {
                    fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlagsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(Guid* riid, void** ppProtectedSession)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[15])(@this, riid, ppProtectedSession);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(Guid* riid, ref void* ppProtectedSession)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[15])(@this, riid, ppProtectedSessionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(ref Guid riid, void** ppProtectedSession)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[15])(@this, riidPtr, ppProtectedSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(ref Guid riid, ref void* ppProtectedSession)
        {
            fixed (ID3D12Resource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
                    {
                        ret = ((delegate* cdecl<ID3D12Resource1*, Guid*, void**, int>)LpVtbl[15])(@this, riidPtr, ppProtectedSessionPtr);
                    }
                }
                return ret;
            }
        }

    }
}
