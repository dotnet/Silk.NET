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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12ShaderCacheSessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<TThis>(this TThis thisVtbl, void* pKey, uint KeySize, void* pValue, uint* pValueSize) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, pValue, pValueSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<TThis>(this TThis thisVtbl, void* pKey, uint KeySize, void* pValue, ref uint pValueSize) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pValueSizePtr = &pValueSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, pValue, pValueSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, void* pKey, uint KeySize, ref T0 pValue, uint* pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, pValuePtr, pValueSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, void* pKey, uint KeySize, ref T0 pValue, ref uint pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pValuePtr = &pValue)
        {
            fixed (uint* pValueSizePtr = &pValueSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, pValuePtr, pValueSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, ref T0 pKey, uint KeySize, void* pValue, uint* pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, pValue, pValueSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, ref T0 pKey, uint KeySize, void* pValue, ref uint pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (uint* pValueSizePtr = &pValueSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, pValue, pValueSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, T1, TThis>(this TThis thisVtbl, ref T0 pKey, uint KeySize, ref T1 pValue, uint* pValueSize) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (void* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, pValuePtr, pValueSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindValue<T0, T1, TThis>(this TThis thisVtbl, ref T0 pKey, uint KeySize, ref T1 pValue, ref uint pValueSize) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (void* pValuePtr = &pValue)
            {
                fixed (uint* pValueSizePtr = &pValueSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, pValuePtr, pValueSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue<TThis>(this TThis thisVtbl, void* pKey, uint KeySize, void* pValue, uint ValueSize) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pValue, ValueSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue<T0, TThis>(this TThis thisVtbl, void* pKey, uint KeySize, ref T0 pValue, uint ValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pValuePtr, ValueSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue<T0, TThis>(this TThis thisVtbl, ref T0 pKey, uint KeySize, void* pValue, uint ValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)@this->LpVtbl[9])(@this, pKeyPtr, KeySize, pValue, ValueSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StoreValue<T0, T1, TThis>(this TThis thisVtbl, ref T0 pKey, uint KeySize, ref T1 pValue, uint ValueSize) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pKeyPtr = &pKey)
        {
            fixed (void* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)@this->LpVtbl[9])(@this, pKeyPtr, KeySize, pValuePtr, ValueSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDeleteOnDestroy<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void>)@this->LpVtbl[10])(@this);
    }

    /// <summary>To be documented.</summary>
    public static ShaderCacheSessionDesc GetDesc<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        ShaderCacheSessionDesc ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, ShaderCacheSessionDesc>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvDevice) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<TThis>(this TThis thisVtbl, void* pKey, uint KeySize, void* pValue, Span<uint> pValueSize) where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(pKey, KeySize, pValue, ref pValueSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, void* pKey, uint KeySize, Span<T0> pValue, uint* pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(pKey, KeySize, ref pValue.GetPinnableReference(), pValueSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, void* pKey, uint KeySize, Span<T0> pValue, Span<uint> pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(pKey, KeySize, ref pValue.GetPinnableReference(), ref pValueSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, Span<T0> pKey, uint KeySize, void* pValue, uint* pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(ref pKey.GetPinnableReference(), KeySize, pValue, pValueSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, TThis>(this TThis thisVtbl, Span<T0> pKey, uint KeySize, void* pValue, Span<uint> pValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(ref pKey.GetPinnableReference(), KeySize, pValue, ref pValueSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0, T1, TThis>(this TThis thisVtbl, Span<T0> pKey, uint KeySize, Span<T1> pValue, uint* pValueSize) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(ref pKey.GetPinnableReference(), KeySize, ref pValue.GetPinnableReference(), pValueSize);
    }

    /// <summary>To be documented.</summary>
    public static int FindValue<T0, T1, TThis>(this TThis thisVtbl, Span<T0> pKey, uint KeySize, Span<T1> pValue, Span<uint> pValueSize) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FindValue(ref pKey.GetPinnableReference(), KeySize, ref pValue.GetPinnableReference(), ref pValueSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue<T0, TThis>(this TThis thisVtbl, void* pKey, uint KeySize, Span<T0> pValue, uint ValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StoreValue(pKey, KeySize, ref pValue.GetPinnableReference(), ValueSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue<T0, TThis>(this TThis thisVtbl, Span<T0> pKey, uint KeySize, void* pValue, uint ValueSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StoreValue(ref pKey.GetPinnableReference(), KeySize, pValue, ValueSize);
    }

    /// <summary>To be documented.</summary>
    public static int StoreValue<T0, T1, TThis>(this TThis thisVtbl, Span<T0> pKey, uint KeySize, Span<T1> pValue, uint ValueSize) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StoreValue(ref pKey.GetPinnableReference(), KeySize, ref pValue.GetPinnableReference(), ValueSize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ShaderCacheSession>
    {
        var @this = (ID3D12ShaderCacheSession*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
