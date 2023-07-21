// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties"]/*' />
[Guid("DE5FA827-9BF9-4F26-89FF-D7F56FDE3860")]
[NativeTypeName("struct ID3D12StateObjectProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12StateObjectProperties : ID3D12StateObjectProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12StateObjectProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties*, uint>)(lpVtbl[1]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties*, uint>)(lpVtbl[2]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetShaderIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName)
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties*, ushort*, void*>)(lpVtbl[3]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
    }

    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetShaderStackSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT64")]
    public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName)
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties*, ushort*, ulong>)(lpVtbl[4]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
    }

    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.GetPipelineStackSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPipelineStackSize()
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties*, ulong>)(lpVtbl[5]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectProperties.xml' path='doc/member[@name="ID3D12StateObjectProperties.SetPipelineStackSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
    {
        ((delegate* unmanaged<ID3D12StateObjectProperties*, ulong, void>)(lpVtbl[6]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), PipelineStackSizeInBytes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName);

        [VtblIndex(4)]
        [return: NativeTypeName("UINT64")]
        ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName);

        [VtblIndex(5)]
        [return: NativeTypeName("UINT64")]
        ulong GetPipelineStackSize();

        [VtblIndex(6)]
        void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes);
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

        [NativeTypeName("void *(LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*> GetShaderIdentifier;

        [NativeTypeName("UINT64 (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong> GetShaderStackSize;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetPipelineStackSize;

        [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, void> SetPipelineStackSize;
    }
}
