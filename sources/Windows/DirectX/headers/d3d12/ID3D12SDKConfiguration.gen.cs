// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D12SDKConfiguration.xml' path='doc/member[@name="ID3D12SDKConfiguration"]/*'/>
[Guid("E9EB5314-33AA-42B2-A718-D77F58B1F1C7")]
[NativeTypeName("struct ID3D12SDKConfiguration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SDKConfiguration : ID3D12SDKConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SDKConfiguration));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint> )(lpVtbl[1]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint> )(lpVtbl[2]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12SDKConfiguration.xml' path='doc/member[@name="ID3D12SDKConfiguration.SetSDKVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath)
    {
        return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint, sbyte*, int> )(lpVtbl[3]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSDKVersion(uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath);
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
    }
}