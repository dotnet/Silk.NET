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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class RecordInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRecordInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRecordInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRecordInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRecordInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRecordInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRecordInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordInit(this ComPtr<IRecordInfo> thisVtbl, void* pvNew)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[3])(@this, pvNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RecordInit<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvNew) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvNewPtr = &pvNew)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[3])(@this, pvNewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordClear(this ComPtr<IRecordInfo> thisVtbl, void* pvExisting)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[4])(@this, pvExisting);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RecordClear<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvExisting) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvExistingPtr = &pvExisting)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[4])(@this, pvExistingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvExisting, void* pvNew)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExisting, pvNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, void* pvExisting, ref T0 pvNew) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvNewPtr = &pvNew)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExisting, pvNewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvExisting, void* pvNew) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvExistingPtr = &pvExisting)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExistingPtr, pvNew);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RecordCopy<T0, T1>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvExisting, ref T1 pvNew) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvExistingPtr = &pvExisting)
        {
            fixed (void* pvNewPtr = &pvNew)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExistingPtr, pvNewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGuid(this ComPtr<IRecordInfo> thisVtbl, Guid* pguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, int>)@this->LpVtbl[6])(@this, pguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGuid(this ComPtr<IRecordInfo> thisVtbl, ref Guid pguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidPtr = &pguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, int>)@this->LpVtbl[6])(@this, pguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IRecordInfo> thisVtbl, char** pbstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, char**, int>)@this->LpVtbl[7])(@this, pbstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IRecordInfo> thisVtbl, ref char* pbstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrNamePtr = &pbstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, char**, int>)@this->LpVtbl[7])(@this, pbstrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IRecordInfo> thisVtbl, uint* pcbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, int>)@this->LpVtbl[8])(@this, pcbSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IRecordInfo> thisVtbl, ref uint pcbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbSizePtr = &pcbSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, int>)@this->LpVtbl[8])(@this, pcbSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<IRecordInfo> thisVtbl, ITypeInfo** ppTypeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, ITypeInfo**, int>)@this->LpVtbl[9])(@this, ppTypeInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<IRecordInfo> thisVtbl, ref ITypeInfo* ppTypeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTypeInfoPtr = &ppTypeInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, ITypeInfo**, int>)@this->LpVtbl[9])(@this, ppTypeInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldName, pvarField);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldName, pvarFieldPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarField);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarFieldPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarField);
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarFieldPtr);
        }
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldName, pvarField);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldName, pvarFieldPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarField);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarField);
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
            }
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarField, ppvDataCArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarField, ppvDataCArrayPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarFieldPtr, ppvDataCArray);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarFieldPtr, ppvDataCArrayPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArray);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArray);
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
        }
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
        }
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
            }
        }
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarField, ppvDataCArray);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarField, ppvDataCArrayPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarFieldPtr, ppvDataCArray);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarFieldPtr, ppvDataCArrayPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArray);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArray);
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
            }
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
            }
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                }
            }
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldName, pvarField);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldName, pvarFieldPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
        }
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldName, pvarField);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldName, pvarFieldPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
            }
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldName, pvarField);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldName, pvarFieldPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szFieldNamePtr = &szFieldName)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
        fixed (Variant* pvarFieldPtr = &pvarField)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
        }
        SilkMarshal.Free((nint)szFieldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldName, pvarField);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldName, pvarFieldPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDataPtr = &pvData)
        {
        var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
            }
        SilkMarshal.Free((nint)szFieldNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, uint* pcNames, char** rgBstrNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNames, rgBstrNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, uint* pcNames, ref char* rgBstrNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgBstrNamesPtr = &rgBstrNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNames, rgBstrNamesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, ref uint pcNames, char** rgBstrNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcNamesPtr = &pcNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNamesPtr, rgBstrNames);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, ref uint pcNames, ref char* rgBstrNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcNamesPtr = &pcNames)
        {
            fixed (char** rgBstrNamesPtr = &rgBstrNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNamesPtr, rgBstrNamesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsMatchingType(this ComPtr<IRecordInfo> thisVtbl, IRecordInfo* pRecordInfo)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, IRecordInfo*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this, pRecordInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMatchingType(this ComPtr<IRecordInfo> thisVtbl, ref IRecordInfo pRecordInfo)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (IRecordInfo* pRecordInfoPtr = &pRecordInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, IRecordInfo*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this, pRecordInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* RecordCreate(this ComPtr<IRecordInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCreateCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvSource, void** ppvDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSource, ppvDest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCreateCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvSource, ref void* ppvDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDestPtr = &ppvDest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSource, ppvDestPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCreateCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvSource, void** ppvDest) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvSourcePtr = &pvSource)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSourcePtr, ppvDest);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCreateCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvSource, ref void* ppvDest) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvSourcePtr = &pvSource)
        {
            fixed (void** ppvDestPtr = &ppvDest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSourcePtr, ppvDestPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordDestroy(this ComPtr<IRecordInfo> thisVtbl, void* pvRecord)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[18])(@this, pvRecord);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RecordDestroy<T0>(this ComPtr<IRecordInfo> thisVtbl, ref T0 pvRecord) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvRecordPtr = &pvRecord)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[18])(@this, pvRecordPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRecordInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRecordInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRecordInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int RecordInit<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvNew) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordInit(ref pvNew.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RecordClear<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvExisting) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordClear(ref pvExisting.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, void* pvExisting, Span<T0> pvNew) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordCopy(pvExisting, ref pvNew.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvExisting, void* pvNew) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordCopy(ref pvExisting.GetPinnableReference(), pvNew);
    }

    /// <summary>To be documented.</summary>
    public static int RecordCopy<T0, T1>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvExisting, Span<T1> pvNew) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordCopy(ref pvExisting.GetPinnableReference(), ref pvNew.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGuid(this ComPtr<IRecordInfo> thisVtbl, Span<Guid> pguid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGuid(ref pguid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetName(this ComPtr<IRecordInfo> thisVtbl, string[] pbstrNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrName = (char**) SilkMarshal.StringArrayToPtr(pbstrNameSa);
        var ret = @this->GetName(pbstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrName, pbstrNameSa);
        SilkMarshal.Free((nint) pbstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IRecordInfo> thisVtbl, Span<uint> pcbSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref pcbSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfo<TI0>(this ComPtr<IRecordInfo> thisVtbl, ref ComPtr<TI0> ppTypeInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeInfo((ITypeInfo**) ppTypeInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(pvData, szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(pvData, in szFieldName.GetPinnableReference(), pvarField);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(pvData, in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(pvData, szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(ref pvData.GetPinnableReference(), szFieldName, pvarField);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), pvarField);
    }

    /// <summary>To be documented.</summary>
    public static int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(ref pvData.GetPinnableReference(), szFieldName, pvarField);
    }

    /// <summary>To be documented.</summary>
    public static int GetField<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetField(ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, szFieldName, ref pvarField.GetPinnableReference(), ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, szFieldName, ref pvarField.GetPinnableReference(), ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, in szFieldName.GetPinnableReference(), pvarField, ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, in szFieldName.GetPinnableReference(), pvarField, ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference(), ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference(), ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField, void** ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, szFieldName, ref pvarField.GetPinnableReference(), ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField, ref void* ppvDataCArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(pvData, szFieldName, ref pvarField.GetPinnableReference(), ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, pvarField, ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, pvarField, ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference(), ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference(), ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), pvarField, ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), pvarField, ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference(), ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference(), ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, pvarField, ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, pvarField, ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField, void** ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference(), ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField, ref void* ppvDataCArray) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNoCopy(ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference(), ref ppvDataCArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, pvData, szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, pvData, in szFieldName.GetPinnableReference(), pvarField);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, pvData, in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, pvData, szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, ref pvData.GetPinnableReference(), szFieldName, pvarField);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), pvarField);
    }

    /// <summary>To be documented.</summary>
    public static int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, ref pvData.GetPinnableReference(), szFieldName, pvarField);
    }

    /// <summary>To be documented.</summary>
    public static int PutField<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutField(wFlags, ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, pvData, szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, pvData, in szFieldName.GetPinnableReference(), pvarField);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, pvData, in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, pvData, szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, ref pvData.GetPinnableReference(), szFieldName, pvarField);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), pvarField);
    }

    /// <summary>To be documented.</summary>
    public static int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, ref pvData.GetPinnableReference(), in szFieldName.GetPinnableReference(), ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, ref pvData.GetPinnableReference(), szFieldName, pvarField);
    }

    /// <summary>To be documented.</summary>
    public static int PutFieldNoCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, uint wFlags, Span<T0> pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Span<Variant> pvarField) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PutFieldNoCopy(wFlags, ref pvData.GetPinnableReference(), szFieldName, ref pvarField.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, uint* pcNames, string[] rgBstrNamesSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
        var ret = @this->GetFieldNames(pcNames, rgBstrNames);
        SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
        SilkMarshal.Free((nint) rgBstrNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, ref uint pcNames, string[] rgBstrNamesSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
        var ret = @this->GetFieldNames(ref pcNames, rgBstrNames);
        SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
        SilkMarshal.Free((nint) rgBstrNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, Span<uint> pcNames, char** rgBstrNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNames(ref pcNames.GetPinnableReference(), rgBstrNames);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFieldNames(this ComPtr<IRecordInfo> thisVtbl, Span<uint> pcNames, ref char* rgBstrNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFieldNames(ref pcNames.GetPinnableReference(), ref rgBstrNames);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMatchingType<TI0>(this ComPtr<IRecordInfo> thisVtbl, ComPtr<TI0> pRecordInfo) where TI0 : unmanaged, IComVtbl<IRecordInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsMatchingType((IRecordInfo*) pRecordInfo.Handle);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMatchingType(this ComPtr<IRecordInfo> thisVtbl, Span<IRecordInfo> pRecordInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsMatchingType(ref pRecordInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCreateCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvSource, void** ppvDest) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordCreateCopy(ref pvSource.GetPinnableReference(), ppvDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecordCreateCopy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvSource, ref void* ppvDest) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordCreateCopy(ref pvSource.GetPinnableReference(), ref ppvDest);
    }

    /// <summary>To be documented.</summary>
    public static int RecordDestroy<T0>(this ComPtr<IRecordInfo> thisVtbl, Span<T0> pvRecord) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecordDestroy(ref pvRecord.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRecordInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
