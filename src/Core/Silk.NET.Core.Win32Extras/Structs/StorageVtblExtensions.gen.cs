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

public unsafe static class StorageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStorage> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStorage> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStorage> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStorage> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint reserved1, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, reserved1, reserved2, ppstm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint reserved1, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, reserved1, reserved2, ppstmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint reserved1, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstm);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint reserved1, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstmPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, uint, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstm);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, uint, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstmPtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, void* reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsName, reserved1, grfMode, reserved2, ppstm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, void* reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsName, reserved1, grfMode, reserved2, ppstmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* reserved1Ptr = &reserved1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsName, reserved1Ptr, grfMode, reserved2, ppstm);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* reserved1Ptr = &reserved1)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsName, reserved1Ptr, grfMode, reserved2, ppstmPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, void* reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1, grfMode, reserved2, ppstm);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, void* reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1, grfMode, reserved2, ppstmPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (void* reserved1Ptr = &reserved1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1Ptr, grfMode, reserved2, ppstm);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (void* reserved1Ptr = &reserved1)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1Ptr, grfMode, reserved2, ppstmPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, void* reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1, grfMode, reserved2, ppstm);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, void* reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1, grfMode, reserved2, ppstmPtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (void* reserved1Ptr = &reserved1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1Ptr, grfMode, reserved2, ppstm);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (void* reserved1Ptr = &reserved1)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, void*, uint, uint, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, reserved1Ptr, grfMode, reserved2, ppstmPtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, IStorage**, int>)@this->LpVtbl[5])(@this, pwcsName, grfMode, reserved1, reserved2, ppstg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage** ppstgPtr = &ppstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, IStorage**, int>)@this->LpVtbl[5])(@this, pwcsName, grfMode, reserved1, reserved2, ppstgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, IStorage**, int>)@this->LpVtbl[5])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage** ppstgPtr = &ppstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, uint, uint, uint, IStorage**, int>)@this->LpVtbl[5])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, uint, uint, uint, IStorage**, int>)@this->LpVtbl[5])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstg);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage** ppstgPtr = &ppstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, uint, uint, uint, IStorage**, int>)@this->LpVtbl[5])(@this, pwcsNamePtr, grfMode, reserved1, reserved2, ppstgPtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage** ppstgPtr = &ppstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** snbExcludePtr = &snbExclude)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriority, grfMode, snbExcludePtr, reserved, ppstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** snbExcludePtr = &snbExclude)
        {
            fixed (IStorage** ppstgPtr = &ppstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriority, grfMode, snbExcludePtr, reserved, ppstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriorityPtr, grfMode, snbExclude, reserved, ppstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            fixed (IStorage** ppstgPtr = &ppstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriorityPtr, grfMode, snbExclude, reserved, ppstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriorityPtr, grfMode, snbExcludePtr, reserved, ppstg);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                fixed (IStorage** ppstgPtr = &ppstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsName, pstgPriorityPtr, grfMode, snbExcludePtr, reserved, ppstgPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage** ppstgPtr = &ppstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExclude, reserved, ppstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExcludePtr, reserved, ppstg);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                fixed (IStorage** ppstgPtr = &ppstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExcludePtr, reserved, ppstgPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgPriorityPtr = &pstgPriority)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExclude, reserved, ppstg);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgPriorityPtr = &pstgPriority)
            {
                fixed (IStorage** ppstgPtr = &ppstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExclude, reserved, ppstgPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgPriorityPtr = &pstgPriority)
            {
                fixed (char** snbExcludePtr = &snbExclude)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExcludePtr, reserved, ppstg);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgPriorityPtr = &pstgPriority)
            {
                fixed (char** snbExcludePtr = &snbExclude)
                {
                    fixed (IStorage** ppstgPtr = &ppstg)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExcludePtr, reserved, ppstgPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage** ppstgPtr = &ppstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExclude, reserved, ppstgPtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (char** snbExcludePtr = &snbExclude)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExcludePtr, reserved, ppstg);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (char** snbExcludePtr = &snbExclude)
        {
            fixed (IStorage** ppstgPtr = &ppstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriority, grfMode, snbExcludePtr, reserved, ppstgPtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExclude, reserved, ppstg);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            fixed (IStorage** ppstgPtr = &ppstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExclude, reserved, ppstgPtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExcludePtr, reserved, ppstg);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgPriorityPtr = &pstgPriority)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                fixed (IStorage** ppstgPtr = &ppstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, uint, char**, uint, IStorage**, int>)@this->LpVtbl[6])(@this, pwcsNamePtr, pstgPriorityPtr, grfMode, snbExcludePtr, reserved, ppstgPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, char** snbExclude, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExclude, snbExclude, pstgDest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, char** snbExclude, ref IStorage pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExclude, snbExclude, pstgDestPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, ref char* snbExclude, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** snbExcludePtr = &snbExclude)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExclude, snbExcludePtr, pstgDest);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, ref char* snbExclude, ref IStorage pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** snbExcludePtr = &snbExclude)
        {
            fixed (IStorage* pstgDestPtr = &pstgDest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExclude, snbExcludePtr, pstgDestPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, char** snbExclude, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rgiidExcludePtr = &rgiidExclude)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExcludePtr, snbExclude, pstgDest);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, char** snbExclude, ref IStorage pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rgiidExcludePtr = &rgiidExclude)
        {
            fixed (IStorage* pstgDestPtr = &pstgDest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExcludePtr, snbExclude, pstgDestPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, ref char* snbExclude, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rgiidExcludePtr = &rgiidExclude)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExcludePtr, snbExcludePtr, pstgDest);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, ref char* snbExclude, ref IStorage pstgDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rgiidExcludePtr = &rgiidExclude)
        {
            fixed (char** snbExcludePtr = &snbExclude)
            {
                fixed (IStorage* pstgDestPtr = &pstgDest)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, Guid*, char**, IStorage*, int>)@this->LpVtbl[7])(@this, ciidExclude, rgiidExcludePtr, snbExcludePtr, pstgDestPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsName, pstgDest, pwcsNewName, grfFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNewNamePtr = &pwcsNewName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsName, pstgDest, pwcsNewNamePtr, grfFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, byte*, uint, int>)@this->LpVtbl[8])(@this, pwcsName, pstgDest, pwcsNewNamePtr, grfFlags);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsName, pstgDestPtr, pwcsNewName, grfFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
            fixed (char* pwcsNewNamePtr = &pwcsNewName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsName, pstgDestPtr, pwcsNewNamePtr, grfFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, byte*, uint, int>)@this->LpVtbl[8])(@this, pwcsName, pstgDestPtr, pwcsNewNamePtr, grfFlags);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDest, pwcsNewName, grfFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (char* pwcsNewNamePtr = &pwcsNewName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDest, pwcsNewNamePtr, grfFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, byte*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDest, pwcsNewNamePtr, grfFlags);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgDestPtr = &pstgDest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDestPtr, pwcsNewName, grfFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgDestPtr = &pstgDest)
            {
                fixed (char* pwcsNewNamePtr = &pwcsNewName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDestPtr, pwcsNewNamePtr, grfFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (IStorage* pstgDestPtr = &pstgDest)
            {
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, IStorage*, byte*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDestPtr, pwcsNewNamePtr, grfFlags);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDest, pwcsNewName, grfFlags);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (char* pwcsNewNamePtr = &pwcsNewName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDest, pwcsNewNamePtr, grfFlags);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, byte*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDest, pwcsNewNamePtr, grfFlags);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDestPtr, pwcsNewName, grfFlags);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
            fixed (char* pwcsNewNamePtr = &pwcsNewName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, char*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDestPtr, pwcsNewNamePtr, grfFlags);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (IStorage* pstgDestPtr = &pstgDest)
        {
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, IStorage*, byte*, uint, int>)@this->LpVtbl[8])(@this, pwcsNamePtr, pstgDestPtr, pwcsNewNamePtr, grfFlags);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IStorage> thisVtbl, uint grfCommitFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, int>)@this->LpVtbl[9])(@this, grfCommitFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Revert(this ComPtr<IStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements(this ComPtr<IStorage> thisVtbl, uint reserved1, void* reserved2, uint reserved3, IEnumSTATSTG** ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, void*, uint, IEnumSTATSTG**, int>)@this->LpVtbl[11])(@this, reserved1, reserved2, reserved3, ppenum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements(this ComPtr<IStorage> thisVtbl, uint reserved1, void* reserved2, uint reserved3, ref IEnumSTATSTG* ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumSTATSTG** ppenumPtr = &ppenum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, void*, uint, IEnumSTATSTG**, int>)@this->LpVtbl[11])(@this, reserved1, reserved2, reserved3, ppenumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements<T0>(this ComPtr<IStorage> thisVtbl, uint reserved1, ref T0 reserved2, uint reserved3, IEnumSTATSTG** ppenum) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* reserved2Ptr = &reserved2)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, void*, uint, IEnumSTATSTG**, int>)@this->LpVtbl[11])(@this, reserved1, reserved2Ptr, reserved3, ppenum);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements<T0>(this ComPtr<IStorage> thisVtbl, uint reserved1, ref T0 reserved2, uint reserved3, ref IEnumSTATSTG* ppenum) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* reserved2Ptr = &reserved2)
        {
            fixed (IEnumSTATSTG** ppenumPtr = &ppenum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, void*, uint, IEnumSTATSTG**, int>)@this->LpVtbl[11])(@this, reserved1, reserved2Ptr, reserved3, ppenumPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DestroyElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, int>)@this->LpVtbl[12])(@this, pwcsName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DestroyElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, int>)@this->LpVtbl[12])(@this, pwcsNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DestroyElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, int>)@this->LpVtbl[12])(@this, pwcsNamePtr);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, char*, int>)@this->LpVtbl[13])(@this, pwcsOldName, pwcsNewName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNewNamePtr = &pwcsNewName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, char*, int>)@this->LpVtbl[13])(@this, pwcsOldName, pwcsNewNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, byte*, int>)@this->LpVtbl[13])(@this, pwcsOldName, pwcsNewNamePtr);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsOldNamePtr = &pwcsOldName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, char*, int>)@this->LpVtbl[13])(@this, pwcsOldNamePtr, pwcsNewName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsOldNamePtr = &pwcsOldName)
        {
            fixed (char* pwcsNewNamePtr = &pwcsNewName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, char*, int>)@this->LpVtbl[13])(@this, pwcsOldNamePtr, pwcsNewNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsOldNamePtr = &pwcsOldName)
        {
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, byte*, int>)@this->LpVtbl[13])(@this, pwcsOldNamePtr, pwcsNewNamePtr);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsOldNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsOldName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, char*, int>)@this->LpVtbl[13])(@this, pwcsOldNamePtr, pwcsNewName);
        SilkMarshal.Free((nint)pwcsOldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsOldNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsOldName, NativeStringEncoding.UTF8);
        fixed (char* pwcsNewNamePtr = &pwcsNewName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, char*, int>)@this->LpVtbl[13])(@this, pwcsOldNamePtr, pwcsNewNamePtr);
        }
        SilkMarshal.Free((nint)pwcsOldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsOldNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsOldName, NativeStringEncoding.UTF8);
        var pwcsNewNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, byte*, int>)@this->LpVtbl[13])(@this, pwcsOldNamePtr, pwcsNewNamePtr);
        SilkMarshal.Free((nint)pwcsNewNamePtr);
        SilkMarshal.Free((nint)pwcsOldNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctime, patime, pmtime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pmtimePtr = &pmtime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctime, patime, pmtimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* patimePtr = &patime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctime, patimePtr, pmtime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* patimePtr = &patime)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctime, patimePtr, pmtimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctimePtr, patime, pmtime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctimePtr, patime, pmtimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctimePtr, patimePtr, pmtime);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsName, pctimePtr, patimePtr, pmtimePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patime, pmtime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patime, pmtimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patimePtr, pmtime);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patimePtr, pmtimePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* pctimePtr = &pctime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patime, pmtime);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* pctimePtr = &pctime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patime, pmtimePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* pctimePtr = &pctime)
            {
                fixed (Filetime* patimePtr = &patime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patimePtr, pmtime);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Filetime* pctimePtr = &pctime)
            {
                fixed (Filetime* patimePtr = &patime)
                {
                    fixed (Filetime* pmtimePtr = &pmtime)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IStorage*, char*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patimePtr, pmtimePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patime, pmtime);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* pmtimePtr = &pmtime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patime, pmtimePtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* patimePtr = &patime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patimePtr, pmtime);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* patimePtr = &patime)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctime, patimePtr, pmtimePtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* pctimePtr = &pctime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patime, pmtime);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patime, pmtimePtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patimePtr, pmtime);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.UTF8);
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStorage*, byte*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[14])(@this, pwcsNamePtr, pctimePtr, patimePtr, pmtimePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClass(this ComPtr<IStorage> thisVtbl, Guid* clsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, Guid*, int>)@this->LpVtbl[15])(@this, clsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClass(this ComPtr<IStorage> thisVtbl, ref Guid clsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, Guid*, int>)@this->LpVtbl[15])(@this, clsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStateBits(this ComPtr<IStorage> thisVtbl, uint grfStateBits, uint grfMask)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, uint, uint, int>)@this->LpVtbl[16])(@this, grfStateBits, grfMask);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stat(this ComPtr<IStorage> thisVtbl, STATSTG* pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStorage*, STATSTG*, uint, int>)@this->LpVtbl[17])(@this, pstatstg, grfStatFlag);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IStorage> thisVtbl, ref STATSTG pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STATSTG* pstatstgPtr = &pstatstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStorage*, STATSTG*, uint, int>)@this->LpVtbl[17])(@this, pstatstgPtr, grfStatFlag);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IStorage> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStorage> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStorage> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint reserved1, uint reserved2, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStream(pwcsName, grfMode, reserved1, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint reserved1, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStream(in pwcsName.GetPinnableReference(), grfMode, reserved1, reserved2, ppstm);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStream<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint reserved1, uint reserved2, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStream(in pwcsName, grfMode, reserved1, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint reserved1, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStream(in pwcsName.GetPinnableReference(), grfMode, reserved1, reserved2, ref ppstm);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStream<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStream(pwcsName, grfMode, reserved1, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, void* reserved1, uint grfMode, uint reserved2, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStream(pwcsName, reserved1, grfMode, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<T0> reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(pwcsName, ref reserved1.GetPinnableReference(), grfMode, reserved2, ppstm);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0, TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, ref ComPtr<TI0> ppstm) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStream(pwcsName, ref reserved1, grfMode, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<T0> reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(pwcsName, ref reserved1.GetPinnableReference(), grfMode, reserved2, ref ppstm);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, void* reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(in pwcsName.GetPinnableReference(), reserved1, grfMode, reserved2, ppstm);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, void* reserved1, uint grfMode, uint reserved2, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStream(in pwcsName, reserved1, grfMode, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, void* reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(in pwcsName.GetPinnableReference(), reserved1, grfMode, reserved2, ref ppstm);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<T0> reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(in pwcsName.GetPinnableReference(), ref reserved1.GetPinnableReference(), grfMode, reserved2, ppstm);
    }

    /// <summary>To be documented.</summary>
    public static int OpenStream<T0, TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, ref ComPtr<TI0> ppstm) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStream(in pwcsName, ref reserved1, grfMode, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<T0> reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(in pwcsName.GetPinnableReference(), ref reserved1.GetPinnableReference(), grfMode, reserved2, ref ppstm);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, void* reserved1, uint grfMode, uint reserved2, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStream(pwcsName, reserved1, grfMode, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<T0> reserved1, uint grfMode, uint reserved2, Silk.NET.Core.Win32Extras.IStream** ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(pwcsName, ref reserved1.GetPinnableReference(), grfMode, reserved2, ppstm);
    }

    /// <summary>To be documented.</summary>
    public static int OpenStream<T0, TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref T0 reserved1, uint grfMode, uint reserved2, ref ComPtr<TI0> ppstm) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStream(pwcsName, ref reserved1, grfMode, reserved2, (Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStream<T0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<T0> reserved1, uint grfMode, uint reserved2, ref Silk.NET.Core.Win32Extras.IStream* ppstm) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStream(pwcsName, ref reserved1.GetPinnableReference(), grfMode, reserved2, ref ppstm);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint reserved1, uint reserved2, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStorage(pwcsName, grfMode, reserved1, reserved2, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorage(in pwcsName.GetPinnableReference(), grfMode, reserved1, reserved2, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint reserved1, uint reserved2, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStorage(in pwcsName, grfMode, reserved1, reserved2, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorage(in pwcsName.GetPinnableReference(), grfMode, reserved1, reserved2, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStorage(pwcsName, grfMode, reserved1, reserved2, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0, TI1>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref ComPtr<TI1> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0, TI1>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref ComPtr<TI1> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, ref snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, ref snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, ref snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(in pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), pstgPriority, grfMode, snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0, TI1>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref ComPtr<TI1> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(in pwcsName, (IStorage*) pstgPriority.Handle, grfMode, snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, IStorage* pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(in pwcsName, pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(in pwcsName, (IStorage*) pstgPriority.Handle, grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), pstgPriority, grfMode, ref snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0, TI1>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref ComPtr<TI1> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(in pwcsName, (IStorage*) pstgPriority.Handle, grfMode, ref snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), pstgPriority, grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(in pwcsName, (IStorage*) pstgPriority.Handle, grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(in pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), ref pstgPriority.GetPinnableReference(), grfMode, snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(in pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(in pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), ref pstgPriority.GetPinnableReference(), grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), ref pstgPriority.GetPinnableReference(), grfMode, ref snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(in pwcsName, ref pstgPriority, grfMode, ref snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(in pwcsName.GetPinnableReference(), ref pstgPriority.GetPinnableReference(), grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0, TI1>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref ComPtr<TI1> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0, TI1>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref ComPtr<TI1> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, ref snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, (IStorage*) pstgPriority.Handle, grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, string[] snbExcludeSa, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, snbExclude, reserved, ref ppstg);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgPriority, uint grfMode, char** snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, IStorage** ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, ref snbExclude, reserved, ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ref IStorage pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref ComPtr<TI0> ppstg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority, grfMode, ref snbExclude, reserved, (IStorage**) ppstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorage(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgPriority, uint grfMode, ref char* snbExclude, uint reserved, ref IStorage* ppstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorage(pwcsName, ref pstgPriority.GetPinnableReference(), grfMode, ref snbExclude, reserved, ref ppstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, string[] snbExcludeSa, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->CopyTo(ciidExclude, rgiidExclude, snbExclude, pstgDest);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, char** snbExclude, ComPtr<TI0> pstgDest) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo(ciidExclude, rgiidExclude, snbExclude, (IStorage*) pstgDest.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, string[] snbExcludeSa, ref IStorage pstgDest)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->CopyTo(ciidExclude, rgiidExclude, snbExclude, ref pstgDest);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, char** snbExclude, Span<IStorage> pstgDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ciidExclude, rgiidExclude, snbExclude, ref pstgDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, ref char* snbExclude, ComPtr<TI0> pstgDest) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo(ciidExclude, rgiidExclude, ref snbExclude, (IStorage*) pstgDest.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* rgiidExclude, ref char* snbExclude, Span<IStorage> pstgDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ciidExclude, rgiidExclude, ref snbExclude, ref pstgDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, string[] snbExcludeSa, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->CopyTo(ciidExclude, in rgiidExclude, snbExclude, pstgDest);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> rgiidExclude, char** snbExclude, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ciidExclude, in rgiidExclude.GetPinnableReference(), snbExclude, pstgDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, char** snbExclude, ComPtr<TI0> pstgDest) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo(ciidExclude, in rgiidExclude, snbExclude, (IStorage*) pstgDest.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, string[] snbExcludeSa, ref IStorage pstgDest)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var snbExclude = (char**) SilkMarshal.StringArrayToPtr(snbExcludeSa);
        var ret = @this->CopyTo(ciidExclude, in rgiidExclude, snbExclude, ref pstgDest);
        SilkMarshal.CopyPtrToStringArray((nint) snbExclude, snbExcludeSa);
        SilkMarshal.Free((nint) snbExclude);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> rgiidExclude, char** snbExclude, Span<IStorage> pstgDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ciidExclude, in rgiidExclude.GetPinnableReference(), snbExclude, ref pstgDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> rgiidExclude, ref char* snbExclude, IStorage* pstgDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ciidExclude, in rgiidExclude.GetPinnableReference(), ref snbExclude, pstgDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid rgiidExclude, ref char* snbExclude, ComPtr<TI0> pstgDest) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo(ciidExclude, in rgiidExclude, ref snbExclude, (IStorage*) pstgDest.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStorage> thisVtbl, uint ciidExclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> rgiidExclude, ref char* snbExclude, Span<IStorage> pstgDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ciidExclude, in rgiidExclude.GetPinnableReference(), ref snbExclude, ref pstgDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(pwcsName, (IStorage*) pstgDest.Handle, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, pstgDest, in pwcsNewName.GetPinnableReference(), grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(pwcsName, (IStorage*) pstgDest.Handle, in pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(pwcsName, (IStorage*) pstgDest.Handle, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, ref pstgDest.GetPinnableReference(), pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, ref pstgDest.GetPinnableReference(), in pwcsNewName.GetPinnableReference(), grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, ref pstgDest.GetPinnableReference(), pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(in pwcsName.GetPinnableReference(), pstgDest, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(in pwcsName, (IStorage*) pstgDest.Handle, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(in pwcsName.GetPinnableReference(), pstgDest, in pwcsNewName.GetPinnableReference(), grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(in pwcsName, (IStorage*) pstgDest.Handle, in pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(in pwcsName.GetPinnableReference(), pstgDest, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(in pwcsName, (IStorage*) pstgDest.Handle, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(in pwcsName.GetPinnableReference(), ref pstgDest.GetPinnableReference(), pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(in pwcsName.GetPinnableReference(), ref pstgDest.GetPinnableReference(), in pwcsNewName.GetPinnableReference(), grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(in pwcsName.GetPinnableReference(), ref pstgDest.GetPinnableReference(), pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(pwcsName, (IStorage*) pstgDest.Handle, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, IStorage* pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, pstgDest, in pwcsNewName.GetPinnableReference(), grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(pwcsName, (IStorage*) pstgDest.Handle, in pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo<TI0>(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, ComPtr<TI0> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveElementTo(pwcsName, (IStorage*) pstgDest.Handle, pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, ref pstgDest.GetPinnableReference(), pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, ref pstgDest.GetPinnableReference(), in pwcsNewName.GetPinnableReference(), grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static int MoveElementTo(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, Span<IStorage> pstgDest, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName, uint grfFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveElementTo(pwcsName, ref pstgDest.GetPinnableReference(), pwcsNewName, grfFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements<TI0>(this ComPtr<IStorage> thisVtbl, uint reserved1, void* reserved2, uint reserved3, ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumSTATSTG>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumElements(reserved1, reserved2, reserved3, (IEnumSTATSTG**) ppenum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements<T0>(this ComPtr<IStorage> thisVtbl, uint reserved1, Span<T0> reserved2, uint reserved3, IEnumSTATSTG** ppenum) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumElements(reserved1, ref reserved2.GetPinnableReference(), reserved3, ppenum);
    }

    /// <summary>To be documented.</summary>
    public static int EnumElements<T0, TI0>(this ComPtr<IStorage> thisVtbl, uint reserved1, ref T0 reserved2, uint reserved3, ref ComPtr<TI0> ppenum) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IEnumSTATSTG>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumElements(reserved1, ref reserved2, reserved3, (IEnumSTATSTG**) ppenum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumElements<T0>(this ComPtr<IStorage> thisVtbl, uint reserved1, Span<T0> reserved2, uint reserved3, ref IEnumSTATSTG* ppenum) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumElements(reserved1, ref reserved2.GetPinnableReference(), reserved3, ref ppenum);
    }

    /// <summary>To be documented.</summary>
    public static int DestroyElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DestroyElement(in pwcsName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameElement(pwcsOldName, in pwcsNewName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameElement(in pwcsOldName.GetPinnableReference(), pwcsNewName);
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameElement(in pwcsOldName.GetPinnableReference(), in pwcsNewName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameElement(in pwcsOldName.GetPinnableReference(), pwcsNewName);
    }

    /// <summary>To be documented.</summary>
    public static int RenameElement(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsOldName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsNewName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RenameElement(pwcsOldName, in pwcsNewName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, pctime, patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, pctime, in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, pctime, in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), patime, pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), pctime, patime, pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), pctime, patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), pctime, in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), pctime, in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), in pctime.GetPinnableReference(), patime, pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), in pctime.GetPinnableReference(), patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), in pctime.GetPinnableReference(), in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(in pwcsName.GetPinnableReference(), in pctime.GetPinnableReference(), in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, pctime, patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, pctime, in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, pctime, in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), patime, pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static int SetElementTimes(this ComPtr<IStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetElementTimes(pwcsName, in pctime.GetPinnableReference(), in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetClass(this ComPtr<IStorage> thisVtbl, Span<Guid> clsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetClass(ref clsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IStorage> thisVtbl, Span<STATSTG> pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Stat(ref pstatstg.GetPinnableReference(), grfStatFlag);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IStorage> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
