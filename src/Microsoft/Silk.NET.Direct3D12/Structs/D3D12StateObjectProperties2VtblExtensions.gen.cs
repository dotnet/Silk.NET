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

public unsafe static class D3D12StateObjectProperties2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12StateObjectProperties2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12StateObjectProperties2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, void*>)@this->LpVtbl[3])(@this, pExportName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ulong GetShaderStackSize(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, ulong>)@this->LpVtbl[4])(@this, pExportName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetShaderStackSize(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetShaderStackSize(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetPipelineStackSize(this ComPtr<ID3D12StateObjectProperties2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ulong>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineStackSize(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, ulong PipelineStackSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ulong, void>)@this->LpVtbl[6])(@this, PipelineStackSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe ProgramIdentifier GetProgramIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName)
    {
        var @this = thisVtbl.Handle;
        ProgramIdentifier silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ProgramIdentifier* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ProgramIdentifier*, char*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramName);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ProgramIdentifier GetProgramIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName)
    {
        var @this = thisVtbl.Handle;
        ProgramIdentifier silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ProgramIdentifier* ret = default;
        fixed (char* pProgramNamePtr = &pProgramName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ProgramIdentifier*, char*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramNamePtr);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ProgramIdentifier GetProgramIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName)
    {
        var @this = thisVtbl.Handle;
        ProgramIdentifier silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ProgramIdentifier* ret = default;
        var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ProgramIdentifier*, byte*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramNamePtr);
        SilkMarshal.Free((nint)pProgramNamePtr);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riid, ppvRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riid, ppvRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riidPtr, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riidPtr, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pProgramNamePtr = &pProgramName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pProgramNamePtr = &pProgramName)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pProgramNamePtr = &pProgramName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pProgramNamePtr = &pProgramName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignature);
        SilkMarshal.Free((nint)pProgramNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignaturePtr);
        }
        SilkMarshal.Free((nint)pProgramNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignature);
        }
        SilkMarshal.Free((nint)pProgramNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignaturePtr);
            }
        }
        SilkMarshal.Free((nint)pProgramNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riid, ppvRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riid, ppvRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riidPtr, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riidPtr, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignature);
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignaturePtr);
        }
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignature);
        }
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignaturePtr);
            }
        }
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExportName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetShaderIdentifier(in pExportName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ulong GetShaderStackSize(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExportName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetShaderStackSize(in pExportName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ProgramIdentifier GetProgramIdentifier(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pProgramName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProgramIdentifier(in pProgramName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->GetGlobalRootSignatureForProgram(pProgramName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(pProgramName, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(pProgramName, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pProgramName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(in pProgramName.GetPinnableReference(), riid, ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlobalRootSignatureForProgram<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->GetGlobalRootSignatureForProgram(in pProgramName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pProgramName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(in pProgramName.GetPinnableReference(), riid, ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pProgramName, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(in pProgramName.GetPinnableReference(), ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pProgramName, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(in pProgramName.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlobalRootSignatureForProgram<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->GetGlobalRootSignatureForProgram(pProgramName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(pProgramName, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForProgram(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForProgram(pProgramName, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->GetGlobalRootSignatureForShader(pExportName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(pExportName, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(pExportName, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExportName, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(in pExportName.GetPinnableReference(), riid, ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlobalRootSignatureForShader<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->GetGlobalRootSignatureForShader(in pExportName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExportName, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(in pExportName.GetPinnableReference(), riid, ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExportName, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(in pExportName.GetPinnableReference(), ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pExportName, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(in pExportName.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlobalRootSignatureForShader<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->GetGlobalRootSignatureForShader(pExportName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(pExportName, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlobalRootSignatureForShader(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlobalRootSignatureForShader(pExportName, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetGlobalRootSignatureForProgram<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForProgram(pProgramName, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetGlobalRootSignatureForProgram<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForProgram(in pProgramName, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetGlobalRootSignatureForProgram<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForProgram(pProgramName, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetGlobalRootSignatureForShader<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForShader(pExportName, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetGlobalRootSignatureForShader<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForShader(in pExportName, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetGlobalRootSignatureForShader<TI0>(this ComPtr<ID3D12StateObjectProperties2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForShader(pExportName, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
