// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("da1d98c5-539f-41b2-bf6b-1198a03b6d26")]
    [NativeName("Name", "ID3D12VideoDecoderHeap1")]
    public unsafe partial struct ID3D12VideoDecoderHeap1
    {
        public static implicit operator ID3D12VideoDecoderHeap(ID3D12VideoDecoderHeap1 val)
            => Unsafe.As<ID3D12VideoDecoderHeap1, ID3D12VideoDecoderHeap>(ref val);

        public static implicit operator ID3D12Pageable(ID3D12VideoDecoderHeap1 val)
            => Unsafe.As<ID3D12VideoDecoderHeap1, ID3D12Pageable>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoDecoderHeap1 val)
            => Unsafe.As<ID3D12VideoDecoderHeap1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoDecoderHeap1 val)
            => Unsafe.As<ID3D12VideoDecoderHeap1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDecoderHeap1 val)
            => Unsafe.As<ID3D12VideoDecoderHeap1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoDecoderHeap1
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetName(string Name)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly VideoDecoderHeapDesc GetDesc()
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                VideoDecoderHeapDesc ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, VideoDecoderHeapDesc>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetProtectedResourceSession(Guid* riid, void** ppProtectedSession)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[9])(@this, riid, ppProtectedSession);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetProtectedResourceSession(Guid* riid, ref void* ppProtectedSession)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[9])(@this, riid, ppProtectedSessionPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetProtectedResourceSession(ref Guid riid, void** ppProtectedSession)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[9])(@this, riidPtr, ppProtectedSession);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetProtectedResourceSession(ref Guid riid, ref void* ppProtectedSession)
        {
            var @this = (ID3D12VideoDecoderHeap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)LpVtbl[9])(@this, riidPtr, ppProtectedSessionPtr);
                }
            }
            return ret;
        }

    }
}
