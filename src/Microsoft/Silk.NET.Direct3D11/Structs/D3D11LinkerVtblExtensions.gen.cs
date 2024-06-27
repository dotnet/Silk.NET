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

public unsafe static class D3D11LinkerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11Linker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11Linker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UseLibrary(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pLibraryMI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMI);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UseLibrary(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pLibraryMI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance* pLibraryMIPtr = &pLibraryMI)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMIPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddClipPlaneFromCBuffer(this ComPtr<ID3D11Linker> thisVtbl, uint uCBufferSlot, uint uCBufferEntry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint, uint, int>)@this->LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11Linker> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntry, pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1, TI2>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), in pEntryName.GetPinnableReference(), pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, in pTargetName.GetPinnableReference(), uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Link<TI0, TI1>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntry.GetPinnableReference(), pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int UseLibrary<TI0>(this ComPtr<ID3D11Linker> thisVtbl, ComPtr<TI0> pLibraryMI) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UseLibrary((ID3D11ModuleInstance*) pLibraryMI.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int UseLibrary(this ComPtr<ID3D11Linker> thisVtbl, Span<ID3D11ModuleInstance> pLibraryMI)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UseLibrary(ref pLibraryMI.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11Linker> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
