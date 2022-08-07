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

public unsafe static class D3D12StateObjectPropertiesVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier<TThis>(this TThis thisVtbl, char* pExportName) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, void*>)@this->LpVtbl[3])(@this, pExportName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier<TThis>(this TThis thisVtbl, ref char pExportName) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        void* ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        void* ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, byte*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ulong GetShaderStackSize<TThis>(this TThis thisVtbl, char* pExportName) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, ulong>)@this->LpVtbl[4])(@this, pExportName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetShaderStackSize<TThis>(this TThis thisVtbl, ref char pExportName) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        fixed (char* pExportNamePtr = &pExportName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetShaderStackSize<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, byte*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
        SilkMarshal.Free((nint)pExportNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetPipelineStackSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, ulong>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineStackSize<TThis>(this TThis thisVtbl, ulong PipelineStackSizeInBytes) where TThis : IComVtbl<ID3D12StateObjectProperties>
    {
        var @this = (ID3D12StateObjectProperties*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, ulong, void>)@this->LpVtbl[6])(@this, PipelineStackSizeInBytes);
    }

}
