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

public unsafe static class D3D11ClassInstanceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11ClassInstance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11ClassInstance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11ClassInstance> thisVtbl, ID3D11Device** ppDevice)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11ClassInstance> thisVtbl, ref ID3D11Device* ppDevice)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetClassLinkage(this ComPtr<ID3D11ClassInstance> thisVtbl, ID3D11ClassLinkage** ppLinkage)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)@this->LpVtbl[7])(@this, ppLinkage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetClassLinkage(this ComPtr<ID3D11ClassInstance> thisVtbl, ref ID3D11ClassLinkage* ppLinkage)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassLinkage** ppLinkagePtr = &ppLinkage)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)@this->LpVtbl[7])(@this, ppLinkagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesc(this ComPtr<ID3D11ClassInstance> thisVtbl, ClassInstanceDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ClassInstanceDesc*, void>)@this->LpVtbl[8])(@this, pDesc);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesc(this ComPtr<ID3D11ClassInstance> thisVtbl, ref ClassInstanceDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        fixed (ClassInstanceDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ClassInstanceDesc*, void>)@this->LpVtbl[8])(@this, pDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, byte* pInstanceName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[9])(@this, pInstanceName, pBufferLength);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, byte* pInstanceName, ref nuint pBufferLength)
    {
        var @this = thisVtbl.Handle;
        fixed (nuint* pBufferLengthPtr = &pBufferLength)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[9])(@this, pInstanceName, pBufferLengthPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, ref byte pInstanceName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pInstanceNamePtr = &pInstanceName)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[9])(@this, pInstanceNamePtr, pBufferLength);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, ref byte pInstanceName, ref nuint pBufferLength)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pInstanceNamePtr = &pInstanceName)
        {
            fixed (nuint* pBufferLengthPtr = &pBufferLength)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[9])(@this, pInstanceNamePtr, pBufferLengthPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pInstanceName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        var pInstanceNamePtr = (byte*) SilkMarshal.StringToPtr(pInstanceName, NativeStringEncoding.LPStr);
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[9])(@this, pInstanceNamePtr, pBufferLength);
        SilkMarshal.Free((nint)pInstanceNamePtr);
    }

    /// <summary>To be documented.</summary>
    public static void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pInstanceName, ref nuint pBufferLength)
    {
        var @this = thisVtbl.Handle;
        var pInstanceNamePtr = (byte*) SilkMarshal.StringToPtr(pInstanceName, NativeStringEncoding.LPStr);
        fixed (nuint* pBufferLengthPtr = &pBufferLength)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[9])(@this, pInstanceNamePtr, pBufferLengthPtr);
        }
        SilkMarshal.Free((nint)pInstanceNamePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, byte* pTypeName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[10])(@this, pTypeName, pBufferLength);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, byte* pTypeName, ref nuint pBufferLength)
    {
        var @this = thisVtbl.Handle;
        fixed (nuint* pBufferLengthPtr = &pBufferLength)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[10])(@this, pTypeName, pBufferLengthPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, ref byte pTypeName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pTypeNamePtr = &pTypeName)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[10])(@this, pTypeNamePtr, pBufferLength);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, ref byte pTypeName, ref nuint pBufferLength)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pTypeNamePtr = &pTypeName)
        {
            fixed (nuint* pBufferLengthPtr = &pBufferLength)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[10])(@this, pTypeNamePtr, pBufferLengthPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTypeName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        var pTypeNamePtr = (byte*) SilkMarshal.StringToPtr(pTypeName, NativeStringEncoding.LPStr);
        ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[10])(@this, pTypeNamePtr, pBufferLength);
        SilkMarshal.Free((nint)pTypeNamePtr);
    }

    /// <summary>To be documented.</summary>
    public static void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTypeName, ref nuint pBufferLength)
    {
        var @this = thisVtbl.Handle;
        var pTypeNamePtr = (byte*) SilkMarshal.StringToPtr(pTypeName, NativeStringEncoding.LPStr);
        fixed (nuint* pBufferLengthPtr = &pBufferLength)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, byte*, nuint*, void>)@this->LpVtbl[10])(@this, pTypeNamePtr, pBufferLengthPtr);
        }
        SilkMarshal.Free((nint)pTypeNamePtr);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11ClassInstance> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0>(this ComPtr<ID3D11ClassInstance> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11ClassInstance> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetClassLinkage<TI0>(this ComPtr<ID3D11ClassInstance> thisVtbl, ref ComPtr<TI0> ppLinkage) where TI0 : unmanaged, IComVtbl<ID3D11ClassLinkage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetClassLinkage((ID3D11ClassLinkage**) ppLinkage.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetDesc(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<ClassInstanceDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, byte* pInstanceName, Span<nuint> pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetInstanceName(pInstanceName, ref pBufferLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<byte> pInstanceName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetInstanceName(ref pInstanceName.GetPinnableReference(), pBufferLength);
    }

    /// <summary>To be documented.</summary>
    public static void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<byte> pInstanceName, Span<nuint> pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetInstanceName(ref pInstanceName.GetPinnableReference(), ref pBufferLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetInstanceName(this ComPtr<ID3D11ClassInstance> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pInstanceName, Span<nuint> pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetInstanceName(pInstanceName, ref pBufferLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, byte* pTypeName, Span<nuint> pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTypeName(pTypeName, ref pBufferLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<byte> pTypeName, nuint* pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTypeName(ref pTypeName.GetPinnableReference(), pBufferLength);
    }

    /// <summary>To be documented.</summary>
    public static void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, Span<byte> pTypeName, Span<nuint> pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTypeName(ref pTypeName.GetPinnableReference(), ref pBufferLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetTypeName(this ComPtr<ID3D11ClassInstance> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTypeName, Span<nuint> pBufferLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTypeName(pTypeName, ref pBufferLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11ClassInstance> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
