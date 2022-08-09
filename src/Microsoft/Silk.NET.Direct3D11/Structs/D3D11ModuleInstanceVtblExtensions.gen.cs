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

public unsafe static class D3D11ModuleInstanceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindConstantBuffer<TThis>(this TThis thisVtbl, uint uSrcSlot, uint uDstSlot, uint cbDstOffset) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindConstantBufferByName<TThis>(this TThis thisVtbl, byte* pName, uint uDstSlot, uint cbDstOffset) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindConstantBufferByName<TThis>(this TThis thisVtbl, ref byte pName, uint uDstSlot, uint cbDstOffset) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindConstantBufferByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint cbDstOffset) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResource<TThis>(this TThis thisVtbl, uint uSrcSlot, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindResourceByName<TThis>(this TThis thisVtbl, byte* pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pName, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceByName<TThis>(this TThis thisVtbl, ref byte pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindSampler<TThis>(this TThis thisVtbl, uint uSrcSlot, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindSamplerByName<TThis>(this TThis thisVtbl, byte* pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pName, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindSamplerByName<TThis>(this TThis thisVtbl, ref byte pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindSamplerByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindUnorderedAccessView<TThis>(this TThis thisVtbl, uint uSrcSlot, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindUnorderedAccessViewByName<TThis>(this TThis thisVtbl, byte* pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pName, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindUnorderedAccessViewByName<TThis>(this TThis thisVtbl, ref byte pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindUnorderedAccessViewByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceAsUnorderedAccessView<TThis>(this TThis thisVtbl, uint uSrcSrvSlot, uint uDstUavSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindResourceAsUnorderedAccessViewByName<TThis>(this TThis thisVtbl, byte* pSrvName, uint uDstUavSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceAsUnorderedAccessViewByName<TThis>(this TThis thisVtbl, ref byte pSrvName, uint uDstUavSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pSrvNamePtr = &pSrvName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceAsUnorderedAccessViewByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrvName, uint uDstUavSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSrvNamePtr = (byte*) SilkMarshal.StringToPtr(pSrvName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
        SilkMarshal.Free((nint)pSrvNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int BindConstantBufferByName<TThis>(this TThis thisVtbl, Span<byte> pName, uint uDstSlot, uint cbDstOffset) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BindConstantBufferByName(ref pName.GetPinnableReference(), uDstSlot, cbDstOffset);
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceByName<TThis>(this TThis thisVtbl, Span<byte> pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BindResourceByName(ref pName.GetPinnableReference(), uDstSlot, uCount);
    }

    /// <summary>To be documented.</summary>
    public static int BindSamplerByName<TThis>(this TThis thisVtbl, Span<byte> pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BindSamplerByName(ref pName.GetPinnableReference(), uDstSlot, uCount);
    }

    /// <summary>To be documented.</summary>
    public static int BindUnorderedAccessViewByName<TThis>(this TThis thisVtbl, Span<byte> pName, uint uDstSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BindUnorderedAccessViewByName(ref pName.GetPinnableReference(), uDstSlot, uCount);
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceAsUnorderedAccessViewByName<TThis>(this TThis thisVtbl, Span<byte> pSrvName, uint uDstUavSlot, uint uCount) where TThis : IComVtbl<ID3D11ModuleInstance>
    {
        var @this = (ID3D11ModuleInstance*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BindResourceAsUnorderedAccessViewByName(ref pSrvName.GetPinnableReference(), uDstUavSlot, uCount);
    }

}
