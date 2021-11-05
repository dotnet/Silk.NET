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
    [Guid("28e2495d-0f64-4ae4-a6ec-129255dc49a8")]
    [NativeName("Name", "ID3D12ShaderCacheSession")]
    public unsafe partial struct ID3D12ShaderCacheSession
    {
        public static readonly Guid Guid = new("28e2495d-0f64-4ae4-a6ec-129255dc49a8");

        public static implicit operator ID3D12DeviceChild(ID3D12ShaderCacheSession val)
            => Unsafe.As<ID3D12ShaderCacheSession, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12ShaderCacheSession val)
            => Unsafe.As<ID3D12ShaderCacheSession, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12ShaderCacheSession val)
            => Unsafe.As<ID3D12ShaderCacheSession, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12ShaderCacheSession
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
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue(void* pKey, uint KeySize, void* pValue, uint* pValueSize)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKey, KeySize, pValue, pValueSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue(void* pKey, uint KeySize, void* pValue, ref uint pValueSize)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValueSizePtr = &pValueSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKey, KeySize, pValue, pValueSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>(void* pKey, uint KeySize, ref T0 pValue, uint* pValueSize) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKey, KeySize, pValuePtr, pValueSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>(void* pKey, uint KeySize, ref T0 pValue, ref uint pValueSize) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pValuePtr = &pValue)
            {
                fixed (uint* pValueSizePtr = &pValueSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKey, KeySize, pValuePtr, pValueSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>(ref T0 pKey, uint KeySize, void* pValue, uint* pValueSize) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKeyPtr, KeySize, pValue, pValueSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>(ref T0 pKey, uint KeySize, void* pValue, ref uint pValueSize) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (uint* pValueSizePtr = &pValueSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKeyPtr, KeySize, pValue, pValueSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0, T1>(ref T0 pKey, uint KeySize, ref T1 pValue, uint* pValueSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (void* pValuePtr = &pValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKeyPtr, KeySize, pValuePtr, pValueSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindValue<T0, T1>(ref T0 pKey, uint KeySize, ref T1 pValue, ref uint pValueSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (void* pValuePtr = &pValue)
                {
                    fixed (uint* pValueSizePtr = &pValueSize)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)LpVtbl[8])(@this, pKeyPtr, KeySize, pValuePtr, pValueSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue(void* pKey, uint KeySize, void* pValue, uint ValueSize)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)LpVtbl[9])(@this, pKey, KeySize, pValue, ValueSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue<T0>(void* pKey, uint KeySize, ref T0 pValue, uint ValueSize) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)LpVtbl[9])(@this, pKey, KeySize, pValuePtr, ValueSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue<T0>(ref T0 pKey, uint KeySize, void* pValue, uint ValueSize) where T0 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)LpVtbl[9])(@this, pKeyPtr, KeySize, pValue, ValueSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StoreValue<T0, T1>(ref T0 pKey, uint KeySize, ref T1 pValue, uint ValueSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (void* pValuePtr = &pValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)LpVtbl[9])(@this, pKeyPtr, KeySize, pValuePtr, ValueSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDeleteOnDestroy()
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void>)LpVtbl[10])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly ShaderCacheSessionDesc GetDesc()
        {
            ShaderCacheSessionDesc silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderCacheSessionDesc* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderCacheSession*, ShaderCacheSessionDesc*, ShaderCacheSessionDesc*>)LpVtbl[11])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

    }
}
