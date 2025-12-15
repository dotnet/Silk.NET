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

public unsafe static class D3D12CompilerFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12CompilerFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12CompilerFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilies(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, AdapterFamily* pAdapterFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, AdapterFamily*, int>)@this->LpVtbl[3])(@this, AdapterFamilyIndex, pAdapterFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateAdapterFamilies(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, ref AdapterFamily pAdapterFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (AdapterFamily* pAdapterFamilyPtr = &pAdapterFamily)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, AdapterFamily*, int>)@this->LpVtbl[3])(@this, AdapterFamilyIndex, pAdapterFamilyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, uint* pNumABIVersions, ulong* pABIVersions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersions, pABIVersions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, uint* pNumABIVersions, ref ulong pABIVersions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pABIVersionsPtr = &pABIVersions)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersions, pABIVersionsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, ref uint pNumABIVersions, ulong* pABIVersions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumABIVersionsPtr = &pNumABIVersions)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersionsPtr, pABIVersions);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, ref uint pNumABIVersions, ref ulong pABIVersions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumABIVersionsPtr = &pNumABIVersions)
        {
            fixed (ulong* pABIVersionsPtr = &pABIVersions)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersionsPtr, pABIVersionsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilyCompilerVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, VersionNumber* pCompilerVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, VersionNumber*, int>)@this->LpVtbl[5])(@this, AdapterFamilyIndex, pCompilerVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateAdapterFamilyCompilerVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, ref VersionNumber pCompilerVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VersionNumber* pCompilerVersionPtr = &pCompilerVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, VersionNumber*, int>)@this->LpVtbl[5])(@this, AdapterFamilyIndex, pCompilerVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDesc, pApplicationProfileVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDesc, pApplicationProfileVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDescPtr, pApplicationProfileVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDescPtr, pApplicationProfileVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDesc, pApplicationProfileVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDesc, pApplicationProfileVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDescPtr, pApplicationProfileVersion);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDescPtr, pApplicationProfileVersionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerTarget* pTargetPtr = &pTarget)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
        {
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ID3D12CompilerCacheSession* pCompilerCacheSession, Guid* riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riid, ppCompiler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ID3D12CompilerCacheSession* pCompilerCacheSession, Guid* riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCompilerPtr = &ppCompiler)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riid, ppCompilerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ID3D12CompilerCacheSession* pCompilerCacheSession, ref Guid riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riidPtr, ppCompiler);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ID3D12CompilerCacheSession* pCompilerCacheSession, ref Guid riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCompilerPtr = &ppCompiler)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riidPtr, ppCompilerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref ID3D12CompilerCacheSession pCompilerCacheSession, Guid* riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riid, ppCompiler);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref ID3D12CompilerCacheSession pCompilerCacheSession, Guid* riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
        {
            fixed (void** ppCompilerPtr = &ppCompiler)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riid, ppCompilerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref ID3D12CompilerCacheSession pCompilerCacheSession, ref Guid riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riidPtr, ppCompiler);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref ID3D12CompilerCacheSession pCompilerCacheSession, ref Guid riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerPtr = &ppCompiler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riidPtr, ppCompilerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateAdapterFamilies(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, Span<AdapterFamily> pAdapterFamily)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateAdapterFamilies(AdapterFamilyIndex, ref pAdapterFamily.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, uint* pNumABIVersions, Span<ulong> pABIVersions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateAdapterFamilyABIVersions(AdapterFamilyIndex, pNumABIVersions, ref pABIVersions.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, Span<uint> pNumABIVersions, ulong* pABIVersions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateAdapterFamilyABIVersions(AdapterFamilyIndex, ref pNumABIVersions.GetPinnableReference(), pABIVersions);
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateAdapterFamilyABIVersions(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, Span<uint> pNumABIVersions, Span<ulong> pABIVersions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateAdapterFamilyABIVersions(AdapterFamilyIndex, ref pNumABIVersions.GetPinnableReference(), ref pABIVersions.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateAdapterFamilyCompilerVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, uint AdapterFamilyIndex, Span<VersionNumber> pCompilerVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateAdapterFamilyCompilerVersion(AdapterFamilyIndex, ref pCompilerVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<VersionNumber> pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(pTarget, pApplicationDesc, ref pApplicationProfileVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(pTarget, in pApplicationDesc.GetPinnableReference(), pApplicationProfileVersion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<VersionNumber> pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(pTarget, in pApplicationDesc.GetPinnableReference(), ref pApplicationProfileVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(in pTarget.GetPinnableReference(), pApplicationDesc, pApplicationProfileVersion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<VersionNumber> pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(in pTarget.GetPinnableReference(), pApplicationDesc, ref pApplicationProfileVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, VersionNumber* pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), pApplicationProfileVersion);
    }

    /// <summary>To be documented.</summary>
    public static int GetApplicationProfileVersion(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<VersionNumber> pApplicationProfileVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationProfileVersion(in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref pApplicationProfileVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, pApplicationDesc, ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, pApplicationDesc, ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, pApplicationDesc, riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, pApplicationDesc, ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, pApplicationDesc, ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, pTarget, in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), pApplicationDesc, ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), riid, ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerCacheSession = default;
        return @this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), riid, ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, void** ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompilerCacheSession(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerDatabasePath> pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerTarget> pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApplicationDesc> pApplicationDesc, Span<Guid> riid, ref void* ppCompilerCacheSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompilerCacheSession(in pPaths.GetPinnableReference(), NumPaths, in pTarget.GetPinnableReference(), in pApplicationDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCompilerCacheSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCompiler<TI0, TI1>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ComPtr<TI0> pCompilerCacheSession, out ComPtr<TI1> ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompiler = default;
        return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppCompiler.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ComPtr<TI0> pCompilerCacheSession, Guid* riid, ref void* ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, riid, ref ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ID3D12CompilerCacheSession* pCompilerCacheSession, Span<Guid> riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompiler(pCompilerCacheSession, ref riid.GetPinnableReference(), ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ComPtr<TI0> pCompilerCacheSession, ref Guid riid, void** ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, ref riid, ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, ID3D12CompilerCacheSession* pCompilerCacheSession, Span<Guid> riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompiler(pCompilerCacheSession, ref riid.GetPinnableReference(), ref ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ComPtr<TI0> pCompilerCacheSession, ref Guid riid, ref void* ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, ref riid, ref ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, Span<ID3D12CompilerCacheSession> pCompilerCacheSession, Guid* riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompiler(ref pCompilerCacheSession.GetPinnableReference(), riid, ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCompiler<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref ID3D12CompilerCacheSession pCompilerCacheSession, out ComPtr<TI0> ppCompiler) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompiler = default;
        return @this->CreateCompiler(ref pCompilerCacheSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompiler.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, Span<ID3D12CompilerCacheSession> pCompilerCacheSession, Guid* riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompiler(ref pCompilerCacheSession.GetPinnableReference(), riid, ref ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, Span<ID3D12CompilerCacheSession> pCompilerCacheSession, Span<Guid> riid, void** ppCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompiler(ref pCompilerCacheSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompiler(this ComPtr<ID3D12CompilerFactory> thisVtbl, Span<ID3D12CompilerCacheSession> pCompilerCacheSession, Span<Guid> riid, ref void* ppCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompiler(ref pCompilerCacheSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCompiler);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCompilerCacheSession<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateCompiler<TI0, TI1>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ComPtr<TI0> pCompilerCacheSession) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompiler(pCompilerCacheSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCompiler<TI0>(this ComPtr<ID3D12CompilerFactory> thisVtbl, ref ID3D12CompilerCacheSession pCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCompiler(ref pCompilerCacheSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
