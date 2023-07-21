// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D11TracingDevice.xml' path='doc/member[@name="ID3D11TracingDevice"]/*' />
[Guid("1911C771-1587-413E-A7E0-FB26C3DE0268")]
[NativeTypeName("struct ID3D11TracingDevice : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11TracingDevice : ID3D11TracingDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11TracingDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11TracingDevice*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11TracingDevice*, uint>)(lpVtbl[1]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11TracingDevice*, uint>)(lpVtbl[2]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11TracingDevice.xml' path='doc/member[@name="ID3D11TracingDevice.SetShaderTrackingOptionsByType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetShaderTrackingOptionsByType(uint ResourceTypeFlags, uint Options)
    {
        return ((delegate* unmanaged<ID3D11TracingDevice*, uint, uint, int>)(lpVtbl[3]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), ResourceTypeFlags, Options);
    }

    /// <include file='ID3D11TracingDevice.xml' path='doc/member[@name="ID3D11TracingDevice.SetShaderTrackingOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetShaderTrackingOptions(IUnknown* pShader, uint Options)
    {
        return ((delegate* unmanaged<ID3D11TracingDevice*, IUnknown*, uint, int>)(lpVtbl[4]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), pShader, Options);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetShaderTrackingOptionsByType(uint ResourceTypeFlags, uint Options);

        [VtblIndex(4)]
        HRESULT SetShaderTrackingOptions(IUnknown* pShader, uint Options);
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

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetShaderTrackingOptionsByType;

        [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, int> SetShaderTrackingOptions;
    }
}
