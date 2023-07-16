// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance"]/*'/>
[Guid("469E07F7-045A-48D5-AA12-68A478CDF75D")]
[NativeTypeName("struct ID3D11ModuleInstance : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11ModuleInstance : ID3D11ModuleInstance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ModuleInstance));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint> )(lpVtbl[1]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint> )(lpVtbl[2]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindConstantBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int> )(lpVtbl[3]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, cbDstOffset);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BindConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint cbDstOffset)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int> )(lpVtbl[4]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, cbDstOffset);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int> )(lpVtbl[5]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResourceByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BindResourceByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int> )(lpVtbl[6]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindSampler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int> )(lpVtbl[7]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindSamplerByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BindSamplerByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int> )(lpVtbl[8]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int> )(lpVtbl[9]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindUnorderedAccessViewByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BindUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int> )(lpVtbl[10]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResourceAsUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int> )(lpVtbl[11]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSrvSlot, uDstUavSlot, uCount);
    }

    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResourceAsUnorderedAccessViewByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT BindResourceAsUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pSrvName, uint uDstUavSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int> )(lpVtbl[12]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pSrvName, uDstUavSlot, uCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset);
        [VtblIndex(4)]
        HRESULT BindConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint cbDstOffset);
        [VtblIndex(5)]
        HRESULT BindResource(uint uSrcSlot, uint uDstSlot, uint uCount);
        [VtblIndex(6)]
        HRESULT BindResourceByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount);
        [VtblIndex(7)]
        HRESULT BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount);
        [VtblIndex(8)]
        HRESULT BindSamplerByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount);
        [VtblIndex(9)]
        HRESULT BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount);
        [VtblIndex(10)]
        HRESULT BindUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount);
        [VtblIndex(11)]
        HRESULT BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount);
        [VtblIndex(12)]
        HRESULT BindResourceAsUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pSrvName, uint uDstUavSlot, uint uCount);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindConstantBuffer;
        [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindConstantBufferByName;
        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindResource;
        [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindResourceByName;
        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindSampler;
        [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindSamplerByName;
        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindUnorderedAccessView;
        [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindUnorderedAccessViewByName;
        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindResourceAsUnorderedAccessView;
        [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindResourceAsUnorderedAccessViewByName;
    }
}