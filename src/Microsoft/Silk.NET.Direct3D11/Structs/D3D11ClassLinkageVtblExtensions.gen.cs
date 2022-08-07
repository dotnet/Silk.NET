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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11ClassLinkageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ID3D11Device** ppDevice) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ref ID3D11Device* ppDevice) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInstance<TThis>(this TThis thisVtbl, byte* pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[7])(@this, pClassInstanceName, InstanceIndex, ppInstance);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInstance<TThis>(this TThis thisVtbl, byte* pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[7])(@this, pClassInstanceName, InstanceIndex, ppInstancePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInstance<TThis>(this TThis thisVtbl, ref byte pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pClassInstanceNamePtr = &pClassInstanceName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstance);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInstance<TThis>(this TThis thisVtbl, ref byte pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pClassInstanceNamePtr = &pClassInstanceName)
        {
            fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstancePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInstance<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pClassInstanceNamePtr = (byte*) SilkMarshal.StringToPtr(pClassInstanceName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstance);
        SilkMarshal.Free((nint)pClassInstanceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInstance<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pClassInstanceNamePtr = (byte*) SilkMarshal.StringToPtr(pClassInstanceName, NativeStringEncoding.LPStr);
        fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstancePtr);
        }
        SilkMarshal.Free((nint)pClassInstanceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateClassInstance<TThis>(this TThis thisVtbl, byte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[8])(@this, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateClassInstance<TThis>(this TThis thisVtbl, byte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[8])(@this, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateClassInstance<TThis>(this TThis thisVtbl, ref byte pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pClassTypeNamePtr = &pClassTypeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateClassInstance<TThis>(this TThis thisVtbl, ref byte pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pClassTypeNamePtr = &pClassTypeName)
        {
            fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateClassInstance<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pClassTypeNamePtr = (byte*) SilkMarshal.StringToPtr(pClassTypeName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
        SilkMarshal.Free((nint)pClassTypeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateClassInstance<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance) where TThis : IComVtbl<ID3D11ClassLinkage>
    {
        var @this = (ID3D11ClassLinkage*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pClassTypeNamePtr = (byte*) SilkMarshal.StringToPtr(pClassTypeName, NativeStringEncoding.LPStr);
        fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)@this->LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
        }
        SilkMarshal.Free((nint)pClassTypeNamePtr);
        return ret;
    }

}
