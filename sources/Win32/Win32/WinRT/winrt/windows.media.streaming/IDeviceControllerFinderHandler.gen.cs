// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A88A7D06-988C-4403-9D8A-015BED140B34")]
[NativeTypeName("struct IDeviceControllerFinderHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceControllerFinderHandler
    : IDeviceControllerFinderHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceControllerFinderHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeviceControllerFinderHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceControllerFinderHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceControllerFinderHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::Media::Streaming::IDeviceController *")]
            IDeviceController sender,
        HSTRING uniqueDeviceName,
        [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice device
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceControllerFinderHandler,
                IDeviceController,
                HSTRING,
                IBasicDevice,
                int>)((*lpVtbl)[3])
        )(this, sender, uniqueDeviceName, device);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName("ABI::Windows::Media::Streaming::IDeviceController *")]
                IDeviceController sender,
            HSTRING uniqueDeviceName,
            [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice device
        );
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IDeviceController *, HSTRING, ABI::Windows::Media::Streaming::IBasicDevice *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceController, HSTRING, IBasicDevice, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceControllerFinderHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceControllerFinderHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceControllerFinderHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceControllerFinderHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceControllerFinderHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceControllerFinderHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceControllerFinderHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceControllerFinderHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
