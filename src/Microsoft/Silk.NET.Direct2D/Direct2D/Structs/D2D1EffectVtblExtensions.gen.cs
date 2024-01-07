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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1EffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyCount(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyName(this ComPtr<ID2D1Effect> thisVtbl, uint index, char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, char*, uint, int>)@this->LpVtbl[4])(@this, index, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyName(this ComPtr<ID2D1Effect> thisVtbl, uint index, ref char name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, char*, uint, int>)@this->LpVtbl[4])(@this, index, namePtr, nameCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyName(this ComPtr<ID2D1Effect> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, byte*, uint, int>)@this->LpVtbl[4])(@this, index, namePtr, nameCount);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyNameLength(this ComPtr<ID2D1Effect> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)@this->LpVtbl[5])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PropertyType GetType(this ComPtr<ID2D1Effect> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        PropertyType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType>)@this->LpVtbl[6])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetPropertyIndex(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, uint>)@this->LpVtbl[7])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyIndex(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, uint>)@this->LpVtbl[7])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyIndex(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, uint>)@this->LpVtbl[7])(@this, namePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, name, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, name, type, dataPtr, dataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, name, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, namePtr, type, data, dataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, namePtr, type, data, dataSize);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[9])(@this, index, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[9])(@this, index, type, dataPtr, dataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[9])(@this, index, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, name, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, ref byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, name, type, dataPtr, dataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, name, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, namePtr, type, data, dataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, PropertyType type, ref byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, namePtr, type, data, dataSize);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, ref byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[11])(@this, index, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, ref byte data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[11])(@this, index, type, dataPtr, dataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[11])(@this, index, type, dataPtr, dataSize);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetValueSize(this ComPtr<ID2D1Effect> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)@this->LpVtbl[12])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubProperties(this ComPtr<ID2D1Effect> thisVtbl, uint index, ID2D1Properties** subProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Properties**, int>)@this->LpVtbl[13])(@this, index, subProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubProperties(this ComPtr<ID2D1Effect> thisVtbl, uint index, ref ID2D1Properties* subProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Properties** subPropertiesPtr = &subProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Properties**, int>)@this->LpVtbl[13])(@this, index, subPropertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, ID2D1Image* input, Silk.NET.Core.Bool32 invalidate)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[14])(@this, index, input, invalidate);
    }

    /// <summary>To be documented.</summary>
    public static void SetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, ref ID2D1Image input, Silk.NET.Core.Bool32 invalidate)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* inputPtr = &input)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[14])(@this, index, inputPtr, invalidate);
        }
    }

    /// <summary>To be documented.</summary>
    public static int SetInputCount(this ComPtr<ID2D1Effect> thisVtbl, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, int>)@this->LpVtbl[15])(@this, inputCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, ID2D1Image** input)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image**, void>)@this->LpVtbl[16])(@this, index, input);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, ref ID2D1Image* input)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image** inputPtr = &input)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image**, void>)@this->LpVtbl[16])(@this, index, inputPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutput(this ComPtr<ID2D1Effect> thisVtbl, ID2D1Image** outputImage)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ID2D1Image**, void>)@this->LpVtbl[18])(@this, outputImage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutput(this ComPtr<ID2D1Effect> thisVtbl, ref ID2D1Image* outputImage)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image** outputImagePtr = &outputImage)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ID2D1Image**, void>)@this->LpVtbl[18])(@this, outputImagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Effect> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyName(this ComPtr<ID2D1Effect> thisVtbl, uint index, Span<char> name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyName(index, ref name.GetPinnableReference(), nameCount);
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyIndex(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyIndex(in name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByName(name, type, in data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByName(in name.GetPinnableReference(), type, data, dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByName(in name.GetPinnableReference(), type, in data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByName(in name.GetPinnableReference(), type, data, dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByName(name, type, in data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int SetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(index, type, in data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, Span<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByName(name, type, ref data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByName(in name.GetPinnableReference(), type, data, dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, PropertyType type, Span<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByName(in name.GetPinnableReference(), type, ref data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByName(in name.GetPinnableReference(), type, data, dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, Span<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByName(name, type, ref data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, Span<byte> data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(index, type, ref data.GetPinnableReference(), dataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetSubProperties<TI0>(this ComPtr<ID2D1Effect> thisVtbl, uint index, ref ComPtr<TI0> subProperties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSubProperties(index, (ID2D1Properties**) subProperties.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetInput<TI0>(this ComPtr<ID2D1Effect> thisVtbl, uint index, ComPtr<TI0> input, Silk.NET.Core.Bool32 invalidate) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetInput(index, (ID2D1Image*) input.Handle, invalidate);
    }

    /// <summary>To be documented.</summary>
    public static void SetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, Span<ID2D1Image> input, Silk.NET.Core.Bool32 invalidate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetInput(index, ref input.GetPinnableReference(), invalidate);
    }

    /// <summary>To be documented.</summary>
    public static void GetInput<TI0>(this ComPtr<ID2D1Effect> thisVtbl, uint index, ref ComPtr<TI0> input) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetInput(index, (ID2D1Image**) input.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetOutput<TI0>(this ComPtr<ID2D1Effect> thisVtbl, ref ComPtr<TI0> outputImage) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetOutput((ID2D1Image**) outputImage.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Effect> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
