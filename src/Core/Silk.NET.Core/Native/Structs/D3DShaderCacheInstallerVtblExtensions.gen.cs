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

public unsafe static class D3DShaderCacheInstallerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterDriverUpdateListener(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterDriverUpdateListener(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterServiceDriverUpdateTrigger(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Silk.NET.Core.Native.ScHandle hServiceHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, Silk.NET.Core.Native.ScHandle, int>)@this->LpVtbl[5])(@this, hServiceHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterServiceDriverUpdateTrigger(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Silk.NET.Core.Native.ScHandle hServiceHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, Silk.NET.Core.Native.ScHandle, int>)@this->LpVtbl[6])(@this, hServiceHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDesc, riid, ppvApp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvAppPtr = &ppvApp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDesc, riid, ppvAppPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDesc, riidPtr, ppvApp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDesc, riidPtr, ppvAppPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDescPtr, riid, ppvApp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDescPtr, riid, ppvAppPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDescPtr, riidPtr, ppvApp);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePath, pApplicationDescPtr, riidPtr, ppvAppPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riid, ppvApp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riid, ppvAppPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riidPtr, ppvApp);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riidPtr, ppvAppPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riid, ppvApp);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riid, ppvAppPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riidPtr, ppvApp);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExePathPtr = &pExePath)
        {
            fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvAppPtr = &ppvApp)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, char*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riidPtr, ppvAppPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riid, ppvApp);
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (void** ppvAppPtr = &ppvApp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riid, ppvAppPtr);
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riidPtr, ppvApp);
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDesc, riidPtr, ppvAppPtr);
            }
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riid, ppvApp);
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riid, ppvAppPtr);
            }
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riidPtr, ppvApp);
            }
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExePathPtr = (byte*) SilkMarshal.StringToPtr(pExePath, NativeStringEncoding.UTF8);
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, byte*, D3DShaderCacheApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pExePathPtr, pApplicationDescPtr, riidPtr, ppvAppPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, ID3DShaderCacheApplication* pApplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, ID3DShaderCacheApplication*, int>)@this->LpVtbl[8])(@this, pApplication);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, ref ID3DShaderCacheApplication pApplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3DShaderCacheApplication* pApplicationPtr = &pApplication)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, ID3DShaderCacheApplication*, int>)@this->LpVtbl[8])(@this, pApplicationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetApplicationCount(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint, Guid*, void**, int>)@this->LpVtbl[10])(@this, index, riid, ppvApp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvAppPtr = &ppvApp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint, Guid*, void**, int>)@this->LpVtbl[10])(@this, index, riid, ppvAppPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint, Guid*, void**, int>)@this->LpVtbl[10])(@this, index, riidPtr, ppvApp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint, Guid*, void**, int>)@this->LpVtbl[10])(@this, index, riidPtr, ppvAppPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ClearAllState(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, int>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMaxPrecompileTargetCount(this ComPtr<ID3DShaderCacheInstaller> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, uint* pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDesc, pArraySize, pArray, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, uint* pArraySize, ref D3DShaderCacheCompilerProperties pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheCompilerProperties* pArrayPtr = &pArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDesc, pArraySize, pArrayPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref uint pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pArraySizePtr = &pArraySize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDesc, pArraySizePtr, pArray, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, ref uint pArraySize, ref D3DShaderCacheCompilerProperties pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pArraySizePtr = &pArraySize)
        {
            fixed (D3DShaderCacheCompilerProperties* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDesc, pArraySizePtr, pArrayPtr, flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, uint* pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDescPtr, pArraySize, pArray, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, uint* pArraySize, ref D3DShaderCacheCompilerProperties pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (D3DShaderCacheCompilerProperties* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDescPtr, pArraySize, pArrayPtr, flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref uint pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (uint* pArraySizePtr = &pArraySize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDescPtr, pArraySizePtr, pArray, flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, ref uint pArraySize, ref D3DShaderCacheCompilerProperties pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCacheApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (uint* pArraySizePtr = &pArraySize)
            {
                fixed (D3DShaderCacheCompilerProperties* pArrayPtr = &pArray)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstaller*, D3DShaderCacheApplicationDesc*, uint*, D3DShaderCacheCompilerProperties*, D3DShaderCacheTargetFlags, int>)@this->LpVtbl[13])(@this, pApplicationDescPtr, pArraySizePtr, pArrayPtr, flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->RegisterApplication(pExePath, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, pApplicationDesc, ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, pApplicationDesc, ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), riid, ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->RegisterApplication(pExePath, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), riid, ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), pApplicationDesc, riid, ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->RegisterApplication(in pExePath, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), pApplicationDesc, riid, ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), pApplicationDesc, ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), pApplicationDesc, ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), riid, ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->RegisterApplication(in pExePath, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), riid, ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(in pExePath.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->RegisterApplication(pExePath, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, pApplicationDesc, ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, pApplicationDesc, ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), riid, ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->RegisterApplication(pExePath, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), riid, ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterApplication(pExePath, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, ComPtr<TI0> pApplication) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheApplication>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveApplication((ID3DShaderCacheApplication*) pApplication.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, Span<ID3DShaderCacheApplication> pApplication)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveApplication(ref pApplication.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->GetApplication(index, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplication(index, ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplication(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplication(index, ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, uint* pArraySize, Span<D3DShaderCacheCompilerProperties> pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(pApplicationDesc, pArraySize, ref pArray.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<uint> pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(pApplicationDesc, ref pArraySize.GetPinnableReference(), pArray, flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc, Span<uint> pArraySize, Span<D3DShaderCacheCompilerProperties> pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(pApplicationDesc, ref pArraySize.GetPinnableReference(), ref pArray.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, uint* pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(in pApplicationDesc.GetPinnableReference(), pArraySize, pArray, flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, uint* pArraySize, Span<D3DShaderCacheCompilerProperties> pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(in pApplicationDesc.GetPinnableReference(), pArraySize, ref pArray.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<uint> pArraySize, D3DShaderCacheCompilerProperties* pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(in pApplicationDesc.GetPinnableReference(), ref pArraySize.GetPinnableReference(), pArray, flags);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompileTargets(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3DShaderCacheApplicationDesc> pApplicationDesc, Span<uint> pArraySize, Span<D3DShaderCacheCompilerProperties> pArray, D3DShaderCacheTargetFlags flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompileTargets(in pApplicationDesc.GetPinnableReference(), ref pArraySize.GetPinnableReference(), ref pArray.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterApplication(pExePath, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterApplication(pExePath, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterApplication(in pExePath, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterApplication(in pExePath, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3DShaderCacheApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterApplication(pExePath, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> RegisterApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pExePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly D3DShaderCacheApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->RegisterApplication(pExePath, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetApplication<TI0>(this ComPtr<ID3DShaderCacheInstaller> thisVtbl, uint index) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetApplication(index, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
