// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("1D7B0652-185F-41C6-85CE-0C5BE3D4AE6C")]
[NativeTypeName("struct ID3D11VideoProcessor : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11VideoProcessor : ID3D11VideoProcessor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoProcessor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11VideoProcessor, ID3D11Device*, void>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoProcessor, Guid*, uint*, void*, int>)((*lpVtbl)[4])
        )(this, guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D11VideoProcessor, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc)
    {
        (
            (delegate* unmanaged<ID3D11VideoProcessor, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, void>)(
                (*lpVtbl)[7]
            )
        )(this, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetRateConversionCaps(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
    {
        (
            (delegate* unmanaged<
                ID3D11VideoProcessor,
                D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*,
                void>)((*lpVtbl)[8])
        )(this, pCaps);
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
        public delegate* unmanaged<TSelf*, ID3D11Device*, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("void (D3D11_VIDEO_PROCESSOR_CONTENT_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D11_VIDEO_PROCESSOR_CONTENT_DESC*,
            void> GetContentDesc;

        [NativeTypeName(
            "void (D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*,
            void> GetRateConversionCaps;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11VideoProcessor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11VideoProcessor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11VideoProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11VideoProcessor(Silk.NET.DirectX.ID3D11DeviceChild value)
    {
        return new ID3D11VideoProcessor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoProcessor"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoProcessor"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(ID3D11VideoProcessor value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11VideoProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11VideoProcessor(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11VideoProcessor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoProcessor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoProcessor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11VideoProcessor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
