// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("20BC074B-7A8D-4609-8C3B-64A0A3B5D7CE")]
[NativeTypeName("struct IMFDXGIDeviceManagerSource : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFDXGIDeviceManagerSource
    : IMFDXGIDeviceManagerSource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDXGIDeviceManagerSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFDXGIDeviceManagerSource, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetManager(IMFDXGIDeviceManager* ppManager)
    {
        return (
            (delegate* unmanaged<IMFDXGIDeviceManagerSource, IMFDXGIDeviceManager*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetManager(IMFDXGIDeviceManager* ppManager);
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

        [NativeTypeName("HRESULT (IMFDXGIDeviceManager **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFDXGIDeviceManager*, int> GetManager;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFDXGIDeviceManagerSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFDXGIDeviceManagerSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFDXGIDeviceManagerSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFDXGIDeviceManagerSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMFDXGIDeviceManagerSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFDXGIDeviceManagerSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFDXGIDeviceManagerSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFDXGIDeviceManagerSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
