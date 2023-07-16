// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12Downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12CommandQueueDownlevel.xml' path='doc/member[@name="ID3D12CommandQueueDownlevel"]/*'/>
[Guid("38A8C5EF-7CCB-4E81-914F-A6E9D072C494")]
[NativeTypeName("struct ID3D12CommandQueueDownlevel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12CommandQueueDownlevel : ID3D12CommandQueueDownlevel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12CommandQueueDownlevel));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12CommandQueueDownlevel*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12CommandQueueDownlevel*, uint> )(lpVtbl[1]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12CommandQueueDownlevel*, uint> )(lpVtbl[2]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CommandQueueDownlevel.xml' path='doc/member[@name="ID3D12CommandQueueDownlevel.Present"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Present(ID3D12GraphicsCommandList* pOpenCommandList, ID3D12Resource* pSourceTex2D, HWND hWindow, D3D12_DOWNLEVEL_PRESENT_FLAGS Flags)
    {
        return ((delegate* unmanaged<ID3D12CommandQueueDownlevel*, ID3D12GraphicsCommandList*, ID3D12Resource*, HWND, D3D12_DOWNLEVEL_PRESENT_FLAGS, int> )(lpVtbl[3]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this), pOpenCommandList, pSourceTex2D, hWindow, Flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Present(ID3D12GraphicsCommandList* pOpenCommandList, ID3D12Resource* pSourceTex2D, HWND hWindow, D3D12_DOWNLEVEL_PRESENT_FLAGS Flags);
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
        [NativeTypeName("HRESULT (ID3D12GraphicsCommandList *, ID3D12Resource *, HWND, D3D12_DOWNLEVEL_PRESENT_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12GraphicsCommandList*, ID3D12Resource*, HWND, D3D12_DOWNLEVEL_PRESENT_FLAGS, int> Present;
    }
}