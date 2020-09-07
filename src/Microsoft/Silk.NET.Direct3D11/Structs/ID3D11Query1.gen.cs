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
    [NativeName("Name", "ID3D11Query1")]
    public unsafe partial struct ID3D11Query1
    {
        public ID3D11Query1
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
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11Query1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11Query1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11Query1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                ((delegate* cdecl<ID3D11Query1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                fixed (ID3D11Device** ppDevicePtr = &ppDevice)
                {
                    ((delegate* cdecl<ID3D11Query1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Query1*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11Query1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Query1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetDataSize()
        {
            fixed (ID3D11Query1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Query1*, uint>)LpVtbl[7])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDesc(QueryDesc* pDesc)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                ((delegate* cdecl<ID3D11Query1*, QueryDesc*, void>)LpVtbl[8])(@this, pDesc);
            }
        }

        /// <summary>To be added.</summary>
        public void GetDesc(ref QueryDesc pDesc)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                fixed (QueryDesc* pDescPtr = &pDesc)
                {
                    ((delegate* cdecl<ID3D11Query1*, QueryDesc*, void>)LpVtbl[8])(@this, pDescPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDesc1(QueryDesc1* pDesc1)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                ((delegate* cdecl<ID3D11Query1*, QueryDesc1*, void>)LpVtbl[9])(@this, pDesc1);
            }
        }

        /// <summary>To be added.</summary>
        public void GetDesc1(ref QueryDesc1 pDesc1)
        {
            fixed (ID3D11Query1* @this = &this)
            {
                fixed (QueryDesc1* pDesc1Ptr = &pDesc1)
                {
                    ((delegate* cdecl<ID3D11Query1*, QueryDesc1*, void>)LpVtbl[9])(@this, pDesc1Ptr);
                }
            }
        }

    }
}
