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

public unsafe static class D3D12WorkGraphPropertiesVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12WorkGraphProperties> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12WorkGraphProperties> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumWorkGraphs(this ComPtr<ID3D12WorkGraphProperties> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe char* GetProgramName(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex)
    {
        var @this = thisVtbl.Handle;
        char* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, char*>)@this->LpVtbl[4])(@this, WorkGraphIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)]
    public static string GetProgramNameS(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex)
    {
        var @this = thisVtbl.Handle;
        string ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, string>)@this->LpVtbl[4])(@this, WorkGraphIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetWorkGraphIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, char*, uint>)@this->LpVtbl[5])(@this, pProgramName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetWorkGraphIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pProgramName)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (char* pProgramNamePtr = &pProgramName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, char*, uint>)@this->LpVtbl[5])(@this, pProgramNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetWorkGraphIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, byte*, uint>)@this->LpVtbl[5])(@this, pProgramNamePtr);
        SilkMarshal.Free((nint)pProgramNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumNodes(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint>)@this->LpVtbl[6])(@this, WorkGraphIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static NodeID GetNodeID(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, uint NodeIndex)
    {
        var @this = thisVtbl.Handle;
        NodeID silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        NodeID* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, NodeID*, uint, uint, NodeID*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, WorkGraphIndex, NodeIndex);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, NodeID NodeID)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, NodeID, uint>)@this->LpVtbl[8])(@this, WorkGraphIndex, NodeID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeLocalRootArgumentsTableIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, uint NodeIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint, uint>)@this->LpVtbl[9])(@this, WorkGraphIndex, NodeIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumEntrypoints(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint>)@this->LpVtbl[10])(@this, WorkGraphIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static NodeID GetEntrypointID(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, uint EntrypointIndex)
    {
        var @this = thisVtbl.Handle;
        NodeID silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        NodeID* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, NodeID*, uint, uint, NodeID*>)@this->LpVtbl[11])(@this, pSilkDotNetReturnFixupResult, WorkGraphIndex, EntrypointIndex);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetEntrypointIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, NodeID NodeID)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, NodeID, uint>)@this->LpVtbl[12])(@this, WorkGraphIndex, NodeID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetEntrypointRecordSizeInBytes(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, uint EntrypointIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint, uint>)@this->LpVtbl[13])(@this, WorkGraphIndex, EntrypointIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetWorkGraphMemoryRequirements(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, WorkGraphMemoryRequirements*, void>)@this->LpVtbl[14])(@this, WorkGraphIndex, pWorkGraphMemoryRequirements);
    }

    /// <summary>To be documented.</summary>
    public static void GetWorkGraphMemoryRequirements(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, ref WorkGraphMemoryRequirements pWorkGraphMemoryRequirements)
    {
        var @this = thisVtbl.Handle;
        fixed (WorkGraphMemoryRequirements* pWorkGraphMemoryRequirementsPtr = &pWorkGraphMemoryRequirements)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, WorkGraphMemoryRequirements*, void>)@this->LpVtbl[14])(@this, WorkGraphIndex, pWorkGraphMemoryRequirementsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static uint GetWorkGraphIndex(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pProgramName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWorkGraphIndex(in pProgramName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetWorkGraphMemoryRequirements(this ComPtr<ID3D12WorkGraphProperties> thisVtbl, uint WorkGraphIndex, Span<WorkGraphMemoryRequirements> pWorkGraphMemoryRequirements)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetWorkGraphMemoryRequirements(WorkGraphIndex, ref pWorkGraphMemoryRequirements.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12WorkGraphProperties> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
