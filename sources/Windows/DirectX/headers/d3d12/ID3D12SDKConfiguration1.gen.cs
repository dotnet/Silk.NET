// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1"]/*'/>
[Guid("8AAF9303-AD25-48B9-9A57-D9C37E009D9F")]
[NativeTypeName("struct ID3D12SDKConfiguration1 : ID3D12SDKConfiguration")]
[NativeInheritance("ID3D12SDKConfiguration")]
public unsafe partial struct ID3D12SDKConfiguration1 : ID3D12SDKConfiguration1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SDKConfiguration1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12SDKConfiguration1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration1*, uint> )(lpVtbl[1]))((ID3D12SDKConfiguration1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration1*, uint> )(lpVtbl[2]))((ID3D12SDKConfiguration1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12SDKConfiguration.SetSDKVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath)
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration1*, uint, sbyte*, int> )(lpVtbl[3]))((ID3D12SDKConfiguration1*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
    }

    /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1.CreateDeviceFactory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath, [NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration1*, uint, sbyte*, Guid*, void**, int> )(lpVtbl[4]))((ID3D12SDKConfiguration1*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath, riid, ppvFactory);
    }

    /// <include file='ID3D12SDKConfiguration1.xml' path='doc/member[@name="ID3D12SDKConfiguration1.FreeUnusedSDKs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void FreeUnusedSDKs()
    {
        ((delegate* unmanaged<ID3D12SDKConfiguration1*, void> )(lpVtbl[5]))((ID3D12SDKConfiguration1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12SDKConfiguration.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateDeviceFactory(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath, [NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
        [VtblIndex(5)]
        void FreeUnusedSDKs();
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
        [NativeTypeName("HRESULT (UINT, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*, int> SetSDKVersion;
        [NativeTypeName("HRESULT (UINT, LPCSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*, Guid*, void**, int> CreateDeviceFactory;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> FreeUnusedSDKs;
    }
}