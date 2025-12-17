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

namespace Silk.NET.Core.Native;

public unsafe static class D3DShaderCacheApplicationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheApplication> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheApplication> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheApplication> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheApplication> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3DShaderCacheApplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3DShaderCacheApplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExePath(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pExePath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char**, int>)@this->LpVtbl[3])(@this, pExePath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExePath(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pExePath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pExePathPtr = &pExePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char**, int>)@this->LpVtbl[3])(@this, pExePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3DShaderCacheApplication> thisVtbl, D3DShaderCacheApplicationDesc* pApplicationDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, D3DShaderCacheApplicationDesc*, int>)@this->LpVtbl[4])(@this, pApplicationDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3DShaderCacheApplication> thisVtbl, ref D3DShaderCacheApplicationDesc pApplicationDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, D3DShaderCacheApplicationDesc*, int>)@this->LpVtbl[4])(@this, pApplicationDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvComponentPtr = &ppvComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBs, riidPtr, ppvComponent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riid, ppvComponent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvComponentPtr = &ppvComponent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponent);
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (void** ppvComponentPtr = &ppvComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponentPtr);
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponent);
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponent);
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pName, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riidPtr, ppvComponent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riid, ppvComponent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvComponentPtr = &ppvComponent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponentPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponent);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvComponentPtr = &ppvComponent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponent);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
                {
                    fixed (void** ppvComponentPtr = &ppvComponent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
            {
                fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvComponentPtr = &ppvComponent)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponent);
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponentPtr);
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponent);
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
                }
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponent);
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
                }
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
                }
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvComponentPtr = &ppvComponent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponent);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (void** ppvComponentPtr = &ppvComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponentPtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riidPtr, ppvComponent);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riid, ppvComponent);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPath, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponent);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponent);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponent);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        fixed (char* pStateObjectDBPathPtr = &pStateObjectDBPath)
        {
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvComponentPtr = &ppvComponent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, char*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponent);
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (void** ppvComponentPtr = &ppvComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riid, ppvComponentPtr);
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponent);
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBs, riidPtr, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponent);
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riid, ppvComponentPtr);
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponent);
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        var pStateObjectDBPathPtr = (byte*) SilkMarshal.StringToPtr(pStateObjectDBPath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvComponentPtr = &ppvComponent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, byte*, byte*, uint, D3DShaderCachePsdbProperties*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pNamePtr, pStateObjectDBPathPtr, NumPSDB, pPSDBsPtr, riidPtr, ppvComponentPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pStateObjectDBPathPtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, ID3DShaderCacheComponent* pComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, ID3DShaderCacheComponent*, int>)@this->LpVtbl[6])(@this, pComponent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, ref ID3DShaderCacheComponent pComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3DShaderCacheComponent* pComponentPtr = &pComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, ID3DShaderCacheComponent*, int>)@this->LpVtbl[6])(@this, pComponentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetComponentCount(this ComPtr<ID3DShaderCacheApplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, index, riid, ppvComponent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvComponentPtr = &ppvComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, index, riid, ppvComponentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, ref Guid riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, index, riidPtr, ppvComponent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, ref Guid riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvComponentPtr = &ppvComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, index, riidPtr, ppvComponentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPrecompileTargetCount(this ComPtr<ID3DShaderCacheApplication> thisVtbl, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, D3DShaderCacheTargetFlags, uint>)@this->LpVtbl[9])(@this, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint ArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[10])(@this, ArraySize, pArray, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompileTargets(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint ArraySize, ref D3DShaderCacheCompilerProperties pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheCompilerProperties* pArrayPtr = &pArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, uint, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[10])(@this, ArraySize, pArrayPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pInstallerName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char**, int>)@this->LpVtbl[11])(@this, pInstallerName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pInstallerName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pInstallerNamePtr = &pInstallerName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheApplication*, char**, int>)@this->LpVtbl[11])(@this, pInstallerNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheApplication> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheApplication> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetExePath(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pExePathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pExePath = (char**) SilkMarshal.StringArrayToPtr(pExePathSa);
        var ret = @this->GetExePath(pExePath);
        SilkMarshal.CopyPtrToStringArray((nint) pExePath, pExePathSa);
        SilkMarshal.Free((nint) pExePath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3DShaderCacheApplication> thisVtbl, Span<D3DShaderCacheApplicationDesc> pApplicationDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pApplicationDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(in pName, in pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(in pName, in pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(in pName.GetPinnableReference(), pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, in pStateObjectDBPath.GetPinnableReference(), NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Guid* riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), riid, ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCachePsdbProperties> pPSDBs, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, ComPtr<TI0> pComponent) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheComponent>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveComponent((ID3DShaderCacheComponent*) pComponent.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, Span<ID3DShaderCacheComponent> pComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveComponent(ref pComponent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, out ComPtr<TI0> ppvComponent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvComponent = default;
        return @this->GetComponent(index, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvComponent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, Span<Guid> riid, void** ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComponent(index, ref riid.GetPinnableReference(), ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponent(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index, Span<Guid> riid, ref void* ppvComponent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComponent(index, ref riid.GetPinnableReference(), ref ppvComponent);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompileTargets(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint ArraySize, Span<D3DShaderCacheCompilerProperties> pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(ArraySize, ref pArray.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static int GetInstallerName(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pInstallerNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pInstallerName = (char**) SilkMarshal.StringArrayToPtr(pInstallerNameSa);
        var ret = @this->GetInstallerName(pInstallerName);
        SilkMarshal.CopyPtrToStringArray((nint) pInstallerName, pInstallerNameSa);
        SilkMarshal.Free((nint) pInstallerName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(in pName, in pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(in pName, in pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(in pName, pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, in pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCachePsdbProperties* pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> RegisterComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStateObjectDBPath, uint NumPSDB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCachePsdbProperties pPSDBs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterComponent(pName, pStateObjectDBPath, NumPSDB, in pPSDBs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetComponent<TI0>(this ComPtr<ID3DShaderCacheApplication> thisVtbl, uint index) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetComponent(index, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
