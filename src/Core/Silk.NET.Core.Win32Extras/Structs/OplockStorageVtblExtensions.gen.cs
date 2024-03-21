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

public unsafe static class OplockStorageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOplockStorage> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOplockStorage> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOplockStorage> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOplockStorage> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IOplockStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IOplockStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppstgOpenPtr = &ppstgOpen)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        fixed (void** ppstgOpenPtr = &ppstgOpen)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppstgOpenPtr = &ppstgOpen)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsName, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNamePtr = &pwcsName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppstgOpenPtr = &ppstgOpen)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, char*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        fixed (void** ppstgOpenPtr = &ppstgOpen)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riid, ppstgOpenPtr);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpen);
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref Guid riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppstgOpenPtr = &ppstgOpen)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOplockStorage*, byte*, uint, uint, uint, Guid*, void**, int>)@this->LpVtbl[4])(@this, pwcsNamePtr, grfMode, stgfmt, grfAttrs, riidPtr, ppstgOpenPtr);
            }
        }
        SilkMarshal.Free((nint)pwcsNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IOplockStorage> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOplockStorage> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOplockStorage> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppstgOpen = default;
        return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppstgOpen = default;
        return @this->CreateStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, riid, ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppstgOpen = default;
        return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppstgOpen = default;
        return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static int OpenStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppstgOpen = default;
        return @this->OpenStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Guid* riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, riid, ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(in pwcsName.GetPinnableReference(), grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static int OpenStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, out ComPtr<TI0> ppstgOpen) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppstgOpen = default;
        return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppstgOpen.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, void** ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenStorageEx(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, Span<Guid> riid, ref void* ppstgOpen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, ref riid.GetPinnableReference(), ref ppstgOpen);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IOplockStorage> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> OpenStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenStorageEx(in pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenStorageEx<TI0>(this ComPtr<IOplockStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenStorageEx(pwcsName, grfMode, stgfmt, grfAttrs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
