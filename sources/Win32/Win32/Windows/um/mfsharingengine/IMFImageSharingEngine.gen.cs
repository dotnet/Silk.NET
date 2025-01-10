// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CFA0AE8E-7E1C-44D2-AE68-FC4C148A6354")]
[NativeTypeName("struct IMFImageSharingEngine : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFImageSharingEngine : IMFImageSharingEngine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFImageSharingEngine));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFImageSharingEngine, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFImageSharingEngine, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFImageSharingEngine, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSource(IUnknown pStream)
    {
        return ((delegate* unmanaged<IMFImageSharingEngine, IUnknown, int>)((*lpVtbl)[3]))(
            this,
            pStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDevice(DEVICE_INFO* pDevice)
    {
        return ((delegate* unmanaged<IMFImageSharingEngine, DEVICE_INFO*, int>)((*lpVtbl)[4]))(
            this,
            pDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFImageSharingEngine, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSource(IUnknown pStream);

        [VtblIndex(4)]
        HRESULT GetDevice(DEVICE_INFO* pDevice);

        [VtblIndex(5)]
        HRESULT Shutdown();
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetSource;

        [NativeTypeName("HRESULT (DEVICE_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEVICE_INFO*, int> GetDevice;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFImageSharingEngine"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFImageSharingEngine(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFImageSharingEngine"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFImageSharingEngine(Silk.NET.Windows.IUnknown value)
    {
        return new IMFImageSharingEngine(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFImageSharingEngine"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFImageSharingEngine"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFImageSharingEngine value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
