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
    [NativeName("Name", "ID3D11CryptoSession")]
    public unsafe partial struct ID3D11CryptoSession
    {
        public ID3D11CryptoSession
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
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                ((delegate* cdecl<ID3D11CryptoSession*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                fixed (ID3D11Device** ppDevicePtr = &ppDevice)
                {
                    ((delegate* cdecl<ID3D11CryptoSession*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetCryptoType(Guid* pCryptoType)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void>)LpVtbl[7])(@this, pCryptoType);
            }
        }

        /// <summary>To be added.</summary>
        public void GetCryptoType(ref Guid pCryptoType)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void>)LpVtbl[7])(@this, pCryptoTypePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDecoderProfile(Guid* pDecoderProfile)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void>)LpVtbl[8])(@this, pDecoderProfile);
            }
        }

        /// <summary>To be added.</summary>
        public void GetDecoderProfile(ref Guid pDecoderProfile)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ((delegate* cdecl<ID3D11CryptoSession*, Guid*, void>)LpVtbl[8])(@this, pDecoderProfilePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCertificateSize(uint* pCertificateSize)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, uint*, int>)LpVtbl[9])(@this, pCertificateSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetCertificateSize(ref uint pCertificateSize)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (uint* pCertificateSizePtr = &pCertificateSize)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, uint*, int>)LpVtbl[9])(@this, pCertificateSizePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCertificate(uint CertificateSize, byte* pCertificate)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11CryptoSession*, uint, byte*, int>)LpVtbl[10])(@this, CertificateSize, pCertificate);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetCertificate(uint CertificateSize, ref byte pCertificate)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
                fixed (byte* pCertificatePtr = &pCertificate)
                {
                    ret = ((delegate* cdecl<ID3D11CryptoSession*, uint, byte*, int>)LpVtbl[10])(@this, CertificateSize, pCertificatePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetCertificate(uint CertificateSize, string pCertificate)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                int ret = default;
            var pCertificatePtr = (byte*) Marshal.StringToHGlobalAnsi(pCertificate);
                ret = ((delegate* cdecl<ID3D11CryptoSession*, uint, byte*, int>)LpVtbl[10])(@this, CertificateSize, pCertificatePtr);
            Marshal.FreeHGlobal((IntPtr)pCertificatePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetCryptoSessionHandle(void** pCryptoSessionHandle)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                ((delegate* cdecl<ID3D11CryptoSession*, void**, void>)LpVtbl[11])(@this, pCryptoSessionHandle);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetCryptoSessionHandle(ref void* pCryptoSessionHandle)
        {
            fixed (ID3D11CryptoSession* @this = &this)
            {
                fixed (void** pCryptoSessionHandlePtr = &pCryptoSessionHandle)
                {
                    ((delegate* cdecl<ID3D11CryptoSession*, void**, void>)LpVtbl[11])(@this, pCryptoSessionHandlePtr);
                }
            }
        }

    }
}
