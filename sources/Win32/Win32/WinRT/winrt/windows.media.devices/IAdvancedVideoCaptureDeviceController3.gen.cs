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

[Guid("A98B8F34-EE0D-470C-B9F0-4229C4BBD089")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController3
    : IAdvancedVideoCaptureDeviceController3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VariablePhotoSequenceController(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IVariablePhotoSequenceController **")]
            IVariablePhotoSequenceController* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController3,
                IVariablePhotoSequenceController*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PhotoConfirmationControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IPhotoConfirmationControl **")]
            IPhotoConfirmationControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController3,
                IPhotoConfirmationControl*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ZoomControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IZoomControl **")] IZoomControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController3, IZoomControl*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VariablePhotoSequenceController(
            [NativeTypeName(
                "ABI::Windows::Media::Devices::Core::IVariablePhotoSequenceController **"
            )]
                IVariablePhotoSequenceController* value
        );

        [VtblIndex(7)]
        HRESULT get_PhotoConfirmationControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IPhotoConfirmationControl **")]
                IPhotoConfirmationControl* value
        );

        [VtblIndex(8)]
        HRESULT get_ZoomControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IZoomControl **")] IZoomControl* value
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
            "HRESULT (ABI::Windows::Media::Devices::Core::IVariablePhotoSequenceController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVariablePhotoSequenceController*,
            int> get_VariablePhotoSequenceController;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IPhotoConfirmationControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPhotoConfirmationControl*,
            int> get_PhotoConfirmationControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IZoomControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IZoomControl*, int> get_ZoomControl;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdvancedVideoCaptureDeviceController3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdvancedVideoCaptureDeviceController3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdvancedVideoCaptureDeviceController3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController3(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdvancedVideoCaptureDeviceController3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdvancedVideoCaptureDeviceController3 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdvancedVideoCaptureDeviceController3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController3(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdvancedVideoCaptureDeviceController3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdvancedVideoCaptureDeviceController3 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
