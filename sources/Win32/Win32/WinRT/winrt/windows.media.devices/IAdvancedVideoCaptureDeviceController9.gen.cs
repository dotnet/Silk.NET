// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8BDCA95D-0255-51BC-A10D-5A169EC1625A")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController9 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController9
    : IAdvancedVideoCaptureDeviceController9.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController9, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController9, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController9, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController9, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController9, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController9, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DigitalWindowControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowControl **")]
            IDigitalWindowControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController9,
                IDigitalWindowControl*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DigitalWindowControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowControl **")]
                IDigitalWindowControl* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IDigitalWindowControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDigitalWindowControl*, int> get_DigitalWindowControl;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdvancedVideoCaptureDeviceController9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdvancedVideoCaptureDeviceController9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdvancedVideoCaptureDeviceController9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController9(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdvancedVideoCaptureDeviceController9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController9"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController9"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdvancedVideoCaptureDeviceController9 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdvancedVideoCaptureDeviceController9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController9(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdvancedVideoCaptureDeviceController9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdvancedVideoCaptureDeviceController9 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
