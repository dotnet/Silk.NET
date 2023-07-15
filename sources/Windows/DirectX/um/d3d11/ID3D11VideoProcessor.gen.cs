// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11VideoProcessor.xml' path='doc/member[@name="ID3D11VideoProcessor"]/*'/>
[Guid("1D7B0652-185F-41C6-85CE-0C5BE3D4AE6C")]
[NativeTypeName("struct ID3D11VideoProcessor : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11VideoProcessor : ID3D11VideoProcessor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoProcessor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor*, uint> )(lpVtbl[1]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor*, uint> )(lpVtbl[2]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11VideoProcessor*, ID3D11Device**, void> )(lpVtbl[3]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, uint*, void*, int> )(lpVtbl[4]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, uint, void*, int> )(lpVtbl[5]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, IUnknown*, int> )(lpVtbl[6]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <include file='ID3D11VideoProcessor.xml' path='doc/member[@name="ID3D11VideoProcessor.GetContentDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, void> )(lpVtbl[7]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11VideoProcessor.xml' path='doc/member[@name="ID3D11VideoProcessor.GetRateConversionCaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetRateConversionCaps(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
    {
        ((delegate* unmanaged<ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, void> )(lpVtbl[8]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), pCaps);
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        void GetContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc);
        [VtblIndex(8)]
        void GetRateConversionCaps(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps);
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
        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("void (D3D11_VIDEO_PROCESSOR_CONTENT_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, void> GetContentDesc;
        [NativeTypeName("void (D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, void> GetRateConversionCaps;
    }
}