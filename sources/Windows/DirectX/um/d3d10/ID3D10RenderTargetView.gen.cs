// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D10RenderTargetView.xml' path='doc/member[@name="ID3D10RenderTargetView"]/*' />
[Guid("9B7E4C08-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10RenderTargetView : ID3D10View")]
[NativeInheritance("ID3D10View")]
public unsafe partial struct ID3D10RenderTargetView : ID3D10RenderTargetView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10RenderTargetView));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10RenderTargetView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10RenderTargetView*, uint>)(lpVtbl[1]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10RenderTargetView*, uint>)(lpVtbl[2]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D10Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D10RenderTargetView*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="ID3D10DeviceChild.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D10RenderTargetView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D10DeviceChild.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D10RenderTargetView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D10DeviceChild.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D10RenderTargetView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D10View.GetResource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetResource(ID3D10Resource** ppResource)
    {
        ((delegate* unmanaged<ID3D10RenderTargetView*, ID3D10Resource**, void>)(lpVtbl[7]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), ppResource);
    }

    /// <include file='ID3D10RenderTargetView.xml' path='doc/member[@name="ID3D10RenderTargetView.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDesc(D3D10_RENDER_TARGET_VIEW_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D10RenderTargetView*, D3D10_RENDER_TARGET_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D10RenderTargetView*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface : ID3D10View.Interface
    {
        [VtblIndex(8)]
        void GetDesc(D3D10_RENDER_TARGET_VIEW_DESC* pDesc);
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

        [NativeTypeName("void (ID3D10Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("void (ID3D10Resource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource**, void> GetResource;

        [NativeTypeName("void (D3D10_RENDER_TARGET_VIEW_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_RENDER_TARGET_VIEW_DESC*, void> GetDesc;
    }
}
