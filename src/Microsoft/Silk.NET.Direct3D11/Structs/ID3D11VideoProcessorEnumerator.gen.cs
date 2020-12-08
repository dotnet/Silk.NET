// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [Guid("31627037-53ab-4200-9061-05faa9ab45f9")]
    [NativeName("Name", "ID3D11VideoProcessorEnumerator")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator
    {
        public static implicit operator ID3D11DeviceChild(ID3D11VideoProcessorEnumerator val)
            => Unsafe.As<ID3D11VideoProcessorEnumerator, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoProcessorEnumerator val)
            => Unsafe.As<ID3D11VideoProcessorEnumerator, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoProcessorEnumerator
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
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorContentDesc(VideoProcessorContentDesc* pContentDesc)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, VideoProcessorContentDesc*, int>)LpVtbl[7])(@this, pContentDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorContentDesc(ref VideoProcessorContentDesc pContentDesc)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VideoProcessorContentDesc* pContentDescPtr = &pContentDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, VideoProcessorContentDesc*, int>)LpVtbl[7])(@this, pContentDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoProcessorFormat(Silk.NET.DXGI.Format Format, uint* pFlags)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Silk.NET.DXGI.Format, uint*, int>)LpVtbl[8])(@this, Format, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckVideoProcessorFormat(Silk.NET.DXGI.Format Format, ref uint pFlags)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, Silk.NET.DXGI.Format, uint*, int>)LpVtbl[8])(@this, Format, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCaps(VideoProcessorCaps* pCaps)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, VideoProcessorCaps*, int>)LpVtbl[9])(@this, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCaps(ref VideoProcessorCaps pCaps)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VideoProcessorCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, VideoProcessorCaps*, int>)LpVtbl[9])(@this, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorRateConversionCaps(uint TypeIndex, VideoProcessorRateConversionCaps* pCaps)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, uint, VideoProcessorRateConversionCaps*, int>)LpVtbl[10])(@this, TypeIndex, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorRateConversionCaps(uint TypeIndex, ref VideoProcessorRateConversionCaps pCaps)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VideoProcessorRateConversionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, uint, VideoProcessorRateConversionCaps*, int>)LpVtbl[10])(@this, TypeIndex, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, VideoProcessorCustomRate* pRate)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, uint, uint, VideoProcessorCustomRate*, int>)LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, ref VideoProcessorCustomRate pRate)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VideoProcessorCustomRate* pRatePtr = &pRate)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, uint, uint, VideoProcessorCustomRate*, int>)LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorFilterRange(VideoProcessorFilter Filter, VideoProcessorFilterRange* pRange)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)LpVtbl[12])(@this, Filter, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorFilterRange(VideoProcessorFilter Filter, ref VideoProcessorFilterRange pRange)
        {
            var @this = (ID3D11VideoProcessorEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VideoProcessorFilterRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoProcessorEnumerator*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)LpVtbl[12])(@this, Filter, pRangePtr);
            }
            return ret;
        }

    }
}
